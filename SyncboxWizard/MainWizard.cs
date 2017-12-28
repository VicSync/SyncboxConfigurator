﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SyncboxWizard
{
    public partial class MainWizard : Form
    {

        /// <summary>
        /// Object to hold all the imported network configuration settings.
        /// </summary>
        private FullInstallSettings baseSettings = null;

        /// <summary>
        /// Object to hold all finalized entered network configuration settings to be written out as xml
        /// </summary>
        private FullInstallSettings finalSettings = null;

        /// <summary>
        /// Boolean validator to check the state of the callsign textbox
        /// </summary>
        private bool callsignvalid = false;
        

        public MainWizard()
        {
            InitializeComponent();

            
            // Load existing xml settings if present
            try
            {
                //Retrieve and store the imported xml data
                InstallImporter importer = new InstallImporter();
                string fileName = "config.xml";
                baseSettings = importer.Deserialize(fileName);
            }
            catch (Exception x)
            {
                baseSettings = new FullInstallSettings();
            }

            //Auto populate the network fields.
            txtCallsign.Text = baseSettings.CallSign;
            txtIpAddress.Text = baseSettings.IpAddress;
            txtSubnetMask.Text = baseSettings.SubnetMask;
            txtDefaultGateway.Text = baseSettings.DefaultGateway;
            txtPreferredDns.Text = baseSettings.PreferredDns;
            txtAlternateDns.Text = baseSettings.AlternateDns;
            rdbManualIP.Checked = (baseSettings.Dhcp.Equals("false")) ? true : false;
            

        }



        /** Initialize, commit and finalize methods  **/

        private void NetworkPreconfiguration_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            callsignvalid = (txtCallsign.Text.Length >= 3) ? true : false;
        }

        private void Introduction_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(DriveInsertionCheck));
            t.IsBackground = true;
            t.Start();

            /** Make the line in main text box bold **/
            int index = rtbMainLabel.Text.IndexOf("it is required in order to continue!!!");
            int length = "it is required in order to continue!!!".Length;
            rtbMainLabel.Select(index, length);
            Font currentFont = rtbMainLabel.SelectionFont;
            rtbMainLabel.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
            rtbMainLabel.SelectAll();
            rtbMainLabel.SelectionBullet = true;
            rtbMainLabel.Select(0, 0);

            /** Make "syncbox" italicized**/
            int index2 = rtbHeader.Text.IndexOf("Syncbox");
            int length2 = "Syncbox".Length;
            rtbHeader.Select(index2, length2);
            Font currentFont2 = rtbHeader.SelectionFont;
            rtbHeader.SelectionFont = new Font(currentFont2.FontFamily, currentFont2.Size, FontStyle.Italic);
            rtbHeader.Select(0,0);

            /** Superscript TM in header**/
            int index3 = rtbHeader.Text.IndexOf("TM");
            int length3 = "TM".Length;
            rtbHeader.Select(index3, length3);
            rtbHeader.SelectionCharOffset = 5;
            var tmFont = rtbHeader.SelectionFont;
            rtbHeader.SelectionFont = new Font(tmFont.FontFamily, 4);
            rtbHeader.Select(0, 0); 

        }
        
        private void NetworkPreconfiguration_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            NetworkPreconfiguration.NextPage = (rdbAutoIP.Checked) ? Conclusion : NetworkDetails;
        }

        private void wizardControl1_Finished(object sender, EventArgs e)
        {
            // Collect all input settings and prepare for xml serialization
            finalSettings = new FullInstallSettings();
            finalSettings.CallSign = txtCallsign.Text;
            finalSettings.Dhcp = (rdbAutoIP.Checked == true) ? "true" : "false";
            finalSettings.Updated = DateTime.Now.ToString("yyyyMMddHHmm");

            string xmlResult = "";
            InstallImporter importer = null;
            if (rdbAutoIP.Checked) //Discard any old imported network settings
            {

            }
            else // Use new settings
            {
                finalSettings.IpAddress = txtIpAddress.Text;
                finalSettings.DefaultGateway = txtDefaultGateway.Text;
                finalSettings.SubnetMask = txtSubnetMask.Text;
                finalSettings.PreferredDns = txtPreferredDns.Text;
                finalSettings.AlternateDns = (txtAlternateDns.Text.Length == 3) ? "" : txtAlternateDns.Text;
            }

            try
            {
                importer = new InstallImporter();
                //Serialize the object to xml
                xmlResult = importer.Serialize(finalSettings);
            }
            catch (Exception)
            {
                
            }
            

            //Write the xml to the file
            try
            {
                importer.WriteXmlToCurrentDirectory(xmlResult);
                MessageBox.Show("Safely remove the thumb drive and insert into the Syncbox. It should stay in the Syncbox while it's in use.", "Configuration Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Drive removed. Reinsert the syncbak drive and try again. Application now closing", "Drive removed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /** Event Methods **/ 
        
        private void txtCallsign_TextChanged(object sender, EventArgs e)
        {
            // Call sign letters entered by the user
            String callSignUserInput = "";
            
            // If user attempts to enter numeric values, those keystrokes are ignored
            // If user attempts to paste a string containing numeric values, nothing will be pasted. Strings consisting of alphabetical characters only will be pasted
            if (txtCallsign.Text.All(character => char.IsLetter(character)))
            {
                callSignUserInput = txtCallsign.Text;
            }
            else
            {
                
                foreach (char l in txtCallsign.Text)
                {
                    if (!Char.IsLetter(l))
                    {
                        var position = txtCallsign.Text.IndexOf(l);
                        txtCallsign.Text = txtCallsign.Text.Remove(position,1);
                        txtCallsign.SelectionStart = (txtCallsign.Text.Length == 0) ? 0 : txtCallsign.Text.Length;
                    }
                }
            }

            callsignvalid = (txtCallsign.Text.Length >= 3) ? true : false;
        }


        /** Private helper methods **/
        private bool VerifyIPSettings()
        {
            bool result = false;
            bool ipValid = false, subnetValid = false, gatewayValid = false, preferredValid = false, alternateValid = true;
            

            ipValid = (IPAddress.TryParse(txtIpAddress.Text, out var ip)) && txtIpAddress.Text != txtDefaultGateway.Text && txtIpAddress.Text != txtAlternateDns.Text && txtIpAddress.Text != txtPreferredDns.Text ? true : false;
            subnetValid = (IPAddress.TryParse(txtSubnetMask.Text, out var sub)) ? true : false;
            gatewayValid = (IPAddress.TryParse(txtDefaultGateway.Text, out var gat)) && txtIpAddress.Text != txtDefaultGateway.Text ? true : false;
            preferredValid = (IPAddress.TryParse(txtPreferredDns.Text, out var pref)) && txtPreferredDns.Text != txtAlternateDns.Text && txtPreferredDns.Text != txtIpAddress.Text ? true : false;
            alternateValid = (IPAddress.TryParse(txtAlternateDns.Text, out var alt) || txtAlternateDns.Text.Length == 3 ) && txtPreferredDns.Text != txtAlternateDns.Text && txtAlternateDns.Text != txtIpAddress.Text ? true : false;

            

            result = (ipValid == true && subnetValid == true && gatewayValid == true && preferredValid == true && alternateValid == true) ? true : false;
            return result;
        }

        private void DriveInsertionCheck()
        {
            
            while (true)
            {
                try
                {
                    /* To ensure the wizard is running off a Syncbak labeled drive */
                    string volumeLabel = "";
                    string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location.ElementAt(0).ToString() + ":\\";

                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    DriveInfo currentDrive = allDrives.Single(x => x.Name.Equals(currentPath));

                    if (currentDrive.IsReady)
                    {
                        volumeLabel = currentDrive.VolumeLabel;

                        switch (wizardControl1.SelectedPage.Name) {
                            case "Introduction": 
                                Introduction.AllowNext = (volumeLabel.Equals("SYNCBAK")) ? true : false;
                                break;
                            case "Conclusion": 
                                Conclusion.AllowNext = (volumeLabel.Equals("SYNCBAK")) ? true : false;
                                break;
                            case "NetworkPreconfiguration":   
                                NetworkPreconfiguration.AllowNext = (volumeLabel.Equals("SYNCBAK")) && callsignvalid ? true : false;
                                break;
                            case "NetworkDetails": 
                                NetworkDetails.AllowNext = (volumeLabel.Equals("SYNCBAK")) && VerifyIPSettings() ? true : false;
                                break;  
                        }

                    }
                    else
                    {
                        wizardControl1.SelectedPage.AllowNext = false;
                    }
                                        
                }
                catch(Exception ex)
                {
                    wizardControl1.SelectedPage.AllowNext = false;
                }
                
            }
            
        }


    }
}
