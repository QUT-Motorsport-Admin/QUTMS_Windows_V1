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
            this.rearAccumulatorBricksGroupBox = new System.Windows.Forms.GroupBox();
            this.rearAccumulatorBrick6 = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue6 = new System.Windows.Forms.Label();
            this.minRearAccumulatorBrick6 = new System.Windows.Forms.Label();
            this.avgRearAccumulatorBrick6 = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue6 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue6 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorBrick6 = new System.Windows.Forms.Label();
            this.rearAccumulatorBrick5 = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue5 = new System.Windows.Forms.Label();
            this.minRearAccumulatorBrick5 = new System.Windows.Forms.Label();
            this.avgRearAccumulatorBrick5 = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue5 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue5 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorBrick5 = new System.Windows.Forms.Label();
            this.rearAccumulatorBrick4 = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue4 = new System.Windows.Forms.Label();
            this.minRearAccumulatorBrick4 = new System.Windows.Forms.Label();
            this.avgRearAccumulatorBrick4 = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue4 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue4 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorBrick4 = new System.Windows.Forms.Label();
            this.rearAccumulatorBrick3 = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue3 = new System.Windows.Forms.Label();
            this.minRearAccumulatorBrick3 = new System.Windows.Forms.Label();
            this.avgRearAccumulatorBrick3 = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue3 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue3 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorBrick3 = new System.Windows.Forms.Label();
            this.rearAccumulatorBrick2 = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue2 = new System.Windows.Forms.Label();
            this.minRearAccumulatorBrick2 = new System.Windows.Forms.Label();
            this.avgRearAccumulatorBrick2 = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue2 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue2 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorBrick2 = new System.Windows.Forms.Label();
            this.rearAccumulatorBrick1 = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue1 = new System.Windows.Forms.Label();
            this.avgRearAccumulatorBrick1 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue1 = new System.Windows.Forms.Label();
            this.maxRearAccumulatorBrick1 = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue1 = new System.Windows.Forms.Label();
            this.minRearAccumulatorBrick1 = new System.Windows.Forms.Label();
            this.frontAccumulatorBricksGroupBox = new System.Windows.Forms.GroupBox();
            this.frontAccumulatorBrick6 = new System.Windows.Forms.GroupBox();
            this.avgFrontAccumulatorValue6 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorBrick6 = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorBrick6 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue6 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorValue6 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorBrick6 = new System.Windows.Forms.Label();
            this.frontAccumulatorBrick5 = new System.Windows.Forms.GroupBox();
            this.avgFrontAccumulatorValue5 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorBrick5 = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorBrick5 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue5 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorValue5 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorBrick5 = new System.Windows.Forms.Label();
            this.frontAccumulatorBrick4 = new System.Windows.Forms.GroupBox();
            this.avgFrontAccumulatorValue4 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorBrick4 = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorBrick4 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue4 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorValue4 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorBrick4 = new System.Windows.Forms.Label();
            this.frontAccumulatorBrick3 = new System.Windows.Forms.GroupBox();
            this.avgFrontAccumulatorValue3 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorBrick3 = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorBrick3 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue3 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorValue3 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorBrick3 = new System.Windows.Forms.Label();
            this.frontAccumulatorBrick2 = new System.Windows.Forms.GroupBox();
            this.avgFrontAccumulatorValue2 = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorBrick2 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorValue2 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorBrick2 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue2 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorBrick2 = new System.Windows.Forms.Label();
            this.frontAccumulatorBrick1 = new System.Windows.Forms.GroupBox();
            this.avgFrontAccumulatorValue1 = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorBrick1 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorValue1 = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorBrick1 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue1 = new System.Windows.Forms.Label();
            this.minFrontAccumulatorBrick1 = new System.Windows.Forms.Label();
            this.rearAccumulatorGroupBox = new System.Windows.Forms.GroupBox();
            this.avgRearAccumulatorValue = new System.Windows.Forms.Label();
            this.maxRearAccumulatorValue = new System.Windows.Forms.Label();
            this.minRearAccumulatorValue = new System.Windows.Forms.Label();
            this.avgRearAccumulatorLabel = new System.Windows.Forms.Label();
            this.maxRearAccumulatorLabel = new System.Windows.Forms.Label();
            this.minRearAccumulatorLabel = new System.Windows.Forms.Label();
            this.frontAccumulatorGroupBox = new System.Windows.Forms.GroupBox();
            this.AvgFrontAccumulatorValue = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorsValue = new System.Windows.Forms.Label();
            this.minFrontAccumulatorValue = new System.Windows.Forms.Label();
            this.avgFrontAccumulatorLabel = new System.Windows.Forms.Label();
            this.maxFrontAccumulatorsLabel = new System.Windows.Forms.Label();
            this.minFrontAccumulatorsLabel = new System.Windows.Forms.Label();
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
            this.statusStrip1.SuspendLayout();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview_Tab.SuspendLayout();
            this.groupBoxCAN.SuspendLayout();
            this.groupBoxSerialTimer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxInverter1.SuspendLayout();
            this.Accumulators_Tab.SuspendLayout();
            this.rearAccumulatorBricksGroupBox.SuspendLayout();
            this.rearAccumulatorBrick6.SuspendLayout();
            this.rearAccumulatorBrick5.SuspendLayout();
            this.rearAccumulatorBrick4.SuspendLayout();
            this.rearAccumulatorBrick3.SuspendLayout();
            this.rearAccumulatorBrick2.SuspendLayout();
            this.rearAccumulatorBrick1.SuspendLayout();
            this.frontAccumulatorBricksGroupBox.SuspendLayout();
            this.frontAccumulatorBrick6.SuspendLayout();
            this.frontAccumulatorBrick5.SuspendLayout();
            this.frontAccumulatorBrick4.SuspendLayout();
            this.frontAccumulatorBrick3.SuspendLayout();
            this.frontAccumulatorBrick2.SuspendLayout();
            this.frontAccumulatorBrick1.SuspendLayout();
            this.rearAccumulatorGroupBox.SuspendLayout();
            this.frontAccumulatorGroupBox.SuspendLayout();
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
            this.Accumulators_Tab.Controls.Add(this.rearAccumulatorBricksGroupBox);
            this.Accumulators_Tab.Controls.Add(this.frontAccumulatorBricksGroupBox);
            this.Accumulators_Tab.Controls.Add(this.rearAccumulatorGroupBox);
            this.Accumulators_Tab.Controls.Add(this.frontAccumulatorGroupBox);
            this.Accumulators_Tab.Location = new System.Drawing.Point(4, 38);
            this.Accumulators_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accumulators_Tab.Name = "Accumulators_Tab";
            this.Accumulators_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accumulators_Tab.Size = new System.Drawing.Size(2017, 998);
            this.Accumulators_Tab.TabIndex = 1;
            this.Accumulators_Tab.Text = "Accumulators";
            this.Accumulators_Tab.UseVisualStyleBackColor = true;
            // 
            // rearAccumulatorBricksGroupBox
            // 
            this.rearAccumulatorBricksGroupBox.Controls.Add(this.rearAccumulatorBrick6);
            this.rearAccumulatorBricksGroupBox.Controls.Add(this.rearAccumulatorBrick5);
            this.rearAccumulatorBricksGroupBox.Controls.Add(this.rearAccumulatorBrick4);
            this.rearAccumulatorBricksGroupBox.Controls.Add(this.rearAccumulatorBrick3);
            this.rearAccumulatorBricksGroupBox.Controls.Add(this.rearAccumulatorBrick2);
            this.rearAccumulatorBricksGroupBox.Controls.Add(this.rearAccumulatorBrick1);
            this.rearAccumulatorBricksGroupBox.Location = new System.Drawing.Point(843, 497);
            this.rearAccumulatorBricksGroupBox.Name = "rearAccumulatorBricksGroupBox";
            this.rearAccumulatorBricksGroupBox.Size = new System.Drawing.Size(457, 480);
            this.rearAccumulatorBricksGroupBox.TabIndex = 2;
            this.rearAccumulatorBricksGroupBox.TabStop = false;
            this.rearAccumulatorBricksGroupBox.Text = "Rear Accumulator Bricks";
            // 
            // rearAccumulatorBrick6
            // 
            this.rearAccumulatorBrick6.Controls.Add(this.avgRearAccumulatorValue6);
            this.rearAccumulatorBrick6.Controls.Add(this.minRearAccumulatorBrick6);
            this.rearAccumulatorBrick6.Controls.Add(this.avgRearAccumulatorBrick6);
            this.rearAccumulatorBrick6.Controls.Add(this.minRearAccumulatorValue6);
            this.rearAccumulatorBrick6.Controls.Add(this.maxRearAccumulatorValue6);
            this.rearAccumulatorBrick6.Controls.Add(this.maxRearAccumulatorBrick6);
            this.rearAccumulatorBrick6.Location = new System.Drawing.Point(28, 406);
            this.rearAccumulatorBrick6.Name = "rearAccumulatorBrick6";
            this.rearAccumulatorBrick6.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick6.TabIndex = 4;
            this.rearAccumulatorBrick6.TabStop = false;
            this.rearAccumulatorBrick6.Text = "Rear Accumulator Brick 6";
            this.rearAccumulatorBrick6.Click += new System.EventHandler(rearAccumulatorBrick6_Click);
            // 
            // avgRearAccumulatorValue6
            // 
            this.avgRearAccumulatorValue6.AutoSize = true;
            this.avgRearAccumulatorValue6.Location = new System.Drawing.Point(350, 33);
            this.avgRearAccumulatorValue6.Name = "avgRearAccumulatorValue6";
            this.avgRearAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue6.TabIndex = 45;
            this.avgRearAccumulatorValue6.Text = "0";
            // 
            // minRearAccumulatorBrick6
            // 
            this.minRearAccumulatorBrick6.AutoSize = true;
            this.minRearAccumulatorBrick6.Location = new System.Drawing.Point(23, 33);
            this.minRearAccumulatorBrick6.Name = "minRearAccumulatorBrick6";
            this.minRearAccumulatorBrick6.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick6.TabIndex = 40;
            this.minRearAccumulatorBrick6.Text = "Min:";
            // 
            // avgRearAccumulatorBrick6
            // 
            this.avgRearAccumulatorBrick6.AutoSize = true;
            this.avgRearAccumulatorBrick6.Location = new System.Drawing.Point(285, 33);
            this.avgRearAccumulatorBrick6.Name = "avgRearAccumulatorBrick6";
            this.avgRearAccumulatorBrick6.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick6.TabIndex = 44;
            this.avgRearAccumulatorBrick6.Text = "Avg:";
            // 
            // minRearAccumulatorValue6
            // 
            this.minRearAccumulatorValue6.AutoSize = true;
            this.minRearAccumulatorValue6.Location = new System.Drawing.Point(88, 33);
            this.minRearAccumulatorValue6.Name = "minRearAccumulatorValue6";
            this.minRearAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue6.TabIndex = 41;
            this.minRearAccumulatorValue6.Text = "0";
            // 
            // maxRearAccumulatorValue6
            // 
            this.maxRearAccumulatorValue6.AutoSize = true;
            this.maxRearAccumulatorValue6.Location = new System.Drawing.Point(214, 33);
            this.maxRearAccumulatorValue6.Name = "maxRearAccumulatorValue6";
            this.maxRearAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue6.TabIndex = 43;
            this.maxRearAccumulatorValue6.Text = "0";
            // 
            // maxRearAccumulatorBrick6
            // 
            this.maxRearAccumulatorBrick6.AutoSize = true;
            this.maxRearAccumulatorBrick6.Location = new System.Drawing.Point(149, 33);
            this.maxRearAccumulatorBrick6.Name = "maxRearAccumulatorBrick6";
            this.maxRearAccumulatorBrick6.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick6.TabIndex = 42;
            this.maxRearAccumulatorBrick6.Text = "Max:";
            // 
            // rearAccumulatorBrick5
            // 
            this.rearAccumulatorBrick5.Controls.Add(this.avgRearAccumulatorValue5);
            this.rearAccumulatorBrick5.Controls.Add(this.minRearAccumulatorBrick5);
            this.rearAccumulatorBrick5.Controls.Add(this.avgRearAccumulatorBrick5);
            this.rearAccumulatorBrick5.Controls.Add(this.minRearAccumulatorValue5);
            this.rearAccumulatorBrick5.Controls.Add(this.maxRearAccumulatorValue5);
            this.rearAccumulatorBrick5.Controls.Add(this.maxRearAccumulatorBrick5);
            this.rearAccumulatorBrick5.Location = new System.Drawing.Point(28, 332);
            this.rearAccumulatorBrick5.Name = "rearAccumulatorBrick5";
            this.rearAccumulatorBrick5.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick5.TabIndex = 3;
            this.rearAccumulatorBrick5.TabStop = false;
            this.rearAccumulatorBrick5.Text = "Rear Accumulator Brick 5";
            this.rearAccumulatorBrick5.Click += new System.EventHandler(rearAccumulatorBrick5_Click);
            // 
            // avgRearAccumulatorValue5
            // 
            this.avgRearAccumulatorValue5.AutoSize = true;
            this.avgRearAccumulatorValue5.Location = new System.Drawing.Point(350, 33);
            this.avgRearAccumulatorValue5.Name = "avgRearAccumulatorValue5";
            this.avgRearAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue5.TabIndex = 39;
            this.avgRearAccumulatorValue5.Text = "0";
            // 
            // minRearAccumulatorBrick5
            // 
            this.minRearAccumulatorBrick5.AutoSize = true;
            this.minRearAccumulatorBrick5.Location = new System.Drawing.Point(23, 33);
            this.minRearAccumulatorBrick5.Name = "minRearAccumulatorBrick5";
            this.minRearAccumulatorBrick5.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick5.TabIndex = 34;
            this.minRearAccumulatorBrick5.Text = "Min:";
            // 
            // avgRearAccumulatorBrick5
            // 
            this.avgRearAccumulatorBrick5.AutoSize = true;
            this.avgRearAccumulatorBrick5.Location = new System.Drawing.Point(285, 33);
            this.avgRearAccumulatorBrick5.Name = "avgRearAccumulatorBrick5";
            this.avgRearAccumulatorBrick5.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick5.TabIndex = 38;
            this.avgRearAccumulatorBrick5.Text = "Avg:";
            // 
            // minRearAccumulatorValue5
            // 
            this.minRearAccumulatorValue5.AutoSize = true;
            this.minRearAccumulatorValue5.Location = new System.Drawing.Point(88, 33);
            this.minRearAccumulatorValue5.Name = "minRearAccumulatorValue5";
            this.minRearAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue5.TabIndex = 35;
            this.minRearAccumulatorValue5.Text = "0";
            // 
            // maxRearAccumulatorValue5
            // 
            this.maxRearAccumulatorValue5.AutoSize = true;
            this.maxRearAccumulatorValue5.Location = new System.Drawing.Point(214, 33);
            this.maxRearAccumulatorValue5.Name = "maxRearAccumulatorValue5";
            this.maxRearAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue5.TabIndex = 37;
            this.maxRearAccumulatorValue5.Text = "0";
            // 
            // maxRearAccumulatorBrick5
            // 
            this.maxRearAccumulatorBrick5.AutoSize = true;
            this.maxRearAccumulatorBrick5.Location = new System.Drawing.Point(149, 33);
            this.maxRearAccumulatorBrick5.Name = "maxRearAccumulatorBrick5";
            this.maxRearAccumulatorBrick5.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick5.TabIndex = 36;
            this.maxRearAccumulatorBrick5.Text = "Max:";
            // 
            // rearAccumulatorBrick4
            // 
            this.rearAccumulatorBrick4.Controls.Add(this.avgRearAccumulatorValue4);
            this.rearAccumulatorBrick4.Controls.Add(this.minRearAccumulatorBrick4);
            this.rearAccumulatorBrick4.Controls.Add(this.avgRearAccumulatorBrick4);
            this.rearAccumulatorBrick4.Controls.Add(this.minRearAccumulatorValue4);
            this.rearAccumulatorBrick4.Controls.Add(this.maxRearAccumulatorValue4);
            this.rearAccumulatorBrick4.Controls.Add(this.maxRearAccumulatorBrick4);
            this.rearAccumulatorBrick4.Location = new System.Drawing.Point(28, 258);
            this.rearAccumulatorBrick4.Name = "rearAccumulatorBrick4";
            this.rearAccumulatorBrick4.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick4.TabIndex = 1;
            this.rearAccumulatorBrick4.TabStop = false;
            this.rearAccumulatorBrick4.Text = "Rear Accumulator Brick 4";
            this.rearAccumulatorBrick4.Click += new System.EventHandler(rearAccumulatorBrick4_Click);
            // 
            // avgRearAccumulatorValue4
            // 
            this.avgRearAccumulatorValue4.AutoSize = true;
            this.avgRearAccumulatorValue4.Location = new System.Drawing.Point(350, 33);
            this.avgRearAccumulatorValue4.Name = "avgRearAccumulatorValue4";
            this.avgRearAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue4.TabIndex = 33;
            this.avgRearAccumulatorValue4.Text = "0";
            // 
            // minRearAccumulatorBrick4
            // 
            this.minRearAccumulatorBrick4.AutoSize = true;
            this.minRearAccumulatorBrick4.Location = new System.Drawing.Point(23, 33);
            this.minRearAccumulatorBrick4.Name = "minRearAccumulatorBrick4";
            this.minRearAccumulatorBrick4.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick4.TabIndex = 28;
            this.minRearAccumulatorBrick4.Text = "Min:";
            // 
            // avgRearAccumulatorBrick4
            // 
            this.avgRearAccumulatorBrick4.AutoSize = true;
            this.avgRearAccumulatorBrick4.Location = new System.Drawing.Point(285, 33);
            this.avgRearAccumulatorBrick4.Name = "avgRearAccumulatorBrick4";
            this.avgRearAccumulatorBrick4.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick4.TabIndex = 32;
            this.avgRearAccumulatorBrick4.Text = "Avg:";
            // 
            // minRearAccumulatorValue4
            // 
            this.minRearAccumulatorValue4.AutoSize = true;
            this.minRearAccumulatorValue4.Location = new System.Drawing.Point(88, 33);
            this.minRearAccumulatorValue4.Name = "minRearAccumulatorValue4";
            this.minRearAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue4.TabIndex = 29;
            this.minRearAccumulatorValue4.Text = "0";
            // 
            // maxRearAccumulatorValue4
            // 
            this.maxRearAccumulatorValue4.AutoSize = true;
            this.maxRearAccumulatorValue4.Location = new System.Drawing.Point(214, 33);
            this.maxRearAccumulatorValue4.Name = "maxRearAccumulatorValue4";
            this.maxRearAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue4.TabIndex = 31;
            this.maxRearAccumulatorValue4.Text = "0";
            // 
            // maxRearAccumulatorBrick4
            // 
            this.maxRearAccumulatorBrick4.AutoSize = true;
            this.maxRearAccumulatorBrick4.Location = new System.Drawing.Point(149, 33);
            this.maxRearAccumulatorBrick4.Name = "maxRearAccumulatorBrick4";
            this.maxRearAccumulatorBrick4.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick4.TabIndex = 30;
            this.maxRearAccumulatorBrick4.Text = "Max:";
            // 
            // rearAccumulatorBrick3
            // 
            this.rearAccumulatorBrick3.Controls.Add(this.avgRearAccumulatorValue3);
            this.rearAccumulatorBrick3.Controls.Add(this.minRearAccumulatorBrick3);
            this.rearAccumulatorBrick3.Controls.Add(this.avgRearAccumulatorBrick3);
            this.rearAccumulatorBrick3.Controls.Add(this.minRearAccumulatorValue3);
            this.rearAccumulatorBrick3.Controls.Add(this.maxRearAccumulatorValue3);
            this.rearAccumulatorBrick3.Controls.Add(this.maxRearAccumulatorBrick3);
            this.rearAccumulatorBrick3.Location = new System.Drawing.Point(28, 184);
            this.rearAccumulatorBrick3.Name = "rearAccumulatorBrick3";
            this.rearAccumulatorBrick3.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick3.TabIndex = 2;
            this.rearAccumulatorBrick3.TabStop = false;
            this.rearAccumulatorBrick3.Text = "Rear Accumulator Brick 3";
            this.rearAccumulatorBrick3.Click += new System.EventHandler(rearAccumulatorBrick3_Click);
            // 
            // avgRearAccumulatorValue3
            // 
            this.avgRearAccumulatorValue3.AutoSize = true;
            this.avgRearAccumulatorValue3.Location = new System.Drawing.Point(350, 36);
            this.avgRearAccumulatorValue3.Name = "avgRearAccumulatorValue3";
            this.avgRearAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue3.TabIndex = 27;
            this.avgRearAccumulatorValue3.Text = "0";
            // 
            // minRearAccumulatorBrick3
            // 
            this.minRearAccumulatorBrick3.AutoSize = true;
            this.minRearAccumulatorBrick3.Location = new System.Drawing.Point(23, 36);
            this.minRearAccumulatorBrick3.Name = "minRearAccumulatorBrick3";
            this.minRearAccumulatorBrick3.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick3.TabIndex = 22;
            this.minRearAccumulatorBrick3.Text = "Min:";
            // 
            // avgRearAccumulatorBrick3
            // 
            this.avgRearAccumulatorBrick3.AutoSize = true;
            this.avgRearAccumulatorBrick3.Location = new System.Drawing.Point(285, 36);
            this.avgRearAccumulatorBrick3.Name = "avgRearAccumulatorBrick3";
            this.avgRearAccumulatorBrick3.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick3.TabIndex = 26;
            this.avgRearAccumulatorBrick3.Text = "Avg:";
            // 
            // minRearAccumulatorValue3
            // 
            this.minRearAccumulatorValue3.AutoSize = true;
            this.minRearAccumulatorValue3.Location = new System.Drawing.Point(88, 36);
            this.minRearAccumulatorValue3.Name = "minRearAccumulatorValue3";
            this.minRearAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue3.TabIndex = 23;
            this.minRearAccumulatorValue3.Text = "0";
            // 
            // maxRearAccumulatorValue3
            // 
            this.maxRearAccumulatorValue3.AutoSize = true;
            this.maxRearAccumulatorValue3.Location = new System.Drawing.Point(214, 36);
            this.maxRearAccumulatorValue3.Name = "maxRearAccumulatorValue3";
            this.maxRearAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue3.TabIndex = 25;
            this.maxRearAccumulatorValue3.Text = "0";
            // 
            // maxRearAccumulatorBrick3
            // 
            this.maxRearAccumulatorBrick3.AutoSize = true;
            this.maxRearAccumulatorBrick3.Location = new System.Drawing.Point(149, 36);
            this.maxRearAccumulatorBrick3.Name = "maxRearAccumulatorBrick3";
            this.maxRearAccumulatorBrick3.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick3.TabIndex = 24;
            this.maxRearAccumulatorBrick3.Text = "Max:";
            // 
            // rearAccumulatorBrick2
            // 
            this.rearAccumulatorBrick2.Controls.Add(this.avgRearAccumulatorValue2);
            this.rearAccumulatorBrick2.Controls.Add(this.minRearAccumulatorBrick2);
            this.rearAccumulatorBrick2.Controls.Add(this.avgRearAccumulatorBrick2);
            this.rearAccumulatorBrick2.Controls.Add(this.minRearAccumulatorValue2);
            this.rearAccumulatorBrick2.Controls.Add(this.maxRearAccumulatorValue2);
            this.rearAccumulatorBrick2.Controls.Add(this.maxRearAccumulatorBrick2);
            this.rearAccumulatorBrick2.Location = new System.Drawing.Point(28, 110);
            this.rearAccumulatorBrick2.Name = "rearAccumulatorBrick2";
            this.rearAccumulatorBrick2.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick2.TabIndex = 1;
            this.rearAccumulatorBrick2.TabStop = false;
            this.rearAccumulatorBrick2.Text = "Rear Accumulator Brick 2";
            this.rearAccumulatorBrick2.Click += new System.EventHandler(rearAccumulatorBrick2_Click);
            // 
            // avgRearAccumulatorValue2
            // 
            this.avgRearAccumulatorValue2.AutoSize = true;
            this.avgRearAccumulatorValue2.Location = new System.Drawing.Point(350, 33);
            this.avgRearAccumulatorValue2.Name = "avgRearAccumulatorValue2";
            this.avgRearAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue2.TabIndex = 21;
            this.avgRearAccumulatorValue2.Text = "0";
            // 
            // minRearAccumulatorBrick2
            // 
            this.minRearAccumulatorBrick2.AutoSize = true;
            this.minRearAccumulatorBrick2.Location = new System.Drawing.Point(23, 33);
            this.minRearAccumulatorBrick2.Name = "minRearAccumulatorBrick2";
            this.minRearAccumulatorBrick2.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick2.TabIndex = 16;
            this.minRearAccumulatorBrick2.Text = "Min:";
            // 
            // avgRearAccumulatorBrick2
            // 
            this.avgRearAccumulatorBrick2.AutoSize = true;
            this.avgRearAccumulatorBrick2.Location = new System.Drawing.Point(285, 33);
            this.avgRearAccumulatorBrick2.Name = "avgRearAccumulatorBrick2";
            this.avgRearAccumulatorBrick2.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick2.TabIndex = 20;
            this.avgRearAccumulatorBrick2.Text = "Avg:";
            // 
            // minRearAccumulatorValue2
            // 
            this.minRearAccumulatorValue2.AutoSize = true;
            this.minRearAccumulatorValue2.Location = new System.Drawing.Point(88, 33);
            this.minRearAccumulatorValue2.Name = "minRearAccumulatorValue2";
            this.minRearAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue2.TabIndex = 17;
            this.minRearAccumulatorValue2.Text = "0";
            // 
            // maxRearAccumulatorValue2
            // 
            this.maxRearAccumulatorValue2.AutoSize = true;
            this.maxRearAccumulatorValue2.Location = new System.Drawing.Point(214, 33);
            this.maxRearAccumulatorValue2.Name = "maxRearAccumulatorValue2";
            this.maxRearAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue2.TabIndex = 19;
            this.maxRearAccumulatorValue2.Text = "0";
            // 
            // maxRearAccumulatorBrick2
            // 
            this.maxRearAccumulatorBrick2.AutoSize = true;
            this.maxRearAccumulatorBrick2.Location = new System.Drawing.Point(149, 33);
            this.maxRearAccumulatorBrick2.Name = "maxRearAccumulatorBrick2";
            this.maxRearAccumulatorBrick2.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick2.TabIndex = 18;
            this.maxRearAccumulatorBrick2.Text = "Max:";
            // 
            // rearAccumulatorBrick1
            // 
            this.rearAccumulatorBrick1.Controls.Add(this.avgRearAccumulatorValue1);
            this.rearAccumulatorBrick1.Controls.Add(this.avgRearAccumulatorBrick1);
            this.rearAccumulatorBrick1.Controls.Add(this.maxRearAccumulatorValue1);
            this.rearAccumulatorBrick1.Controls.Add(this.maxRearAccumulatorBrick1);
            this.rearAccumulatorBrick1.Controls.Add(this.minRearAccumulatorValue1);
            this.rearAccumulatorBrick1.Controls.Add(this.minRearAccumulatorBrick1);
            this.rearAccumulatorBrick1.Location = new System.Drawing.Point(28, 36);
            this.rearAccumulatorBrick1.Name = "rearAccumulatorBrick1";
            this.rearAccumulatorBrick1.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick1.TabIndex = 0;
            this.rearAccumulatorBrick1.TabStop = false;
            this.rearAccumulatorBrick1.Text = "Rear Accumulator Brick 1";
            this.rearAccumulatorBrick1.Click += new System.EventHandler(rearAccumulatorBrick1_Click);
            // 
            // avgRearAccumulatorValue1
            // 
            this.avgRearAccumulatorValue1.AutoSize = true;
            this.avgRearAccumulatorValue1.Location = new System.Drawing.Point(350, 33);
            this.avgRearAccumulatorValue1.Name = "avgRearAccumulatorValue1";
            this.avgRearAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue1.TabIndex = 15;
            this.avgRearAccumulatorValue1.Text = "0";
            // 
            // avgRearAccumulatorBrick1
            // 
            this.avgRearAccumulatorBrick1.AutoSize = true;
            this.avgRearAccumulatorBrick1.Location = new System.Drawing.Point(285, 33);
            this.avgRearAccumulatorBrick1.Name = "avgRearAccumulatorBrick1";
            this.avgRearAccumulatorBrick1.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick1.TabIndex = 14;
            this.avgRearAccumulatorBrick1.Text = "Avg:";
            // 
            // maxRearAccumulatorValue1
            // 
            this.maxRearAccumulatorValue1.AutoSize = true;
            this.maxRearAccumulatorValue1.Location = new System.Drawing.Point(214, 33);
            this.maxRearAccumulatorValue1.Name = "maxRearAccumulatorValue1";
            this.maxRearAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue1.TabIndex = 13;
            this.maxRearAccumulatorValue1.Text = "0";
            // 
            // maxRearAccumulatorBrick1
            // 
            this.maxRearAccumulatorBrick1.AutoSize = true;
            this.maxRearAccumulatorBrick1.Location = new System.Drawing.Point(149, 33);
            this.maxRearAccumulatorBrick1.Name = "maxRearAccumulatorBrick1";
            this.maxRearAccumulatorBrick1.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick1.TabIndex = 12;
            this.maxRearAccumulatorBrick1.Text = "Max:";
            // 
            // minRearAccumulatorValue1
            // 
            this.minRearAccumulatorValue1.AutoSize = true;
            this.minRearAccumulatorValue1.Location = new System.Drawing.Point(88, 33);
            this.minRearAccumulatorValue1.Name = "minRearAccumulatorValue1";
            this.minRearAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue1.TabIndex = 11;
            this.minRearAccumulatorValue1.Text = "0";
            // 
            // minRearAccumulatorBrick1
            // 
            this.minRearAccumulatorBrick1.AutoSize = true;
            this.minRearAccumulatorBrick1.Location = new System.Drawing.Point(23, 33);
            this.minRearAccumulatorBrick1.Name = "minRearAccumulatorBrick1";
            this.minRearAccumulatorBrick1.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick1.TabIndex = 10;
            this.minRearAccumulatorBrick1.Text = "Min:";
            // 
            // frontAccumulatorBricksGroupBox
            // 
            this.frontAccumulatorBricksGroupBox.Controls.Add(this.frontAccumulatorBrick6);
            this.frontAccumulatorBricksGroupBox.Controls.Add(this.frontAccumulatorBrick5);
            this.frontAccumulatorBricksGroupBox.Controls.Add(this.frontAccumulatorBrick4);
            this.frontAccumulatorBricksGroupBox.Controls.Add(this.frontAccumulatorBrick3);
            this.frontAccumulatorBricksGroupBox.Controls.Add(this.frontAccumulatorBrick2);
            this.frontAccumulatorBricksGroupBox.Controls.Add(this.frontAccumulatorBrick1);
            this.frontAccumulatorBricksGroupBox.Location = new System.Drawing.Point(843, 8);
            this.frontAccumulatorBricksGroupBox.Name = "frontAccumulatorBricksGroupBox";
            this.frontAccumulatorBricksGroupBox.Size = new System.Drawing.Size(457, 483);
            this.frontAccumulatorBricksGroupBox.TabIndex = 0;
            this.frontAccumulatorBricksGroupBox.TabStop = false;
            this.frontAccumulatorBricksGroupBox.Text = "Front Accumulator Bricks";
            // 
            // frontAccumulatorBrick6
            // 
            this.frontAccumulatorBrick6.Controls.Add(this.avgFrontAccumulatorValue6);
            this.frontAccumulatorBrick6.Controls.Add(this.minFrontAccumulatorBrick6);
            this.frontAccumulatorBrick6.Controls.Add(this.avgFrontAccumulatorBrick6);
            this.frontAccumulatorBrick6.Controls.Add(this.minFrontAccumulatorValue6);
            this.frontAccumulatorBrick6.Controls.Add(this.maxFrontAccumulatorValue6);
            this.frontAccumulatorBrick6.Controls.Add(this.maxFrontAccumulatorBrick6);
            this.frontAccumulatorBrick6.Location = new System.Drawing.Point(28, 406);
            this.frontAccumulatorBrick6.Name = "frontAccumulatorBrick6";
            this.frontAccumulatorBrick6.Size = new System.Drawing.Size(405, 68);
            this.frontAccumulatorBrick6.TabIndex = 4;
            this.frontAccumulatorBrick6.TabStop = false;
            this.frontAccumulatorBrick6.Text = "Front Accumulator Brick 6";
            this.frontAccumulatorBrick6.Click += new System.EventHandler(this.frontAccumulatorBrick6_Click);
            // 
            // avgFrontAccumulatorValue6
            // 
            this.avgFrontAccumulatorValue6.AutoSize = true;
            this.avgFrontAccumulatorValue6.Location = new System.Drawing.Point(350, 33);
            this.avgFrontAccumulatorValue6.Name = "avgFrontAccumulatorValue6";
            this.avgFrontAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue6.TabIndex = 39;
            this.avgFrontAccumulatorValue6.Text = "0";
            // 
            // minFrontAccumulatorBrick6
            // 
            this.minFrontAccumulatorBrick6.AutoSize = true;
            this.minFrontAccumulatorBrick6.Location = new System.Drawing.Point(23, 33);
            this.minFrontAccumulatorBrick6.Name = "minFrontAccumulatorBrick6";
            this.minFrontAccumulatorBrick6.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick6.TabIndex = 34;
            this.minFrontAccumulatorBrick6.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick6
            // 
            this.avgFrontAccumulatorBrick6.AutoSize = true;
            this.avgFrontAccumulatorBrick6.Location = new System.Drawing.Point(285, 33);
            this.avgFrontAccumulatorBrick6.Name = "avgFrontAccumulatorBrick6";
            this.avgFrontAccumulatorBrick6.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick6.TabIndex = 38;
            this.avgFrontAccumulatorBrick6.Text = "Avg:";
            // 
            // minFrontAccumulatorValue6
            // 
            this.minFrontAccumulatorValue6.AutoSize = true;
            this.minFrontAccumulatorValue6.Location = new System.Drawing.Point(88, 33);
            this.minFrontAccumulatorValue6.Name = "minFrontAccumulatorValue6";
            this.minFrontAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue6.TabIndex = 35;
            this.minFrontAccumulatorValue6.Text = "0";
            // 
            // maxFrontAccumulatorValue6
            // 
            this.maxFrontAccumulatorValue6.AutoSize = true;
            this.maxFrontAccumulatorValue6.Location = new System.Drawing.Point(214, 33);
            this.maxFrontAccumulatorValue6.Name = "maxFrontAccumulatorValue6";
            this.maxFrontAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue6.TabIndex = 37;
            this.maxFrontAccumulatorValue6.Text = "0";
            // 
            // maxFrontAccumulatorBrick6
            // 
            this.maxFrontAccumulatorBrick6.AutoSize = true;
            this.maxFrontAccumulatorBrick6.Location = new System.Drawing.Point(149, 33);
            this.maxFrontAccumulatorBrick6.Name = "maxFrontAccumulatorBrick6";
            this.maxFrontAccumulatorBrick6.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick6.TabIndex = 36;
            this.maxFrontAccumulatorBrick6.Text = "Max:";
            // 
            // frontAccumulatorBrick5
            // 
            this.frontAccumulatorBrick5.Controls.Add(this.avgFrontAccumulatorValue5);
            this.frontAccumulatorBrick5.Controls.Add(this.minFrontAccumulatorBrick5);
            this.frontAccumulatorBrick5.Controls.Add(this.avgFrontAccumulatorBrick5);
            this.frontAccumulatorBrick5.Controls.Add(this.minFrontAccumulatorValue5);
            this.frontAccumulatorBrick5.Controls.Add(this.maxFrontAccumulatorValue5);
            this.frontAccumulatorBrick5.Controls.Add(this.maxFrontAccumulatorBrick5);
            this.frontAccumulatorBrick5.Location = new System.Drawing.Point(28, 332);
            this.frontAccumulatorBrick5.Name = "frontAccumulatorBrick5";
            this.frontAccumulatorBrick5.Size = new System.Drawing.Size(405, 68);
            this.frontAccumulatorBrick5.TabIndex = 3;
            this.frontAccumulatorBrick5.TabStop = false;
            this.frontAccumulatorBrick5.Text = "Front Accumulator Brick 5";
            this.frontAccumulatorBrick5.Click += new System.EventHandler(this.frontAccumulatorBrick5_Click);
            // 
            // avgFrontAccumulatorValue5
            // 
            this.avgFrontAccumulatorValue5.AutoSize = true;
            this.avgFrontAccumulatorValue5.Location = new System.Drawing.Point(350, 33);
            this.avgFrontAccumulatorValue5.Name = "avgFrontAccumulatorValue5";
            this.avgFrontAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue5.TabIndex = 33;
            this.avgFrontAccumulatorValue5.Text = "0";
            // 
            // minFrontAccumulatorBrick5
            // 
            this.minFrontAccumulatorBrick5.AutoSize = true;
            this.minFrontAccumulatorBrick5.Location = new System.Drawing.Point(23, 33);
            this.minFrontAccumulatorBrick5.Name = "minFrontAccumulatorBrick5";
            this.minFrontAccumulatorBrick5.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick5.TabIndex = 28;
            this.minFrontAccumulatorBrick5.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick5
            // 
            this.avgFrontAccumulatorBrick5.AutoSize = true;
            this.avgFrontAccumulatorBrick5.Location = new System.Drawing.Point(285, 33);
            this.avgFrontAccumulatorBrick5.Name = "avgFrontAccumulatorBrick5";
            this.avgFrontAccumulatorBrick5.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick5.TabIndex = 32;
            this.avgFrontAccumulatorBrick5.Text = "Avg:";
            // 
            // minFrontAccumulatorValue5
            // 
            this.minFrontAccumulatorValue5.AutoSize = true;
            this.minFrontAccumulatorValue5.Location = new System.Drawing.Point(88, 33);
            this.minFrontAccumulatorValue5.Name = "minFrontAccumulatorValue5";
            this.minFrontAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue5.TabIndex = 29;
            this.minFrontAccumulatorValue5.Text = "0";
            // 
            // maxFrontAccumulatorValue5
            // 
            this.maxFrontAccumulatorValue5.AutoSize = true;
            this.maxFrontAccumulatorValue5.Location = new System.Drawing.Point(214, 33);
            this.maxFrontAccumulatorValue5.Name = "maxFrontAccumulatorValue5";
            this.maxFrontAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue5.TabIndex = 31;
            this.maxFrontAccumulatorValue5.Text = "0";
            // 
            // maxFrontAccumulatorBrick5
            // 
            this.maxFrontAccumulatorBrick5.AutoSize = true;
            this.maxFrontAccumulatorBrick5.Location = new System.Drawing.Point(149, 33);
            this.maxFrontAccumulatorBrick5.Name = "maxFrontAccumulatorBrick5";
            this.maxFrontAccumulatorBrick5.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick5.TabIndex = 30;
            this.maxFrontAccumulatorBrick5.Text = "Max:";
            // 
            // frontAccumulatorBrick4
            // 
            this.frontAccumulatorBrick4.Controls.Add(this.avgFrontAccumulatorValue4);
            this.frontAccumulatorBrick4.Controls.Add(this.minFrontAccumulatorBrick4);
            this.frontAccumulatorBrick4.Controls.Add(this.avgFrontAccumulatorBrick4);
            this.frontAccumulatorBrick4.Controls.Add(this.minFrontAccumulatorValue4);
            this.frontAccumulatorBrick4.Controls.Add(this.maxFrontAccumulatorValue4);
            this.frontAccumulatorBrick4.Controls.Add(this.maxFrontAccumulatorBrick4);
            this.frontAccumulatorBrick4.Location = new System.Drawing.Point(28, 258);
            this.frontAccumulatorBrick4.Name = "frontAccumulatorBrick4";
            this.frontAccumulatorBrick4.Size = new System.Drawing.Size(405, 68);
            this.frontAccumulatorBrick4.TabIndex = 1;
            this.frontAccumulatorBrick4.TabStop = false;
            this.frontAccumulatorBrick4.Text = "Front Accumulator Brick 4";
            this.frontAccumulatorBrick4.Click += new System.EventHandler(this.frontAccumulatorBrick4_Click);
            // 
            // avgFrontAccumulatorValue4
            // 
            this.avgFrontAccumulatorValue4.AutoSize = true;
            this.avgFrontAccumulatorValue4.Location = new System.Drawing.Point(350, 33);
            this.avgFrontAccumulatorValue4.Name = "avgFrontAccumulatorValue4";
            this.avgFrontAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue4.TabIndex = 27;
            this.avgFrontAccumulatorValue4.Text = "0";
            // 
            // minFrontAccumulatorBrick4
            // 
            this.minFrontAccumulatorBrick4.AutoSize = true;
            this.minFrontAccumulatorBrick4.Location = new System.Drawing.Point(23, 33);
            this.minFrontAccumulatorBrick4.Name = "minFrontAccumulatorBrick4";
            this.minFrontAccumulatorBrick4.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick4.TabIndex = 22;
            this.minFrontAccumulatorBrick4.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick4
            // 
            this.avgFrontAccumulatorBrick4.AutoSize = true;
            this.avgFrontAccumulatorBrick4.Location = new System.Drawing.Point(285, 33);
            this.avgFrontAccumulatorBrick4.Name = "avgFrontAccumulatorBrick4";
            this.avgFrontAccumulatorBrick4.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick4.TabIndex = 26;
            this.avgFrontAccumulatorBrick4.Text = "Avg:";
            // 
            // minFrontAccumulatorValue4
            // 
            this.minFrontAccumulatorValue4.AutoSize = true;
            this.minFrontAccumulatorValue4.Location = new System.Drawing.Point(88, 33);
            this.minFrontAccumulatorValue4.Name = "minFrontAccumulatorValue4";
            this.minFrontAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue4.TabIndex = 23;
            this.minFrontAccumulatorValue4.Text = "0";
            // 
            // maxFrontAccumulatorValue4
            // 
            this.maxFrontAccumulatorValue4.AutoSize = true;
            this.maxFrontAccumulatorValue4.Location = new System.Drawing.Point(214, 33);
            this.maxFrontAccumulatorValue4.Name = "maxFrontAccumulatorValue4";
            this.maxFrontAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue4.TabIndex = 25;
            this.maxFrontAccumulatorValue4.Text = "0";
            // 
            // maxFrontAccumulatorBrick4
            // 
            this.maxFrontAccumulatorBrick4.AutoSize = true;
            this.maxFrontAccumulatorBrick4.Location = new System.Drawing.Point(149, 33);
            this.maxFrontAccumulatorBrick4.Name = "maxFrontAccumulatorBrick4";
            this.maxFrontAccumulatorBrick4.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick4.TabIndex = 24;
            this.maxFrontAccumulatorBrick4.Text = "Max:";
            // 
            // frontAccumulatorBrick3
            // 
            this.frontAccumulatorBrick3.Controls.Add(this.avgFrontAccumulatorValue3);
            this.frontAccumulatorBrick3.Controls.Add(this.minFrontAccumulatorBrick3);
            this.frontAccumulatorBrick3.Controls.Add(this.avgFrontAccumulatorBrick3);
            this.frontAccumulatorBrick3.Controls.Add(this.minFrontAccumulatorValue3);
            this.frontAccumulatorBrick3.Controls.Add(this.maxFrontAccumulatorValue3);
            this.frontAccumulatorBrick3.Controls.Add(this.maxFrontAccumulatorBrick3);
            this.frontAccumulatorBrick3.Location = new System.Drawing.Point(28, 184);
            this.frontAccumulatorBrick3.Name = "frontAccumulatorBrick3";
            this.frontAccumulatorBrick3.Size = new System.Drawing.Size(405, 68);
            this.frontAccumulatorBrick3.TabIndex = 2;
            this.frontAccumulatorBrick3.TabStop = false;
            this.frontAccumulatorBrick3.Text = "Front Accumulator Brick 3";
            this.frontAccumulatorBrick3.Click += new System.EventHandler(this.frontAccumulatorBrick3_Click);
            // 
            // avgFrontAccumulatorValue3
            // 
            this.avgFrontAccumulatorValue3.AutoSize = true;
            this.avgFrontAccumulatorValue3.Location = new System.Drawing.Point(350, 33);
            this.avgFrontAccumulatorValue3.Name = "avgFrontAccumulatorValue3";
            this.avgFrontAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue3.TabIndex = 21;
            this.avgFrontAccumulatorValue3.Text = "0";
            // 
            // minFrontAccumulatorBrick3
            // 
            this.minFrontAccumulatorBrick3.AutoSize = true;
            this.minFrontAccumulatorBrick3.Location = new System.Drawing.Point(23, 33);
            this.minFrontAccumulatorBrick3.Name = "minFrontAccumulatorBrick3";
            this.minFrontAccumulatorBrick3.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick3.TabIndex = 16;
            this.minFrontAccumulatorBrick3.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick3
            // 
            this.avgFrontAccumulatorBrick3.AutoSize = true;
            this.avgFrontAccumulatorBrick3.Location = new System.Drawing.Point(285, 33);
            this.avgFrontAccumulatorBrick3.Name = "avgFrontAccumulatorBrick3";
            this.avgFrontAccumulatorBrick3.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick3.TabIndex = 20;
            this.avgFrontAccumulatorBrick3.Text = "Avg:";
            // 
            // minFrontAccumulatorValue3
            // 
            this.minFrontAccumulatorValue3.AutoSize = true;
            this.minFrontAccumulatorValue3.Location = new System.Drawing.Point(88, 33);
            this.minFrontAccumulatorValue3.Name = "minFrontAccumulatorValue3";
            this.minFrontAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue3.TabIndex = 17;
            this.minFrontAccumulatorValue3.Text = "0";
            // 
            // maxFrontAccumulatorValue3
            // 
            this.maxFrontAccumulatorValue3.AutoSize = true;
            this.maxFrontAccumulatorValue3.Location = new System.Drawing.Point(214, 33);
            this.maxFrontAccumulatorValue3.Name = "maxFrontAccumulatorValue3";
            this.maxFrontAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue3.TabIndex = 19;
            this.maxFrontAccumulatorValue3.Text = "0";
            // 
            // maxFrontAccumulatorBrick3
            // 
            this.maxFrontAccumulatorBrick3.AutoSize = true;
            this.maxFrontAccumulatorBrick3.Location = new System.Drawing.Point(149, 33);
            this.maxFrontAccumulatorBrick3.Name = "maxFrontAccumulatorBrick3";
            this.maxFrontAccumulatorBrick3.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick3.TabIndex = 18;
            this.maxFrontAccumulatorBrick3.Text = "Max:";
            // 
            // frontAccumulatorBrick2
            // 
            this.frontAccumulatorBrick2.Controls.Add(this.avgFrontAccumulatorValue2);
            this.frontAccumulatorBrick2.Controls.Add(this.avgFrontAccumulatorBrick2);
            this.frontAccumulatorBrick2.Controls.Add(this.maxFrontAccumulatorValue2);
            this.frontAccumulatorBrick2.Controls.Add(this.maxFrontAccumulatorBrick2);
            this.frontAccumulatorBrick2.Controls.Add(this.minFrontAccumulatorValue2);
            this.frontAccumulatorBrick2.Controls.Add(this.minFrontAccumulatorBrick2);
            this.frontAccumulatorBrick2.Location = new System.Drawing.Point(28, 110);
            this.frontAccumulatorBrick2.Name = "frontAccumulatorBrick2";
            this.frontAccumulatorBrick2.Size = new System.Drawing.Size(405, 68);
            this.frontAccumulatorBrick2.TabIndex = 1;
            this.frontAccumulatorBrick2.TabStop = false;
            this.frontAccumulatorBrick2.Text = "Front Accumulator Brick 2";
            this.frontAccumulatorBrick2.Click += new System.EventHandler(this.frontAccumulatorBrick2_Click);
            // 
            // avgFrontAccumulatorValue2
            // 
            this.avgFrontAccumulatorValue2.AutoSize = true;
            this.avgFrontAccumulatorValue2.Location = new System.Drawing.Point(350, 33);
            this.avgFrontAccumulatorValue2.Name = "avgFrontAccumulatorValue2";
            this.avgFrontAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue2.TabIndex = 15;
            this.avgFrontAccumulatorValue2.Text = "0";
            // 
            // avgFrontAccumulatorBrick2
            // 
            this.avgFrontAccumulatorBrick2.AutoSize = true;
            this.avgFrontAccumulatorBrick2.Location = new System.Drawing.Point(285, 33);
            this.avgFrontAccumulatorBrick2.Name = "avgFrontAccumulatorBrick2";
            this.avgFrontAccumulatorBrick2.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick2.TabIndex = 14;
            this.avgFrontAccumulatorBrick2.Text = "Avg:";
            // 
            // maxFrontAccumulatorValue2
            // 
            this.maxFrontAccumulatorValue2.AutoSize = true;
            this.maxFrontAccumulatorValue2.Location = new System.Drawing.Point(214, 33);
            this.maxFrontAccumulatorValue2.Name = "maxFrontAccumulatorValue2";
            this.maxFrontAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue2.TabIndex = 13;
            this.maxFrontAccumulatorValue2.Text = "0";
            // 
            // maxFrontAccumulatorBrick2
            // 
            this.maxFrontAccumulatorBrick2.AutoSize = true;
            this.maxFrontAccumulatorBrick2.Location = new System.Drawing.Point(149, 33);
            this.maxFrontAccumulatorBrick2.Name = "maxFrontAccumulatorBrick2";
            this.maxFrontAccumulatorBrick2.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick2.TabIndex = 12;
            this.maxFrontAccumulatorBrick2.Text = "Max:";
            // 
            // minFrontAccumulatorValue2
            // 
            this.minFrontAccumulatorValue2.AutoSize = true;
            this.minFrontAccumulatorValue2.Location = new System.Drawing.Point(88, 33);
            this.minFrontAccumulatorValue2.Name = "minFrontAccumulatorValue2";
            this.minFrontAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue2.TabIndex = 11;
            this.minFrontAccumulatorValue2.Text = "0";
            // 
            // minFrontAccumulatorBrick2
            // 
            this.minFrontAccumulatorBrick2.AutoSize = true;
            this.minFrontAccumulatorBrick2.Location = new System.Drawing.Point(23, 33);
            this.minFrontAccumulatorBrick2.Name = "minFrontAccumulatorBrick2";
            this.minFrontAccumulatorBrick2.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick2.TabIndex = 10;
            this.minFrontAccumulatorBrick2.Text = "Min:";
            // 
            // frontAccumulatorBrick1
            // 
            this.frontAccumulatorBrick1.Controls.Add(this.avgFrontAccumulatorValue1);
            this.frontAccumulatorBrick1.Controls.Add(this.avgFrontAccumulatorBrick1);
            this.frontAccumulatorBrick1.Controls.Add(this.maxFrontAccumulatorValue1);
            this.frontAccumulatorBrick1.Controls.Add(this.maxFrontAccumulatorBrick1);
            this.frontAccumulatorBrick1.Controls.Add(this.minFrontAccumulatorValue1);
            this.frontAccumulatorBrick1.Controls.Add(this.minFrontAccumulatorBrick1);
            this.frontAccumulatorBrick1.Location = new System.Drawing.Point(28, 36);
            this.frontAccumulatorBrick1.Name = "frontAccumulatorBrick1";
            this.frontAccumulatorBrick1.Size = new System.Drawing.Size(405, 68);
            this.frontAccumulatorBrick1.TabIndex = 0;
            this.frontAccumulatorBrick1.TabStop = false;
            this.frontAccumulatorBrick1.Text = "Front Accumulator Brick 1";
            this.frontAccumulatorBrick1.Click += new System.EventHandler(this.frontAccumulatorBrick1_Click);
            // 
            // avgFrontAccumulatorValue1
            // 
            this.avgFrontAccumulatorValue1.AutoSize = true;
            this.avgFrontAccumulatorValue1.Location = new System.Drawing.Point(350, 33);
            this.avgFrontAccumulatorValue1.Name = "avgFrontAccumulatorValue1";
            this.avgFrontAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue1.TabIndex = 9;
            this.avgFrontAccumulatorValue1.Text = "0";
            // 
            // avgFrontAccumulatorBrick1
            // 
            this.avgFrontAccumulatorBrick1.AutoSize = true;
            this.avgFrontAccumulatorBrick1.Location = new System.Drawing.Point(285, 33);
            this.avgFrontAccumulatorBrick1.Name = "avgFrontAccumulatorBrick1";
            this.avgFrontAccumulatorBrick1.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick1.TabIndex = 8;
            this.avgFrontAccumulatorBrick1.Text = "Avg:";
            // 
            // maxFrontAccumulatorValue1
            // 
            this.maxFrontAccumulatorValue1.AutoSize = true;
            this.maxFrontAccumulatorValue1.Location = new System.Drawing.Point(214, 33);
            this.maxFrontAccumulatorValue1.Name = "maxFrontAccumulatorValue1";
            this.maxFrontAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue1.TabIndex = 7;
            this.maxFrontAccumulatorValue1.Text = "0";
            // 
            // maxFrontAccumulatorBrick1
            // 
            this.maxFrontAccumulatorBrick1.AutoSize = true;
            this.maxFrontAccumulatorBrick1.Location = new System.Drawing.Point(149, 33);
            this.maxFrontAccumulatorBrick1.Name = "maxFrontAccumulatorBrick1";
            this.maxFrontAccumulatorBrick1.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick1.TabIndex = 6;
            this.maxFrontAccumulatorBrick1.Text = "Max:";
            // 
            // minFrontAccumulatorValue1
            // 
            this.minFrontAccumulatorValue1.AutoSize = true;
            this.minFrontAccumulatorValue1.Location = new System.Drawing.Point(88, 33);
            this.minFrontAccumulatorValue1.Name = "minFrontAccumulatorValue1";
            this.minFrontAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue1.TabIndex = 5;
            this.minFrontAccumulatorValue1.Text = "0";
            // 
            // minFrontAccumulatorBrick1
            // 
            this.minFrontAccumulatorBrick1.AutoSize = true;
            this.minFrontAccumulatorBrick1.Location = new System.Drawing.Point(23, 33);
            this.minFrontAccumulatorBrick1.Name = "minFrontAccumulatorBrick1";
            this.minFrontAccumulatorBrick1.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick1.TabIndex = 4;
            this.minFrontAccumulatorBrick1.Text = "Min:";
            // 
            // rearAccumulatorGroupBox
            // 
            this.rearAccumulatorGroupBox.Controls.Add(this.avgRearAccumulatorValue);
            this.rearAccumulatorGroupBox.Controls.Add(this.maxRearAccumulatorValue);
            this.rearAccumulatorGroupBox.Controls.Add(this.minRearAccumulatorValue);
            this.rearAccumulatorGroupBox.Controls.Add(this.avgRearAccumulatorLabel);
            this.rearAccumulatorGroupBox.Controls.Add(this.maxRearAccumulatorLabel);
            this.rearAccumulatorGroupBox.Controls.Add(this.minRearAccumulatorLabel);
            this.rearAccumulatorGroupBox.Location = new System.Drawing.Point(49, 425);
            this.rearAccumulatorGroupBox.Name = "rearAccumulatorGroupBox";
            this.rearAccumulatorGroupBox.Size = new System.Drawing.Size(280, 313);
            this.rearAccumulatorGroupBox.TabIndex = 1;
            this.rearAccumulatorGroupBox.TabStop = false;
            this.rearAccumulatorGroupBox.Text = "Rear Accumulators";
            // 
            // avgRearAccumulatorValue
            // 
            this.avgRearAccumulatorValue.AutoSize = true;
            this.avgRearAccumulatorValue.Location = new System.Drawing.Point(128, 220);
            this.avgRearAccumulatorValue.Name = "avgRearAccumulatorValue";
            this.avgRearAccumulatorValue.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue.TabIndex = 5;
            this.avgRearAccumulatorValue.Text = "0";
            // 
            // maxRearAccumulatorValue
            // 
            this.maxRearAccumulatorValue.AutoSize = true;
            this.maxRearAccumulatorValue.Location = new System.Drawing.Point(128, 141);
            this.maxRearAccumulatorValue.Name = "maxRearAccumulatorValue";
            this.maxRearAccumulatorValue.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue.TabIndex = 4;
            this.maxRearAccumulatorValue.Text = "0";
            // 
            // minRearAccumulatorValue
            // 
            this.minRearAccumulatorValue.AutoSize = true;
            this.minRearAccumulatorValue.Location = new System.Drawing.Point(128, 70);
            this.minRearAccumulatorValue.Name = "minRearAccumulatorValue";
            this.minRearAccumulatorValue.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue.TabIndex = 3;
            this.minRearAccumulatorValue.Text = "0";
            // 
            // avgRearAccumulatorLabel
            // 
            this.avgRearAccumulatorLabel.AutoSize = true;
            this.avgRearAccumulatorLabel.Location = new System.Drawing.Point(30, 220);
            this.avgRearAccumulatorLabel.Name = "avgRearAccumulatorLabel";
            this.avgRearAccumulatorLabel.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorLabel.TabIndex = 2;
            this.avgRearAccumulatorLabel.Text = "Avg:";
            // 
            // maxRearAccumulatorLabel
            // 
            this.maxRearAccumulatorLabel.AutoSize = true;
            this.maxRearAccumulatorLabel.Location = new System.Drawing.Point(30, 141);
            this.maxRearAccumulatorLabel.Name = "maxRearAccumulatorLabel";
            this.maxRearAccumulatorLabel.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorLabel.TabIndex = 1;
            this.maxRearAccumulatorLabel.Text = "Max:";
            // 
            // minRearAccumulatorLabel
            // 
            this.minRearAccumulatorLabel.AutoSize = true;
            this.minRearAccumulatorLabel.Location = new System.Drawing.Point(30, 70);
            this.minRearAccumulatorLabel.Name = "minRearAccumulatorLabel";
            this.minRearAccumulatorLabel.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorLabel.TabIndex = 0;
            this.minRearAccumulatorLabel.Text = "Min:";
            // 
            // frontAccumulatorGroupBox
            // 
            this.frontAccumulatorGroupBox.Controls.Add(this.AvgFrontAccumulatorValue);
            this.frontAccumulatorGroupBox.Controls.Add(this.maxFrontAccumulatorsValue);
            this.frontAccumulatorGroupBox.Controls.Add(this.minFrontAccumulatorValue);
            this.frontAccumulatorGroupBox.Controls.Add(this.avgFrontAccumulatorLabel);
            this.frontAccumulatorGroupBox.Controls.Add(this.maxFrontAccumulatorsLabel);
            this.frontAccumulatorGroupBox.Controls.Add(this.minFrontAccumulatorsLabel);
            this.frontAccumulatorGroupBox.Location = new System.Drawing.Point(49, 39);
            this.frontAccumulatorGroupBox.Name = "frontAccumulatorGroupBox";
            this.frontAccumulatorGroupBox.Size = new System.Drawing.Size(280, 313);
            this.frontAccumulatorGroupBox.TabIndex = 0;
            this.frontAccumulatorGroupBox.TabStop = false;
            this.frontAccumulatorGroupBox.Text = "Front Accumulators";
            // 
            // AvgFrontAccumulatorValue
            // 
            this.AvgFrontAccumulatorValue.AutoSize = true;
            this.AvgFrontAccumulatorValue.Location = new System.Drawing.Point(128, 220);
            this.AvgFrontAccumulatorValue.Name = "AvgFrontAccumulatorValue";
            this.AvgFrontAccumulatorValue.Size = new System.Drawing.Size(25, 29);
            this.AvgFrontAccumulatorValue.TabIndex = 5;
            this.AvgFrontAccumulatorValue.Text = "0";
            // 
            // maxFrontAccumulatorsValue
            // 
            this.maxFrontAccumulatorsValue.AutoSize = true;
            this.maxFrontAccumulatorsValue.Location = new System.Drawing.Point(128, 141);
            this.maxFrontAccumulatorsValue.Name = "maxFrontAccumulatorsValue";
            this.maxFrontAccumulatorsValue.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorsValue.TabIndex = 4;
            this.maxFrontAccumulatorsValue.Text = "0";
            // 
            // minFrontAccumulatorValue
            // 
            this.minFrontAccumulatorValue.AutoSize = true;
            this.minFrontAccumulatorValue.Location = new System.Drawing.Point(128, 70);
            this.minFrontAccumulatorValue.Name = "minFrontAccumulatorValue";
            this.minFrontAccumulatorValue.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue.TabIndex = 3;
            this.minFrontAccumulatorValue.Text = "0";
            // 
            // avgFrontAccumulatorLabel
            // 
            this.avgFrontAccumulatorLabel.AutoSize = true;
            this.avgFrontAccumulatorLabel.Location = new System.Drawing.Point(30, 220);
            this.avgFrontAccumulatorLabel.Name = "avgFrontAccumulatorLabel";
            this.avgFrontAccumulatorLabel.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorLabel.TabIndex = 2;
            this.avgFrontAccumulatorLabel.Text = "Avg:";
            // 
            // maxFrontAccumulatorsLabel
            // 
            this.maxFrontAccumulatorsLabel.AutoSize = true;
            this.maxFrontAccumulatorsLabel.Location = new System.Drawing.Point(30, 141);
            this.maxFrontAccumulatorsLabel.Name = "maxFrontAccumulatorsLabel";
            this.maxFrontAccumulatorsLabel.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorsLabel.TabIndex = 1;
            this.maxFrontAccumulatorsLabel.Text = "Max:";
            // 
            // minFrontAccumulatorsLabel
            // 
            this.minFrontAccumulatorsLabel.AutoSize = true;
            this.minFrontAccumulatorsLabel.Location = new System.Drawing.Point(30, 70);
            this.minFrontAccumulatorsLabel.Name = "minFrontAccumulatorsLabel";
            this.minFrontAccumulatorsLabel.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorsLabel.TabIndex = 0;
            this.minFrontAccumulatorsLabel.Text = "Min:";
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
            this.GLV_Tab.Location = new System.Drawing.Point(4, 38);
            this.GLV_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GLV_Tab.Name = "GLV_Tab";
            this.GLV_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GLV_Tab.Size = new System.Drawing.Size(2017, 998);
            this.GLV_Tab.TabIndex = 4;
            this.GLV_Tab.Text = "Power Management";
            this.GLV_Tab.UseVisualStyleBackColor = true;
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
            this.Accumulators_Tab.ResumeLayout(false);
            this.rearAccumulatorBricksGroupBox.ResumeLayout(false);
            this.rearAccumulatorBrick6.ResumeLayout(false);
            this.rearAccumulatorBrick6.PerformLayout();
            this.rearAccumulatorBrick5.ResumeLayout(false);
            this.rearAccumulatorBrick5.PerformLayout();
            this.rearAccumulatorBrick4.ResumeLayout(false);
            this.rearAccumulatorBrick4.PerformLayout();
            this.rearAccumulatorBrick3.ResumeLayout(false);
            this.rearAccumulatorBrick3.PerformLayout();
            this.rearAccumulatorBrick2.ResumeLayout(false);
            this.rearAccumulatorBrick2.PerformLayout();
            this.rearAccumulatorBrick1.ResumeLayout(false);
            this.rearAccumulatorBrick1.PerformLayout();
            this.frontAccumulatorBricksGroupBox.ResumeLayout(false);
            this.frontAccumulatorBrick6.ResumeLayout(false);
            this.frontAccumulatorBrick6.PerformLayout();
            this.frontAccumulatorBrick5.ResumeLayout(false);
            this.frontAccumulatorBrick5.PerformLayout();
            this.frontAccumulatorBrick4.ResumeLayout(false);
            this.frontAccumulatorBrick4.PerformLayout();
            this.frontAccumulatorBrick3.ResumeLayout(false);
            this.frontAccumulatorBrick3.PerformLayout();
            this.frontAccumulatorBrick2.ResumeLayout(false);
            this.frontAccumulatorBrick2.PerformLayout();
            this.frontAccumulatorBrick1.ResumeLayout(false);
            this.frontAccumulatorBrick1.PerformLayout();
            this.rearAccumulatorGroupBox.ResumeLayout(false);
            this.rearAccumulatorGroupBox.PerformLayout();
            this.frontAccumulatorGroupBox.ResumeLayout(false);
            this.frontAccumulatorGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox frontAccumulatorGroupBox;
        private System.Windows.Forms.Label avgFrontAccumulatorLabel;
        private System.Windows.Forms.Label maxFrontAccumulatorsLabel;
        private System.Windows.Forms.Label minFrontAccumulatorsLabel;
        private System.Windows.Forms.GroupBox rearAccumulatorGroupBox;
        private System.Windows.Forms.Label avgRearAccumulatorValue;
        private System.Windows.Forms.Label maxRearAccumulatorValue;
        private System.Windows.Forms.Label minRearAccumulatorValue;
        private System.Windows.Forms.Label avgRearAccumulatorLabel;
        private System.Windows.Forms.Label maxRearAccumulatorLabel;
        private System.Windows.Forms.Label minRearAccumulatorLabel;
        private System.Windows.Forms.Label AvgFrontAccumulatorValue;
        private System.Windows.Forms.Label maxFrontAccumulatorsValue;
        private System.Windows.Forms.Label minFrontAccumulatorValue;
        private System.Windows.Forms.GroupBox frontAccumulatorBricksGroupBox;
        private System.Windows.Forms.GroupBox rearAccumulatorBricksGroupBox;
        private System.Windows.Forms.GroupBox rearAccumulatorBrick6;
        private System.Windows.Forms.GroupBox rearAccumulatorBrick5;
        private System.Windows.Forms.GroupBox rearAccumulatorBrick4;
        private System.Windows.Forms.GroupBox rearAccumulatorBrick3;
        private System.Windows.Forms.GroupBox rearAccumulatorBrick2;
        private System.Windows.Forms.GroupBox rearAccumulatorBrick1;
        private System.Windows.Forms.GroupBox frontAccumulatorBrick6;
        private System.Windows.Forms.GroupBox frontAccumulatorBrick5;
        private System.Windows.Forms.GroupBox frontAccumulatorBrick4;
        private System.Windows.Forms.GroupBox frontAccumulatorBrick3;
        private System.Windows.Forms.GroupBox frontAccumulatorBrick2;
        private System.Windows.Forms.GroupBox frontAccumulatorBrick1;
        private System.Windows.Forms.Label avgRearAccumulatorValue6;
        private System.Windows.Forms.Label minRearAccumulatorBrick6;
        private System.Windows.Forms.Label avgRearAccumulatorBrick6;
        private System.Windows.Forms.Label minRearAccumulatorValue6;
        private System.Windows.Forms.Label maxRearAccumulatorValue6;
        private System.Windows.Forms.Label maxRearAccumulatorBrick6;
        private System.Windows.Forms.Label avgRearAccumulatorValue5;
        private System.Windows.Forms.Label minRearAccumulatorBrick5;
        private System.Windows.Forms.Label avgRearAccumulatorBrick5;
        private System.Windows.Forms.Label minRearAccumulatorValue5;
        private System.Windows.Forms.Label maxRearAccumulatorValue5;
        private System.Windows.Forms.Label maxRearAccumulatorBrick5;
        private System.Windows.Forms.Label avgRearAccumulatorValue4;
        private System.Windows.Forms.Label minRearAccumulatorBrick4;
        private System.Windows.Forms.Label avgRearAccumulatorBrick4;
        private System.Windows.Forms.Label minRearAccumulatorValue4;
        private System.Windows.Forms.Label maxRearAccumulatorValue4;
        private System.Windows.Forms.Label maxRearAccumulatorBrick4;
        private System.Windows.Forms.Label avgRearAccumulatorValue3;
        private System.Windows.Forms.Label minRearAccumulatorBrick3;
        private System.Windows.Forms.Label avgRearAccumulatorBrick3;
        private System.Windows.Forms.Label minRearAccumulatorValue3;
        private System.Windows.Forms.Label maxRearAccumulatorValue3;
        private System.Windows.Forms.Label maxRearAccumulatorBrick3;
        private System.Windows.Forms.Label avgRearAccumulatorValue2;
        private System.Windows.Forms.Label minRearAccumulatorBrick2;
        private System.Windows.Forms.Label avgRearAccumulatorBrick2;
        private System.Windows.Forms.Label minRearAccumulatorValue2;
        private System.Windows.Forms.Label maxRearAccumulatorValue2;
        private System.Windows.Forms.Label maxRearAccumulatorBrick2;
        private System.Windows.Forms.Label avgRearAccumulatorValue1;
        private System.Windows.Forms.Label avgRearAccumulatorBrick1;
        private System.Windows.Forms.Label maxRearAccumulatorValue1;
        private System.Windows.Forms.Label maxRearAccumulatorBrick1;
        private System.Windows.Forms.Label minRearAccumulatorValue1;
        private System.Windows.Forms.Label minRearAccumulatorBrick1;
        private System.Windows.Forms.Label avgFrontAccumulatorValue6;
        private System.Windows.Forms.Label minFrontAccumulatorBrick6;
        private System.Windows.Forms.Label avgFrontAccumulatorBrick6;
        private System.Windows.Forms.Label minFrontAccumulatorValue6;
        private System.Windows.Forms.Label maxFrontAccumulatorValue6;
        private System.Windows.Forms.Label maxFrontAccumulatorBrick6;
        private System.Windows.Forms.Label avgFrontAccumulatorValue5;
        private System.Windows.Forms.Label minFrontAccumulatorBrick5;
        private System.Windows.Forms.Label avgFrontAccumulatorBrick5;
        private System.Windows.Forms.Label minFrontAccumulatorValue5;
        private System.Windows.Forms.Label maxFrontAccumulatorValue5;
        private System.Windows.Forms.Label maxFrontAccumulatorBrick5;
        private System.Windows.Forms.Label avgFrontAccumulatorValue4;
        private System.Windows.Forms.Label minFrontAccumulatorBrick4;
        private System.Windows.Forms.Label avgFrontAccumulatorBrick4;
        private System.Windows.Forms.Label minFrontAccumulatorValue4;
        private System.Windows.Forms.Label maxFrontAccumulatorValue4;
        private System.Windows.Forms.Label maxFrontAccumulatorBrick4;
        private System.Windows.Forms.Label avgFrontAccumulatorValue3;
        private System.Windows.Forms.Label minFrontAccumulatorBrick3;
        private System.Windows.Forms.Label avgFrontAccumulatorBrick3;
        private System.Windows.Forms.Label minFrontAccumulatorValue3;
        private System.Windows.Forms.Label maxFrontAccumulatorValue3;
        private System.Windows.Forms.Label maxFrontAccumulatorBrick3;
        private System.Windows.Forms.Label avgFrontAccumulatorValue2;
        private System.Windows.Forms.Label avgFrontAccumulatorBrick2;
        private System.Windows.Forms.Label maxFrontAccumulatorValue2;
        private System.Windows.Forms.Label maxFrontAccumulatorBrick2;
        private System.Windows.Forms.Label minFrontAccumulatorValue2;
        private System.Windows.Forms.Label minFrontAccumulatorBrick2;
        private System.Windows.Forms.Label avgFrontAccumulatorValue1;
        private System.Windows.Forms.Label avgFrontAccumulatorBrick1;
        private System.Windows.Forms.Label maxFrontAccumulatorValue1;
        private System.Windows.Forms.Label maxFrontAccumulatorBrick1;
        private System.Windows.Forms.Label minFrontAccumulatorValue1;
        private System.Windows.Forms.Label minFrontAccumulatorBrick1;
    }
}