using System;
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

            //Split the pulled data on the dot and populate the ip textboxes
            try
            {
                string[] ipArray = baseSettings.IpAddress.Split('.');
                ipMi1.Text = ipArray[0];
                ipMi2.Text = ipArray[1];
                ipMi3.Text = ipArray[2];
                ipMi4.Text = ipArray[3];

                string[] subnetArray = baseSettings.SubnetMask.Split('.');
                subnetMi1.Text = subnetArray[0];
                subnetMi2.Text = subnetArray[1];
                subnetMi3.Text = subnetArray[2];
                subnetMi4.Text = subnetArray[3];

                string[] gatewayArray = baseSettings.DefaultGateway.Split('.');
                gatewayMi1.Text = gatewayArray[0];
                gatewayMi2.Text = gatewayArray[1];
                gatewayMi3.Text = gatewayArray[2];
                gatewayMi4.Text = gatewayArray[3];

                string[] prefDns = baseSettings.PreferredDns.Split('.');
                prefDnsMi1.Text = prefDns[0];
                prefDnsMi2.Text = prefDns[1];
                prefDnsMi3.Text = prefDns[2];
                prefDnsMi4.Text = prefDns[3];

                string[] altArray = baseSettings.AlternateDns.Split('.');
                altDnsMi1.Text = altArray[0];
                altDnsMi2.Text = altArray[1];
                altDnsMi3.Text = altArray[2];
                altDnsMi4.Text = altArray[3];
            }
            catch (Exception)
            {
                
            }
            
            
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
                // Concat all the boxes for each field together and then remove all whitespace just as a safety measure
                finalSettings.IpAddress = ipMi1.Text + "." + ipMi2.Text + "." + ipMi3.Text + "." + ipMi4.Text;
                finalSettings.IpAddress.Replace(" ", string.Empty);
                finalSettings.SubnetMask = subnetMi1.Text + "." + subnetMi2.Text + "." + subnetMi3.Text + "." + subnetMi4.Text;
                finalSettings.SubnetMask.Replace(" ", string.Empty);
                finalSettings.DefaultGateway = gatewayMi1.Text + "." + gatewayMi2.Text + "." + gatewayMi3.Text + "." + gatewayMi4.Text;
                finalSettings.DefaultGateway.Replace(" ", string.Empty);
                finalSettings.PreferredDns = prefDnsMi1.Text + "." + prefDnsMi2.Text + "." + prefDnsMi3.Text + "." + prefDnsMi4.Text;
                finalSettings.PreferredDns.Replace(" ", string.Empty);
                string altdns = altDnsMi1.Text + "." + altDnsMi2.Text + "." + altDnsMi3.Text + "." + altDnsMi4.Text;

                //If alternate dns is only 3 characters ("..."), save it as an empty string, else, use the inputed altDns
                if (altdns.Length == 3)
                {
                    finalSettings.AlternateDns = "";
                }
                else
                {
                    finalSettings.AlternateDns = altdns;
                    finalSettings.AlternateDns.Replace(" ", string.Empty);
                }
                
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
        
        //Ensures callsign does not involve numbers and is > 3 characters
        private void txtCallsign_TextChanged(object sender, EventArgs e)
        {
            
            string currentText = txtCallsign.Text;

            // Search through the callsign text and remove all non letters
            foreach (var c in currentText)
            {
                if (!Char.IsLetter(c))
                {
                    int pos = currentText.IndexOf(c);
                    currentText = currentText.Remove(pos, 1);
                }
            }
            txtCallsign.Text = currentText;
            txtCallsign.SelectionStart = (txtCallsign.Text.Length == 0) ? 0 : txtCallsign.Text.Length;

            callsignvalid = (txtCallsign.Text.Length >= 3) ? true : false;
        }

        //Ensure key entered is a number and if above 255 reset is to 255
        public void StandardNumberInput(object sender, KeyEventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (Enum.IsDefined(typeof(numberKeycodes), e.KeyCode.ToString()))
            {
                try
                {
                    textBox.Text = int.Parse(textBox.Text) > 255 ? 255.ToString() : textBox.Text;
                }
                catch (FormatException)
                {

                }

            }
            else
            {
                e.SuppressKeyPress = true;
            }


        }

        //Ensure key entered is a number, otherwise surpress the keypress. If number check iff text is a valid subnet ip
        public void subnetNumberInput(object sender, KeyEventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (Enum.IsDefined(typeof(numberKeycodes), e.KeyCode.ToString()))
            {

            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        //Does not allow a textbox to have a number greater than 254, else resets to 254
        public void FinalOctetCheck(object sender, KeyEventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (Enum.IsDefined(typeof(numberKeycodes), e.KeyCode.ToString()))
            {
                try
                {
                    textBox.Text = int.Parse(textBox.Text) > 254 ? 254.ToString() : textBox.Text;
                }
                catch (FormatException)
                {

                }

            }
        }

        // Puts the curser at index 0 when entering a textbox
        private void mi_Enter(object sender, EventArgs e)
        {
            MaskedTextBox input = sender as MaskedTextBox;
            input.SelectionStart = 0;
        }

        // Ensures user clicking in textbox is always at the current index
        private void CurserIndexCheck(object sender, EventArgs e)
        {
            MaskedTextBox box = sender as MaskedTextBox;
            try
            {
                box.Select(box.Text.Length, 0);
            }
            catch (Exception)
            {

            }


        }

        // Ensures the user cannot press arrow keys, back, or home. This will prevent empty strings from being entered in the IP textboxes
        private void IgnoreArrowKey(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 35 || e.KeyValue == 36 || e.KeyValue == 37 || e.KeyValue == 38 || e.KeyValue == 39 || e.KeyValue == 40)
            {
                try
                {
                    e.SuppressKeyPress = true;
                }
                catch (Exception)
                {

                }
            }
        }



        /** Private helper methods **/

        // Tests whether the entered ip boxes contain appropriate valid data
        private bool VerifyIPSettings()
        {
            bool result = false;

            bool ipValid = false, subnetValid = false, gatewayValid = false, preferredValid = false, alternateValid = true;

            string fullIpText = ipMi1.Text +"." + ipMi2.Text + "." + ipMi3.Text + "." + ipMi4.Text;
            string fullSubnetText = subnetMi1.Text + "." + subnetMi2.Text + "." + subnetMi3.Text + "." + subnetMi4.Text;
            string fullGatewayText = gatewayMi1.Text + "." + gatewayMi2.Text + "." + gatewayMi3.Text + "." + gatewayMi4.Text;
            string fullPrefDnsText = prefDnsMi1.Text + "." + prefDnsMi2.Text + "." + prefDnsMi3.Text + "." + prefDnsMi4.Text;
            string fullAltDnsText = altDnsMi1.Text + "." + altDnsMi2.Text + "." + altDnsMi3.Text + "." + altDnsMi4.Text;

            // Validates the ip's and sets the boolean triggers
            ipValid = (IPAddress.TryParse(fullIpText, out var ip)) && fullIpText != fullGatewayText && fullIpText != fullAltDnsText && fullIpText != fullPrefDnsText && invalidEntries.Contains(fullIpText) != true ? true : false;
            subnetValid = (IPAddress.TryParse(fullSubnetText, out var sub)) && fullSubnetText != fullIpText && fullSubnetText != fullGatewayText && invalidEntries.Contains(fullSubnetText) != true && subnetOptions.Contains(int.Parse(subnetMi1.Text)) != false && subnetOptions.Contains(int.Parse(subnetMi2.Text)) != false && subnetOptions.Contains(int.Parse(subnetMi3.Text)) != false && subnetOptions.Contains(int.Parse(subnetMi4.Text)) != false ? true : false;
            gatewayValid = (IPAddress.TryParse(fullGatewayText, out var gw)) && fullIpText != fullGatewayText && fullGatewayText != fullSubnetText && invalidEntries.Contains(fullGatewayText) != true ? true : false;
            preferredValid = (IPAddress.TryParse(fullPrefDnsText, out var dns1)) && fullPrefDnsText != fullAltDnsText && fullPrefDnsText != fullIpText && invalidEntries.Contains(fullPrefDnsText) != true ? true : false;
            alternateValid = (IPAddress.TryParse(fullAltDnsText, out var dns2) || fullAltDnsText.Length == 3) && fullPrefDnsText != fullAltDnsText && fullAltDnsText != fullIpText && invalidEntries.Contains(fullAltDnsText) != true ? true : false;

            // Shows or hides the ip error messages
            lblIpError.Visible = ((fullIpText.Equals(fullSubnetText) || fullIpText.Equals(fullGatewayText) || fullIpText.Equals(fullPrefDnsText) || fullIpText.Equals(fullAltDnsText)) && fullIpText.Length != 3) ? true : false;
            lblSubnetError.Visible = ((fullSubnetText.Equals(fullIpText) || fullSubnetText.Equals(fullGatewayText)) && fullSubnetText.Length != 3) ? true : false;
            lblPreferredError.Visible = (fullPrefDnsText.Equals(fullAltDnsText) && fullPrefDnsText.Length != 3) ? true : false;
            lblValidSubnetError.Visible = subnetValid == false ? true : false;

            // Changes the texbox content color based on tha validated triggers
            ChangeColor(new MaskedTextBox[] { ipMi1, ipMi2, ipMi3, ipMi4 }, ipValid);
            ChangeColor(new MaskedTextBox[] { subnetMi1, subnetMi2, subnetMi3, subnetMi4}, subnetValid);
            ChangeColor(new MaskedTextBox[] { gatewayMi1, gatewayMi2, gatewayMi3, gatewayMi4 }, gatewayValid);
            ChangeColor(new MaskedTextBox[] { prefDnsMi1, prefDnsMi2, prefDnsMi3, prefDnsMi4 }, preferredValid);
            ChangeColor(new MaskedTextBox[] { altDnsMi1, altDnsMi2, altDnsMi3, altDnsMi4 }, alternateValid);


            result = (ipValid == true && subnetValid == true && gatewayValid == true && preferredValid == true && alternateValid == true) ? true : false;
            return result; 
        }

        //Checks to ensure the application is running on a synbak drive and the drive is currently inserted
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

        //Turn text boxes red
        private void ChangeColor(MaskedTextBox[] boxes, bool valid)
        {
            foreach (var box in boxes)
            {
                box.ForeColor = (valid == true) ? Color.Black : Color.Red;
            }
        }



        /* Arrays and enums */

        // Enum of acceptable keycodes to be used in the octets. Contains the keycodes for all number keys on a keyboard 
        public enum numberKeycodes { D0, D1, D2, D3, D4, D5, D6, D7, D8, D9, NumPad0, NumPad1, NumPad2, NumPad3, NumPad4, NumPad5, NumPad6, NumPad7, NumPad8, NumPad9 };

        // int array containing all acceptable subnet octet entries 
        public int[] subnetOptions = new int[]{ 0, 128, 192, 224, 240, 248, 252, 254, 255};

        // string array containing all invalid octet entries
        public string[] invalidEntries = new string[]{ "0.0.0.0", "255.255.255.255" };

       
    }
}
