namespace QEV1_Windows_Updated
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCOMnumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripErrorFlag = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.getDataTimer = new System.Windows.Forms.Timer(this.components);
            this.mainScreenTabControl = new System.Windows.Forms.TabControl();
            this.Overview_Tab = new System.Windows.Forms.TabPage();
            this.loggingStopStartButton = new System.Windows.Forms.Button();
            this.groupBoxCAN = new System.Windows.Forms.GroupBox();
            this.rx_status_label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBoxSerialTimer = new System.Windows.Forms.GroupBox();
            this.serialLinkSpeedLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vehicleProfileLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.editProfilesButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.profileStartupCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.profileCurrentCombo = new System.Windows.Forms.ComboBox();
            this.groupBoxInverter1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.avgVoltsLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxCellTempLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DCcurrentLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inverterTempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.coolantTempLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.brakeLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Enable1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RPM = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxAccumulators = new System.Windows.Forms.GroupBox();
            this.Accumulators_Tab = new System.Windows.Forms.TabPage();
            this.Inverters_Tab = new System.Windows.Forms.TabPage();
            this.TorqueVectoring_Tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.GLV_Tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PMnameBox4 = new System.Windows.Forms.TextBox();
            this.PMnameBox3 = new System.Windows.Forms.TextBox();
            this.PMnameBox2 = new System.Windows.Forms.TextBox();
            this.PMtypeLabel2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PMnameBox1 = new System.Windows.Forms.TextBox();
            this.PMchannelLabel1 = new System.Windows.Forms.Label();
            this.PMchannelLabel2 = new System.Windows.Forms.Label();
            this.PMchannelLabel3 = new System.Windows.Forms.Label();
            this.PMchannelLabel4 = new System.Windows.Forms.Label();
            this.PMchannelLabel5 = new System.Windows.Forms.Label();
            this.PMchannelLabel6 = new System.Windows.Forms.Label();
            this.PMchannelLabel7 = new System.Windows.Forms.Label();
            this.PMchannelLabel8 = new System.Windows.Forms.Label();
            this.PMchannelLabel9 = new System.Windows.Forms.Label();
            this.PMchannelLabel10 = new System.Windows.Forms.Label();
            this.PMchannelLabel11 = new System.Windows.Forms.Label();
            this.PMchannelLabel12 = new System.Windows.Forms.Label();
            this.PMchannelLabel13 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel1 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel2 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel3 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel4 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel5 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel6 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel7 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel8 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel9 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel10 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel11 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel12 = new System.Windows.Forms.Label();
            this.PMcurrentDrawLabel13 = new System.Windows.Forms.Label();
            this.PMstatusLabel1 = new System.Windows.Forms.Label();
            this.PMstatusLabel2 = new System.Windows.Forms.Label();
            this.PMstatusLabel3 = new System.Windows.Forms.Label();
            this.PMstatusLabel4 = new System.Windows.Forms.Label();
            this.PMstatusLabel5 = new System.Windows.Forms.Label();
            this.PMstatusLabel6 = new System.Windows.Forms.Label();
            this.PMstatusLabel7 = new System.Windows.Forms.Label();
            this.PMstatusLabel8 = new System.Windows.Forms.Label();
            this.PMstatusLabel9 = new System.Windows.Forms.Label();
            this.PMstatusLabel10 = new System.Windows.Forms.Label();
            this.PMstatusLabel11 = new System.Windows.Forms.Label();
            this.PMstatusLabel12 = new System.Windows.Forms.Label();
            this.PMstatusLabel13 = new System.Windows.Forms.Label();
            this.PMtypeLabel1 = new System.Windows.Forms.Label();
            this.PMtypeLabel4 = new System.Windows.Forms.Label();
            this.PMtypeLabel3 = new System.Windows.Forms.Label();
            this.PMtypeLabel5 = new System.Windows.Forms.Label();
            this.PMtypeLabel6 = new System.Windows.Forms.Label();
            this.PMtypeLabel7 = new System.Windows.Forms.Label();
            this.PMtypeLabel8 = new System.Windows.Forms.Label();
            this.PMtypeLabel9 = new System.Windows.Forms.Label();
            this.PMtypeLabel10 = new System.Windows.Forms.Label();
            this.PMtypeLabel11 = new System.Windows.Forms.Label();
            this.PMtypeLabel12 = new System.Windows.Forms.Label();
            this.PMtypeLabel13 = new System.Windows.Forms.Label();
            this.PMnameBox5 = new System.Windows.Forms.TextBox();
            this.PMnameBox6 = new System.Windows.Forms.TextBox();
            this.PMnameBox7 = new System.Windows.Forms.TextBox();
            this.PMnameBox8 = new System.Windows.Forms.TextBox();
            this.PMnameBox9 = new System.Windows.Forms.TextBox();
            this.PMnameBox10 = new System.Windows.Forms.TextBox();
            this.PMnameBox11 = new System.Windows.Forms.TextBox();
            this.PMnameBox12 = new System.Windows.Forms.TextBox();
            this.PMnameBox13 = new System.Windows.Forms.TextBox();
            this.Cooling_Tab = new System.Windows.Forms.TabPage();
            this.Safety_Tab = new System.Windows.Forms.TabPage();
            this.IOsetup_Tab = new System.Windows.Forms.TabPage();
            this.Diagnostics_Tab = new System.Windows.Forms.TabPage();
            this.balancingLabel = new System.Windows.Forms.Label();
            this.balancingButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CANrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Firmware_Tab = new System.Windows.Forms.TabPage();
            this.firmwareTextBox = new System.Windows.Forms.RichTextBox();
            this.firmwareLaunch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTorqueSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTorqueSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanForSerialPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToTelemetryServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview_Tab.SuspendLayout();
            this.groupBoxCAN.SuspendLayout();
            this.groupBoxSerialTimer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxInverter1.SuspendLayout();
            this.TorqueVectoring_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.GLV_Tab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Diagnostics_Tab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Firmware_Tab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConnectionStatus,
            this.statusCOMnumber,
            this.statusStripErrorFlag});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1046);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2013, 38);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusConnectionStatus
            // 
            this.statusConnectionStatus.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.statusConnectionStatus.AutoSize = false;
            this.statusConnectionStatus.BackColor = System.Drawing.Color.IndianRed;
            this.statusConnectionStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConnectionStatus.ForeColor = System.Drawing.Color.Black;
            this.statusConnectionStatus.Name = "statusConnectionStatus";
            this.statusConnectionStatus.Size = new System.Drawing.Size(120, 33);
            this.statusConnectionStatus.Text = "DISCONNECTED";
            this.statusConnectionStatus.Click += new System.EventHandler(this.statusConnectionStatus_Click);
            // 
            // statusCOMnumber
            // 
            this.statusCOMnumber.AutoSize = false;
            this.statusCOMnumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCOMnumber.Name = "statusCOMnumber";
            this.statusCOMnumber.Size = new System.Drawing.Size(80, 33);
            this.statusCOMnumber.Text = "COMx";
            // 
            // statusStripErrorFlag
            // 
            this.statusStripErrorFlag.AutoSize = false;
            this.statusStripErrorFlag.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripErrorFlag.Name = "statusStripErrorFlag";
            this.statusStripErrorFlag.Size = new System.Drawing.Size(118, 33);
            this.statusStripErrorFlag.Text = "No Errors";
            // 
            // getDataTimer
            // 
            this.getDataTimer.Tick += new System.EventHandler(this.getDataTimer_Tick);
            // 
            // mainScreenTabControl
            // 
            this.mainScreenTabControl.Controls.Add(this.Overview_Tab);
            this.mainScreenTabControl.Controls.Add(this.Accumulators_Tab);
            this.mainScreenTabControl.Controls.Add(this.Inverters_Tab);
            this.mainScreenTabControl.Controls.Add(this.TorqueVectoring_Tab);
            this.mainScreenTabControl.Controls.Add(this.GLV_Tab);
            this.mainScreenTabControl.Controls.Add(this.Cooling_Tab);
            this.mainScreenTabControl.Controls.Add(this.Safety_Tab);
            this.mainScreenTabControl.Controls.Add(this.IOsetup_Tab);
            this.mainScreenTabControl.Controls.Add(this.Diagnostics_Tab);
            this.mainScreenTabControl.Controls.Add(this.Firmware_Tab);
            this.mainScreenTabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenTabControl.Location = new System.Drawing.Point(0, 34);
            this.mainScreenTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(2025, 1040);
            this.mainScreenTabControl.TabIndex = 1;
            // 
            // Overview_Tab
            // 
            this.Overview_Tab.Controls.Add(this.loggingStopStartButton);
            this.Overview_Tab.Controls.Add(this.groupBoxCAN);
            this.Overview_Tab.Controls.Add(this.groupBoxSerialTimer);
            this.Overview_Tab.Controls.Add(this.groupBox4);
            this.Overview_Tab.Controls.Add(this.groupBoxInverter1);
            this.Overview_Tab.Controls.Add(this.groupBoxAccumulators);
            this.Overview_Tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview_Tab.Location = new System.Drawing.Point(4, 38);
            this.Overview_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Overview_Tab.Name = "Overview_Tab";
            this.Overview_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Overview_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Overview_Tab.TabIndex = 0;
            this.Overview_Tab.Text = "Overview";
            this.Overview_Tab.UseVisualStyleBackColor = true;
            this.Overview_Tab.Click += new System.EventHandler(this.Overview_Tab_Click);
            // 
            // loggingStopStartButton
            // 
            this.loggingStopStartButton.Location = new System.Drawing.Point(723, 30);
            this.loggingStopStartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loggingStopStartButton.Name = "loggingStopStartButton";
            this.loggingStopStartButton.Size = new System.Drawing.Size(184, 43);
            this.loggingStopStartButton.TabIndex = 6;
            this.loggingStopStartButton.Text = "Start Logging";
            this.loggingStopStartButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxCAN
            // 
            this.groupBoxCAN.Controls.Add(this.rx_status_label);
            this.groupBoxCAN.Controls.Add(this.label20);
            this.groupBoxCAN.Location = new System.Drawing.Point(430, 138);
            this.groupBoxCAN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCAN.Name = "groupBoxCAN";
            this.groupBoxCAN.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCAN.Size = new System.Drawing.Size(261, 115);
            this.groupBoxCAN.TabIndex = 5;
            this.groupBoxCAN.TabStop = false;
            this.groupBoxCAN.Text = "CAN";
            // 
            // rx_status_label
            // 
            this.rx_status_label.AutoSize = true;
            this.rx_status_label.Location = new System.Drawing.Point(141, 54);
            this.rx_status_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rx_status_label.Name = "rx_status_label";
            this.rx_status_label.Size = new System.Drawing.Size(34, 29);
            this.rx_status_label.TabIndex = 1;
            this.rx_status_label.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "RX status:";
            // 
            // groupBoxSerialTimer
            // 
            this.groupBoxSerialTimer.Controls.Add(this.serialLinkSpeedLabel);
            this.groupBoxSerialTimer.Controls.Add(this.label18);
            this.groupBoxSerialTimer.Location = new System.Drawing.Point(430, 14);
            this.groupBoxSerialTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSerialTimer.Name = "groupBoxSerialTimer";
            this.groupBoxSerialTimer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSerialTimer.Size = new System.Drawing.Size(261, 115);
            this.groupBoxSerialTimer.TabIndex = 4;
            this.groupBoxSerialTimer.TabStop = false;
            this.groupBoxSerialTimer.Text = "Serial Timer";
            // 
            // serialLinkSpeedLabel
            // 
            this.serialLinkSpeedLabel.AutoSize = true;
            this.serialLinkSpeedLabel.Location = new System.Drawing.Point(141, 54);
            this.serialLinkSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serialLinkSpeedLabel.Name = "serialLinkSpeedLabel";
            this.serialLinkSpeedLabel.Size = new System.Drawing.Size(34, 29);
            this.serialLinkSpeedLabel.TabIndex = 1;
            this.serialLinkSpeedLabel.Text = "---";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 54);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Link Speed:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vehicleProfileLabel);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.editProfilesButton);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.profileStartupCombo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.profileCurrentCombo);
            this.groupBox4.Location = new System.Drawing.Point(14, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(405, 317);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profiles";
            // 
            // vehicleProfileLabel
            // 
            this.vehicleProfileLabel.Location = new System.Drawing.Point(188, 177);
            this.vehicleProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehicleProfileLabel.Name = "vehicleProfileLabel";
            this.vehicleProfileLabel.Size = new System.Drawing.Size(177, 37);
            this.vehicleProfileLabel.TabIndex = 6;
            this.vehicleProfileLabel.Text = "---";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(10, 177);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 37);
            this.label17.TabIndex = 5;
            this.label17.Text = "Vehicle Current:";
            // 
            // editProfilesButton
            // 
            this.editProfilesButton.Location = new System.Drawing.Point(105, 243);
            this.editProfilesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editProfilesButton.Name = "editProfilesButton";
            this.editProfilesButton.Size = new System.Drawing.Size(189, 40);
            this.editProfilesButton.TabIndex = 4;
            this.editProfilesButton.Text = "Edit Profiles";
            this.editProfilesButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(10, 110);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 37);
            this.label16.TabIndex = 3;
            this.label16.Text = "Vehicle Startup:";
            // 
            // profileStartupCombo
            // 
            this.profileStartupCombo.FormattingEnabled = true;
            this.profileStartupCombo.Items.AddRange(new object[] {
            "Profile 1",
            "Profile 2",
            "Endurance",
            "Autocross",
            "Skid Pad",
            "Acceleration",
            "Testing 1"});
            this.profileStartupCombo.Location = new System.Drawing.Point(189, 108);
            this.profileStartupCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileStartupCombo.Name = "profileStartupCombo";
            this.profileStartupCombo.Size = new System.Drawing.Size(198, 37);
            this.profileStartupCombo.TabIndex = 2;
            this.profileStartupCombo.Text = "undefined";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(42, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "Current Edit:";
            // 
            // profileCurrentCombo
            // 
            this.profileCurrentCombo.FormattingEnabled = true;
            this.profileCurrentCombo.Items.AddRange(new object[] {
            "Profile 1",
            "Profile 2",
            "Endurance",
            "Autocross",
            "Skid Pad",
            "Acceleration",
            "Testing 1"});
            this.profileCurrentCombo.Location = new System.Drawing.Point(189, 42);
            this.profileCurrentCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileCurrentCombo.Name = "profileCurrentCombo";
            this.profileCurrentCombo.Size = new System.Drawing.Size(198, 37);
            this.profileCurrentCombo.TabIndex = 0;
            this.profileCurrentCombo.Text = "Profile 1";
            // 
            // groupBoxInverter1
            // 
            this.groupBoxInverter1.Controls.Add(this.label10);
            this.groupBoxInverter1.Controls.Add(this.avgVoltsLabel);
            this.groupBoxInverter1.Controls.Add(this.label25);
            this.groupBoxInverter1.Controls.Add(this.label7);
            this.groupBoxInverter1.Controls.Add(this.maxCellTempLabel);
            this.groupBoxInverter1.Controls.Add(this.label9);
            this.groupBoxInverter1.Controls.Add(this.label4);
            this.groupBoxInverter1.Controls.Add(this.DCcurrentLabel);
            this.groupBoxInverter1.Controls.Add(this.label6);
            this.groupBoxInverter1.Controls.Add(this.label1);
            this.groupBoxInverter1.Controls.Add(this.inverterTempLabel);
            this.groupBoxInverter1.Controls.Add(this.label3);
            this.groupBoxInverter1.Controls.Add(this.label21);
            this.groupBoxInverter1.Controls.Add(this.coolantTempLabel);
            this.groupBoxInverter1.Controls.Add(this.label24);
            this.groupBoxInverter1.Controls.Add(this.label19);
            this.groupBoxInverter1.Controls.Add(this.brakeLabel);
            this.groupBoxInverter1.Controls.Add(this.label22);
            this.groupBoxInverter1.Controls.Add(this.Enable1);
            this.groupBoxInverter1.Controls.Add(this.label12);
            this.groupBoxInverter1.Controls.Add(this.label15);
            this.groupBoxInverter1.Controls.Add(this.throttleLabel);
            this.groupBoxInverter1.Controls.Add(this.label14);
            this.groupBoxInverter1.Controls.Add(this.RPM);
            this.groupBoxInverter1.Controls.Add(this.label13);
            this.groupBoxInverter1.Location = new System.Drawing.Point(723, 98);
            this.groupBoxInverter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter1.Name = "groupBoxInverter1";
            this.groupBoxInverter1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter1.Size = new System.Drawing.Size(765, 630);
            this.groupBoxInverter1.TabIndex = 1;
            this.groupBoxInverter1.TabStop = false;
            this.groupBoxInverter1.Text = "Inverter 1 (Test)";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(399, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 72);
            this.label10.TabIndex = 60;
            this.label10.Text = "V";
            // 
            // avgVoltsLabel
            // 
            this.avgVoltsLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgVoltsLabel.Location = new System.Drawing.Point(302, 242);
            this.avgVoltsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avgVoltsLabel.Name = "avgVoltsLabel";
            this.avgVoltsLabel.Size = new System.Drawing.Size(100, 72);
            this.avgVoltsLabel.TabIndex = 59;
            this.avgVoltsLabel.Text = "25";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(33, 242);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(260, 72);
            this.label25.TabIndex = 58;
            this.label25.Text = "Average Voltage";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 72);
            this.label7.TabIndex = 57;
            this.label7.Text = "°C";
            // 
            // maxCellTempLabel
            // 
            this.maxCellTempLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCellTempLabel.Location = new System.Drawing.Point(302, 312);
            this.maxCellTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxCellTempLabel.Name = "maxCellTempLabel";
            this.maxCellTempLabel.Size = new System.Drawing.Size(100, 72);
            this.maxCellTempLabel.TabIndex = 56;
            this.maxCellTempLabel.Text = "25";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 72);
            this.label9.TabIndex = 55;
            this.label9.Text = "Max Cell Temp";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 72);
            this.label4.TabIndex = 54;
            this.label4.Text = "A";
            // 
            // DCcurrentLabel
            // 
            this.DCcurrentLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCcurrentLabel.Location = new System.Drawing.Point(302, 380);
            this.DCcurrentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCcurrentLabel.Name = "DCcurrentLabel";
            this.DCcurrentLabel.Size = new System.Drawing.Size(100, 72);
            this.DCcurrentLabel.TabIndex = 53;
            this.DCcurrentLabel.Text = "25";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 72);
            this.label6.TabIndex = 52;
            this.label6.Text = "DC Current";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 72);
            this.label1.TabIndex = 51;
            this.label1.Text = "°C";
            // 
            // inverterTempLabel
            // 
            this.inverterTempLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterTempLabel.Location = new System.Drawing.Point(302, 452);
            this.inverterTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inverterTempLabel.Name = "inverterTempLabel";
            this.inverterTempLabel.Size = new System.Drawing.Size(100, 72);
            this.inverterTempLabel.TabIndex = 50;
            this.inverterTempLabel.Text = "25";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 72);
            this.label3.TabIndex = 49;
            this.label3.Text = "Inverter Temp";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(384, 525);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 72);
            this.label21.TabIndex = 48;
            this.label21.Text = "°C";
            // 
            // coolantTempLabel
            // 
            this.coolantTempLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolantTempLabel.Location = new System.Drawing.Point(298, 525);
            this.coolantTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coolantTempLabel.Name = "coolantTempLabel";
            this.coolantTempLabel.Size = new System.Drawing.Size(100, 72);
            this.coolantTempLabel.TabIndex = 47;
            this.coolantTempLabel.Text = "25";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(30, 525);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(260, 72);
            this.label24.TabIndex = 46;
            this.label24.Text = "Coolant Temp";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(224, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 30);
            this.label19.TabIndex = 45;
            this.label19.Text = "%";
            // 
            // brakeLabel
            // 
            this.brakeLabel.Location = new System.Drawing.Point(147, 85);
            this.brakeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brakeLabel.Name = "brakeLabel";
            this.brakeLabel.Size = new System.Drawing.Size(68, 30);
            this.brakeLabel.TabIndex = 44;
            this.brakeLabel.Text = "1.234";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(33, 85);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 30);
            this.label22.TabIndex = 43;
            this.label22.Text = "Brake";
            // 
            // Enable1
            // 
            this.Enable1.ForeColor = System.Drawing.Color.Red;
            this.Enable1.Location = new System.Drawing.Point(148, 150);
            this.Enable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enable1.Name = "Enable1";
            this.Enable1.Size = new System.Drawing.Size(64, 30);
            this.Enable1.TabIndex = 42;
            this.Enable1.Text = "False";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(32, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 30);
            this.label12.TabIndex = 41;
            this.label12.Text = "Enable";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(222, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 30);
            this.label15.TabIndex = 40;
            this.label15.Text = "%";
            // 
            // throttleLabel
            // 
            this.throttleLabel.Location = new System.Drawing.Point(146, 50);
            this.throttleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(68, 30);
            this.throttleLabel.TabIndex = 39;
            this.throttleLabel.Text = "1.234";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(32, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 30);
            this.label14.TabIndex = 36;
            this.label14.Text = "Throttle";
            // 
            // RPM
            // 
            this.RPM.Location = new System.Drawing.Point(148, 122);
            this.RPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RPM.Name = "RPM";
            this.RPM.Size = new System.Drawing.Size(98, 30);
            this.RPM.TabIndex = 38;
            this.RPM.Text = "44";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(32, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 30);
            this.label13.TabIndex = 37;
            this.label13.Text = "RPM";
            // 
            // groupBoxAccumulators
            // 
            this.groupBoxAccumulators.Location = new System.Drawing.Point(15, 340);
            this.groupBoxAccumulators.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAccumulators.Name = "groupBoxAccumulators";
            this.groupBoxAccumulators.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAccumulators.Size = new System.Drawing.Size(496, 403);
            this.groupBoxAccumulators.TabIndex = 0;
            this.groupBoxAccumulators.TabStop = false;
            this.groupBoxAccumulators.Text = "Accumulators";
            // 
            // Accumulators_Tab
            // 
            this.Accumulators_Tab.Location = new System.Drawing.Point(4, 38);
            this.Accumulators_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accumulators_Tab.Name = "Accumulators_Tab";
            this.Accumulators_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accumulators_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Accumulators_Tab.TabIndex = 1;
            this.Accumulators_Tab.Text = "Accumulators";
            this.Accumulators_Tab.UseVisualStyleBackColor = true;
            // 
            // Inverters_Tab
            // 
            this.Inverters_Tab.Location = new System.Drawing.Point(4, 38);
            this.Inverters_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inverters_Tab.Name = "Inverters_Tab";
            this.Inverters_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inverters_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Inverters_Tab.TabIndex = 2;
            this.Inverters_Tab.Text = "Inverters";
            this.Inverters_Tab.UseVisualStyleBackColor = true;
            // 
            // TorqueVectoring_Tab
            // 
            this.TorqueVectoring_Tab.BackgroundImage = global::QEV1_Windows_Updated.Properties.Resources.car_outline1;
            this.TorqueVectoring_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TorqueVectoring_Tab.Controls.Add(this.dataGridView1);
            this.TorqueVectoring_Tab.Location = new System.Drawing.Point(4, 38);
            this.TorqueVectoring_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TorqueVectoring_Tab.Name = "TorqueVectoring_Tab";
            this.TorqueVectoring_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TorqueVectoring_Tab.Size = new System.Drawing.Size(2017, 998);
            this.TorqueVectoring_Tab.TabIndex = 3;
            this.TorqueVectoring_Tab.Text = "Torque Vectoring";
            this.TorqueVectoring_Tab.UseVisualStyleBackColor = true;
            this.TorqueVectoring_Tab.Enter += new System.EventHandler(this.TorqueVectoring_Tab_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("Relation1", "Table1", "Table1", new string[] {
                        "Rate 1"}, new string[] {
                        "Rate 2"}, false)});
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "Rate 1"}, false),
            new System.Data.ForeignKeyConstraint("Relation1", "Table1", new string[] {
                        "Rate 1"}, new string[] {
                        "Rate 2"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Rate 1";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Rate 2";
            // 
            // GLV_Tab
            // 
            this.GLV_Tab.Controls.Add(this.tableLayoutPanel1);
            this.GLV_Tab.Location = new System.Drawing.Point(4, 38);
            this.GLV_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GLV_Tab.Name = "GLV_Tab";
            this.GLV_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GLV_Tab.Size = new System.Drawing.Size(2017, 998);
            this.GLV_Tab.TabIndex = 4;
            this.GLV_Tab.Text = "Power Management";
            this.GLV_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.87156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 473F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label28, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label27, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel11, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel12, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.PMchannelLabel13, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel4, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel5, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel6, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel7, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel8, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel9, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel10, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel11, 6, 11);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel12, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.PMcurrentDrawLabel13, 6, 13);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel4, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel6, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel7, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel8, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel9, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel10, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel11, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel12, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.PMstatusLabel13, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel9, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel10, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel11, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel12, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.PMtypeLabel13, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox10, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox11, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox12, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.PMnameBox13, 1, 13);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1989, 982);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PMnameBox4
            // 
            this.PMnameBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox4.Location = new System.Drawing.Point(141, 307);
            this.PMnameBox4.MaxLength = 16;
            this.PMnameBox4.Name = "PMnameBox4";
            this.PMnameBox4.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox4.TabIndex = 68;
            // 
            // PMnameBox3
            // 
            this.PMnameBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox3.Location = new System.Drawing.Point(141, 239);
            this.PMnameBox3.MaxLength = 16;
            this.PMnameBox3.Name = "PMnameBox3";
            this.PMnameBox3.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox3.TabIndex = 65;
            // 
            // PMnameBox2
            // 
            this.PMnameBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox2.Location = new System.Drawing.Point(141, 171);
            this.PMnameBox2.MaxLength = 16;
            this.PMnameBox2.Name = "PMnameBox2";
            this.PMnameBox2.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox2.TabIndex = 62;
            // 
            // PMtypeLabel2
            // 
            this.PMtypeLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel2.AutoSize = true;
            this.PMtypeLabel2.Location = new System.Drawing.Point(437, 175);
            this.PMtypeLabel2.Name = "PMtypeLabel2";
            this.PMtypeLabel2.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel2.TabIndex = 51;
            this.PMtypeLabel2.Text = "High Current";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1810, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(145, 29);
            this.label28.TabIndex = 6;
            this.label28.Text = "Current Draw";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1644, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 29);
            this.label27.TabIndex = 5;
            this.label27.Text = "Status";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1297, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 29);
            this.label26.TabIndex = 4;
            this.label26.Text = "Effort";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(772, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 29);
            this.label23.TabIndex = 3;
            this.label23.Text = "Trip Current";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Channel";
            // 
            // PMnameBox1
            // 
            this.PMnameBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox1.Location = new System.Drawing.Point(141, 103);
            this.PMnameBox1.MaxLength = 16;
            this.PMnameBox1.Name = "PMnameBox1";
            this.PMnameBox1.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox1.TabIndex = 7;
            // 
            // PMchannelLabel1
            // 
            this.PMchannelLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel1.AutoSize = true;
            this.PMchannelLabel1.Location = new System.Drawing.Point(47, 107);
            this.PMchannelLabel1.Name = "PMchannelLabel1";
            this.PMchannelLabel1.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel1.TabIndex = 8;
            this.PMchannelLabel1.Text = "1";
            // 
            // PMchannelLabel2
            // 
            this.PMchannelLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel2.AutoSize = true;
            this.PMchannelLabel2.Location = new System.Drawing.Point(47, 175);
            this.PMchannelLabel2.Name = "PMchannelLabel2";
            this.PMchannelLabel2.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel2.TabIndex = 9;
            this.PMchannelLabel2.Text = "2";
            // 
            // PMchannelLabel3
            // 
            this.PMchannelLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel3.AutoSize = true;
            this.PMchannelLabel3.Location = new System.Drawing.Point(47, 243);
            this.PMchannelLabel3.Name = "PMchannelLabel3";
            this.PMchannelLabel3.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel3.TabIndex = 10;
            this.PMchannelLabel3.Text = "3";
            // 
            // PMchannelLabel4
            // 
            this.PMchannelLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel4.AutoSize = true;
            this.PMchannelLabel4.Location = new System.Drawing.Point(47, 311);
            this.PMchannelLabel4.Name = "PMchannelLabel4";
            this.PMchannelLabel4.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel4.TabIndex = 11;
            this.PMchannelLabel4.Text = "4";
            // 
            // PMchannelLabel5
            // 
            this.PMchannelLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel5.AutoSize = true;
            this.PMchannelLabel5.Location = new System.Drawing.Point(47, 379);
            this.PMchannelLabel5.Name = "PMchannelLabel5";
            this.PMchannelLabel5.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel5.TabIndex = 12;
            this.PMchannelLabel5.Text = "5";
            // 
            // PMchannelLabel6
            // 
            this.PMchannelLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel6.AutoSize = true;
            this.PMchannelLabel6.Location = new System.Drawing.Point(47, 447);
            this.PMchannelLabel6.Name = "PMchannelLabel6";
            this.PMchannelLabel6.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel6.TabIndex = 13;
            this.PMchannelLabel6.Text = "6";
            // 
            // PMchannelLabel7
            // 
            this.PMchannelLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel7.AutoSize = true;
            this.PMchannelLabel7.Location = new System.Drawing.Point(47, 515);
            this.PMchannelLabel7.Name = "PMchannelLabel7";
            this.PMchannelLabel7.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel7.TabIndex = 14;
            this.PMchannelLabel7.Text = "7";
            // 
            // PMchannelLabel8
            // 
            this.PMchannelLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel8.AutoSize = true;
            this.PMchannelLabel8.Location = new System.Drawing.Point(47, 583);
            this.PMchannelLabel8.Name = "PMchannelLabel8";
            this.PMchannelLabel8.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel8.TabIndex = 15;
            this.PMchannelLabel8.Text = "8";
            // 
            // PMchannelLabel9
            // 
            this.PMchannelLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel9.AutoSize = true;
            this.PMchannelLabel9.Location = new System.Drawing.Point(47, 651);
            this.PMchannelLabel9.Name = "PMchannelLabel9";
            this.PMchannelLabel9.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel9.TabIndex = 16;
            this.PMchannelLabel9.Text = "9";
            // 
            // PMchannelLabel10
            // 
            this.PMchannelLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel10.AutoSize = true;
            this.PMchannelLabel10.Location = new System.Drawing.Point(41, 719);
            this.PMchannelLabel10.Name = "PMchannelLabel10";
            this.PMchannelLabel10.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel10.TabIndex = 17;
            this.PMchannelLabel10.Text = "10";
            // 
            // PMchannelLabel11
            // 
            this.PMchannelLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel11.AutoSize = true;
            this.PMchannelLabel11.Location = new System.Drawing.Point(41, 787);
            this.PMchannelLabel11.Name = "PMchannelLabel11";
            this.PMchannelLabel11.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel11.TabIndex = 18;
            this.PMchannelLabel11.Text = "11";
            // 
            // PMchannelLabel12
            // 
            this.PMchannelLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel12.AutoSize = true;
            this.PMchannelLabel12.Location = new System.Drawing.Point(41, 855);
            this.PMchannelLabel12.Name = "PMchannelLabel12";
            this.PMchannelLabel12.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel12.TabIndex = 19;
            this.PMchannelLabel12.Text = "12";
            // 
            // PMchannelLabel13
            // 
            this.PMchannelLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel13.AutoSize = true;
            this.PMchannelLabel13.Location = new System.Drawing.Point(41, 928);
            this.PMchannelLabel13.Name = "PMchannelLabel13";
            this.PMchannelLabel13.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel13.TabIndex = 20;
            this.PMchannelLabel13.Text = "13";
            // 
            // PMcurrentDrawLabel1
            // 
            this.PMcurrentDrawLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel1.AutoSize = true;
            this.PMcurrentDrawLabel1.Location = new System.Drawing.Point(1831, 107);
            this.PMcurrentDrawLabel1.Name = "PMcurrentDrawLabel1";
            this.PMcurrentDrawLabel1.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel1.TabIndex = 21;
            this.PMcurrentDrawLabel1.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel2
            // 
            this.PMcurrentDrawLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel2.AutoSize = true;
            this.PMcurrentDrawLabel2.Location = new System.Drawing.Point(1831, 175);
            this.PMcurrentDrawLabel2.Name = "PMcurrentDrawLabel2";
            this.PMcurrentDrawLabel2.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel2.TabIndex = 22;
            this.PMcurrentDrawLabel2.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel3
            // 
            this.PMcurrentDrawLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel3.AutoSize = true;
            this.PMcurrentDrawLabel3.Location = new System.Drawing.Point(1831, 243);
            this.PMcurrentDrawLabel3.Name = "PMcurrentDrawLabel3";
            this.PMcurrentDrawLabel3.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel3.TabIndex = 23;
            this.PMcurrentDrawLabel3.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel4
            // 
            this.PMcurrentDrawLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel4.AutoSize = true;
            this.PMcurrentDrawLabel4.Location = new System.Drawing.Point(1831, 311);
            this.PMcurrentDrawLabel4.Name = "PMcurrentDrawLabel4";
            this.PMcurrentDrawLabel4.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel4.TabIndex = 24;
            this.PMcurrentDrawLabel4.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel5
            // 
            this.PMcurrentDrawLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel5.AutoSize = true;
            this.PMcurrentDrawLabel5.Location = new System.Drawing.Point(1831, 379);
            this.PMcurrentDrawLabel5.Name = "PMcurrentDrawLabel5";
            this.PMcurrentDrawLabel5.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel5.TabIndex = 25;
            this.PMcurrentDrawLabel5.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel6
            // 
            this.PMcurrentDrawLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel6.AutoSize = true;
            this.PMcurrentDrawLabel6.Location = new System.Drawing.Point(1831, 447);
            this.PMcurrentDrawLabel6.Name = "PMcurrentDrawLabel6";
            this.PMcurrentDrawLabel6.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel6.TabIndex = 26;
            this.PMcurrentDrawLabel6.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel7
            // 
            this.PMcurrentDrawLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel7.AutoSize = true;
            this.PMcurrentDrawLabel7.Location = new System.Drawing.Point(1831, 515);
            this.PMcurrentDrawLabel7.Name = "PMcurrentDrawLabel7";
            this.PMcurrentDrawLabel7.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel7.TabIndex = 27;
            this.PMcurrentDrawLabel7.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel8
            // 
            this.PMcurrentDrawLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel8.AutoSize = true;
            this.PMcurrentDrawLabel8.Location = new System.Drawing.Point(1831, 583);
            this.PMcurrentDrawLabel8.Name = "PMcurrentDrawLabel8";
            this.PMcurrentDrawLabel8.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel8.TabIndex = 28;
            this.PMcurrentDrawLabel8.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel9
            // 
            this.PMcurrentDrawLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel9.AutoSize = true;
            this.PMcurrentDrawLabel9.Location = new System.Drawing.Point(1831, 651);
            this.PMcurrentDrawLabel9.Name = "PMcurrentDrawLabel9";
            this.PMcurrentDrawLabel9.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel9.TabIndex = 29;
            this.PMcurrentDrawLabel9.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel10
            // 
            this.PMcurrentDrawLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel10.AutoSize = true;
            this.PMcurrentDrawLabel10.Location = new System.Drawing.Point(1831, 719);
            this.PMcurrentDrawLabel10.Name = "PMcurrentDrawLabel10";
            this.PMcurrentDrawLabel10.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel10.TabIndex = 30;
            this.PMcurrentDrawLabel10.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel11
            // 
            this.PMcurrentDrawLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel11.AutoSize = true;
            this.PMcurrentDrawLabel11.Location = new System.Drawing.Point(1831, 787);
            this.PMcurrentDrawLabel11.Name = "PMcurrentDrawLabel11";
            this.PMcurrentDrawLabel11.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel11.TabIndex = 31;
            this.PMcurrentDrawLabel11.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel12
            // 
            this.PMcurrentDrawLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel12.AutoSize = true;
            this.PMcurrentDrawLabel12.Location = new System.Drawing.Point(1831, 855);
            this.PMcurrentDrawLabel12.Name = "PMcurrentDrawLabel12";
            this.PMcurrentDrawLabel12.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel12.TabIndex = 32;
            this.PMcurrentDrawLabel12.Text = "0.0 Amps";
            // 
            // PMcurrentDrawLabel13
            // 
            this.PMcurrentDrawLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel13.AutoSize = true;
            this.PMcurrentDrawLabel13.Location = new System.Drawing.Point(1831, 928);
            this.PMcurrentDrawLabel13.Name = "PMcurrentDrawLabel13";
            this.PMcurrentDrawLabel13.Size = new System.Drawing.Size(103, 29);
            this.PMcurrentDrawLabel13.TabIndex = 33;
            this.PMcurrentDrawLabel13.Text = "0.0 Amps";
            // 
            // PMstatusLabel1
            // 
            this.PMstatusLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel1.AutoSize = true;
            this.PMstatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PMstatusLabel1.ForeColor = System.Drawing.Color.Green;
            this.PMstatusLabel1.Location = new System.Drawing.Point(1659, 107);
            this.PMstatusLabel1.Name = "PMstatusLabel1";
            this.PMstatusLabel1.Size = new System.Drawing.Size(45, 29);
            this.PMstatusLabel1.TabIndex = 34;
            this.PMstatusLabel1.Text = "ON";
            // 
            // PMstatusLabel2
            // 
            this.PMstatusLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel2.AutoSize = true;
            this.PMstatusLabel2.Location = new System.Drawing.Point(1656, 175);
            this.PMstatusLabel2.Name = "PMstatusLabel2";
            this.PMstatusLabel2.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel2.TabIndex = 35;
            this.PMstatusLabel2.Text = "OFF";
            // 
            // PMstatusLabel3
            // 
            this.PMstatusLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel3.AutoSize = true;
            this.PMstatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PMstatusLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.PMstatusLabel3.Location = new System.Drawing.Point(1627, 243);
            this.PMstatusLabel3.Name = "PMstatusLabel3";
            this.PMstatusLabel3.Size = new System.Drawing.Size(109, 29);
            this.PMstatusLabel3.TabIndex = 36;
            this.PMstatusLabel3.Text = "DISABLED";
            // 
            // PMstatusLabel4
            // 
            this.PMstatusLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel4.AutoSize = true;
            this.PMstatusLabel4.BackColor = System.Drawing.Color.Red;
            this.PMstatusLabel4.ForeColor = System.Drawing.Color.White;
            this.PMstatusLabel4.Location = new System.Drawing.Point(1653, 311);
            this.PMstatusLabel4.Name = "PMstatusLabel4";
            this.PMstatusLabel4.Size = new System.Drawing.Size(56, 29);
            this.PMstatusLabel4.TabIndex = 37;
            this.PMstatusLabel4.Text = "TRIP";
            // 
            // PMstatusLabel5
            // 
            this.PMstatusLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel5.AutoSize = true;
            this.PMstatusLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PMstatusLabel5.ForeColor = System.Drawing.Color.Red;
            this.PMstatusLabel5.Location = new System.Drawing.Point(1645, 379);
            this.PMstatusLabel5.Name = "PMstatusLabel5";
            this.PMstatusLabel5.Size = new System.Drawing.Size(72, 29);
            this.PMstatusLabel5.TabIndex = 38;
            this.PMstatusLabel5.Text = "FAULT";
            // 
            // PMstatusLabel6
            // 
            this.PMstatusLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel6.AutoSize = true;
            this.PMstatusLabel6.Location = new System.Drawing.Point(1656, 447);
            this.PMstatusLabel6.Name = "PMstatusLabel6";
            this.PMstatusLabel6.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel6.TabIndex = 39;
            this.PMstatusLabel6.Text = "OFF";
            // 
            // PMstatusLabel7
            // 
            this.PMstatusLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel7.AutoSize = true;
            this.PMstatusLabel7.Location = new System.Drawing.Point(1656, 515);
            this.PMstatusLabel7.Name = "PMstatusLabel7";
            this.PMstatusLabel7.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel7.TabIndex = 40;
            this.PMstatusLabel7.Text = "OFF";
            // 
            // PMstatusLabel8
            // 
            this.PMstatusLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel8.AutoSize = true;
            this.PMstatusLabel8.Location = new System.Drawing.Point(1656, 583);
            this.PMstatusLabel8.Name = "PMstatusLabel8";
            this.PMstatusLabel8.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel8.TabIndex = 41;
            this.PMstatusLabel8.Text = "OFF";
            // 
            // PMstatusLabel9
            // 
            this.PMstatusLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel9.AutoSize = true;
            this.PMstatusLabel9.Location = new System.Drawing.Point(1656, 651);
            this.PMstatusLabel9.Name = "PMstatusLabel9";
            this.PMstatusLabel9.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel9.TabIndex = 42;
            this.PMstatusLabel9.Text = "OFF";
            // 
            // PMstatusLabel10
            // 
            this.PMstatusLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel10.AutoSize = true;
            this.PMstatusLabel10.Location = new System.Drawing.Point(1656, 719);
            this.PMstatusLabel10.Name = "PMstatusLabel10";
            this.PMstatusLabel10.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel10.TabIndex = 43;
            this.PMstatusLabel10.Text = "OFF";
            // 
            // PMstatusLabel11
            // 
            this.PMstatusLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel11.AutoSize = true;
            this.PMstatusLabel11.Location = new System.Drawing.Point(1656, 787);
            this.PMstatusLabel11.Name = "PMstatusLabel11";
            this.PMstatusLabel11.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel11.TabIndex = 44;
            this.PMstatusLabel11.Text = "OFF";
            // 
            // PMstatusLabel12
            // 
            this.PMstatusLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel12.AutoSize = true;
            this.PMstatusLabel12.Location = new System.Drawing.Point(1656, 855);
            this.PMstatusLabel12.Name = "PMstatusLabel12";
            this.PMstatusLabel12.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel12.TabIndex = 45;
            this.PMstatusLabel12.Text = "OFF";
            // 
            // PMstatusLabel13
            // 
            this.PMstatusLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel13.AutoSize = true;
            this.PMstatusLabel13.Location = new System.Drawing.Point(1656, 928);
            this.PMstatusLabel13.Name = "PMstatusLabel13";
            this.PMstatusLabel13.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel13.TabIndex = 46;
            this.PMstatusLabel13.Text = "OFF";
            // 
            // PMtypeLabel1
            // 
            this.PMtypeLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel1.AutoSize = true;
            this.PMtypeLabel1.Location = new System.Drawing.Point(437, 107);
            this.PMtypeLabel1.Name = "PMtypeLabel1";
            this.PMtypeLabel1.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel1.TabIndex = 47;
            this.PMtypeLabel1.Text = "High Current";
            // 
            // PMtypeLabel4
            // 
            this.PMtypeLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel4.AutoSize = true;
            this.PMtypeLabel4.Location = new System.Drawing.Point(437, 311);
            this.PMtypeLabel4.Name = "PMtypeLabel4";
            this.PMtypeLabel4.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel4.TabIndex = 54;
            this.PMtypeLabel4.Text = "High Current";
            // 
            // PMtypeLabel3
            // 
            this.PMtypeLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel3.AutoSize = true;
            this.PMtypeLabel3.Location = new System.Drawing.Point(437, 243);
            this.PMtypeLabel3.Name = "PMtypeLabel3";
            this.PMtypeLabel3.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel3.TabIndex = 50;
            this.PMtypeLabel3.Text = "High Current";
            // 
            // PMtypeLabel5
            // 
            this.PMtypeLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel5.AutoSize = true;
            this.PMtypeLabel5.Location = new System.Drawing.Point(437, 379);
            this.PMtypeLabel5.Name = "PMtypeLabel5";
            this.PMtypeLabel5.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel5.TabIndex = 52;
            this.PMtypeLabel5.Text = "High Current";
            // 
            // PMtypeLabel6
            // 
            this.PMtypeLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel6.AutoSize = true;
            this.PMtypeLabel6.Location = new System.Drawing.Point(437, 447);
            this.PMtypeLabel6.Name = "PMtypeLabel6";
            this.PMtypeLabel6.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel6.TabIndex = 53;
            this.PMtypeLabel6.Text = "High Current";
            // 
            // PMtypeLabel7
            // 
            this.PMtypeLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel7.AutoSize = true;
            this.PMtypeLabel7.Location = new System.Drawing.Point(437, 515);
            this.PMtypeLabel7.Name = "PMtypeLabel7";
            this.PMtypeLabel7.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel7.TabIndex = 49;
            this.PMtypeLabel7.Text = "High Current";
            // 
            // PMtypeLabel8
            // 
            this.PMtypeLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel8.AutoSize = true;
            this.PMtypeLabel8.Location = new System.Drawing.Point(437, 583);
            this.PMtypeLabel8.Name = "PMtypeLabel8";
            this.PMtypeLabel8.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel8.TabIndex = 48;
            this.PMtypeLabel8.Text = "High Current";
            // 
            // PMtypeLabel9
            // 
            this.PMtypeLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel9.AutoSize = true;
            this.PMtypeLabel9.Location = new System.Drawing.Point(437, 651);
            this.PMtypeLabel9.Name = "PMtypeLabel9";
            this.PMtypeLabel9.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel9.TabIndex = 55;
            this.PMtypeLabel9.Text = "High Current";
            // 
            // PMtypeLabel10
            // 
            this.PMtypeLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel10.AutoSize = true;
            this.PMtypeLabel10.Location = new System.Drawing.Point(438, 719);
            this.PMtypeLabel10.Name = "PMtypeLabel10";
            this.PMtypeLabel10.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel10.TabIndex = 56;
            this.PMtypeLabel10.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel11
            // 
            this.PMtypeLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel11.AutoSize = true;
            this.PMtypeLabel11.Location = new System.Drawing.Point(438, 787);
            this.PMtypeLabel11.Name = "PMtypeLabel11";
            this.PMtypeLabel11.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel11.TabIndex = 57;
            this.PMtypeLabel11.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel12
            // 
            this.PMtypeLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel12.AutoSize = true;
            this.PMtypeLabel12.Location = new System.Drawing.Point(438, 855);
            this.PMtypeLabel12.Name = "PMtypeLabel12";
            this.PMtypeLabel12.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel12.TabIndex = 58;
            this.PMtypeLabel12.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel13
            // 
            this.PMtypeLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel13.AutoSize = true;
            this.PMtypeLabel13.Location = new System.Drawing.Point(438, 928);
            this.PMtypeLabel13.Name = "PMtypeLabel13";
            this.PMtypeLabel13.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel13.TabIndex = 59;
            this.PMtypeLabel13.Text = "Push/Pull 5A";
            // 
            // PMnameBox5
            // 
            this.PMnameBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox5.Location = new System.Drawing.Point(141, 375);
            this.PMnameBox5.MaxLength = 16;
            this.PMnameBox5.Name = "PMnameBox5";
            this.PMnameBox5.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox5.TabIndex = 60;
            // 
            // PMnameBox6
            // 
            this.PMnameBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox6.Location = new System.Drawing.Point(141, 443);
            this.PMnameBox6.MaxLength = 16;
            this.PMnameBox6.Name = "PMnameBox6";
            this.PMnameBox6.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox6.TabIndex = 63;
            // 
            // PMnameBox7
            // 
            this.PMnameBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox7.Location = new System.Drawing.Point(141, 511);
            this.PMnameBox7.MaxLength = 16;
            this.PMnameBox7.Name = "PMnameBox7";
            this.PMnameBox7.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox7.TabIndex = 66;
            // 
            // PMnameBox8
            // 
            this.PMnameBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox8.Location = new System.Drawing.Point(141, 579);
            this.PMnameBox8.MaxLength = 16;
            this.PMnameBox8.Name = "PMnameBox8";
            this.PMnameBox8.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox8.TabIndex = 61;
            // 
            // PMnameBox9
            // 
            this.PMnameBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox9.Location = new System.Drawing.Point(141, 647);
            this.PMnameBox9.MaxLength = 16;
            this.PMnameBox9.Name = "PMnameBox9";
            this.PMnameBox9.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox9.TabIndex = 73;
            // 
            // PMnameBox10
            // 
            this.PMnameBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox10.Location = new System.Drawing.Point(141, 715);
            this.PMnameBox10.MaxLength = 16;
            this.PMnameBox10.Name = "PMnameBox10";
            this.PMnameBox10.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox10.TabIndex = 72;
            // 
            // PMnameBox11
            // 
            this.PMnameBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox11.Location = new System.Drawing.Point(141, 783);
            this.PMnameBox11.MaxLength = 16;
            this.PMnameBox11.Name = "PMnameBox11";
            this.PMnameBox11.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox11.TabIndex = 71;
            // 
            // PMnameBox12
            // 
            this.PMnameBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox12.Location = new System.Drawing.Point(141, 851);
            this.PMnameBox12.MaxLength = 16;
            this.PMnameBox12.Name = "PMnameBox12";
            this.PMnameBox12.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox12.TabIndex = 69;
            // 
            // PMnameBox13
            // 
            this.PMnameBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox13.Location = new System.Drawing.Point(141, 924);
            this.PMnameBox13.MaxLength = 16;
            this.PMnameBox13.Name = "PMnameBox13";
            this.PMnameBox13.Size = new System.Drawing.Size(249, 37);
            this.PMnameBox13.TabIndex = 70;
            // 
            // Cooling_Tab
            // 
            this.Cooling_Tab.Location = new System.Drawing.Point(4, 38);
            this.Cooling_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cooling_Tab.Name = "Cooling_Tab";
            this.Cooling_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cooling_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Cooling_Tab.TabIndex = 5;
            this.Cooling_Tab.Text = "Cooling";
            this.Cooling_Tab.UseVisualStyleBackColor = true;
            // 
            // Safety_Tab
            // 
            this.Safety_Tab.Location = new System.Drawing.Point(4, 38);
            this.Safety_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Safety_Tab.Name = "Safety_Tab";
            this.Safety_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Safety_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Safety_Tab.TabIndex = 6;
            this.Safety_Tab.Text = "Safety";
            this.Safety_Tab.UseVisualStyleBackColor = true;
            // 
            // IOsetup_Tab
            // 
            this.IOsetup_Tab.Location = new System.Drawing.Point(4, 38);
            this.IOsetup_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IOsetup_Tab.Name = "IOsetup_Tab";
            this.IOsetup_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IOsetup_Tab.Size = new System.Drawing.Size(2017, 998);
            this.IOsetup_Tab.TabIndex = 8;
            this.IOsetup_Tab.Text = "IO Setup";
            this.IOsetup_Tab.UseVisualStyleBackColor = true;
            // 
            // Diagnostics_Tab
            // 
            this.Diagnostics_Tab.Controls.Add(this.balancingLabel);
            this.Diagnostics_Tab.Controls.Add(this.balancingButton);
            this.Diagnostics_Tab.Controls.Add(this.groupBox5);
            this.Diagnostics_Tab.Controls.Add(this.CANrichTextBox);
            this.Diagnostics_Tab.Location = new System.Drawing.Point(4, 38);
            this.Diagnostics_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Diagnostics_Tab.Name = "Diagnostics_Tab";
            this.Diagnostics_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Diagnostics_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Diagnostics_Tab.TabIndex = 7;
            this.Diagnostics_Tab.Text = "Diagnostics";
            this.Diagnostics_Tab.UseVisualStyleBackColor = true;
            // 
            // balancingLabel
            // 
            this.balancingLabel.AutoSize = true;
            this.balancingLabel.Location = new System.Drawing.Point(1032, 86);
            this.balancingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balancingLabel.Name = "balancingLabel";
            this.balancingLabel.Size = new System.Drawing.Size(144, 29);
            this.balancingLabel.TabIndex = 3;
            this.balancingLabel.Text = "Balancing Off";
            // 
            // balancingButton
            // 
            this.balancingButton.Location = new System.Drawing.Point(878, 70);
            this.balancingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balancingButton.Name = "balancingButton";
            this.balancingButton.Size = new System.Drawing.Size(129, 62);
            this.balancingButton.TabIndex = 2;
            this.balancingButton.Text = "Balancing";
            this.balancingButton.UseVisualStyleBackColor = true;
            this.balancingButton.Click += new System.EventHandler(this.balancingButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(26, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(777, 154);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CAN list filters";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(364, 86);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(99, 33);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Safety";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(364, 42);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(86, 33);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Data";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear List";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start/Stop";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(166, 86);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(192, 33);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Driver Interface";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(28, 86);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(76, 33);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "GLV";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(166, 42);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 33);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Accumulators";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 42);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Inverters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CANrichTextBox
            // 
            this.CANrichTextBox.Location = new System.Drawing.Point(26, 185);
            this.CANrichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANrichTextBox.Name = "CANrichTextBox";
            this.CANrichTextBox.Size = new System.Drawing.Size(775, 774);
            this.CANrichTextBox.TabIndex = 0;
            this.CANrichTextBox.Text = "";
            // 
            // Firmware_Tab
            // 
            this.Firmware_Tab.Controls.Add(this.firmwareTextBox);
            this.Firmware_Tab.Controls.Add(this.firmwareLaunch);
            this.Firmware_Tab.Location = new System.Drawing.Point(4, 38);
            this.Firmware_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Firmware_Tab.Name = "Firmware_Tab";
            this.Firmware_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Firmware_Tab.TabIndex = 9;
            this.Firmware_Tab.Text = "Update Firmware";
            this.Firmware_Tab.UseVisualStyleBackColor = true;
            // 
            // firmwareTextBox
            // 
            this.firmwareTextBox.Location = new System.Drawing.Point(32, 92);
            this.firmwareTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firmwareTextBox.Name = "firmwareTextBox";
            this.firmwareTextBox.Size = new System.Drawing.Size(850, 852);
            this.firmwareTextBox.TabIndex = 1;
            this.firmwareTextBox.Text = "";
            // 
            // firmwareLaunch
            // 
            this.firmwareLaunch.Location = new System.Drawing.Point(32, 37);
            this.firmwareLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firmwareLaunch.Name = "firmwareLaunch";
            this.firmwareLaunch.Size = new System.Drawing.Size(112, 46);
            this.firmwareLaunch.TabIndex = 0;
            this.firmwareLaunch.Text = "Launch";
            this.firmwareLaunch.UseVisualStyleBackColor = true;
            this.firmwareLaunch.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2013, 39);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSettingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.importTorqueSettingsToolStripMenuItem,
            this.exportTorqueSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 33);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.loadSettingsToolStripMenuItem.Text = "Load Settings";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            // 
            // importTorqueSettingsToolStripMenuItem
            // 
            this.importTorqueSettingsToolStripMenuItem.Name = "importTorqueSettingsToolStripMenuItem";
            this.importTorqueSettingsToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.importTorqueSettingsToolStripMenuItem.Text = "Import Torque Settings";
            // 
            // exportTorqueSettingsToolStripMenuItem
            // 
            this.exportTorqueSettingsToolStripMenuItem.Name = "exportTorqueSettingsToolStripMenuItem";
            this.exportTorqueSettingsToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.exportTorqueSettingsToolStripMenuItem.Text = "Export Torque Settings";
            // 
            // commsToolStripMenuItem
            // 
            this.commsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanForSerialPortsToolStripMenuItem,
            this.connectSerialToolStripMenuItem,
            this.disconnectSerialToolStripMenuItem,
            this.linkToTelemetryServerToolStripMenuItem});
            this.commsToolStripMenuItem.Name = "commsToolStripMenuItem";
            this.commsToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
            this.commsToolStripMenuItem.Text = "Comms";
            // 
            // scanForSerialPortsToolStripMenuItem
            // 
            this.scanForSerialPortsToolStripMenuItem.Name = "scanForSerialPortsToolStripMenuItem";
            this.scanForSerialPortsToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.scanForSerialPortsToolStripMenuItem.Text = "Scan for Serial Ports";
            // 
            // connectSerialToolStripMenuItem
            // 
            this.connectSerialToolStripMenuItem.Name = "connectSerialToolStripMenuItem";
            this.connectSerialToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.connectSerialToolStripMenuItem.Text = "Connect Serial";
            // 
            // disconnectSerialToolStripMenuItem
            // 
            this.disconnectSerialToolStripMenuItem.Name = "disconnectSerialToolStripMenuItem";
            this.disconnectSerialToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.disconnectSerialToolStripMenuItem.Text = "Disconnect Serial";
            // 
            // linkToTelemetryServerToolStripMenuItem
            // 
            this.linkToTelemetryServerToolStripMenuItem.Name = "linkToTelemetryServerToolStripMenuItem";
            this.linkToTelemetryServerToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.linkToTelemetryServerToolStripMenuItem.Text = "Link to Telemetry Server";
            // 
            // serialTimer
            // 
            this.serialTimer.Enabled = true;
            this.serialTimer.Interval = 10000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2013, 1084);
            this.Controls.Add(this.mainScreenTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2035, 1140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2035, 1140);
            this.Name = "Form1";
            this.Text = "QUT Motorsport - QEV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainScreenTabControl.ResumeLayout(false);
            this.Overview_Tab.ResumeLayout(false);
            this.groupBoxCAN.ResumeLayout(false);
            this.groupBoxCAN.PerformLayout();
            this.groupBoxSerialTimer.ResumeLayout(false);
            this.groupBoxSerialTimer.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBoxInverter1.ResumeLayout(false);
            this.TorqueVectoring_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.GLV_Tab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Diagnostics_Tab.ResumeLayout(false);
            this.Diagnostics_Tab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Firmware_Tab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusCOMnumber;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer getDataTimer;
        private System.Windows.Forms.TabControl mainScreenTabControl;
        private System.Windows.Forms.TabPage Overview_Tab;
        private System.Windows.Forms.TabPage Accumulators_Tab;
        private System.Windows.Forms.TabPage Inverters_Tab;
        private System.Windows.Forms.TabPage TorqueVectoring_Tab;
        private System.Windows.Forms.TabPage GLV_Tab;
        private System.Windows.Forms.TabPage Cooling_Tab;
        private System.Windows.Forms.TabPage Safety_Tab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAccumulators;
        private System.Windows.Forms.GroupBox groupBoxInverter1;
        private System.Windows.Forms.Label throttleLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label RPM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Enable1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button editProfilesButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox profileStartupCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox profileCurrentCombo;
        private System.Windows.Forms.ToolStripStatusLabel statusStripErrorFlag;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTorqueSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTorqueSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanForSerialPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToTelemetryServerToolStripMenuItem;
        private System.Windows.Forms.Label vehicleProfileLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage Diagnostics_Tab;
        private System.Windows.Forms.RichTextBox CANrichTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxSerialTimer;
        private System.Windows.Forms.Label serialLinkSpeedLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer serialTimer;
        private System.Windows.Forms.GroupBox groupBoxCAN;
        private System.Windows.Forms.Label rx_status_label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button loggingStopStartButton;
        private System.Windows.Forms.TabPage IOsetup_Tab;
        private System.Windows.Forms.TabPage Firmware_Tab;
        private System.Windows.Forms.Button firmwareLaunch;
        private System.Windows.Forms.RichTextBox firmwareTextBox;
        private System.Windows.Forms.Button balancingButton;
        private System.Windows.Forms.Label balancingLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label coolantTempLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label avgVoltsLabel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label maxCellTempLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DCcurrentLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inverterTempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label brakeLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PMnameBox1;
        private System.Windows.Forms.Label PMchannelLabel1;
        private System.Windows.Forms.Label PMchannelLabel2;
        private System.Windows.Forms.Label PMchannelLabel3;
        private System.Windows.Forms.Label PMchannelLabel4;
        private System.Windows.Forms.Label PMchannelLabel5;
        private System.Windows.Forms.Label PMchannelLabel6;
        private System.Windows.Forms.Label PMchannelLabel7;
        private System.Windows.Forms.Label PMchannelLabel8;
        private System.Windows.Forms.Label PMchannelLabel9;
        private System.Windows.Forms.Label PMchannelLabel10;
        private System.Windows.Forms.Label PMchannelLabel11;
        private System.Windows.Forms.Label PMchannelLabel12;
        private System.Windows.Forms.Label PMchannelLabel13;
        private System.Windows.Forms.Label PMtypeLabel2;
        private System.Windows.Forms.Label PMcurrentDrawLabel1;
        private System.Windows.Forms.Label PMcurrentDrawLabel2;
        private System.Windows.Forms.Label PMcurrentDrawLabel3;
        private System.Windows.Forms.Label PMcurrentDrawLabel4;
        private System.Windows.Forms.Label PMcurrentDrawLabel5;
        private System.Windows.Forms.Label PMcurrentDrawLabel6;
        private System.Windows.Forms.Label PMcurrentDrawLabel7;
        private System.Windows.Forms.Label PMcurrentDrawLabel8;
        private System.Windows.Forms.Label PMcurrentDrawLabel9;
        private System.Windows.Forms.Label PMcurrentDrawLabel10;
        private System.Windows.Forms.Label PMcurrentDrawLabel11;
        private System.Windows.Forms.Label PMcurrentDrawLabel12;
        private System.Windows.Forms.Label PMcurrentDrawLabel13;
        private System.Windows.Forms.Label PMstatusLabel1;
        private System.Windows.Forms.Label PMstatusLabel2;
        private System.Windows.Forms.Label PMstatusLabel3;
        private System.Windows.Forms.Label PMstatusLabel4;
        private System.Windows.Forms.Label PMstatusLabel5;
        private System.Windows.Forms.Label PMstatusLabel6;
        private System.Windows.Forms.Label PMstatusLabel7;
        private System.Windows.Forms.Label PMstatusLabel8;
        private System.Windows.Forms.Label PMstatusLabel9;
        private System.Windows.Forms.Label PMstatusLabel10;
        private System.Windows.Forms.Label PMstatusLabel11;
        private System.Windows.Forms.Label PMstatusLabel12;
        private System.Windows.Forms.Label PMstatusLabel13;
        private System.Windows.Forms.Label PMtypeLabel1;
        private System.Windows.Forms.Label PMtypeLabel4;
        private System.Windows.Forms.Label PMtypeLabel3;
        private System.Windows.Forms.Label PMtypeLabel5;
        private System.Windows.Forms.Label PMtypeLabel6;
        private System.Windows.Forms.Label PMtypeLabel7;
        private System.Windows.Forms.Label PMtypeLabel8;
        private System.Windows.Forms.Label PMtypeLabel9;
        private System.Windows.Forms.Label PMtypeLabel10;
        private System.Windows.Forms.Label PMtypeLabel11;
        private System.Windows.Forms.Label PMtypeLabel12;
        private System.Windows.Forms.Label PMtypeLabel13;
        private System.Windows.Forms.TextBox PMnameBox4;
        private System.Windows.Forms.TextBox PMnameBox3;
        private System.Windows.Forms.TextBox PMnameBox2;
        private System.Windows.Forms.TextBox PMnameBox5;
        private System.Windows.Forms.TextBox PMnameBox6;
        private System.Windows.Forms.TextBox PMnameBox7;
        private System.Windows.Forms.TextBox PMnameBox8;
        private System.Windows.Forms.TextBox PMnameBox9;
        private System.Windows.Forms.TextBox PMnameBox10;
        private System.Windows.Forms.TextBox PMnameBox11;
        private System.Windows.Forms.TextBox PMnameBox12;
        private System.Windows.Forms.TextBox PMnameBox13;
    }
}