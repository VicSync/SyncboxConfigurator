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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWizard));
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.Introduction = new AeroWizard.WizardPage();
            this.rtbHeader = new System.Windows.Forms.RichTextBox();
            this.rtbMainLabel = new System.Windows.Forms.RichTextBox();
            this.NetworkPreconfiguration = new AeroWizard.WizardPage();
            this.rdbManualIP = new System.Windows.Forms.RadioButton();
            this.rdbAutoIP = new System.Windows.Forms.RadioButton();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.lblCallsign = new System.Windows.Forms.Label();
            this.NetworkDetails = new AeroWizard.WizardPage();
            this.lblNetworkError = new System.Windows.Forms.Label();
            this.lblSubnetError = new System.Windows.Forms.Label();
            this.lblEntryError = new System.Windows.Forms.Label();
            this.lblPreferredError = new System.Windows.Forms.Label();
            this.lblIpError = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.altDnsMi4 = new System.Windows.Forms.MaskedTextBox();
            this.altDnsMi3 = new System.Windows.Forms.MaskedTextBox();
            this.altDnsMi2 = new System.Windows.Forms.MaskedTextBox();
            this.altDnsMi1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prefDnsMi4 = new System.Windows.Forms.MaskedTextBox();
            this.prefDnsMi3 = new System.Windows.Forms.MaskedTextBox();
            this.prefDnsMi2 = new System.Windows.Forms.MaskedTextBox();
            this.prefDnsMi1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gatewayMi4 = new System.Windows.Forms.MaskedTextBox();
            this.gatewayMi3 = new System.Windows.Forms.MaskedTextBox();
            this.gatewayMi2 = new System.Windows.Forms.MaskedTextBox();
            this.gatewayMi1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.subnetMi4 = new System.Windows.Forms.MaskedTextBox();
            this.subnetMi3 = new System.Windows.Forms.MaskedTextBox();
            this.subnetMi2 = new System.Windows.Forms.MaskedTextBox();
            this.subnetMi1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipMi4 = new System.Windows.Forms.MaskedTextBox();
            this.ipMi3 = new System.Windows.Forms.MaskedTextBox();
            this.ipMi2 = new System.Windows.Forms.MaskedTextBox();
            this.ipMi1 = new System.Windows.Forms.MaskedTextBox();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.Introduction.Controls.Add(this.rtbHeader);
            this.Introduction.Controls.Add(this.rtbMainLabel);
            this.Introduction.Name = "Introduction";
            this.Introduction.NextPage = this.NetworkPreconfiguration;
            this.Introduction.Size = new System.Drawing.Size(630, 357);
            this.Introduction.TabIndex = 0;
            this.Introduction.Text = "Introduction";
            this.Introduction.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.Introduction_Initialize);
            // 
            // rtbHeader
            // 
            this.rtbHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHeader.Location = new System.Drawing.Point(4, 4);
            this.rtbHeader.Multiline = false;
            this.rtbHeader.Name = "rtbHeader";
            this.rtbHeader.ReadOnly = true;
            this.rtbHeader.Size = new System.Drawing.Size(623, 29);
            this.rtbHeader.TabIndex = 5;
            this.rtbHeader.Text = "This wizard will help you configure the SyncboxTM. The following items are needed" +
    " to complete the configuration:";
            // 
            // rtbMainLabel
            // 
            this.rtbMainLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbMainLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMainLabel.BulletIndent = 3;
            this.rtbMainLabel.Location = new System.Drawing.Point(35, 39);
            this.rtbMainLabel.Name = "rtbMainLabel";
            this.rtbMainLabel.ReadOnly = true;
            this.rtbMainLabel.Size = new System.Drawing.Size(526, 96);
            this.rtbMainLabel.TabIndex = 4;
            this.rtbMainLabel.Text = resources.GetString("rtbMainLabel.Text");
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
            this.NetworkDetails.Controls.Add(this.lblNetworkError);
            this.NetworkDetails.Controls.Add(this.lblSubnetError);
            this.NetworkDetails.Controls.Add(this.lblEntryError);
            this.NetworkDetails.Controls.Add(this.lblPreferredError);
            this.NetworkDetails.Controls.Add(this.lblIpError);
            this.NetworkDetails.Controls.Add(this.label14);
            this.NetworkDetails.Controls.Add(this.label15);
            this.NetworkDetails.Controls.Add(this.label16);
            this.NetworkDetails.Controls.Add(this.altDnsMi4);
            this.NetworkDetails.Controls.Add(this.altDnsMi3);
            this.NetworkDetails.Controls.Add(this.altDnsMi2);
            this.NetworkDetails.Controls.Add(this.altDnsMi1);
            this.NetworkDetails.Controls.Add(this.label11);
            this.NetworkDetails.Controls.Add(this.label12);
            this.NetworkDetails.Controls.Add(this.label13);
            this.NetworkDetails.Controls.Add(this.prefDnsMi4);
            this.NetworkDetails.Controls.Add(this.prefDnsMi3);
            this.NetworkDetails.Controls.Add(this.prefDnsMi2);
            this.NetworkDetails.Controls.Add(this.prefDnsMi1);
            this.NetworkDetails.Controls.Add(this.label8);
            this.NetworkDetails.Controls.Add(this.label9);
            this.NetworkDetails.Controls.Add(this.label10);
            this.NetworkDetails.Controls.Add(this.gatewayMi4);
            this.NetworkDetails.Controls.Add(this.gatewayMi3);
            this.NetworkDetails.Controls.Add(this.gatewayMi2);
            this.NetworkDetails.Controls.Add(this.gatewayMi1);
            this.NetworkDetails.Controls.Add(this.label5);
            this.NetworkDetails.Controls.Add(this.label6);
            this.NetworkDetails.Controls.Add(this.label7);
            this.NetworkDetails.Controls.Add(this.subnetMi4);
            this.NetworkDetails.Controls.Add(this.subnetMi3);
            this.NetworkDetails.Controls.Add(this.subnetMi2);
            this.NetworkDetails.Controls.Add(this.subnetMi1);
            this.NetworkDetails.Controls.Add(this.label4);
            this.NetworkDetails.Controls.Add(this.label3);
            this.NetworkDetails.Controls.Add(this.label1);
            this.NetworkDetails.Controls.Add(this.ipMi4);
            this.NetworkDetails.Controls.Add(this.ipMi3);
            this.NetworkDetails.Controls.Add(this.ipMi2);
            this.NetworkDetails.Controls.Add(this.ipMi1);
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
            this.NetworkDetails.Text = "Fill out your Network Details";
            // 
            // lblNetworkError
            // 
            this.lblNetworkError.AutoSize = true;
            this.lblNetworkError.Location = new System.Drawing.Point(50, 254);
            this.lblNetworkError.Name = "lblNetworkError";
            this.lblNetworkError.Size = new System.Drawing.Size(0, 15);
            this.lblNetworkError.TabIndex = 55;
            // 
            // lblSubnetError
            // 
            this.lblSubnetError.AutoSize = true;
            this.lblSubnetError.ForeColor = System.Drawing.Color.Red;
            this.lblSubnetError.Location = new System.Drawing.Point(50, 294);
            this.lblSubnetError.Name = "lblSubnetError";
            this.lblSubnetError.Size = new System.Drawing.Size(325, 15);
            this.lblSubnetError.TabIndex = 54;
            this.lblSubnetError.Text = "Subnet Mask CANNOT match IP Address or Default Gateway";
            // 
            // lblEntryError
            // 
            this.lblEntryError.AutoSize = true;
            this.lblEntryError.ForeColor = System.Drawing.Color.Black;
            this.lblEntryError.Location = new System.Drawing.Point(290, 218);
            this.lblEntryError.Name = "lblEntryError";
            this.lblEntryError.Size = new System.Drawing.Size(253, 15);
            this.lblEntryError.TabIndex = 53;
            this.lblEntryError.Text = "0.0.0.0 and 255.255.255.255 are not valid entries";
            // 
            // lblPreferredError
            // 
            this.lblPreferredError.AutoSize = true;
            this.lblPreferredError.ForeColor = System.Drawing.Color.Red;
            this.lblPreferredError.Location = new System.Drawing.Point(50, 319);
            this.lblPreferredError.Name = "lblPreferredError";
            this.lblPreferredError.Size = new System.Drawing.Size(247, 15);
            this.lblPreferredError.TabIndex = 52;
            this.lblPreferredError.Text = "Preferred DNS CANNOT match Alternate DNS";
            // 
            // lblIpError
            // 
            this.lblIpError.AutoSize = true;
            this.lblIpError.ForeColor = System.Drawing.Color.Red;
            this.lblIpError.Location = new System.Drawing.Point(50, 269);
            this.lblIpError.Name = "lblIpError";
            this.lblIpError.Size = new System.Drawing.Size(485, 15);
            this.lblIpError.TabIndex = 51;
            this.lblIpError.Text = "IP Address CANNOT match Subnet mask, Default Gateway, Preferred DNS or Alternate " +
    "DNS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(405, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(512, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 15);
            this.label15.TabIndex = 49;
            this.label15.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(298, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 15);
            this.label16.TabIndex = 45;
            this.label16.Text = ".";
            // 
            // altDnsMi4
            // 
            this.altDnsMi4.HidePromptOnLeave = true;
            this.altDnsMi4.Location = new System.Drawing.Point(522, 168);
            this.altDnsMi4.Mask = "099";
            this.altDnsMi4.Name = "altDnsMi4";
            this.altDnsMi4.PromptChar = ' ';
            this.altDnsMi4.Size = new System.Drawing.Size(97, 23);
            this.altDnsMi4.TabIndex = 50;
            this.altDnsMi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altDnsMi4.Click += new System.EventHandler(this.CurserIndexCheck);
            this.altDnsMi4.Enter += new System.EventHandler(this.mi_Enter);
            this.altDnsMi4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.altDnsMi4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FinalOctetCheck);
            // 
            // altDnsMi3
            // 
            this.altDnsMi3.HidePromptOnLeave = true;
            this.altDnsMi3.Location = new System.Drawing.Point(415, 168);
            this.altDnsMi3.Mask = "099";
            this.altDnsMi3.Name = "altDnsMi3";
            this.altDnsMi3.PromptChar = ' ';
            this.altDnsMi3.Size = new System.Drawing.Size(97, 23);
            this.altDnsMi3.TabIndex = 48;
            this.altDnsMi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altDnsMi3.Click += new System.EventHandler(this.CurserIndexCheck);
            this.altDnsMi3.Enter += new System.EventHandler(this.mi_Enter);
            this.altDnsMi3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.altDnsMi3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // altDnsMi2
            // 
            this.altDnsMi2.HidePromptOnLeave = true;
            this.altDnsMi2.Location = new System.Drawing.Point(308, 168);
            this.altDnsMi2.Mask = "099";
            this.altDnsMi2.Name = "altDnsMi2";
            this.altDnsMi2.PromptChar = ' ';
            this.altDnsMi2.Size = new System.Drawing.Size(97, 23);
            this.altDnsMi2.TabIndex = 46;
            this.altDnsMi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altDnsMi2.Click += new System.EventHandler(this.CurserIndexCheck);
            this.altDnsMi2.Enter += new System.EventHandler(this.mi_Enter);
            this.altDnsMi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.altDnsMi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // altDnsMi1
            // 
            this.altDnsMi1.AllowPromptAsInput = false;
            this.altDnsMi1.HidePromptOnLeave = true;
            this.altDnsMi1.Location = new System.Drawing.Point(200, 168);
            this.altDnsMi1.Mask = "099";
            this.altDnsMi1.Name = "altDnsMi1";
            this.altDnsMi1.PromptChar = ' ';
            this.altDnsMi1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.altDnsMi1.ShortcutsEnabled = false;
            this.altDnsMi1.Size = new System.Drawing.Size(97, 23);
            this.altDnsMi1.TabIndex = 44;
            this.altDnsMi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altDnsMi1.Click += new System.EventHandler(this.CurserIndexCheck);
            this.altDnsMi1.Enter += new System.EventHandler(this.mi_Enter);
            this.altDnsMi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.altDnsMi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(405, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(512, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(298, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = ".";
            // 
            // prefDnsMi4
            // 
            this.prefDnsMi4.HidePromptOnLeave = true;
            this.prefDnsMi4.Location = new System.Drawing.Point(522, 139);
            this.prefDnsMi4.Mask = "099";
            this.prefDnsMi4.Name = "prefDnsMi4";
            this.prefDnsMi4.PromptChar = ' ';
            this.prefDnsMi4.Size = new System.Drawing.Size(97, 23);
            this.prefDnsMi4.TabIndex = 43;
            this.prefDnsMi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prefDnsMi4.Click += new System.EventHandler(this.CurserIndexCheck);
            this.prefDnsMi4.Enter += new System.EventHandler(this.mi_Enter);
            this.prefDnsMi4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.prefDnsMi4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FinalOctetCheck);
            // 
            // prefDnsMi3
            // 
            this.prefDnsMi3.HidePromptOnLeave = true;
            this.prefDnsMi3.Location = new System.Drawing.Point(415, 139);
            this.prefDnsMi3.Mask = "099";
            this.prefDnsMi3.Name = "prefDnsMi3";
            this.prefDnsMi3.PromptChar = ' ';
            this.prefDnsMi3.Size = new System.Drawing.Size(97, 23);
            this.prefDnsMi3.TabIndex = 41;
            this.prefDnsMi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prefDnsMi3.Click += new System.EventHandler(this.CurserIndexCheck);
            this.prefDnsMi3.Enter += new System.EventHandler(this.mi_Enter);
            this.prefDnsMi3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.prefDnsMi3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // prefDnsMi2
            // 
            this.prefDnsMi2.HidePromptOnLeave = true;
            this.prefDnsMi2.Location = new System.Drawing.Point(308, 139);
            this.prefDnsMi2.Mask = "099";
            this.prefDnsMi2.Name = "prefDnsMi2";
            this.prefDnsMi2.PromptChar = ' ';
            this.prefDnsMi2.Size = new System.Drawing.Size(97, 23);
            this.prefDnsMi2.TabIndex = 39;
            this.prefDnsMi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prefDnsMi2.Click += new System.EventHandler(this.CurserIndexCheck);
            this.prefDnsMi2.Enter += new System.EventHandler(this.mi_Enter);
            this.prefDnsMi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.prefDnsMi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // prefDnsMi1
            // 
            this.prefDnsMi1.AllowPromptAsInput = false;
            this.prefDnsMi1.HidePromptOnLeave = true;
            this.prefDnsMi1.Location = new System.Drawing.Point(200, 139);
            this.prefDnsMi1.Mask = "099";
            this.prefDnsMi1.Name = "prefDnsMi1";
            this.prefDnsMi1.PromptChar = ' ';
            this.prefDnsMi1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prefDnsMi1.ShortcutsEnabled = false;
            this.prefDnsMi1.Size = new System.Drawing.Size(97, 23);
            this.prefDnsMi1.TabIndex = 37;
            this.prefDnsMi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prefDnsMi1.Click += new System.EventHandler(this.CurserIndexCheck);
            this.prefDnsMi1.Enter += new System.EventHandler(this.mi_Enter);
            this.prefDnsMi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.prefDnsMi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(405, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(512, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(298, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = ".";
            // 
            // gatewayMi4
            // 
            this.gatewayMi4.HidePromptOnLeave = true;
            this.gatewayMi4.Location = new System.Drawing.Point(522, 108);
            this.gatewayMi4.Mask = "099";
            this.gatewayMi4.Name = "gatewayMi4";
            this.gatewayMi4.PromptChar = ' ';
            this.gatewayMi4.Size = new System.Drawing.Size(97, 23);
            this.gatewayMi4.TabIndex = 36;
            this.gatewayMi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gatewayMi4.Click += new System.EventHandler(this.CurserIndexCheck);
            this.gatewayMi4.Enter += new System.EventHandler(this.mi_Enter);
            this.gatewayMi4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.gatewayMi4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FinalOctetCheck);
            // 
            // gatewayMi3
            // 
            this.gatewayMi3.HidePromptOnLeave = true;
            this.gatewayMi3.Location = new System.Drawing.Point(415, 108);
            this.gatewayMi3.Mask = "099";
            this.gatewayMi3.Name = "gatewayMi3";
            this.gatewayMi3.PromptChar = ' ';
            this.gatewayMi3.Size = new System.Drawing.Size(97, 23);
            this.gatewayMi3.TabIndex = 34;
            this.gatewayMi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gatewayMi3.Click += new System.EventHandler(this.CurserIndexCheck);
            this.gatewayMi3.Enter += new System.EventHandler(this.mi_Enter);
            this.gatewayMi3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.gatewayMi3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // gatewayMi2
            // 
            this.gatewayMi2.HidePromptOnLeave = true;
            this.gatewayMi2.Location = new System.Drawing.Point(308, 108);
            this.gatewayMi2.Mask = "099";
            this.gatewayMi2.Name = "gatewayMi2";
            this.gatewayMi2.PromptChar = ' ';
            this.gatewayMi2.Size = new System.Drawing.Size(97, 23);
            this.gatewayMi2.TabIndex = 32;
            this.gatewayMi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gatewayMi2.Click += new System.EventHandler(this.CurserIndexCheck);
            this.gatewayMi2.Enter += new System.EventHandler(this.mi_Enter);
            this.gatewayMi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.gatewayMi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // gatewayMi1
            // 
            this.gatewayMi1.AllowPromptAsInput = false;
            this.gatewayMi1.HidePromptOnLeave = true;
            this.gatewayMi1.Location = new System.Drawing.Point(200, 108);
            this.gatewayMi1.Mask = "099";
            this.gatewayMi1.Name = "gatewayMi1";
            this.gatewayMi1.PromptChar = ' ';
            this.gatewayMi1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gatewayMi1.ShortcutsEnabled = false;
            this.gatewayMi1.Size = new System.Drawing.Size(97, 23);
            this.gatewayMi1.TabIndex = 30;
            this.gatewayMi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gatewayMi1.Click += new System.EventHandler(this.CurserIndexCheck);
            this.gatewayMi1.Enter += new System.EventHandler(this.mi_Enter);
            this.gatewayMi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.gatewayMi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(405, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(512, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(298, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = ".";
            // 
            // subnetMi4
            // 
            this.subnetMi4.HidePromptOnLeave = true;
            this.subnetMi4.Location = new System.Drawing.Point(522, 79);
            this.subnetMi4.Mask = "099";
            this.subnetMi4.Name = "subnetMi4";
            this.subnetMi4.PromptChar = ' ';
            this.subnetMi4.Size = new System.Drawing.Size(97, 23);
            this.subnetMi4.TabIndex = 29;
            this.subnetMi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.subnetMi4, "Options: 0,128,192,224,240,248,252, 254");
            this.subnetMi4.Click += new System.EventHandler(this.CurserIndexCheck);
            this.subnetMi4.Enter += new System.EventHandler(this.mi_Enter);
            this.subnetMi4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.subnetMi4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FinalOctetCheck);
            this.subnetMi4.Leave += new System.EventHandler(this.SubnetMaskCheck);
            // 
            // subnetMi3
            // 
            this.subnetMi3.HidePromptOnLeave = true;
            this.subnetMi3.Location = new System.Drawing.Point(415, 79);
            this.subnetMi3.Mask = "099";
            this.subnetMi3.Name = "subnetMi3";
            this.subnetMi3.PromptChar = ' ';
            this.subnetMi3.Size = new System.Drawing.Size(97, 23);
            this.subnetMi3.TabIndex = 27;
            this.subnetMi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.subnetMi3, "Options: 0,128,192,224,240,248,252, 254 and 255");
            this.subnetMi3.Click += new System.EventHandler(this.CurserIndexCheck);
            this.subnetMi3.Enter += new System.EventHandler(this.mi_Enter);
            this.subnetMi3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.subnetMi3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subnetNumberInput);
            this.subnetMi3.Leave += new System.EventHandler(this.SubnetMaskCheck);
            // 
            // subnetMi2
            // 
            this.subnetMi2.HidePromptOnLeave = true;
            this.subnetMi2.Location = new System.Drawing.Point(308, 79);
            this.subnetMi2.Mask = "099";
            this.subnetMi2.Name = "subnetMi2";
            this.subnetMi2.PromptChar = ' ';
            this.subnetMi2.Size = new System.Drawing.Size(97, 23);
            this.subnetMi2.TabIndex = 25;
            this.subnetMi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.subnetMi2, "Options: 0,128,192,224,240,248,252, 254 and 255");
            this.subnetMi2.Click += new System.EventHandler(this.CurserIndexCheck);
            this.subnetMi2.Enter += new System.EventHandler(this.mi_Enter);
            this.subnetMi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.subnetMi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subnetNumberInput);
            this.subnetMi2.Leave += new System.EventHandler(this.SubnetMaskCheck);
            // 
            // subnetMi1
            // 
            this.subnetMi1.AllowPromptAsInput = false;
            this.subnetMi1.HidePromptOnLeave = true;
            this.subnetMi1.Location = new System.Drawing.Point(200, 79);
            this.subnetMi1.Mask = "099";
            this.subnetMi1.Name = "subnetMi1";
            this.subnetMi1.PromptChar = ' ';
            this.subnetMi1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subnetMi1.ShortcutsEnabled = false;
            this.subnetMi1.Size = new System.Drawing.Size(97, 23);
            this.subnetMi1.TabIndex = 23;
            this.subnetMi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.subnetMi1, "Options: 0,128,192,224,240,248,252, 254 and 255\r\n");
            this.subnetMi1.Click += new System.EventHandler(this.CurserIndexCheck);
            this.subnetMi1.Enter += new System.EventHandler(this.mi_Enter);
            this.subnetMi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.subnetMi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subnetNumberInput);
            this.subnetMi1.Leave += new System.EventHandler(this.SubnetMaskCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(405, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(512, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(298, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = ".";
            // 
            // ipMi4
            // 
            this.ipMi4.HidePromptOnLeave = true;
            this.ipMi4.Location = new System.Drawing.Point(522, 51);
            this.ipMi4.Mask = "099";
            this.ipMi4.Name = "ipMi4";
            this.ipMi4.PromptChar = ' ';
            this.ipMi4.Size = new System.Drawing.Size(97, 23);
            this.ipMi4.TabIndex = 22;
            this.ipMi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ipMi4, "Cannot be 255");
            this.ipMi4.Click += new System.EventHandler(this.CurserIndexCheck);
            this.ipMi4.Enter += new System.EventHandler(this.mi_Enter);
            this.ipMi4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.ipMi4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FinalOctetCheck);
            // 
            // ipMi3
            // 
            this.ipMi3.HidePromptOnLeave = true;
            this.ipMi3.Location = new System.Drawing.Point(415, 51);
            this.ipMi3.Mask = "099";
            this.ipMi3.Name = "ipMi3";
            this.ipMi3.PromptChar = ' ';
            this.ipMi3.Size = new System.Drawing.Size(97, 23);
            this.ipMi3.TabIndex = 20;
            this.ipMi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipMi3.Click += new System.EventHandler(this.CurserIndexCheck);
            this.ipMi3.Enter += new System.EventHandler(this.mi_Enter);
            this.ipMi3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.ipMi3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // ipMi2
            // 
            this.ipMi2.HidePromptOnLeave = true;
            this.ipMi2.Location = new System.Drawing.Point(308, 51);
            this.ipMi2.Mask = "099";
            this.ipMi2.Name = "ipMi2";
            this.ipMi2.PromptChar = ' ';
            this.ipMi2.Size = new System.Drawing.Size(97, 23);
            this.ipMi2.TabIndex = 18;
            this.ipMi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipMi2.Click += new System.EventHandler(this.CurserIndexCheck);
            this.ipMi2.Enter += new System.EventHandler(this.mi_Enter);
            this.ipMi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.ipMi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // ipMi1
            // 
            this.ipMi1.AllowPromptAsInput = false;
            this.ipMi1.HidePromptOnLeave = true;
            this.ipMi1.Location = new System.Drawing.Point(200, 51);
            this.ipMi1.Mask = "099";
            this.ipMi1.Name = "ipMi1";
            this.ipMi1.PromptChar = ' ';
            this.ipMi1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ipMi1.ShortcutsEnabled = false;
            this.ipMi1.Size = new System.Drawing.Size(97, 23);
            this.ipMi1.TabIndex = 16;
            this.ipMi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipMi1.Click += new System.EventHandler(this.CurserIndexCheck);
            this.ipMi1.Enter += new System.EventHandler(this.mi_Enter);
            this.ipMi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreArrowKey);
            this.ipMi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StandardNumberInput);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(3, 1);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(540, 16);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "All of the fields except the Alternate DNS server address are required.";
            // 
            // lblAlternateDns
            // 
            this.lblAlternateDns.AutoSize = true;
            this.lblAlternateDns.Location = new System.Drawing.Point(19, 176);
            this.lblAlternateDns.Name = "lblAlternateDns";
            this.lblAlternateDns.Size = new System.Drawing.Size(164, 15);
            this.lblAlternateDns.TabIndex = 4;
            this.lblAlternateDns.Text = "Alternate DNS server address: ";
            // 
            // lblPreferredDns
            // 
            this.lblPreferredDns.AutoSize = true;
            this.lblPreferredDns.Location = new System.Drawing.Point(19, 147);
            this.lblPreferredDns.Name = "lblPreferredDns";
            this.lblPreferredDns.Size = new System.Drawing.Size(164, 15);
            this.lblPreferredDns.TabIndex = 3;
            this.lblPreferredDns.Text = "Preferred DNS server address: ";
            // 
            // lblDefaultGateway
            // 
            this.lblDefaultGateway.AutoSize = true;
            this.lblDefaultGateway.Location = new System.Drawing.Point(19, 116);
            this.lblDefaultGateway.Name = "lblDefaultGateway";
            this.lblDefaultGateway.Size = new System.Drawing.Size(98, 15);
            this.lblDefaultGateway.TabIndex = 2;
            this.lblDefaultGateway.Text = "Default gateway: ";
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(19, 87);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(81, 15);
            this.lblSubnetMask.TabIndex = 1;
            this.lblSubnetMask.Text = "Subnet mask: ";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(19, 59);
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
        private System.Windows.Forms.Label lblHangingCompleteHeader;
        private System.Windows.Forms.Label lblCompleteParagraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbMainLabel;
        private System.Windows.Forms.RichTextBox rtbHeader;
        private System.Windows.Forms.MaskedTextBox ipMi4;
        private System.Windows.Forms.MaskedTextBox ipMi3;
        private System.Windows.Forms.MaskedTextBox ipMi2;
        private System.Windows.Forms.MaskedTextBox ipMi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox altDnsMi4;
        private System.Windows.Forms.MaskedTextBox altDnsMi3;
        private System.Windows.Forms.MaskedTextBox altDnsMi2;
        private System.Windows.Forms.MaskedTextBox altDnsMi1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox prefDnsMi4;
        private System.Windows.Forms.MaskedTextBox prefDnsMi3;
        private System.Windows.Forms.MaskedTextBox prefDnsMi2;
        private System.Windows.Forms.MaskedTextBox prefDnsMi1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox gatewayMi4;
        private System.Windows.Forms.MaskedTextBox gatewayMi3;
        private System.Windows.Forms.MaskedTextBox gatewayMi2;
        private System.Windows.Forms.MaskedTextBox gatewayMi1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox subnetMi4;
        private System.Windows.Forms.MaskedTextBox subnetMi3;
        private System.Windows.Forms.MaskedTextBox subnetMi2;
        private System.Windows.Forms.MaskedTextBox subnetMi1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblIpError;
        private System.Windows.Forms.Label lblNetworkError;
        private System.Windows.Forms.Label lblSubnetError;
        private System.Windows.Forms.Label lblEntryError;
        private System.Windows.Forms.Label lblPreferredError;
    }
}