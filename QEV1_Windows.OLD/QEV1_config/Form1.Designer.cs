﻿namespace QEV1_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCOMnumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripErrorFlag = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.getDataTimer = new System.Windows.Forms.Timer(this.components);
            this.mainScreenTabControl = new System.Windows.Forms.TabControl();
            this.Overview_Tab = new System.Windows.Forms.TabPage();
            this.loggingStopStartButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rx_status_label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Enable1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RPM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Accumulators_Tab = new System.Windows.Forms.TabPage();
            this.Inverters_Tab = new System.Windows.Forms.TabPage();
            this.TorqueVectoring_Tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.GLV_Tab = new System.Windows.Forms.TabPage();
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
            this.label21 = new System.Windows.Forms.Label();
            this.coolantTempLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.brakeLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inverterTempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DCcurrentLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxCellTempLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.avgVoltsLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview_Tab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TorqueVectoring_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.Diagnostics_Tab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Firmware_Tab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConnectionStatus,
            this.statusCOMnumber,
            this.statusStripErrorFlag});
            this.statusStrip1.Location = new System.Drawing.Point(0, 701);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 28);
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
            this.statusConnectionStatus.Size = new System.Drawing.Size(120, 23);
            this.statusConnectionStatus.Text = "DISCONNECTED";
            this.statusConnectionStatus.Click += new System.EventHandler(this.statusConnectionStatus_Click);
            // 
            // statusCOMnumber
            // 
            this.statusCOMnumber.AutoSize = false;
            this.statusCOMnumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCOMnumber.Name = "statusCOMnumber";
            this.statusCOMnumber.Size = new System.Drawing.Size(80, 23);
            this.statusCOMnumber.Text = "COMx";
            // 
            // statusStripErrorFlag
            // 
            this.statusStripErrorFlag.AutoSize = false;
            this.statusStripErrorFlag.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripErrorFlag.Name = "statusStripErrorFlag";
            this.statusStripErrorFlag.Size = new System.Drawing.Size(118, 23);
            this.statusStripErrorFlag.Text = "No Errors";
            // 
            // getDataTimer
            // 
            this.getDataTimer.Interval = 1000;
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
            this.mainScreenTabControl.Location = new System.Drawing.Point(0, 22);
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(1350, 676);
            this.mainScreenTabControl.TabIndex = 1;
            // 
            // Overview_Tab
            // 
            this.Overview_Tab.Controls.Add(this.loggingStopStartButton);
            this.Overview_Tab.Controls.Add(this.groupBox7);
            this.Overview_Tab.Controls.Add(this.groupBox6);
            this.Overview_Tab.Controls.Add(this.groupBox4);
            this.Overview_Tab.Controls.Add(this.groupBox2);
            this.Overview_Tab.Controls.Add(this.groupBox1);
            this.Overview_Tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview_Tab.Location = new System.Drawing.Point(4, 28);
            this.Overview_Tab.Name = "Overview_Tab";
            this.Overview_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Overview_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Overview_Tab.TabIndex = 0;
            this.Overview_Tab.Text = "Overview";
            this.Overview_Tab.UseVisualStyleBackColor = true;
            this.Overview_Tab.Click += new System.EventHandler(this.Overview_Tab_Click);
            // 
            // loggingStopStartButton
            // 
            this.loggingStopStartButton.Location = new System.Drawing.Point(482, 20);
            this.loggingStopStartButton.Name = "loggingStopStartButton";
            this.loggingStopStartButton.Size = new System.Drawing.Size(123, 28);
            this.loggingStopStartButton.TabIndex = 6;
            this.loggingStopStartButton.Text = "Start Logging";
            this.loggingStopStartButton.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rx_status_label);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Location = new System.Drawing.Point(287, 90);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(174, 75);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CAN";
            // 
            // rx_status_label
            // 
            this.rx_status_label.AutoSize = true;
            this.rx_status_label.Location = new System.Drawing.Point(94, 35);
            this.rx_status_label.Name = "rx_status_label";
            this.rx_status_label.Size = new System.Drawing.Size(24, 19);
            this.rx_status_label.TabIndex = 1;
            this.rx_status_label.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "RX status:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.serialLinkSpeedLabel);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(287, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(174, 75);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Serial Timer";
            // 
            // serialLinkSpeedLabel
            // 
            this.serialLinkSpeedLabel.AutoSize = true;
            this.serialLinkSpeedLabel.Location = new System.Drawing.Point(94, 35);
            this.serialLinkSpeedLabel.Name = "serialLinkSpeedLabel";
            this.serialLinkSpeedLabel.Size = new System.Drawing.Size(24, 19);
            this.serialLinkSpeedLabel.TabIndex = 1;
            this.serialLinkSpeedLabel.Text = "---";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 19);
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
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 206);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profiles";
            // 
            // vehicleProfileLabel
            // 
            this.vehicleProfileLabel.Location = new System.Drawing.Point(125, 115);
            this.vehicleProfileLabel.Name = "vehicleProfileLabel";
            this.vehicleProfileLabel.Size = new System.Drawing.Size(118, 24);
            this.vehicleProfileLabel.TabIndex = 6;
            this.vehicleProfileLabel.Text = "---";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(7, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "Vehicle Current:";
            // 
            // editProfilesButton
            // 
            this.editProfilesButton.Location = new System.Drawing.Point(70, 158);
            this.editProfilesButton.Name = "editProfilesButton";
            this.editProfilesButton.Size = new System.Drawing.Size(126, 26);
            this.editProfilesButton.TabIndex = 4;
            this.editProfilesButton.Text = "Edit Profiles";
            this.editProfilesButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(7, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 24);
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
            this.profileStartupCombo.Location = new System.Drawing.Point(126, 70);
            this.profileStartupCombo.Name = "profileStartupCombo";
            this.profileStartupCombo.Size = new System.Drawing.Size(133, 27);
            this.profileStartupCombo.TabIndex = 2;
            this.profileStartupCombo.Text = "undefined";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(28, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
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
            this.profileCurrentCombo.Location = new System.Drawing.Point(126, 27);
            this.profileCurrentCombo.Name = "profileCurrentCombo";
            this.profileCurrentCombo.Size = new System.Drawing.Size(133, 27);
            this.profileCurrentCombo.TabIndex = 0;
            this.profileCurrentCombo.Text = "Profile 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.avgVoltsLabel);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.maxCellTempLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DCcurrentLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.inverterTempLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.coolantTempLabel);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.brakeLabel);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.Enable1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.throttleLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.RPM);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(482, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inverter 1 (Test)";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(149, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "%";
            // 
            // Enable1
            // 
            this.Enable1.ForeColor = System.Drawing.Color.Red;
            this.Enable1.Location = new System.Drawing.Point(99, 98);
            this.Enable1.Name = "Enable1";
            this.Enable1.Size = new System.Drawing.Size(43, 19);
            this.Enable1.TabIndex = 42;
            this.Enable1.Text = "False";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(21, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "Enable";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(148, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "%";
            // 
            // throttleLabel
            // 
            this.throttleLabel.Location = new System.Drawing.Point(97, 32);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(45, 19);
            this.throttleLabel.TabIndex = 39;
            this.throttleLabel.Text = "1.234";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(21, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Throttle";
            // 
            // RPM
            // 
            this.RPM.Location = new System.Drawing.Point(99, 79);
            this.RPM.Name = "RPM";
            this.RPM.Size = new System.Drawing.Size(65, 19);
            this.RPM.TabIndex = 38;
            this.RPM.Text = "44";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accumulators";
            // 
            // Accumulators_Tab
            // 
            this.Accumulators_Tab.Location = new System.Drawing.Point(4, 28);
            this.Accumulators_Tab.Name = "Accumulators_Tab";
            this.Accumulators_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Accumulators_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Accumulators_Tab.TabIndex = 1;
            this.Accumulators_Tab.Text = "Accumulators";
            this.Accumulators_Tab.UseVisualStyleBackColor = true;
            // 
            // Inverters_Tab
            // 
            this.Inverters_Tab.Location = new System.Drawing.Point(4, 28);
            this.Inverters_Tab.Name = "Inverters_Tab";
            this.Inverters_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Inverters_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Inverters_Tab.TabIndex = 2;
            this.Inverters_Tab.Text = "Inverters";
            this.Inverters_Tab.UseVisualStyleBackColor = true;
            // 
            // TorqueVectoring_Tab
            // 
            this.TorqueVectoring_Tab.BackgroundImage = global::QEV1_config.Properties.Resources.car_outline1;
            this.TorqueVectoring_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TorqueVectoring_Tab.Controls.Add(this.dataGridView1);
            this.TorqueVectoring_Tab.Location = new System.Drawing.Point(4, 28);
            this.TorqueVectoring_Tab.Name = "TorqueVectoring_Tab";
            this.TorqueVectoring_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.TorqueVectoring_Tab.Size = new System.Drawing.Size(1342, 644);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
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
            this.GLV_Tab.Location = new System.Drawing.Point(4, 28);
            this.GLV_Tab.Name = "GLV_Tab";
            this.GLV_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.GLV_Tab.Size = new System.Drawing.Size(1342, 644);
            this.GLV_Tab.TabIndex = 4;
            this.GLV_Tab.Text = "Power Management";
            this.GLV_Tab.UseVisualStyleBackColor = true;
            // 
            // Cooling_Tab
            // 
            this.Cooling_Tab.Location = new System.Drawing.Point(4, 28);
            this.Cooling_Tab.Name = "Cooling_Tab";
            this.Cooling_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Cooling_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Cooling_Tab.TabIndex = 5;
            this.Cooling_Tab.Text = "Cooling";
            this.Cooling_Tab.UseVisualStyleBackColor = true;
            // 
            // Safety_Tab
            // 
            this.Safety_Tab.Location = new System.Drawing.Point(4, 28);
            this.Safety_Tab.Name = "Safety_Tab";
            this.Safety_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Safety_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Safety_Tab.TabIndex = 6;
            this.Safety_Tab.Text = "Safety";
            this.Safety_Tab.UseVisualStyleBackColor = true;
            // 
            // IOsetup_Tab
            // 
            this.IOsetup_Tab.Location = new System.Drawing.Point(4, 28);
            this.IOsetup_Tab.Name = "IOsetup_Tab";
            this.IOsetup_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.IOsetup_Tab.Size = new System.Drawing.Size(1342, 644);
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
            this.Diagnostics_Tab.Location = new System.Drawing.Point(4, 28);
            this.Diagnostics_Tab.Name = "Diagnostics_Tab";
            this.Diagnostics_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Diagnostics_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Diagnostics_Tab.TabIndex = 7;
            this.Diagnostics_Tab.Text = "Diagnostics";
            this.Diagnostics_Tab.UseVisualStyleBackColor = true;
            // 
            // balancingLabel
            // 
            this.balancingLabel.AutoSize = true;
            this.balancingLabel.Location = new System.Drawing.Point(688, 56);
            this.balancingLabel.Name = "balancingLabel";
            this.balancingLabel.Size = new System.Drawing.Size(97, 19);
            this.balancingLabel.TabIndex = 3;
            this.balancingLabel.Text = "Balancing Off";
            // 
            // balancingButton
            // 
            this.balancingButton.Location = new System.Drawing.Point(585, 45);
            this.balancingButton.Name = "balancingButton";
            this.balancingButton.Size = new System.Drawing.Size(86, 40);
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
            this.groupBox5.Location = new System.Drawing.Point(17, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(518, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CAN list filters";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(243, 56);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 23);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Safety";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(243, 27);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(59, 23);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Data";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear List";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 27);
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
            this.checkBox3.Location = new System.Drawing.Point(111, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(129, 23);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Driver Interface";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(19, 56);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(53, 23);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "GLV";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(111, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 23);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Accumulators";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(19, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Inverters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CANrichTextBox
            // 
            this.CANrichTextBox.Location = new System.Drawing.Point(17, 120);
            this.CANrichTextBox.Name = "CANrichTextBox";
            this.CANrichTextBox.Size = new System.Drawing.Size(518, 505);
            this.CANrichTextBox.TabIndex = 0;
            this.CANrichTextBox.Text = "";
            // 
            // Firmware_Tab
            // 
            this.Firmware_Tab.Controls.Add(this.firmwareTextBox);
            this.Firmware_Tab.Controls.Add(this.firmwareLaunch);
            this.Firmware_Tab.Location = new System.Drawing.Point(4, 28);
            this.Firmware_Tab.Name = "Firmware_Tab";
            this.Firmware_Tab.Size = new System.Drawing.Size(1342, 644);
            this.Firmware_Tab.TabIndex = 9;
            this.Firmware_Tab.Text = "Update Firmware";
            this.Firmware_Tab.UseVisualStyleBackColor = true;
            // 
            // firmwareTextBox
            // 
            this.firmwareTextBox.Location = new System.Drawing.Point(21, 60);
            this.firmwareTextBox.Name = "firmwareTextBox";
            this.firmwareTextBox.Size = new System.Drawing.Size(568, 555);
            this.firmwareTextBox.TabIndex = 1;
            this.firmwareTextBox.Text = "";
            // 
            // firmwareLaunch
            // 
            this.firmwareLaunch.Location = new System.Drawing.Point(21, 24);
            this.firmwareLaunch.Name = "firmwareLaunch";
            this.firmwareLaunch.Size = new System.Drawing.Size(75, 30);
            this.firmwareLaunch.TabIndex = 0;
            this.firmwareLaunch.Text = "Launch";
            this.firmwareLaunch.UseVisualStyleBackColor = true;
            this.firmwareLaunch.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 27);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.loadSettingsToolStripMenuItem.Text = "Load Settings";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            // 
            // importTorqueSettingsToolStripMenuItem
            // 
            this.importTorqueSettingsToolStripMenuItem.Name = "importTorqueSettingsToolStripMenuItem";
            this.importTorqueSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.importTorqueSettingsToolStripMenuItem.Text = "Import Torque Settings";
            // 
            // exportTorqueSettingsToolStripMenuItem
            // 
            this.exportTorqueSettingsToolStripMenuItem.Name = "exportTorqueSettingsToolStripMenuItem";
            this.exportTorqueSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
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
            this.commsToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.commsToolStripMenuItem.Text = "Comms";
            // 
            // scanForSerialPortsToolStripMenuItem
            // 
            this.scanForSerialPortsToolStripMenuItem.Name = "scanForSerialPortsToolStripMenuItem";
            this.scanForSerialPortsToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.scanForSerialPortsToolStripMenuItem.Text = "Scan for Serial Ports";
            // 
            // connectSerialToolStripMenuItem
            // 
            this.connectSerialToolStripMenuItem.Name = "connectSerialToolStripMenuItem";
            this.connectSerialToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.connectSerialToolStripMenuItem.Text = "Connect Serial";
            // 
            // disconnectSerialToolStripMenuItem
            // 
            this.disconnectSerialToolStripMenuItem.Name = "disconnectSerialToolStripMenuItem";
            this.disconnectSerialToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.disconnectSerialToolStripMenuItem.Text = "Disconnect Serial";
            // 
            // linkToTelemetryServerToolStripMenuItem
            // 
            this.linkToTelemetryServerToolStripMenuItem.Name = "linkToTelemetryServerToolStripMenuItem";
            this.linkToTelemetryServerToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.linkToTelemetryServerToolStripMenuItem.Text = "Link to Telemetry Server";
            // 
            // serialTimer
            // 
            this.serialTimer.Enabled = true;
            this.serialTimer.Interval = 10000;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(256, 341);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 47);
            this.label21.TabIndex = 48;
            this.label21.Text = "°C";
            // 
            // coolantTempLabel
            // 
            this.coolantTempLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolantTempLabel.Location = new System.Drawing.Point(199, 341);
            this.coolantTempLabel.Name = "coolantTempLabel";
            this.coolantTempLabel.Size = new System.Drawing.Size(67, 47);
            this.coolantTempLabel.TabIndex = 47;
            this.coolantTempLabel.Text = "25";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(20, 341);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(173, 47);
            this.label24.TabIndex = 46;
            this.label24.Text = "Coolant Temp";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(21, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "RPM";
            // 
            // brakeLabel
            // 
            this.brakeLabel.Location = new System.Drawing.Point(98, 55);
            this.brakeLabel.Name = "brakeLabel";
            this.brakeLabel.Size = new System.Drawing.Size(45, 19);
            this.brakeLabel.TabIndex = 44;
            this.brakeLabel.Text = "1.234";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(22, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 19);
            this.label22.TabIndex = 43;
            this.label22.Text = "Brake";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 47);
            this.label1.TabIndex = 51;
            this.label1.Text = "°C";
            // 
            // inverterTempLabel
            // 
            this.inverterTempLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterTempLabel.Location = new System.Drawing.Point(201, 294);
            this.inverterTempLabel.Name = "inverterTempLabel";
            this.inverterTempLabel.Size = new System.Drawing.Size(67, 47);
            this.inverterTempLabel.TabIndex = 50;
            this.inverterTempLabel.Text = "25";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 47);
            this.label3.TabIndex = 49;
            this.label3.Text = "Inverter Temp";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 47);
            this.label4.TabIndex = 54;
            this.label4.Text = "A";
            // 
            // DCcurrentLabel
            // 
            this.DCcurrentLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCcurrentLabel.Location = new System.Drawing.Point(201, 247);
            this.DCcurrentLabel.Name = "DCcurrentLabel";
            this.DCcurrentLabel.Size = new System.Drawing.Size(67, 47);
            this.DCcurrentLabel.TabIndex = 53;
            this.DCcurrentLabel.Text = "25";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 47);
            this.label6.TabIndex = 52;
            this.label6.Text = "DC Current";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 47);
            this.label7.TabIndex = 57;
            this.label7.Text = "°C";
            // 
            // maxCellTempLabel
            // 
            this.maxCellTempLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCellTempLabel.Location = new System.Drawing.Point(201, 203);
            this.maxCellTempLabel.Name = "maxCellTempLabel";
            this.maxCellTempLabel.Size = new System.Drawing.Size(67, 47);
            this.maxCellTempLabel.TabIndex = 56;
            this.maxCellTempLabel.Text = "25";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 47);
            this.label9.TabIndex = 55;
            this.label9.Text = "Max Cell Temp";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 47);
            this.label10.TabIndex = 60;
            this.label10.Text = "V";
            // 
            // avgVoltsLabel
            // 
            this.avgVoltsLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgVoltsLabel.Location = new System.Drawing.Point(201, 157);
            this.avgVoltsLabel.Name = "avgVoltsLabel";
            this.avgVoltsLabel.Size = new System.Drawing.Size(67, 47);
            this.avgVoltsLabel.TabIndex = 59;
            this.avgVoltsLabel.Text = "25";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 157);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(173, 47);
            this.label25.TabIndex = 58;
            this.label25.Text = "Average Voltage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mainScreenTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Form1";
            this.Text = "QUT Motorsport - QEV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainScreenTabControl.ResumeLayout(false);
            this.Overview_Tab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.TorqueVectoring_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label serialLinkSpeedLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer serialTimer;
        private System.Windows.Forms.GroupBox groupBox7;
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
    }
}

