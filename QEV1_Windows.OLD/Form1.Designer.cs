namespace QEV1_Windows {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTorqueSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTorqueSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scanForSerialPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToTelemetryServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccumulatorsTab = new System.Windows.Forms.TabPage();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.loggingStopStartButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rx_status_label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.serialLinkSpeedLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicleProfileLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.editProfilesButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.profileStartupCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.profileCurrentCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusTabs = new System.Windows.Forms.TabControl();
            this.InvertersTab = new System.Windows.Forms.TabPage();
            this.TorqueVectoringTab = new System.Windows.Forms.TabPage();
            this.PowerManagementTab = new System.Windows.Forms.TabPage();
            this.CoolingTab = new System.Windows.Forms.TabPage();
            this.SafteyTab = new System.Windows.Forms.TabPage();
            this.IOSetupTab = new System.Windows.Forms.TabPage();
            this.DiagnosticsTab = new System.Windows.Forms.TabPage();
            this.UpdateFirmwareTab = new System.Windows.Forms.TabPage();
            this.SerialConnectionStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SerialConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ComPortNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialTimer = new System.Windows.Forms.Timer(this.components);
            this.getDataTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.profileGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusTabs.SuspendLayout();
            this.SerialConnectionStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.commsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSettingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.importTorqueSettingsToolStripMenuItem,
            this.exportTorqueSettingsToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 23);
            this.fileMenu.Text = "File";
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
            // commsMenu
            // 
            this.commsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanForSerialPortsToolStripMenuItem,
            this.connectSerialToolStripMenuItem,
            this.disconnectSerialToolStripMenuItem,
            this.linkToTelemetryServerToolStripMenuItem});
            this.commsMenu.Name = "commsMenu";
            this.commsMenu.Size = new System.Drawing.Size(69, 23);
            this.commsMenu.Text = "Comms";
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
            // AccumulatorsTab
            // 
            this.AccumulatorsTab.Location = new System.Drawing.Point(4, 28);
            this.AccumulatorsTab.Name = "AccumulatorsTab";
            this.AccumulatorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccumulatorsTab.Size = new System.Drawing.Size(1330, 646);
            this.AccumulatorsTab.TabIndex = 1;
            this.AccumulatorsTab.Text = "Accumulators";
            this.AccumulatorsTab.UseVisualStyleBackColor = true;
            // 
            // OverviewTab
            // 
            this.OverviewTab.Controls.Add(this.loggingStopStartButton);
            this.OverviewTab.Controls.Add(this.groupBox7);
            this.OverviewTab.Controls.Add(this.groupBox6);
            this.OverviewTab.Controls.Add(this.profileGroupBox);
            this.OverviewTab.Controls.Add(this.groupBox2);
            this.OverviewTab.Controls.Add(this.groupBox1);
            this.OverviewTab.Location = new System.Drawing.Point(4, 28);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverviewTab.Size = new System.Drawing.Size(1330, 646);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            this.OverviewTab.UseVisualStyleBackColor = true;
            // 
            // loggingStopStartButton
            // 
            this.loggingStopStartButton.Location = new System.Drawing.Point(491, 26);
            this.loggingStopStartButton.Name = "loggingStopStartButton";
            this.loggingStopStartButton.Size = new System.Drawing.Size(123, 28);
            this.loggingStopStartButton.TabIndex = 18;
            this.loggingStopStartButton.Text = "Start Logging";
            this.loggingStopStartButton.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rx_status_label);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(296, 96);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(174, 75);
            this.groupBox7.TabIndex = 17;
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
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(296, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(174, 75);
            this.groupBox6.TabIndex = 16;
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
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.vehicleProfileLabel);
            this.profileGroupBox.Controls.Add(this.label17);
            this.profileGroupBox.Controls.Add(this.editProfilesButton);
            this.profileGroupBox.Controls.Add(this.label16);
            this.profileGroupBox.Controls.Add(this.profileStartupCombo);
            this.profileGroupBox.Controls.Add(this.label11);
            this.profileGroupBox.Controls.Add(this.profileCurrentCombo);
            this.profileGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileGroupBox.Location = new System.Drawing.Point(18, 15);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(270, 206);
            this.profileGroupBox.TabIndex = 15;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "Profiles";
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
            this.groupBox2.Location = new System.Drawing.Point(491, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 409);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inverter 1 (Test)";
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
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(149, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "%";
            // 
            // brakeLabel
            // 
            this.brakeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeLabel.Location = new System.Drawing.Point(98, 55);
            this.brakeLabel.Name = "brakeLabel";
            this.brakeLabel.Size = new System.Drawing.Size(45, 19);
            this.brakeLabel.TabIndex = 44;
            this.brakeLabel.Text = "1.234";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 19);
            this.label22.TabIndex = 43;
            this.label22.Text = "Brake";
            // 
            // Enable1
            // 
            this.Enable1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enable1.ForeColor = System.Drawing.Color.Red;
            this.Enable1.Location = new System.Drawing.Point(99, 98);
            this.Enable1.Name = "Enable1";
            this.Enable1.Size = new System.Drawing.Size(43, 19);
            this.Enable1.TabIndex = 42;
            this.Enable1.Text = "False";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "Enable";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(148, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "%";
            // 
            // throttleLabel
            // 
            this.throttleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throttleLabel.Location = new System.Drawing.Point(97, 32);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(45, 19);
            this.throttleLabel.TabIndex = 39;
            this.throttleLabel.Text = "1.234";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Throttle";
            // 
            // RPM
            // 
            this.RPM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPM.Location = new System.Drawing.Point(99, 79);
            this.RPM.Name = "RPM";
            this.RPM.Size = new System.Drawing.Size(65, 19);
            this.RPM.TabIndex = 38;
            this.RPM.Text = "44";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "RPM";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 262);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accumulators";
            // 
            // statusTabs
            // 
            this.statusTabs.Controls.Add(this.OverviewTab);
            this.statusTabs.Controls.Add(this.AccumulatorsTab);
            this.statusTabs.Controls.Add(this.InvertersTab);
            this.statusTabs.Controls.Add(this.TorqueVectoringTab);
            this.statusTabs.Controls.Add(this.PowerManagementTab);
            this.statusTabs.Controls.Add(this.CoolingTab);
            this.statusTabs.Controls.Add(this.SafteyTab);
            this.statusTabs.Controls.Add(this.IOSetupTab);
            this.statusTabs.Controls.Add(this.DiagnosticsTab);
            this.statusTabs.Controls.Add(this.UpdateFirmwareTab);
            this.statusTabs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTabs.Location = new System.Drawing.Point(12, 30);
            this.statusTabs.Name = "statusTabs";
            this.statusTabs.SelectedIndex = 0;
            this.statusTabs.Size = new System.Drawing.Size(1338, 678);
            this.statusTabs.TabIndex = 13;
            // 
            // InvertersTab
            // 
            this.InvertersTab.Location = new System.Drawing.Point(4, 28);
            this.InvertersTab.Name = "InvertersTab";
            this.InvertersTab.Size = new System.Drawing.Size(1330, 646);
            this.InvertersTab.TabIndex = 2;
            this.InvertersTab.Text = "Inverters";
            this.InvertersTab.UseVisualStyleBackColor = true;
            // 
            // TorqueVectoringTab
            // 
            this.TorqueVectoringTab.Location = new System.Drawing.Point(4, 28);
            this.TorqueVectoringTab.Name = "TorqueVectoringTab";
            this.TorqueVectoringTab.Size = new System.Drawing.Size(1330, 646);
            this.TorqueVectoringTab.TabIndex = 3;
            this.TorqueVectoringTab.Text = "Torque Vectoring";
            this.TorqueVectoringTab.UseVisualStyleBackColor = true;
            // 
            // PowerManagementTab
            // 
            this.PowerManagementTab.Location = new System.Drawing.Point(4, 28);
            this.PowerManagementTab.Name = "PowerManagementTab";
            this.PowerManagementTab.Size = new System.Drawing.Size(1330, 646);
            this.PowerManagementTab.TabIndex = 4;
            this.PowerManagementTab.Text = "Power Management";
            this.PowerManagementTab.UseVisualStyleBackColor = true;
            // 
            // CoolingTab
            // 
            this.CoolingTab.Location = new System.Drawing.Point(4, 28);
            this.CoolingTab.Name = "CoolingTab";
            this.CoolingTab.Size = new System.Drawing.Size(1330, 646);
            this.CoolingTab.TabIndex = 5;
            this.CoolingTab.Text = "Cooling";
            this.CoolingTab.UseVisualStyleBackColor = true;
            // 
            // SafteyTab
            // 
            this.SafteyTab.Location = new System.Drawing.Point(4, 28);
            this.SafteyTab.Name = "SafteyTab";
            this.SafteyTab.Size = new System.Drawing.Size(1330, 646);
            this.SafteyTab.TabIndex = 6;
            this.SafteyTab.Text = "Safety";
            this.SafteyTab.UseVisualStyleBackColor = true;
            // 
            // IOSetupTab
            // 
            this.IOSetupTab.Location = new System.Drawing.Point(4, 28);
            this.IOSetupTab.Name = "IOSetupTab";
            this.IOSetupTab.Size = new System.Drawing.Size(1330, 646);
            this.IOSetupTab.TabIndex = 7;
            this.IOSetupTab.Text = "IO Setup";
            this.IOSetupTab.UseVisualStyleBackColor = true;
            // 
            // DiagnosticsTab
            // 
            this.DiagnosticsTab.Location = new System.Drawing.Point(4, 28);
            this.DiagnosticsTab.Name = "DiagnosticsTab";
            this.DiagnosticsTab.Size = new System.Drawing.Size(1330, 646);
            this.DiagnosticsTab.TabIndex = 8;
            this.DiagnosticsTab.Text = "Diagnostics";
            this.DiagnosticsTab.UseVisualStyleBackColor = true;
            // 
            // UpdateFirmwareTab
            // 
            this.UpdateFirmwareTab.Location = new System.Drawing.Point(4, 28);
            this.UpdateFirmwareTab.Name = "UpdateFirmwareTab";
            this.UpdateFirmwareTab.Size = new System.Drawing.Size(1330, 646);
            this.UpdateFirmwareTab.TabIndex = 9;
            this.UpdateFirmwareTab.Text = "Update Firmware";
            this.UpdateFirmwareTab.UseVisualStyleBackColor = true;
            // 
            // SerialConnectionStatusStrip
            // 
            this.SerialConnectionStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerialConnectionStatus,
            this.ComPortNumber,
            this.ErrorStatus});
            this.SerialConnectionStatusStrip.Location = new System.Drawing.Point(0, 705);
            this.SerialConnectionStatusStrip.Name = "SerialConnectionStatusStrip";
            this.SerialConnectionStatusStrip.Size = new System.Drawing.Size(1350, 24);
            this.SerialConnectionStatusStrip.TabIndex = 14;
            this.SerialConnectionStatusStrip.Text = "statusStrip1";
            // 
            // SerialConnectionStatus
            // 
            this.SerialConnectionStatus.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.SerialConnectionStatus.BackColor = System.Drawing.Color.IndianRed;
            this.SerialConnectionStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialConnectionStatus.Name = "SerialConnectionStatus";
            this.SerialConnectionStatus.Size = new System.Drawing.Size(113, 19);
            this.SerialConnectionStatus.Text = "DISCONNECTED";
            this.SerialConnectionStatus.Click += new System.EventHandler(this.SerialConnectionStatus_Click);
            // 
            // ComPortNumber
            // 
            this.ComPortNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortNumber.Name = "ComPortNumber";
            this.ComPortNumber.Size = new System.Drawing.Size(49, 19);
            this.ComPortNumber.Text = "COMx";
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(69, 19);
            this.ErrorStatus.Text = "No Errors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.SerialConnectionStatusStrip);
            this.Controls.Add(this.statusTabs);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "QUT Motorsports - QEV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.OverviewTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.profileGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusTabs.ResumeLayout(false);
            this.SerialConnectionStatusStrip.ResumeLayout(false);
            this.SerialConnectionStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTorqueSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTorqueSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commsMenu;
        private System.Windows.Forms.ToolStripMenuItem scanForSerialPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToTelemetryServerToolStripMenuItem;
        private System.Windows.Forms.TabPage AccumulatorsTab;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.Button loggingStopStartButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label rx_status_label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label serialLinkSpeedLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.Label vehicleProfileLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button editProfilesButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox profileStartupCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox profileCurrentCombo;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label coolantTempLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label brakeLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label Enable1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label throttleLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label RPM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl statusTabs;
        private System.Windows.Forms.TabPage InvertersTab;
        private System.Windows.Forms.TabPage TorqueVectoringTab;
        private System.Windows.Forms.TabPage PowerManagementTab;
        private System.Windows.Forms.TabPage CoolingTab;
        private System.Windows.Forms.TabPage SafteyTab;
        private System.Windows.Forms.TabPage IOSetupTab;
        private System.Windows.Forms.TabPage DiagnosticsTab;
        private System.Windows.Forms.TabPage UpdateFirmwareTab;
        private System.Windows.Forms.StatusStrip SerialConnectionStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SerialConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel ComPortNumber;
        private System.Windows.Forms.ToolStripStatusLabel ErrorStatus;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer serialTimer;
        private System.Windows.Forms.Timer getDataTimer;
    }
}

