namespace SyncboxWizard
{
    partial class MainWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWizard));
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.Introduction = new AeroWizard.WizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHangingSetupHeader = new System.Windows.Forms.Label();
            this.NetworkPreconfiguration = new AeroWizard.WizardPage();
            this.rdbManualIP = new System.Windows.Forms.RadioButton();
            this.rdbAutoIP = new System.Windows.Forms.RadioButton();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.lblCallsign = new System.Windows.Forms.Label();
            this.NetworkDetails = new AeroWizard.WizardPage();
            this.txtSubnetMask = new IPAddressControlLib.IPAddressControl();
            this.txtDefaultGateway = new IPAddressControlLib.IPAddressControl();
            this.txtPreferredDns = new IPAddressControlLib.IPAddressControl();
            this.txtAlternateDns = new IPAddressControlLib.IPAddressControl();
            this.txtIpAddress = new IPAddressControlLib.IPAddressControl();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblAlternateDns = new System.Windows.Forms.Label();
            this.lblPreferredDns = new System.Windows.Forms.Label();
            this.lblDefaultGateway = new System.Windows.Forms.Label();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.Conclusion = new AeroWizard.WizardPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompleteParagraph = new System.Windows.Forms.Label();
            this.lblHangingCompleteHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.Introduction.SuspendLayout();
            this.NetworkPreconfiguration.SuspendLayout();
            this.NetworkDetails.SuspendLayout();
            this.Conclusion.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.Introduction);
            this.wizardControl1.Pages.Add(this.NetworkPreconfiguration);
            this.wizardControl1.Pages.Add(this.NetworkDetails);
            this.wizardControl1.Pages.Add(this.Conclusion);
            this.wizardControl1.Size = new System.Drawing.Size(677, 511);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Network Prequalification Wizard";
            this.wizardControl1.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("wizardControl1.TitleIcon")));
            this.wizardControl1.Finished += new System.EventHandler(this.wizardControl1_Finished);
            // 
            // Introduction
            // 
            this.Introduction.AllowBack = false;
            this.Introduction.Controls.Add(this.label1);
            this.Introduction.Controls.Add(this.lblHangingSetupHeader);
            this.Introduction.Name = "Introduction";
            this.Introduction.NextPage = this.NetworkPreconfiguration;
            this.Introduction.Size = new System.Drawing.Size(630, 357);
            this.Introduction.TabIndex = 0;
            this.Introduction.Text = "Introduction";
            this.Introduction.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.Introduction_Initialize);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 82);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblHangingSetupHeader
            // 
            this.lblHangingSetupHeader.AutoSize = true;
            this.lblHangingSetupHeader.Location = new System.Drawing.Point(4, 4);
            this.lblHangingSetupHeader.Name = "lblHangingSetupHeader";
            this.lblHangingSetupHeader.Size = new System.Drawing.Size(594, 15);
            this.lblHangingSetupHeader.TabIndex = 2;
            this.lblHangingSetupHeader.Text = "This wizard will help you configure the Syncbox. The following items are needed t" +
    "o complete the configuration:";
            // 
            // NetworkPreconfiguration
            // 
            this.NetworkPreconfiguration.AllowNext = false;
            this.NetworkPreconfiguration.Controls.Add(this.rdbManualIP);
            this.NetworkPreconfiguration.Controls.Add(this.rdbAutoIP);
            this.NetworkPreconfiguration.Controls.Add(this.txtCallsign);
            this.NetworkPreconfiguration.Controls.Add(this.lblCallsign);
            this.NetworkPreconfiguration.Name = "NetworkPreconfiguration";
            this.NetworkPreconfiguration.Size = new System.Drawing.Size(630, 357);
            this.NetworkPreconfiguration.TabIndex = 1;
            this.NetworkPreconfiguration.Text = "Network Preconfiguration Setup";
            this.NetworkPreconfiguration.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.NetworkPreconfiguration_Commit);
            this.NetworkPreconfiguration.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.NetworkPreconfiguration_Initialize);
            // 
            // rdbManualIP
            // 
            this.rdbManualIP.AutoSize = true;
            this.rdbManualIP.Location = new System.Drawing.Point(46, 117);
            this.rdbManualIP.Name = "rdbManualIP";
            this.rdbManualIP.Size = new System.Drawing.Size(200, 19);
            this.rdbManualIP.TabIndex = 3;
            this.rdbManualIP.TabStop = true;
            this.rdbManualIP.Text = "Manually configure an IP address";
            this.rdbManualIP.UseVisualStyleBackColor = true;
            // 
            // rdbAutoIP
            // 
            this.rdbAutoIP.AutoSize = true;
            this.rdbAutoIP.Checked = true;
            this.rdbAutoIP.Location = new System.Drawing.Point(46, 91);
            this.rdbAutoIP.Name = "rdbAutoIP";
            this.rdbAutoIP.Size = new System.Drawing.Size(208, 19);
            this.rdbAutoIP.TabIndex = 2;
            this.rdbAutoIP.TabStop = true;
            this.rdbAutoIP.Text = "Automatically obtain an IP address";
            this.rdbAutoIP.UseVisualStyleBackColor = true;
            // 
            // txtCallsign
            // 
            this.txtCallsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCallsign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.txtCallsign.Location = new System.Drawing.Point(87, 23);
            this.txtCallsign.MaxLength = 10;
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(526, 23);
            this.txtCallsign.TabIndex = 1;
            this.txtCallsign.TextChanged += new System.EventHandler(this.txtCallsign_TextChanged);
            // 
            // lblCallsign
            // 
            this.lblCallsign.AutoSize = true;
            this.lblCallsign.Location = new System.Drawing.Point(15, 29);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(71, 15);
            this.lblCallsign.TabIndex = 0;
            this.lblCallsign.Text = "Call Letters: ";
            // 
            // NetworkDetails
            // 
            this.NetworkDetails.Controls.Add(this.txtSubnetMask);
            this.NetworkDetails.Controls.Add(this.txtDefaultGateway);
            this.NetworkDetails.Controls.Add(this.txtPreferredDns);
            this.NetworkDetails.Controls.Add(this.txtAlternateDns);
            this.NetworkDetails.Controls.Add(this.txtIpAddress);
            this.NetworkDetails.Controls.Add(this.textBox6);
            this.NetworkDetails.Controls.Add(this.lblAlternateDns);
            this.NetworkDetails.Controls.Add(this.lblPreferredDns);
            this.NetworkDetails.Controls.Add(this.lblDefaultGateway);
            this.NetworkDetails.Controls.Add(this.lblSubnetMask);
            this.NetworkDetails.Controls.Add(this.lblIpAddress);
            this.NetworkDetails.Name = "NetworkDetails";
            this.NetworkDetails.NextPage = this.Conclusion;
            this.NetworkDetails.Size = new System.Drawing.Size(630, 357);
            this.NetworkDetails.TabIndex = 2;
            this.NetworkDetails.Text = "Fill In Your Network Details";
            this.NetworkDetails.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.NetworkDetails_Initialize);
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.AllowInternalTab = true;
            this.txtSubnetMask.AutoHeight = true;
            this.txtSubnetMask.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSubnetMask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubnetMask.Location = new System.Drawing.Point(198, 56);
            this.txtSubnetMask.MinimumSize = new System.Drawing.Size(84, 23);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = false;
            this.txtSubnetMask.Size = new System.Drawing.Size(429, 23);
            this.txtSubnetMask.TabIndex = 12;
            this.txtSubnetMask.Text = "...";
            this.txtSubnetMask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textChanged);
            // 
            // txtDefaultGateway
            // 
            this.txtDefaultGateway.AllowInternalTab = true;
            this.txtDefaultGateway.AutoHeight = true;
            this.txtDefaultGateway.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDefaultGateway.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultGateway.Location = new System.Drawing.Point(198, 85);
            this.txtDefaultGateway.MinimumSize = new System.Drawing.Size(84, 23);
            this.txtDefaultGateway.Name = "txtDefaultGateway";
            this.txtDefaultGateway.ReadOnly = false;
            this.txtDefaultGateway.Size = new System.Drawing.Size(429, 23);
            this.txtDefaultGateway.TabIndex = 13;
            this.txtDefaultGateway.Text = "...";
            this.txtDefaultGateway.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textChanged);
            // 
            // txtPreferredDns
            // 
            this.txtPreferredDns.AllowInternalTab = true;
            this.txtPreferredDns.AutoHeight = true;
            this.txtPreferredDns.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreferredDns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPreferredDns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreferredDns.Location = new System.Drawing.Point(197, 116);
            this.txtPreferredDns.MinimumSize = new System.Drawing.Size(84, 23);
            this.txtPreferredDns.Name = "txtPreferredDns";
            this.txtPreferredDns.ReadOnly = false;
            this.txtPreferredDns.Size = new System.Drawing.Size(429, 23);
            this.txtPreferredDns.TabIndex = 14;
            this.txtPreferredDns.Text = "...";
            this.txtPreferredDns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textChanged);
            // 
            // txtAlternateDns
            // 
            this.txtAlternateDns.AllowInternalTab = true;
            this.txtAlternateDns.AutoHeight = true;
            this.txtAlternateDns.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlternateDns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAlternateDns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlternateDns.Location = new System.Drawing.Point(197, 145);
            this.txtAlternateDns.MinimumSize = new System.Drawing.Size(84, 23);
            this.txtAlternateDns.Name = "txtAlternateDns";
            this.txtAlternateDns.ReadOnly = false;
            this.txtAlternateDns.Size = new System.Drawing.Size(429, 23);
            this.txtAlternateDns.TabIndex = 15;
            this.txtAlternateDns.Text = "...";
            this.txtAlternateDns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textChanged);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.AllowInternalTab = true;
            this.txtIpAddress.AutoHeight = true;
            this.txtIpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtIpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIpAddress.Location = new System.Drawing.Point(198, 28);
            this.txtIpAddress.MinimumSize = new System.Drawing.Size(84, 23);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.ReadOnly = false;
            this.txtIpAddress.Size = new System.Drawing.Size(429, 23);
            this.txtIpAddress.TabIndex = 11;
            this.txtIpAddress.Text = "...";
            this.txtIpAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(3, 1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(540, 16);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "All of the fields except the Alternate DNS server address are required.";
            // 
            // lblAlternateDns
            // 
            this.lblAlternateDns.AutoSize = true;
            this.lblAlternateDns.Location = new System.Drawing.Point(27, 153);
            this.lblAlternateDns.Name = "lblAlternateDns";
            this.lblAlternateDns.Size = new System.Drawing.Size(164, 15);
            this.lblAlternateDns.TabIndex = 4;
            this.lblAlternateDns.Text = "Alternate DNS server address: ";
            // 
            // lblPreferredDns
            // 
            this.lblPreferredDns.AutoSize = true;
            this.lblPreferredDns.Location = new System.Drawing.Point(27, 124);
            this.lblPreferredDns.Name = "lblPreferredDns";
            this.lblPreferredDns.Size = new System.Drawing.Size(164, 15);
            this.lblPreferredDns.TabIndex = 3;
            this.lblPreferredDns.Text = "Preferred DNS server address: ";
            // 
            // lblDefaultGateway
            // 
            this.lblDefaultGateway.AutoSize = true;
            this.lblDefaultGateway.Location = new System.Drawing.Point(27, 93);
            this.lblDefaultGateway.Name = "lblDefaultGateway";
            this.lblDefaultGateway.Size = new System.Drawing.Size(98, 15);
            this.lblDefaultGateway.TabIndex = 2;
            this.lblDefaultGateway.Text = "Default gateway: ";
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(27, 64);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(81, 15);
            this.lblSubnetMask.TabIndex = 1;
            this.lblSubnetMask.Text = "Subnet mask: ";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(27, 36);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(68, 15);
            this.lblIpAddress.TabIndex = 0;
            this.lblIpAddress.Text = "IP Address: ";
            // 
            // Conclusion
            // 
            this.Conclusion.Controls.Add(this.label2);
            this.Conclusion.Controls.Add(this.lblCompleteParagraph);
            this.Conclusion.Controls.Add(this.lblHangingCompleteHeader);
            this.Conclusion.IsFinishPage = true;
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(630, 357);
            this.Conclusion.TabIndex = 3;
            this.Conclusion.Text = "Conclusion";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "To finish the preconfiguration, click the \"Finish\" button. After doing so, you ma" +
    "y remove the thumb drive from your computer and insert it into the Syncbox.\r\n";
            // 
            // lblCompleteParagraph
            // 
            this.lblCompleteParagraph.AutoSize = true;
            this.lblCompleteParagraph.Location = new System.Drawing.Point(9, 36);
            this.lblCompleteParagraph.Name = "lblCompleteParagraph";
            this.lblCompleteParagraph.Size = new System.Drawing.Size(0, 15);
            this.lblCompleteParagraph.TabIndex = 1;
            // 
            // lblHangingCompleteHeader
            // 
            this.lblHangingCompleteHeader.AutoSize = true;
            this.lblHangingCompleteHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblHangingCompleteHeader.Location = new System.Drawing.Point(4, 4);
            this.lblHangingCompleteHeader.Name = "lblHangingCompleteHeader";
            this.lblHangingCompleteHeader.Size = new System.Drawing.Size(276, 28);
            this.lblHangingCompleteHeader.TabIndex = 0;
            this.lblHangingCompleteHeader.Text = "Complete the Configuration";
            // 
            // MainWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 511);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.Introduction.ResumeLayout(false);
            this.Introduction.PerformLayout();
            this.NetworkPreconfiguration.ResumeLayout(false);
            this.NetworkPreconfiguration.PerformLayout();
            this.NetworkDetails.ResumeLayout(false);
            this.NetworkDetails.PerformLayout();
            this.Conclusion.ResumeLayout(false);
            this.Conclusion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage Introduction;
        private AeroWizard.WizardPage NetworkPreconfiguration;
        private AeroWizard.WizardPage NetworkDetails;
        private AeroWizard.WizardPage Conclusion;
        private System.Windows.Forms.RadioButton rdbManualIP;
        private System.Windows.Forms.RadioButton rdbAutoIP;
        private System.Windows.Forms.TextBox txtCallsign;
        private System.Windows.Forms.Label lblCallsign;
        private System.Windows.Forms.Label lblAlternateDns;
        private System.Windows.Forms.Label lblPreferredDns;
        private System.Windows.Forms.Label lblDefaultGateway;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblHangingSetupHeader;
        private System.Windows.Forms.Label lblHangingCompleteHeader;
        private System.Windows.Forms.Label lblCompleteParagraph;
        private IPAddressControlLib.IPAddressControl txtSubnetMask;
        private IPAddressControlLib.IPAddressControl txtDefaultGateway;
        private IPAddressControlLib.IPAddressControl txtPreferredDns;
        private IPAddressControlLib.IPAddressControl txtAlternateDns;
        private IPAddressControlLib.IPAddressControl txtIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}