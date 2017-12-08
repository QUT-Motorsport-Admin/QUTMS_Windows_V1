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
            this.groupBoxInverter4 = new System.Windows.Forms.GroupBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.lblInv4Temp = new System.Windows.Forms.Label();
            this.lblInv4Current = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBoxInverter3 = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.lblInv3Temp = new System.Windows.Forms.Label();
            this.lblInv3Current = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.groupBoxInverter2 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.lblInv2Temp = new System.Windows.Forms.Label();
            this.lblInv2Current = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.groupBoxGeneralStats = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.lblOverviewBrakeRearPressure = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblOverviewYawRate = new System.Windows.Forms.Label();
            this.lblOverviewLatG = new System.Windows.Forms.Label();
            this.lblOverviewLongG = new System.Windows.Forms.Label();
            this.lblOverviewSteeringAngle = new System.Windows.Forms.Label();
            this.lblOverviewBrakeFrontPressure = new System.Windows.Forms.Label();
            this.lblOverviewBrakePedal = new System.Windows.Forms.Label();
            this.lblOverviewAcceleratorPedal = new System.Windows.Forms.Label();
            this.lblOverviewSpeed = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBoxAcc2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAcc2AvTemp = new System.Windows.Forms.Label();
            this.lblAcc2MaxTemp = new System.Windows.Forms.Label();
            this.lblAcc2MinTemp = new System.Windows.Forms.Label();
            this.lblAcc2AvVolts = new System.Windows.Forms.Label();
            this.lblAcc2MaxVolts = new System.Windows.Forms.Label();
            this.lblAcc2MinVolts = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
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
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lblInv1Temp = new System.Windows.Forms.Label();
            this.lblInv1Current = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.groupBoxAcc1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.lblAcc1AvTemp = new System.Windows.Forms.Label();
            this.lblAcc1MaxTemp = new System.Windows.Forms.Label();
            this.lblAcc1MinTemp = new System.Windows.Forms.Label();
            this.lblAcc1AvVolts = new System.Windows.Forms.Label();
            this.lblAcc1MaxVolts = new System.Windows.Forms.Label();
            this.lblAcc1MinVolts = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
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
            this.guiUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview_Tab.SuspendLayout();
            this.groupBoxInverter4.SuspendLayout();
            this.groupBoxInverter3.SuspendLayout();
            this.groupBoxInverter2.SuspendLayout();
            this.groupBoxGeneralStats.SuspendLayout();
            this.groupBoxAcc2.SuspendLayout();
            this.groupBoxCAN.SuspendLayout();
            this.groupBoxSerialTimer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxInverter1.SuspendLayout();
            this.groupBoxAcc1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 732);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1265, 38);
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
            this.statusStripErrorFlag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStripErrorFlag.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusStripErrorFlag.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripErrorFlag.Name = "statusStripErrorFlag";
            this.statusStripErrorFlag.Size = new System.Drawing.Size(300, 33);
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
            this.mainScreenTabControl.Location = new System.Drawing.Point(0, 22);
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(1253, 676);
            this.mainScreenTabControl.TabIndex = 1;
            // 
            // Overview_Tab
            // 
            this.Overview_Tab.Controls.Add(this.groupBoxInverter4);
            this.Overview_Tab.Controls.Add(this.groupBoxInverter3);
            this.Overview_Tab.Controls.Add(this.groupBoxInverter2);
            this.Overview_Tab.Controls.Add(this.groupBoxGeneralStats);
            this.Overview_Tab.Controls.Add(this.groupBoxAcc2);
            this.Overview_Tab.Controls.Add(this.loggingStopStartButton);
            this.Overview_Tab.Controls.Add(this.groupBoxCAN);
            this.Overview_Tab.Controls.Add(this.groupBoxSerialTimer);
            this.Overview_Tab.Controls.Add(this.groupBox4);
            this.Overview_Tab.Controls.Add(this.groupBoxInverter1);
            this.Overview_Tab.Controls.Add(this.groupBoxAcc1);
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
            // groupBoxInverter4
            // 
            this.groupBoxInverter4.Controls.Add(this.label73);
            this.groupBoxInverter4.Controls.Add(this.label75);
            this.groupBoxInverter4.Controls.Add(this.lblInv4Temp);
            this.groupBoxInverter4.Controls.Add(this.lblInv4Current);
            this.groupBoxInverter4.Controls.Add(this.label80);
            this.groupBoxInverter4.Controls.Add(this.label81);
            this.groupBoxInverter4.Location = new System.Drawing.Point(706, 311);
            this.groupBoxInverter4.Name = "groupBoxInverter4";
            this.groupBoxInverter4.Size = new System.Drawing.Size(205, 127);
            this.groupBoxInverter4.TabIndex = 11;
            this.groupBoxInverter4.TabStop = false;
            this.groupBoxInverter4.Text = "Inverter 4";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(178, 53);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(23, 19);
            this.label73.TabIndex = 41;
            this.label73.Text = "°C";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(178, 34);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(18, 19);
            this.label75.TabIndex = 39;
            this.label75.Text = "A";
            // 
            // lblInv4Temp
            // 
            this.lblInv4Temp.AutoSize = true;
            this.lblInv4Temp.Location = new System.Drawing.Point(134, 53);
            this.lblInv4Temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv4Temp.Name = "lblInv4Temp";
            this.lblInv4Temp.Size = new System.Drawing.Size(17, 19);
            this.lblInv4Temp.TabIndex = 37;
            this.lblInv4Temp.Text = "0";
            // 
            // lblInv4Current
            // 
            this.lblInv4Current.AutoSize = true;
            this.lblInv4Current.Location = new System.Drawing.Point(134, 34);
            this.lblInv4Current.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv4Current.Name = "lblInv4Current";
            this.lblInv4Current.Size = new System.Drawing.Size(17, 19);
            this.lblInv4Current.TabIndex = 36;
            this.lblInv4Current.Text = "0";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(9, 53);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(95, 19);
            this.label80.TabIndex = 34;
            this.label80.Text = "Temperature:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(9, 34);
            this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(65, 19);
            this.label81.TabIndex = 33;
            this.label81.Text = "Current: ";
            // 
            // groupBoxInverter3
            // 
            this.groupBoxInverter3.Controls.Add(this.label64);
            this.groupBoxInverter3.Controls.Add(this.label66);
            this.groupBoxInverter3.Controls.Add(this.lblInv3Temp);
            this.groupBoxInverter3.Controls.Add(this.lblInv3Current);
            this.groupBoxInverter3.Controls.Add(this.label71);
            this.groupBoxInverter3.Controls.Add(this.label72);
            this.groupBoxInverter3.Location = new System.Drawing.Point(485, 311);
            this.groupBoxInverter3.Name = "groupBoxInverter3";
            this.groupBoxInverter3.Size = new System.Drawing.Size(206, 127);
            this.groupBoxInverter3.TabIndex = 12;
            this.groupBoxInverter3.TabStop = false;
            this.groupBoxInverter3.Text = "Inverter 3";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(172, 53);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(23, 19);
            this.label64.TabIndex = 41;
            this.label64.Text = "°C";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(172, 34);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(18, 19);
            this.label66.TabIndex = 39;
            this.label66.Text = "A";
            // 
            // lblInv3Temp
            // 
            this.lblInv3Temp.AutoSize = true;
            this.lblInv3Temp.Location = new System.Drawing.Point(128, 53);
            this.lblInv3Temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv3Temp.Name = "lblInv3Temp";
            this.lblInv3Temp.Size = new System.Drawing.Size(17, 19);
            this.lblInv3Temp.TabIndex = 37;
            this.lblInv3Temp.Text = "0";
            // 
            // lblInv3Current
            // 
            this.lblInv3Current.AutoSize = true;
            this.lblInv3Current.Location = new System.Drawing.Point(128, 34);
            this.lblInv3Current.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv3Current.Name = "lblInv3Current";
            this.lblInv3Current.Size = new System.Drawing.Size(17, 19);
            this.lblInv3Current.TabIndex = 36;
            this.lblInv3Current.Text = "0";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(3, 53);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(95, 19);
            this.label71.TabIndex = 34;
            this.label71.Text = "Temperature:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(3, 34);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(61, 19);
            this.label72.TabIndex = 33;
            this.label72.Text = "Current:";
            // 
            // groupBoxInverter2
            // 
            this.groupBoxInverter2.Controls.Add(this.label55);
            this.groupBoxInverter2.Controls.Add(this.label57);
            this.groupBoxInverter2.Controls.Add(this.lblInv2Temp);
            this.groupBoxInverter2.Controls.Add(this.lblInv2Current);
            this.groupBoxInverter2.Controls.Add(this.label62);
            this.groupBoxInverter2.Controls.Add(this.label63);
            this.groupBoxInverter2.Location = new System.Drawing.Point(485, 181);
            this.groupBoxInverter2.Name = "groupBoxInverter2";
            this.groupBoxInverter2.Size = new System.Drawing.Size(206, 119);
            this.groupBoxInverter2.TabIndex = 13;
            this.groupBoxInverter2.TabStop = false;
            this.groupBoxInverter2.Text = "Inverter 2";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(173, 44);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(23, 19);
            this.label55.TabIndex = 41;
            this.label55.Text = "°C";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(173, 25);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(18, 19);
            this.label57.TabIndex = 39;
            this.label57.Text = "A";
            // 
            // lblInv2Temp
            // 
            this.lblInv2Temp.AutoSize = true;
            this.lblInv2Temp.Location = new System.Drawing.Point(129, 44);
            this.lblInv2Temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv2Temp.Name = "lblInv2Temp";
            this.lblInv2Temp.Size = new System.Drawing.Size(17, 19);
            this.lblInv2Temp.TabIndex = 37;
            this.lblInv2Temp.Text = "0";
            // 
            // lblInv2Current
            // 
            this.lblInv2Current.AutoSize = true;
            this.lblInv2Current.Location = new System.Drawing.Point(129, 25);
            this.lblInv2Current.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv2Current.Name = "lblInv2Current";
            this.lblInv2Current.Size = new System.Drawing.Size(17, 19);
            this.lblInv2Current.TabIndex = 36;
            this.lblInv2Current.Text = "0";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(4, 44);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(95, 19);
            this.label62.TabIndex = 34;
            this.label62.Text = "Temperature:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(4, 25);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(61, 19);
            this.label63.TabIndex = 33;
            this.label63.Text = "Current:";
            // 
            // groupBoxGeneralStats
            // 
            this.groupBoxGeneralStats.Controls.Add(this.label59);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewBrakeRearPressure);
            this.groupBoxGeneralStats.Controls.Add(this.label61);
            this.groupBoxGeneralStats.Controls.Add(this.label45);
            this.groupBoxGeneralStats.Controls.Add(this.label44);
            this.groupBoxGeneralStats.Controls.Add(this.label43);
            this.groupBoxGeneralStats.Controls.Add(this.label42);
            this.groupBoxGeneralStats.Controls.Add(this.label41);
            this.groupBoxGeneralStats.Controls.Add(this.label40);
            this.groupBoxGeneralStats.Controls.Add(this.label39);
            this.groupBoxGeneralStats.Controls.Add(this.label38);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewYawRate);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewLatG);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewLongG);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewSteeringAngle);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewBrakeFrontPressure);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewBrakePedal);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewAcceleratorPedal);
            this.groupBoxGeneralStats.Controls.Add(this.lblOverviewSpeed);
            this.groupBoxGeneralStats.Controls.Add(this.label37);
            this.groupBoxGeneralStats.Controls.Add(this.label36);
            this.groupBoxGeneralStats.Controls.Add(this.label29);
            this.groupBoxGeneralStats.Controls.Add(this.label1);
            this.groupBoxGeneralStats.Controls.Add(this.label3);
            this.groupBoxGeneralStats.Controls.Add(this.label4);
            this.groupBoxGeneralStats.Controls.Add(this.label25);
            this.groupBoxGeneralStats.Controls.Add(this.label24);
            this.groupBoxGeneralStats.Location = new System.Drawing.Point(485, 6);
            this.groupBoxGeneralStats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGeneralStats.Name = "groupBoxGeneralStats";
            this.groupBoxGeneralStats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGeneralStats.Size = new System.Drawing.Size(479, 155);
            this.groupBoxGeneralStats.TabIndex = 18;
            this.groupBoxGeneralStats.TabStop = false;
            this.groupBoxGeneralStats.Text = "General Overview";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(194, 127);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(41, 19);
            this.label59.TabIndex = 26;
            this.label59.Text = "units";
            // 
            // lblOverviewBrakeRearPressure
            // 
            this.lblOverviewBrakeRearPressure.AutoSize = true;
            this.lblOverviewBrakeRearPressure.Location = new System.Drawing.Point(158, 127);
            this.lblOverviewBrakeRearPressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewBrakeRearPressure.Name = "lblOverviewBrakeRearPressure";
            this.lblOverviewBrakeRearPressure.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewBrakeRearPressure.TabIndex = 25;
            this.lblOverviewBrakeRearPressure.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(4, 127);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(143, 19);
            this.label61.TabIndex = 24;
            this.label61.Text = "Rear Brake Pressure:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(441, 100);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 19);
            this.label45.TabIndex = 23;
            this.label45.Text = "units";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(441, 72);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(19, 19);
            this.label44.TabIndex = 22;
            this.label44.Text = "G";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(441, 47);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(19, 19);
            this.label43.TabIndex = 21;
            this.label43.Text = "G";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(441, 23);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(14, 19);
            this.label42.TabIndex = 20;
            this.label42.Text = "°";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(193, 100);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 19);
            this.label41.TabIndex = 19;
            this.label41.Text = "units";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(193, 72);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(20, 19);
            this.label40.TabIndex = 18;
            this.label40.Text = "%";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(193, 47);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(20, 19);
            this.label39.TabIndex = 17;
            this.label39.Text = "%";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(193, 23);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(42, 19);
            this.label38.TabIndex = 16;
            this.label38.Text = "km/h";
            // 
            // lblOverviewYawRate
            // 
            this.lblOverviewYawRate.AutoSize = true;
            this.lblOverviewYawRate.Location = new System.Drawing.Point(411, 100);
            this.lblOverviewYawRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewYawRate.Name = "lblOverviewYawRate";
            this.lblOverviewYawRate.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewYawRate.TabIndex = 15;
            this.lblOverviewYawRate.Text = "0";
            // 
            // lblOverviewLatG
            // 
            this.lblOverviewLatG.AutoSize = true;
            this.lblOverviewLatG.Location = new System.Drawing.Point(411, 72);
            this.lblOverviewLatG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewLatG.Name = "lblOverviewLatG";
            this.lblOverviewLatG.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewLatG.TabIndex = 14;
            this.lblOverviewLatG.Text = "0";
            // 
            // lblOverviewLongG
            // 
            this.lblOverviewLongG.AutoSize = true;
            this.lblOverviewLongG.Location = new System.Drawing.Point(411, 47);
            this.lblOverviewLongG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewLongG.Name = "lblOverviewLongG";
            this.lblOverviewLongG.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewLongG.TabIndex = 13;
            this.lblOverviewLongG.Text = "0";
            // 
            // lblOverviewSteeringAngle
            // 
            this.lblOverviewSteeringAngle.AutoSize = true;
            this.lblOverviewSteeringAngle.Location = new System.Drawing.Point(411, 23);
            this.lblOverviewSteeringAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewSteeringAngle.Name = "lblOverviewSteeringAngle";
            this.lblOverviewSteeringAngle.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewSteeringAngle.TabIndex = 12;
            this.lblOverviewSteeringAngle.Text = "0";
            // 
            // lblOverviewBrakeFrontPressure
            // 
            this.lblOverviewBrakeFrontPressure.AutoSize = true;
            this.lblOverviewBrakeFrontPressure.Location = new System.Drawing.Point(157, 100);
            this.lblOverviewBrakeFrontPressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewBrakeFrontPressure.Name = "lblOverviewBrakeFrontPressure";
            this.lblOverviewBrakeFrontPressure.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewBrakeFrontPressure.TabIndex = 11;
            this.lblOverviewBrakeFrontPressure.Text = "0";
            // 
            // lblOverviewBrakePedal
            // 
            this.lblOverviewBrakePedal.AutoSize = true;
            this.lblOverviewBrakePedal.Location = new System.Drawing.Point(157, 72);
            this.lblOverviewBrakePedal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewBrakePedal.Name = "lblOverviewBrakePedal";
            this.lblOverviewBrakePedal.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewBrakePedal.TabIndex = 10;
            this.lblOverviewBrakePedal.Text = "0";
            // 
            // lblOverviewAcceleratorPedal
            // 
            this.lblOverviewAcceleratorPedal.AutoSize = true;
            this.lblOverviewAcceleratorPedal.Location = new System.Drawing.Point(157, 47);
            this.lblOverviewAcceleratorPedal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewAcceleratorPedal.Name = "lblOverviewAcceleratorPedal";
            this.lblOverviewAcceleratorPedal.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewAcceleratorPedal.TabIndex = 9;
            this.lblOverviewAcceleratorPedal.Text = "0";
            // 
            // lblOverviewSpeed
            // 
            this.lblOverviewSpeed.AutoSize = true;
            this.lblOverviewSpeed.Location = new System.Drawing.Point(157, 23);
            this.lblOverviewSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverviewSpeed.Name = "lblOverviewSpeed";
            this.lblOverviewSpeed.Size = new System.Drawing.Size(17, 19);
            this.lblOverviewSpeed.TabIndex = 8;
            this.lblOverviewSpeed.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(246, 100);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 19);
            this.label37.TabIndex = 7;
            this.label37.Text = "Yaw Rate: ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(246, 72);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(112, 19);
            this.label36.TabIndex = 6;
            this.label36.Text = "Lateral G-Force:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(246, 47);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(135, 19);
            this.label29.TabIndex = 5;
            this.label29.Text = "Longitudal G-Force:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Steering Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Front Brake Pressure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Brake Pedal:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 47);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(127, 19);
            this.label25.TabIndex = 1;
            this.label25.Text = "Accelerator Pedal:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 23);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Speed: ";
            // 
            // groupBoxAcc2
            // 
            this.groupBoxAcc2.Controls.Add(this.label14);
            this.groupBoxAcc2.Controls.Add(this.label15);
            this.groupBoxAcc2.Controls.Add(this.label19);
            this.groupBoxAcc2.Controls.Add(this.label21);
            this.groupBoxAcc2.Controls.Add(this.label22);
            this.groupBoxAcc2.Controls.Add(this.label6);
            this.groupBoxAcc2.Controls.Add(this.lblAcc2AvTemp);
            this.groupBoxAcc2.Controls.Add(this.lblAcc2MaxTemp);
            this.groupBoxAcc2.Controls.Add(this.lblAcc2MinTemp);
            this.groupBoxAcc2.Controls.Add(this.lblAcc2AvVolts);
            this.groupBoxAcc2.Controls.Add(this.lblAcc2MaxVolts);
            this.groupBoxAcc2.Controls.Add(this.lblAcc2MinVolts);
            this.groupBoxAcc2.Controls.Add(this.label30);
            this.groupBoxAcc2.Controls.Add(this.label31);
            this.groupBoxAcc2.Controls.Add(this.label32);
            this.groupBoxAcc2.Controls.Add(this.label33);
            this.groupBoxAcc2.Controls.Add(this.label34);
            this.groupBoxAcc2.Controls.Add(this.label35);
            this.groupBoxAcc2.Location = new System.Drawing.Point(241, 219);
            this.groupBoxAcc2.Name = "groupBoxAcc2";
            this.groupBoxAcc2.Size = new System.Drawing.Size(219, 219);
            this.groupBoxAcc2.TabIndex = 9;
            this.groupBoxAcc2.TabStop = false;
            this.groupBoxAcc2.Text = "Rear Accumulator";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 19);
            this.label14.TabIndex = 35;
            this.label14.Text = "°C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(183, 151);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "°C";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(183, 132);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 19);
            this.label19.TabIndex = 33;
            this.label19.Text = "°C";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(183, 49);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 19);
            this.label21.TabIndex = 32;
            this.label21.Text = "V";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(183, 68);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 19);
            this.label22.TabIndex = 31;
            this.label22.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "V";
            // 
            // lblAcc2AvTemp
            // 
            this.lblAcc2AvTemp.AutoSize = true;
            this.lblAcc2AvTemp.Location = new System.Drawing.Point(139, 170);
            this.lblAcc2AvTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc2AvTemp.Name = "lblAcc2AvTemp";
            this.lblAcc2AvTemp.Size = new System.Drawing.Size(17, 19);
            this.lblAcc2AvTemp.TabIndex = 29;
            this.lblAcc2AvTemp.Text = "0";
            // 
            // lblAcc2MaxTemp
            // 
            this.lblAcc2MaxTemp.AutoSize = true;
            this.lblAcc2MaxTemp.Location = new System.Drawing.Point(139, 151);
            this.lblAcc2MaxTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc2MaxTemp.Name = "lblAcc2MaxTemp";
            this.lblAcc2MaxTemp.Size = new System.Drawing.Size(17, 19);
            this.lblAcc2MaxTemp.TabIndex = 28;
            this.lblAcc2MaxTemp.Text = "0";
            // 
            // lblAcc2MinTemp
            // 
            this.lblAcc2MinTemp.AutoSize = true;
            this.lblAcc2MinTemp.Location = new System.Drawing.Point(139, 132);
            this.lblAcc2MinTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc2MinTemp.Name = "lblAcc2MinTemp";
            this.lblAcc2MinTemp.Size = new System.Drawing.Size(17, 19);
            this.lblAcc2MinTemp.TabIndex = 27;
            this.lblAcc2MinTemp.Text = "0";
            // 
            // lblAcc2AvVolts
            // 
            this.lblAcc2AvVolts.AutoSize = true;
            this.lblAcc2AvVolts.Location = new System.Drawing.Point(139, 68);
            this.lblAcc2AvVolts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc2AvVolts.Name = "lblAcc2AvVolts";
            this.lblAcc2AvVolts.Size = new System.Drawing.Size(17, 19);
            this.lblAcc2AvVolts.TabIndex = 26;
            this.lblAcc2AvVolts.Text = "0";
            // 
            // lblAcc2MaxVolts
            // 
            this.lblAcc2MaxVolts.AutoSize = true;
            this.lblAcc2MaxVolts.Location = new System.Drawing.Point(139, 49);
            this.lblAcc2MaxVolts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc2MaxVolts.Name = "lblAcc2MaxVolts";
            this.lblAcc2MaxVolts.Size = new System.Drawing.Size(17, 19);
            this.lblAcc2MaxVolts.TabIndex = 25;
            this.lblAcc2MaxVolts.Text = "0";
            // 
            // lblAcc2MinVolts
            // 
            this.lblAcc2MinVolts.AutoSize = true;
            this.lblAcc2MinVolts.Location = new System.Drawing.Point(139, 30);
            this.lblAcc2MinVolts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc2MinVolts.Name = "lblAcc2MinVolts";
            this.lblAcc2MinVolts.Size = new System.Drawing.Size(17, 19);
            this.lblAcc2MinVolts.TabIndex = 24;
            this.lblAcc2MinVolts.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 170);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(105, 19);
            this.label30.TabIndex = 23;
            this.label30.Text = "Average Temp:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(14, 151);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(80, 19);
            this.label31.TabIndex = 22;
            this.label31.Text = "Max Temp:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(14, 132);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(77, 19);
            this.label32.TabIndex = 21;
            this.label32.Text = "Min Temp:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(14, 68);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(119, 19);
            this.label33.TabIndex = 20;
            this.label33.Text = "Average Voltage:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(14, 49);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(94, 19);
            this.label34.TabIndex = 19;
            this.label34.Text = "Max Voltage:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(14, 30);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 19);
            this.label35.TabIndex = 18;
            this.label35.Text = "Min Voltage:";
            // 
            // loggingStopStartButton
            // 
            this.loggingStopStartButton.Location = new System.Drawing.Point(286, 168);
            this.loggingStopStartButton.Name = "loggingStopStartButton";
            this.loggingStopStartButton.Size = new System.Drawing.Size(123, 28);
            this.loggingStopStartButton.TabIndex = 17;
            this.loggingStopStartButton.Text = "Start Logging";
            this.loggingStopStartButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxCAN
            // 
            this.groupBoxCAN.Controls.Add(this.rx_status_label);
            this.groupBoxCAN.Controls.Add(this.label20);
            this.groupBoxCAN.Location = new System.Drawing.Point(286, 87);
            this.groupBoxCAN.Name = "groupBoxCAN";
            this.groupBoxCAN.Size = new System.Drawing.Size(174, 75);
            this.groupBoxCAN.TabIndex = 16;
            this.groupBoxCAN.TabStop = false;
            this.groupBoxCAN.Text = "CAN";
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
            // groupBoxSerialTimer
            // 
            this.groupBoxSerialTimer.Controls.Add(this.serialLinkSpeedLabel);
            this.groupBoxSerialTimer.Controls.Add(this.label18);
            this.groupBoxSerialTimer.Location = new System.Drawing.Point(286, 6);
            this.groupBoxSerialTimer.Name = "groupBoxSerialTimer";
            this.groupBoxSerialTimer.Size = new System.Drawing.Size(174, 75);
            this.groupBoxSerialTimer.TabIndex = 15;
            this.groupBoxSerialTimer.TabStop = false;
            this.groupBoxSerialTimer.Text = "Serial Timer";
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
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 206);
            this.groupBox4.TabIndex = 14;
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
            // groupBoxInverter1
            // 
            this.groupBoxInverter1.Controls.Add(this.label46);
            this.groupBoxInverter1.Controls.Add(this.label48);
            this.groupBoxInverter1.Controls.Add(this.lblInv1Temp);
            this.groupBoxInverter1.Controls.Add(this.lblInv1Current);
            this.groupBoxInverter1.Controls.Add(this.label53);
            this.groupBoxInverter1.Controls.Add(this.label54);
            this.groupBoxInverter1.Location = new System.Drawing.Point(706, 181);
            this.groupBoxInverter1.Name = "groupBoxInverter1";
            this.groupBoxInverter1.Size = new System.Drawing.Size(205, 119);
            this.groupBoxInverter1.TabIndex = 10;
            this.groupBoxInverter1.TabStop = false;
            this.groupBoxInverter1.Text = "Inverter 1";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(176, 44);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 19);
            this.label46.TabIndex = 41;
            this.label46.Text = "°C";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(176, 25);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(18, 19);
            this.label48.TabIndex = 39;
            this.label48.Text = "A";
            // 
            // lblInv1Temp
            // 
            this.lblInv1Temp.AutoSize = true;
            this.lblInv1Temp.Location = new System.Drawing.Point(131, 44);
            this.lblInv1Temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv1Temp.Name = "lblInv1Temp";
            this.lblInv1Temp.Size = new System.Drawing.Size(17, 19);
            this.lblInv1Temp.TabIndex = 37;
            this.lblInv1Temp.Text = "0";
            // 
            // lblInv1Current
            // 
            this.lblInv1Current.AutoSize = true;
            this.lblInv1Current.Location = new System.Drawing.Point(131, 25);
            this.lblInv1Current.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv1Current.Name = "lblInv1Current";
            this.lblInv1Current.Size = new System.Drawing.Size(17, 19);
            this.lblInv1Current.TabIndex = 36;
            this.lblInv1Current.Text = "0";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(7, 44);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(95, 19);
            this.label53.TabIndex = 34;
            this.label53.Text = "Temperature:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(7, 25);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(61, 19);
            this.label54.TabIndex = 33;
            this.label54.Text = "Current:";
            // 
            // groupBoxAcc1
            // 
            this.groupBoxAcc1.Controls.Add(this.label13);
            this.groupBoxAcc1.Controls.Add(this.label12);
            this.groupBoxAcc1.Controls.Add(this.label10);
            this.groupBoxAcc1.Controls.Add(this.label9);
            this.groupBoxAcc1.Controls.Add(this.label7);
            this.groupBoxAcc1.Controls.Add(this.label47);
            this.groupBoxAcc1.Controls.Add(this.lblAcc1AvTemp);
            this.groupBoxAcc1.Controls.Add(this.lblAcc1MaxTemp);
            this.groupBoxAcc1.Controls.Add(this.lblAcc1MinTemp);
            this.groupBoxAcc1.Controls.Add(this.lblAcc1AvVolts);
            this.groupBoxAcc1.Controls.Add(this.lblAcc1MaxVolts);
            this.groupBoxAcc1.Controls.Add(this.lblAcc1MinVolts);
            this.groupBoxAcc1.Controls.Add(this.label49);
            this.groupBoxAcc1.Controls.Add(this.label50);
            this.groupBoxAcc1.Controls.Add(this.label51);
            this.groupBoxAcc1.Controls.Add(this.label52);
            this.groupBoxAcc1.Controls.Add(this.label56);
            this.groupBoxAcc1.Controls.Add(this.label58);
            this.groupBoxAcc1.Location = new System.Drawing.Point(8, 219);
            this.groupBoxAcc1.Name = "groupBoxAcc1";
            this.groupBoxAcc1.Size = new System.Drawing.Size(209, 219);
            this.groupBoxAcc1.TabIndex = 8;
            this.groupBoxAcc1.TabStop = false;
            this.groupBoxAcc1.Text = "Front Accumulator";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 164);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "°C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(178, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "°C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "°C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "V";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(178, 24);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(18, 19);
            this.label47.TabIndex = 12;
            this.label47.Text = "V";
            // 
            // lblAcc1AvTemp
            // 
            this.lblAcc1AvTemp.AutoSize = true;
            this.lblAcc1AvTemp.Location = new System.Drawing.Point(134, 164);
            this.lblAcc1AvTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc1AvTemp.Name = "lblAcc1AvTemp";
            this.lblAcc1AvTemp.Size = new System.Drawing.Size(17, 19);
            this.lblAcc1AvTemp.TabIndex = 11;
            this.lblAcc1AvTemp.Text = "0";
            // 
            // lblAcc1MaxTemp
            // 
            this.lblAcc1MaxTemp.AutoSize = true;
            this.lblAcc1MaxTemp.Location = new System.Drawing.Point(134, 145);
            this.lblAcc1MaxTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc1MaxTemp.Name = "lblAcc1MaxTemp";
            this.lblAcc1MaxTemp.Size = new System.Drawing.Size(17, 19);
            this.lblAcc1MaxTemp.TabIndex = 10;
            this.lblAcc1MaxTemp.Text = "0";
            // 
            // lblAcc1MinTemp
            // 
            this.lblAcc1MinTemp.AutoSize = true;
            this.lblAcc1MinTemp.Location = new System.Drawing.Point(134, 126);
            this.lblAcc1MinTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc1MinTemp.Name = "lblAcc1MinTemp";
            this.lblAcc1MinTemp.Size = new System.Drawing.Size(17, 19);
            this.lblAcc1MinTemp.TabIndex = 9;
            this.lblAcc1MinTemp.Text = "0";
            // 
            // lblAcc1AvVolts
            // 
            this.lblAcc1AvVolts.AutoSize = true;
            this.lblAcc1AvVolts.Location = new System.Drawing.Point(134, 62);
            this.lblAcc1AvVolts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc1AvVolts.Name = "lblAcc1AvVolts";
            this.lblAcc1AvVolts.Size = new System.Drawing.Size(17, 19);
            this.lblAcc1AvVolts.TabIndex = 8;
            this.lblAcc1AvVolts.Text = "0";
            // 
            // lblAcc1MaxVolts
            // 
            this.lblAcc1MaxVolts.AutoSize = true;
            this.lblAcc1MaxVolts.Location = new System.Drawing.Point(134, 43);
            this.lblAcc1MaxVolts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc1MaxVolts.Name = "lblAcc1MaxVolts";
            this.lblAcc1MaxVolts.Size = new System.Drawing.Size(17, 19);
            this.lblAcc1MaxVolts.TabIndex = 7;
            this.lblAcc1MaxVolts.Text = "0";
            // 
            // lblAcc1MinVolts
            // 
            this.lblAcc1MinVolts.AutoSize = true;
            this.lblAcc1MinVolts.Location = new System.Drawing.Point(134, 24);
            this.lblAcc1MinVolts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc1MinVolts.Name = "lblAcc1MinVolts";
            this.lblAcc1MinVolts.Size = new System.Drawing.Size(17, 19);
            this.lblAcc1MinVolts.TabIndex = 6;
            this.lblAcc1MinVolts.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(9, 164);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(105, 19);
            this.label49.TabIndex = 5;
            this.label49.Text = "Average Temp:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(9, 145);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(80, 19);
            this.label50.TabIndex = 4;
            this.label50.Text = "Max Temp:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(9, 126);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(77, 19);
            this.label51.TabIndex = 3;
            this.label51.Text = "Min Temp:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(9, 62);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(119, 19);
            this.label52.TabIndex = 2;
            this.label52.Text = "Average Voltage:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(9, 43);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(94, 19);
            this.label56.TabIndex = 1;
            this.label56.Text = "Max Voltage:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(9, 24);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(91, 19);
            this.label58.TabIndex = 0;
            this.label58.Text = "Min Voltage:";
            // 
            // Accumulators_Tab
            // 
            this.Accumulators_Tab.Controls.Add(this.rearAccumulatorBricksGroupBox);
            this.Accumulators_Tab.Controls.Add(this.frontAccumulatorBricksGroupBox);
            this.Accumulators_Tab.Controls.Add(this.rearAccumulatorGroupBox);
            this.Accumulators_Tab.Controls.Add(this.frontAccumulatorGroupBox);
            this.Accumulators_Tab.Location = new System.Drawing.Point(4, 28);
            this.Accumulators_Tab.Name = "Accumulators_Tab";
            this.Accumulators_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Accumulators_Tab.Size = new System.Drawing.Size(1342, 644);
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
            this.rearAccumulatorBricksGroupBox.Location = new System.Drawing.Point(562, 323);
            this.rearAccumulatorBricksGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBricksGroupBox.Name = "rearAccumulatorBricksGroupBox";
            this.rearAccumulatorBricksGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBricksGroupBox.Size = new System.Drawing.Size(305, 312);
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
            this.rearAccumulatorBrick6.Location = new System.Drawing.Point(19, 264);
            this.rearAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick6.Name = "rearAccumulatorBrick6";
            this.rearAccumulatorBrick6.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick6.Size = new System.Drawing.Size(270, 44);
            this.rearAccumulatorBrick6.TabIndex = 4;
            this.rearAccumulatorBrick6.TabStop = false;
            this.rearAccumulatorBrick6.Text = "Rear Accumulator Brick 6";
            this.rearAccumulatorBrick6.Click += new System.EventHandler(this.rearAccumulatorBrick6_Click);
            // 
            // avgRearAccumulatorValue6
            // 
            this.avgRearAccumulatorValue6.AutoSize = true;
            this.avgRearAccumulatorValue6.Location = new System.Drawing.Point(233, 21);
            this.avgRearAccumulatorValue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue6.Name = "avgRearAccumulatorValue6";
            this.avgRearAccumulatorValue6.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue6.TabIndex = 45;
            this.avgRearAccumulatorValue6.Text = "0";
            // 
            // minRearAccumulatorBrick6
            // 
            this.minRearAccumulatorBrick6.AutoSize = true;
            this.minRearAccumulatorBrick6.Location = new System.Drawing.Point(15, 21);
            this.minRearAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorBrick6.Name = "minRearAccumulatorBrick6";
            this.minRearAccumulatorBrick6.Size = new System.Drawing.Size(38, 19);
            this.minRearAccumulatorBrick6.TabIndex = 40;
            this.minRearAccumulatorBrick6.Text = "Min:";
            // 
            // avgRearAccumulatorBrick6
            // 
            this.avgRearAccumulatorBrick6.AutoSize = true;
            this.avgRearAccumulatorBrick6.Location = new System.Drawing.Point(190, 21);
            this.avgRearAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorBrick6.Name = "avgRearAccumulatorBrick6";
            this.avgRearAccumulatorBrick6.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorBrick6.TabIndex = 44;
            this.avgRearAccumulatorBrick6.Text = "Avg:";
            // 
            // minRearAccumulatorValue6
            // 
            this.minRearAccumulatorValue6.AutoSize = true;
            this.minRearAccumulatorValue6.Location = new System.Drawing.Point(59, 21);
            this.minRearAccumulatorValue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue6.Name = "minRearAccumulatorValue6";
            this.minRearAccumulatorValue6.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue6.TabIndex = 41;
            this.minRearAccumulatorValue6.Text = "0";
            // 
            // maxRearAccumulatorValue6
            // 
            this.maxRearAccumulatorValue6.AutoSize = true;
            this.maxRearAccumulatorValue6.Location = new System.Drawing.Point(143, 21);
            this.maxRearAccumulatorValue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue6.Name = "maxRearAccumulatorValue6";
            this.maxRearAccumulatorValue6.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue6.TabIndex = 43;
            this.maxRearAccumulatorValue6.Text = "0";
            // 
            // maxRearAccumulatorBrick6
            // 
            this.maxRearAccumulatorBrick6.AutoSize = true;
            this.maxRearAccumulatorBrick6.Location = new System.Drawing.Point(99, 21);
            this.maxRearAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorBrick6.Name = "maxRearAccumulatorBrick6";
            this.maxRearAccumulatorBrick6.Size = new System.Drawing.Size(41, 19);
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
            this.rearAccumulatorBrick5.Location = new System.Drawing.Point(19, 216);
            this.rearAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick5.Name = "rearAccumulatorBrick5";
            this.rearAccumulatorBrick5.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick5.Size = new System.Drawing.Size(270, 44);
            this.rearAccumulatorBrick5.TabIndex = 3;
            this.rearAccumulatorBrick5.TabStop = false;
            this.rearAccumulatorBrick5.Text = "Rear Accumulator Brick 5";
            this.rearAccumulatorBrick5.Click += new System.EventHandler(this.rearAccumulatorBrick5_Click);
            // 
            // avgRearAccumulatorValue5
            // 
            this.avgRearAccumulatorValue5.AutoSize = true;
            this.avgRearAccumulatorValue5.Location = new System.Drawing.Point(233, 21);
            this.avgRearAccumulatorValue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue5.Name = "avgRearAccumulatorValue5";
            this.avgRearAccumulatorValue5.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue5.TabIndex = 39;
            this.avgRearAccumulatorValue5.Text = "0";
            // 
            // minRearAccumulatorBrick5
            // 
            this.minRearAccumulatorBrick5.AutoSize = true;
            this.minRearAccumulatorBrick5.Location = new System.Drawing.Point(15, 21);
            this.minRearAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorBrick5.Name = "minRearAccumulatorBrick5";
            this.minRearAccumulatorBrick5.Size = new System.Drawing.Size(38, 19);
            this.minRearAccumulatorBrick5.TabIndex = 34;
            this.minRearAccumulatorBrick5.Text = "Min:";
            // 
            // avgRearAccumulatorBrick5
            // 
            this.avgRearAccumulatorBrick5.AutoSize = true;
            this.avgRearAccumulatorBrick5.Location = new System.Drawing.Point(190, 21);
            this.avgRearAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorBrick5.Name = "avgRearAccumulatorBrick5";
            this.avgRearAccumulatorBrick5.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorBrick5.TabIndex = 38;
            this.avgRearAccumulatorBrick5.Text = "Avg:";
            // 
            // minRearAccumulatorValue5
            // 
            this.minRearAccumulatorValue5.AutoSize = true;
            this.minRearAccumulatorValue5.Location = new System.Drawing.Point(59, 21);
            this.minRearAccumulatorValue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue5.Name = "minRearAccumulatorValue5";
            this.minRearAccumulatorValue5.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue5.TabIndex = 35;
            this.minRearAccumulatorValue5.Text = "0";
            // 
            // maxRearAccumulatorValue5
            // 
            this.maxRearAccumulatorValue5.AutoSize = true;
            this.maxRearAccumulatorValue5.Location = new System.Drawing.Point(143, 21);
            this.maxRearAccumulatorValue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue5.Name = "maxRearAccumulatorValue5";
            this.maxRearAccumulatorValue5.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue5.TabIndex = 37;
            this.maxRearAccumulatorValue5.Text = "0";
            // 
            // maxRearAccumulatorBrick5
            // 
            this.maxRearAccumulatorBrick5.AutoSize = true;
            this.maxRearAccumulatorBrick5.Location = new System.Drawing.Point(99, 21);
            this.maxRearAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorBrick5.Name = "maxRearAccumulatorBrick5";
            this.maxRearAccumulatorBrick5.Size = new System.Drawing.Size(41, 19);
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
            this.rearAccumulatorBrick4.Location = new System.Drawing.Point(19, 168);
            this.rearAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick4.Name = "rearAccumulatorBrick4";
            this.rearAccumulatorBrick4.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick4.Size = new System.Drawing.Size(270, 44);
            this.rearAccumulatorBrick4.TabIndex = 1;
            this.rearAccumulatorBrick4.TabStop = false;
            this.rearAccumulatorBrick4.Text = "Rear Accumulator Brick 4";
            this.rearAccumulatorBrick4.Click += new System.EventHandler(this.rearAccumulatorBrick4_Click);
            // 
            // avgRearAccumulatorValue4
            // 
            this.avgRearAccumulatorValue4.AutoSize = true;
            this.avgRearAccumulatorValue4.Location = new System.Drawing.Point(233, 21);
            this.avgRearAccumulatorValue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue4.Name = "avgRearAccumulatorValue4";
            this.avgRearAccumulatorValue4.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue4.TabIndex = 33;
            this.avgRearAccumulatorValue4.Text = "0";
            // 
            // minRearAccumulatorBrick4
            // 
            this.minRearAccumulatorBrick4.AutoSize = true;
            this.minRearAccumulatorBrick4.Location = new System.Drawing.Point(15, 21);
            this.minRearAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorBrick4.Name = "minRearAccumulatorBrick4";
            this.minRearAccumulatorBrick4.Size = new System.Drawing.Size(38, 19);
            this.minRearAccumulatorBrick4.TabIndex = 28;
            this.minRearAccumulatorBrick4.Text = "Min:";
            // 
            // avgRearAccumulatorBrick4
            // 
            this.avgRearAccumulatorBrick4.AutoSize = true;
            this.avgRearAccumulatorBrick4.Location = new System.Drawing.Point(190, 21);
            this.avgRearAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorBrick4.Name = "avgRearAccumulatorBrick4";
            this.avgRearAccumulatorBrick4.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorBrick4.TabIndex = 32;
            this.avgRearAccumulatorBrick4.Text = "Avg:";
            // 
            // minRearAccumulatorValue4
            // 
            this.minRearAccumulatorValue4.AutoSize = true;
            this.minRearAccumulatorValue4.Location = new System.Drawing.Point(59, 21);
            this.minRearAccumulatorValue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue4.Name = "minRearAccumulatorValue4";
            this.minRearAccumulatorValue4.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue4.TabIndex = 29;
            this.minRearAccumulatorValue4.Text = "0";
            // 
            // maxRearAccumulatorValue4
            // 
            this.maxRearAccumulatorValue4.AutoSize = true;
            this.maxRearAccumulatorValue4.Location = new System.Drawing.Point(143, 21);
            this.maxRearAccumulatorValue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue4.Name = "maxRearAccumulatorValue4";
            this.maxRearAccumulatorValue4.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue4.TabIndex = 31;
            this.maxRearAccumulatorValue4.Text = "0";
            // 
            // maxRearAccumulatorBrick4
            // 
            this.maxRearAccumulatorBrick4.AutoSize = true;
            this.maxRearAccumulatorBrick4.Location = new System.Drawing.Point(99, 21);
            this.maxRearAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorBrick4.Name = "maxRearAccumulatorBrick4";
            this.maxRearAccumulatorBrick4.Size = new System.Drawing.Size(41, 19);
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
            this.rearAccumulatorBrick3.Location = new System.Drawing.Point(19, 120);
            this.rearAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick3.Name = "rearAccumulatorBrick3";
            this.rearAccumulatorBrick3.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick3.Size = new System.Drawing.Size(270, 44);
            this.rearAccumulatorBrick3.TabIndex = 2;
            this.rearAccumulatorBrick3.TabStop = false;
            this.rearAccumulatorBrick3.Text = "Rear Accumulator Brick 3";
            this.rearAccumulatorBrick3.Click += new System.EventHandler(this.rearAccumulatorBrick3_Click);
            // 
            // avgRearAccumulatorValue3
            // 
            this.avgRearAccumulatorValue3.AutoSize = true;
            this.avgRearAccumulatorValue3.Location = new System.Drawing.Point(233, 23);
            this.avgRearAccumulatorValue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue3.Name = "avgRearAccumulatorValue3";
            this.avgRearAccumulatorValue3.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue3.TabIndex = 27;
            this.avgRearAccumulatorValue3.Text = "0";
            // 
            // minRearAccumulatorBrick3
            // 
            this.minRearAccumulatorBrick3.AutoSize = true;
            this.minRearAccumulatorBrick3.Location = new System.Drawing.Point(15, 23);
            this.minRearAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorBrick3.Name = "minRearAccumulatorBrick3";
            this.minRearAccumulatorBrick3.Size = new System.Drawing.Size(38, 19);
            this.minRearAccumulatorBrick3.TabIndex = 22;
            this.minRearAccumulatorBrick3.Text = "Min:";
            // 
            // avgRearAccumulatorBrick3
            // 
            this.avgRearAccumulatorBrick3.AutoSize = true;
            this.avgRearAccumulatorBrick3.Location = new System.Drawing.Point(190, 23);
            this.avgRearAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorBrick3.Name = "avgRearAccumulatorBrick3";
            this.avgRearAccumulatorBrick3.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorBrick3.TabIndex = 26;
            this.avgRearAccumulatorBrick3.Text = "Avg:";
            // 
            // minRearAccumulatorValue3
            // 
            this.minRearAccumulatorValue3.AutoSize = true;
            this.minRearAccumulatorValue3.Location = new System.Drawing.Point(59, 23);
            this.minRearAccumulatorValue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue3.Name = "minRearAccumulatorValue3";
            this.minRearAccumulatorValue3.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue3.TabIndex = 23;
            this.minRearAccumulatorValue3.Text = "0";
            // 
            // maxRearAccumulatorValue3
            // 
            this.maxRearAccumulatorValue3.AutoSize = true;
            this.maxRearAccumulatorValue3.Location = new System.Drawing.Point(143, 23);
            this.maxRearAccumulatorValue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue3.Name = "maxRearAccumulatorValue3";
            this.maxRearAccumulatorValue3.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue3.TabIndex = 25;
            this.maxRearAccumulatorValue3.Text = "0";
            // 
            // maxRearAccumulatorBrick3
            // 
            this.maxRearAccumulatorBrick3.AutoSize = true;
            this.maxRearAccumulatorBrick3.Location = new System.Drawing.Point(99, 23);
            this.maxRearAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorBrick3.Name = "maxRearAccumulatorBrick3";
            this.maxRearAccumulatorBrick3.Size = new System.Drawing.Size(41, 19);
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
            this.rearAccumulatorBrick2.Location = new System.Drawing.Point(19, 71);
            this.rearAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick2.Name = "rearAccumulatorBrick2";
            this.rearAccumulatorBrick2.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick2.Size = new System.Drawing.Size(270, 44);
            this.rearAccumulatorBrick2.TabIndex = 1;
            this.rearAccumulatorBrick2.TabStop = false;
            this.rearAccumulatorBrick2.Text = "Rear Accumulator Brick 2";
            this.rearAccumulatorBrick2.Click += new System.EventHandler(this.rearAccumulatorBrick2_Click);
            // 
            // avgRearAccumulatorValue2
            // 
            this.avgRearAccumulatorValue2.AutoSize = true;
            this.avgRearAccumulatorValue2.Location = new System.Drawing.Point(233, 21);
            this.avgRearAccumulatorValue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue2.Name = "avgRearAccumulatorValue2";
            this.avgRearAccumulatorValue2.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue2.TabIndex = 21;
            this.avgRearAccumulatorValue2.Text = "0";
            // 
            // minRearAccumulatorBrick2
            // 
            this.minRearAccumulatorBrick2.AutoSize = true;
            this.minRearAccumulatorBrick2.Location = new System.Drawing.Point(15, 21);
            this.minRearAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorBrick2.Name = "minRearAccumulatorBrick2";
            this.minRearAccumulatorBrick2.Size = new System.Drawing.Size(38, 19);
            this.minRearAccumulatorBrick2.TabIndex = 16;
            this.minRearAccumulatorBrick2.Text = "Min:";
            // 
            // avgRearAccumulatorBrick2
            // 
            this.avgRearAccumulatorBrick2.AutoSize = true;
            this.avgRearAccumulatorBrick2.Location = new System.Drawing.Point(190, 21);
            this.avgRearAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorBrick2.Name = "avgRearAccumulatorBrick2";
            this.avgRearAccumulatorBrick2.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorBrick2.TabIndex = 20;
            this.avgRearAccumulatorBrick2.Text = "Avg:";
            // 
            // minRearAccumulatorValue2
            // 
            this.minRearAccumulatorValue2.AutoSize = true;
            this.minRearAccumulatorValue2.Location = new System.Drawing.Point(59, 21);
            this.minRearAccumulatorValue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue2.Name = "minRearAccumulatorValue2";
            this.minRearAccumulatorValue2.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue2.TabIndex = 17;
            this.minRearAccumulatorValue2.Text = "0";
            // 
            // maxRearAccumulatorValue2
            // 
            this.maxRearAccumulatorValue2.AutoSize = true;
            this.maxRearAccumulatorValue2.Location = new System.Drawing.Point(143, 21);
            this.maxRearAccumulatorValue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue2.Name = "maxRearAccumulatorValue2";
            this.maxRearAccumulatorValue2.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue2.TabIndex = 19;
            this.maxRearAccumulatorValue2.Text = "0";
            // 
            // maxRearAccumulatorBrick2
            // 
            this.maxRearAccumulatorBrick2.AutoSize = true;
            this.maxRearAccumulatorBrick2.Location = new System.Drawing.Point(99, 21);
            this.maxRearAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorBrick2.Name = "maxRearAccumulatorBrick2";
            this.maxRearAccumulatorBrick2.Size = new System.Drawing.Size(41, 19);
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
            this.rearAccumulatorBrick1.Location = new System.Drawing.Point(19, 23);
            this.rearAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick1.Name = "rearAccumulatorBrick1";
            this.rearAccumulatorBrick1.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorBrick1.Size = new System.Drawing.Size(270, 44);
            this.rearAccumulatorBrick1.TabIndex = 0;
            this.rearAccumulatorBrick1.TabStop = false;
            this.rearAccumulatorBrick1.Text = "Rear Accumulator Brick 1";
            this.rearAccumulatorBrick1.Click += new System.EventHandler(this.rearAccumulatorBrick1_Click);
            // 
            // avgRearAccumulatorValue1
            // 
            this.avgRearAccumulatorValue1.AutoSize = true;
            this.avgRearAccumulatorValue1.Location = new System.Drawing.Point(233, 21);
            this.avgRearAccumulatorValue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue1.Name = "avgRearAccumulatorValue1";
            this.avgRearAccumulatorValue1.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue1.TabIndex = 15;
            this.avgRearAccumulatorValue1.Text = "0";
            // 
            // avgRearAccumulatorBrick1
            // 
            this.avgRearAccumulatorBrick1.AutoSize = true;
            this.avgRearAccumulatorBrick1.Location = new System.Drawing.Point(190, 21);
            this.avgRearAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorBrick1.Name = "avgRearAccumulatorBrick1";
            this.avgRearAccumulatorBrick1.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorBrick1.TabIndex = 14;
            this.avgRearAccumulatorBrick1.Text = "Avg:";
            // 
            // maxRearAccumulatorValue1
            // 
            this.maxRearAccumulatorValue1.AutoSize = true;
            this.maxRearAccumulatorValue1.Location = new System.Drawing.Point(143, 21);
            this.maxRearAccumulatorValue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue1.Name = "maxRearAccumulatorValue1";
            this.maxRearAccumulatorValue1.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue1.TabIndex = 13;
            this.maxRearAccumulatorValue1.Text = "0";
            // 
            // maxRearAccumulatorBrick1
            // 
            this.maxRearAccumulatorBrick1.AutoSize = true;
            this.maxRearAccumulatorBrick1.Location = new System.Drawing.Point(99, 21);
            this.maxRearAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorBrick1.Name = "maxRearAccumulatorBrick1";
            this.maxRearAccumulatorBrick1.Size = new System.Drawing.Size(41, 19);
            this.maxRearAccumulatorBrick1.TabIndex = 12;
            this.maxRearAccumulatorBrick1.Text = "Max:";
            // 
            // minRearAccumulatorValue1
            // 
            this.minRearAccumulatorValue1.AutoSize = true;
            this.minRearAccumulatorValue1.Location = new System.Drawing.Point(59, 21);
            this.minRearAccumulatorValue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue1.Name = "minRearAccumulatorValue1";
            this.minRearAccumulatorValue1.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue1.TabIndex = 11;
            this.minRearAccumulatorValue1.Text = "0";
            // 
            // minRearAccumulatorBrick1
            // 
            this.minRearAccumulatorBrick1.AutoSize = true;
            this.minRearAccumulatorBrick1.Location = new System.Drawing.Point(15, 21);
            this.minRearAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorBrick1.Name = "minRearAccumulatorBrick1";
            this.minRearAccumulatorBrick1.Size = new System.Drawing.Size(38, 19);
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
            this.frontAccumulatorBricksGroupBox.Location = new System.Drawing.Point(562, 5);
            this.frontAccumulatorBricksGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBricksGroupBox.Name = "frontAccumulatorBricksGroupBox";
            this.frontAccumulatorBricksGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBricksGroupBox.Size = new System.Drawing.Size(305, 314);
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
            this.frontAccumulatorBrick6.Location = new System.Drawing.Point(19, 264);
            this.frontAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick6.Name = "frontAccumulatorBrick6";
            this.frontAccumulatorBrick6.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick6.Size = new System.Drawing.Size(270, 44);
            this.frontAccumulatorBrick6.TabIndex = 4;
            this.frontAccumulatorBrick6.TabStop = false;
            this.frontAccumulatorBrick6.Text = "Front Accumulator Brick 6";
            this.frontAccumulatorBrick6.Click += new System.EventHandler(this.frontAccumulatorBrick6_Click);
            // 
            // avgFrontAccumulatorValue6
            // 
            this.avgFrontAccumulatorValue6.AutoSize = true;
            this.avgFrontAccumulatorValue6.Location = new System.Drawing.Point(233, 21);
            this.avgFrontAccumulatorValue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorValue6.Name = "avgFrontAccumulatorValue6";
            this.avgFrontAccumulatorValue6.Size = new System.Drawing.Size(17, 19);
            this.avgFrontAccumulatorValue6.TabIndex = 39;
            this.avgFrontAccumulatorValue6.Text = "0";
            // 
            // minFrontAccumulatorBrick6
            // 
            this.minFrontAccumulatorBrick6.AutoSize = true;
            this.minFrontAccumulatorBrick6.Location = new System.Drawing.Point(15, 21);
            this.minFrontAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorBrick6.Name = "minFrontAccumulatorBrick6";
            this.minFrontAccumulatorBrick6.Size = new System.Drawing.Size(38, 19);
            this.minFrontAccumulatorBrick6.TabIndex = 34;
            this.minFrontAccumulatorBrick6.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick6
            // 
            this.avgFrontAccumulatorBrick6.AutoSize = true;
            this.avgFrontAccumulatorBrick6.Location = new System.Drawing.Point(190, 21);
            this.avgFrontAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorBrick6.Name = "avgFrontAccumulatorBrick6";
            this.avgFrontAccumulatorBrick6.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorBrick6.TabIndex = 38;
            this.avgFrontAccumulatorBrick6.Text = "Avg:";
            // 
            // minFrontAccumulatorValue6
            // 
            this.minFrontAccumulatorValue6.AutoSize = true;
            this.minFrontAccumulatorValue6.Location = new System.Drawing.Point(59, 21);
            this.minFrontAccumulatorValue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue6.Name = "minFrontAccumulatorValue6";
            this.minFrontAccumulatorValue6.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue6.TabIndex = 35;
            this.minFrontAccumulatorValue6.Text = "0";
            // 
            // maxFrontAccumulatorValue6
            // 
            this.maxFrontAccumulatorValue6.AutoSize = true;
            this.maxFrontAccumulatorValue6.Location = new System.Drawing.Point(143, 21);
            this.maxFrontAccumulatorValue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorValue6.Name = "maxFrontAccumulatorValue6";
            this.maxFrontAccumulatorValue6.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorValue6.TabIndex = 37;
            this.maxFrontAccumulatorValue6.Text = "0";
            // 
            // maxFrontAccumulatorBrick6
            // 
            this.maxFrontAccumulatorBrick6.AutoSize = true;
            this.maxFrontAccumulatorBrick6.Location = new System.Drawing.Point(99, 21);
            this.maxFrontAccumulatorBrick6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorBrick6.Name = "maxFrontAccumulatorBrick6";
            this.maxFrontAccumulatorBrick6.Size = new System.Drawing.Size(41, 19);
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
            this.frontAccumulatorBrick5.Location = new System.Drawing.Point(19, 216);
            this.frontAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick5.Name = "frontAccumulatorBrick5";
            this.frontAccumulatorBrick5.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick5.Size = new System.Drawing.Size(270, 44);
            this.frontAccumulatorBrick5.TabIndex = 3;
            this.frontAccumulatorBrick5.TabStop = false;
            this.frontAccumulatorBrick5.Text = "Front Accumulator Brick 5";
            this.frontAccumulatorBrick5.Click += new System.EventHandler(this.frontAccumulatorBrick5_Click);
            // 
            // avgFrontAccumulatorValue5
            // 
            this.avgFrontAccumulatorValue5.AutoSize = true;
            this.avgFrontAccumulatorValue5.Location = new System.Drawing.Point(233, 21);
            this.avgFrontAccumulatorValue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorValue5.Name = "avgFrontAccumulatorValue5";
            this.avgFrontAccumulatorValue5.Size = new System.Drawing.Size(17, 19);
            this.avgFrontAccumulatorValue5.TabIndex = 33;
            this.avgFrontAccumulatorValue5.Text = "0";
            // 
            // minFrontAccumulatorBrick5
            // 
            this.minFrontAccumulatorBrick5.AutoSize = true;
            this.minFrontAccumulatorBrick5.Location = new System.Drawing.Point(15, 21);
            this.minFrontAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorBrick5.Name = "minFrontAccumulatorBrick5";
            this.minFrontAccumulatorBrick5.Size = new System.Drawing.Size(38, 19);
            this.minFrontAccumulatorBrick5.TabIndex = 28;
            this.minFrontAccumulatorBrick5.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick5
            // 
            this.avgFrontAccumulatorBrick5.AutoSize = true;
            this.avgFrontAccumulatorBrick5.Location = new System.Drawing.Point(190, 21);
            this.avgFrontAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorBrick5.Name = "avgFrontAccumulatorBrick5";
            this.avgFrontAccumulatorBrick5.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorBrick5.TabIndex = 32;
            this.avgFrontAccumulatorBrick5.Text = "Avg:";
            // 
            // minFrontAccumulatorValue5
            // 
            this.minFrontAccumulatorValue5.AutoSize = true;
            this.minFrontAccumulatorValue5.Location = new System.Drawing.Point(59, 21);
            this.minFrontAccumulatorValue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue5.Name = "minFrontAccumulatorValue5";
            this.minFrontAccumulatorValue5.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue5.TabIndex = 29;
            this.minFrontAccumulatorValue5.Text = "0";
            // 
            // maxFrontAccumulatorValue5
            // 
            this.maxFrontAccumulatorValue5.AutoSize = true;
            this.maxFrontAccumulatorValue5.Location = new System.Drawing.Point(143, 21);
            this.maxFrontAccumulatorValue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorValue5.Name = "maxFrontAccumulatorValue5";
            this.maxFrontAccumulatorValue5.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorValue5.TabIndex = 31;
            this.maxFrontAccumulatorValue5.Text = "0";
            // 
            // maxFrontAccumulatorBrick5
            // 
            this.maxFrontAccumulatorBrick5.AutoSize = true;
            this.maxFrontAccumulatorBrick5.Location = new System.Drawing.Point(99, 21);
            this.maxFrontAccumulatorBrick5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorBrick5.Name = "maxFrontAccumulatorBrick5";
            this.maxFrontAccumulatorBrick5.Size = new System.Drawing.Size(41, 19);
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
            this.frontAccumulatorBrick4.Location = new System.Drawing.Point(19, 168);
            this.frontAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick4.Name = "frontAccumulatorBrick4";
            this.frontAccumulatorBrick4.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick4.Size = new System.Drawing.Size(270, 44);
            this.frontAccumulatorBrick4.TabIndex = 1;
            this.frontAccumulatorBrick4.TabStop = false;
            this.frontAccumulatorBrick4.Text = "Front Accumulator Brick 4";
            this.frontAccumulatorBrick4.Click += new System.EventHandler(this.frontAccumulatorBrick4_Click);
            // 
            // avgFrontAccumulatorValue4
            // 
            this.avgFrontAccumulatorValue4.AutoSize = true;
            this.avgFrontAccumulatorValue4.Location = new System.Drawing.Point(233, 21);
            this.avgFrontAccumulatorValue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorValue4.Name = "avgFrontAccumulatorValue4";
            this.avgFrontAccumulatorValue4.Size = new System.Drawing.Size(17, 19);
            this.avgFrontAccumulatorValue4.TabIndex = 27;
            this.avgFrontAccumulatorValue4.Text = "0";
            // 
            // minFrontAccumulatorBrick4
            // 
            this.minFrontAccumulatorBrick4.AutoSize = true;
            this.minFrontAccumulatorBrick4.Location = new System.Drawing.Point(15, 21);
            this.minFrontAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorBrick4.Name = "minFrontAccumulatorBrick4";
            this.minFrontAccumulatorBrick4.Size = new System.Drawing.Size(38, 19);
            this.minFrontAccumulatorBrick4.TabIndex = 22;
            this.minFrontAccumulatorBrick4.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick4
            // 
            this.avgFrontAccumulatorBrick4.AutoSize = true;
            this.avgFrontAccumulatorBrick4.Location = new System.Drawing.Point(190, 21);
            this.avgFrontAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorBrick4.Name = "avgFrontAccumulatorBrick4";
            this.avgFrontAccumulatorBrick4.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorBrick4.TabIndex = 26;
            this.avgFrontAccumulatorBrick4.Text = "Avg:";
            // 
            // minFrontAccumulatorValue4
            // 
            this.minFrontAccumulatorValue4.AutoSize = true;
            this.minFrontAccumulatorValue4.Location = new System.Drawing.Point(59, 21);
            this.minFrontAccumulatorValue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue4.Name = "minFrontAccumulatorValue4";
            this.minFrontAccumulatorValue4.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue4.TabIndex = 23;
            this.minFrontAccumulatorValue4.Text = "0";
            // 
            // maxFrontAccumulatorValue4
            // 
            this.maxFrontAccumulatorValue4.AutoSize = true;
            this.maxFrontAccumulatorValue4.Location = new System.Drawing.Point(143, 21);
            this.maxFrontAccumulatorValue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorValue4.Name = "maxFrontAccumulatorValue4";
            this.maxFrontAccumulatorValue4.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorValue4.TabIndex = 25;
            this.maxFrontAccumulatorValue4.Text = "0";
            // 
            // maxFrontAccumulatorBrick4
            // 
            this.maxFrontAccumulatorBrick4.AutoSize = true;
            this.maxFrontAccumulatorBrick4.Location = new System.Drawing.Point(99, 21);
            this.maxFrontAccumulatorBrick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorBrick4.Name = "maxFrontAccumulatorBrick4";
            this.maxFrontAccumulatorBrick4.Size = new System.Drawing.Size(41, 19);
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
            this.frontAccumulatorBrick3.Location = new System.Drawing.Point(19, 120);
            this.frontAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick3.Name = "frontAccumulatorBrick3";
            this.frontAccumulatorBrick3.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick3.Size = new System.Drawing.Size(270, 44);
            this.frontAccumulatorBrick3.TabIndex = 2;
            this.frontAccumulatorBrick3.TabStop = false;
            this.frontAccumulatorBrick3.Text = "Front Accumulator Brick 3";
            this.frontAccumulatorBrick3.Click += new System.EventHandler(this.frontAccumulatorBrick3_Click);
            // 
            // avgFrontAccumulatorValue3
            // 
            this.avgFrontAccumulatorValue3.AutoSize = true;
            this.avgFrontAccumulatorValue3.Location = new System.Drawing.Point(233, 21);
            this.avgFrontAccumulatorValue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorValue3.Name = "avgFrontAccumulatorValue3";
            this.avgFrontAccumulatorValue3.Size = new System.Drawing.Size(17, 19);
            this.avgFrontAccumulatorValue3.TabIndex = 21;
            this.avgFrontAccumulatorValue3.Text = "0";
            // 
            // minFrontAccumulatorBrick3
            // 
            this.minFrontAccumulatorBrick3.AutoSize = true;
            this.minFrontAccumulatorBrick3.Location = new System.Drawing.Point(15, 21);
            this.minFrontAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorBrick3.Name = "minFrontAccumulatorBrick3";
            this.minFrontAccumulatorBrick3.Size = new System.Drawing.Size(38, 19);
            this.minFrontAccumulatorBrick3.TabIndex = 16;
            this.minFrontAccumulatorBrick3.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick3
            // 
            this.avgFrontAccumulatorBrick3.AutoSize = true;
            this.avgFrontAccumulatorBrick3.Location = new System.Drawing.Point(190, 21);
            this.avgFrontAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorBrick3.Name = "avgFrontAccumulatorBrick3";
            this.avgFrontAccumulatorBrick3.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorBrick3.TabIndex = 20;
            this.avgFrontAccumulatorBrick3.Text = "Avg:";
            // 
            // minFrontAccumulatorValue3
            // 
            this.minFrontAccumulatorValue3.AutoSize = true;
            this.minFrontAccumulatorValue3.Location = new System.Drawing.Point(59, 21);
            this.minFrontAccumulatorValue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue3.Name = "minFrontAccumulatorValue3";
            this.minFrontAccumulatorValue3.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue3.TabIndex = 17;
            this.minFrontAccumulatorValue3.Text = "0";
            // 
            // maxFrontAccumulatorValue3
            // 
            this.maxFrontAccumulatorValue3.AutoSize = true;
            this.maxFrontAccumulatorValue3.Location = new System.Drawing.Point(143, 21);
            this.maxFrontAccumulatorValue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorValue3.Name = "maxFrontAccumulatorValue3";
            this.maxFrontAccumulatorValue3.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorValue3.TabIndex = 19;
            this.maxFrontAccumulatorValue3.Text = "0";
            // 
            // maxFrontAccumulatorBrick3
            // 
            this.maxFrontAccumulatorBrick3.AutoSize = true;
            this.maxFrontAccumulatorBrick3.Location = new System.Drawing.Point(99, 21);
            this.maxFrontAccumulatorBrick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorBrick3.Name = "maxFrontAccumulatorBrick3";
            this.maxFrontAccumulatorBrick3.Size = new System.Drawing.Size(41, 19);
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
            this.frontAccumulatorBrick2.Location = new System.Drawing.Point(19, 71);
            this.frontAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick2.Name = "frontAccumulatorBrick2";
            this.frontAccumulatorBrick2.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick2.Size = new System.Drawing.Size(270, 44);
            this.frontAccumulatorBrick2.TabIndex = 1;
            this.frontAccumulatorBrick2.TabStop = false;
            this.frontAccumulatorBrick2.Text = "Front Accumulator Brick 2";
            this.frontAccumulatorBrick2.Click += new System.EventHandler(this.frontAccumulatorBrick2_Click);
            // 
            // avgFrontAccumulatorValue2
            // 
            this.avgFrontAccumulatorValue2.AutoSize = true;
            this.avgFrontAccumulatorValue2.Location = new System.Drawing.Point(233, 21);
            this.avgFrontAccumulatorValue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorValue2.Name = "avgFrontAccumulatorValue2";
            this.avgFrontAccumulatorValue2.Size = new System.Drawing.Size(17, 19);
            this.avgFrontAccumulatorValue2.TabIndex = 15;
            this.avgFrontAccumulatorValue2.Text = "0";
            // 
            // avgFrontAccumulatorBrick2
            // 
            this.avgFrontAccumulatorBrick2.AutoSize = true;
            this.avgFrontAccumulatorBrick2.Location = new System.Drawing.Point(190, 21);
            this.avgFrontAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorBrick2.Name = "avgFrontAccumulatorBrick2";
            this.avgFrontAccumulatorBrick2.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorBrick2.TabIndex = 14;
            this.avgFrontAccumulatorBrick2.Text = "Avg:";
            // 
            // maxFrontAccumulatorValue2
            // 
            this.maxFrontAccumulatorValue2.AutoSize = true;
            this.maxFrontAccumulatorValue2.Location = new System.Drawing.Point(143, 21);
            this.maxFrontAccumulatorValue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorValue2.Name = "maxFrontAccumulatorValue2";
            this.maxFrontAccumulatorValue2.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorValue2.TabIndex = 13;
            this.maxFrontAccumulatorValue2.Text = "0";
            // 
            // maxFrontAccumulatorBrick2
            // 
            this.maxFrontAccumulatorBrick2.AutoSize = true;
            this.maxFrontAccumulatorBrick2.Location = new System.Drawing.Point(99, 21);
            this.maxFrontAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorBrick2.Name = "maxFrontAccumulatorBrick2";
            this.maxFrontAccumulatorBrick2.Size = new System.Drawing.Size(41, 19);
            this.maxFrontAccumulatorBrick2.TabIndex = 12;
            this.maxFrontAccumulatorBrick2.Text = "Max:";
            // 
            // minFrontAccumulatorValue2
            // 
            this.minFrontAccumulatorValue2.AutoSize = true;
            this.minFrontAccumulatorValue2.Location = new System.Drawing.Point(59, 21);
            this.minFrontAccumulatorValue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue2.Name = "minFrontAccumulatorValue2";
            this.minFrontAccumulatorValue2.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue2.TabIndex = 11;
            this.minFrontAccumulatorValue2.Text = "0";
            // 
            // minFrontAccumulatorBrick2
            // 
            this.minFrontAccumulatorBrick2.AutoSize = true;
            this.minFrontAccumulatorBrick2.Location = new System.Drawing.Point(15, 21);
            this.minFrontAccumulatorBrick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorBrick2.Name = "minFrontAccumulatorBrick2";
            this.minFrontAccumulatorBrick2.Size = new System.Drawing.Size(38, 19);
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
            this.frontAccumulatorBrick1.Location = new System.Drawing.Point(19, 23);
            this.frontAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick1.Name = "frontAccumulatorBrick1";
            this.frontAccumulatorBrick1.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorBrick1.Size = new System.Drawing.Size(270, 44);
            this.frontAccumulatorBrick1.TabIndex = 0;
            this.frontAccumulatorBrick1.TabStop = false;
            this.frontAccumulatorBrick1.Text = "Front Accumulator Brick 1";
            this.frontAccumulatorBrick1.Click += new System.EventHandler(this.frontAccumulatorBrick1_Click);
            // 
            // avgFrontAccumulatorValue1
            // 
            this.avgFrontAccumulatorValue1.AutoSize = true;
            this.avgFrontAccumulatorValue1.Location = new System.Drawing.Point(233, 21);
            this.avgFrontAccumulatorValue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorValue1.Name = "avgFrontAccumulatorValue1";
            this.avgFrontAccumulatorValue1.Size = new System.Drawing.Size(17, 19);
            this.avgFrontAccumulatorValue1.TabIndex = 9;
            this.avgFrontAccumulatorValue1.Text = "0";
            // 
            // avgFrontAccumulatorBrick1
            // 
            this.avgFrontAccumulatorBrick1.AutoSize = true;
            this.avgFrontAccumulatorBrick1.Location = new System.Drawing.Point(190, 21);
            this.avgFrontAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorBrick1.Name = "avgFrontAccumulatorBrick1";
            this.avgFrontAccumulatorBrick1.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorBrick1.TabIndex = 8;
            this.avgFrontAccumulatorBrick1.Text = "Avg:";
            // 
            // maxFrontAccumulatorValue1
            // 
            this.maxFrontAccumulatorValue1.AutoSize = true;
            this.maxFrontAccumulatorValue1.Location = new System.Drawing.Point(143, 21);
            this.maxFrontAccumulatorValue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorValue1.Name = "maxFrontAccumulatorValue1";
            this.maxFrontAccumulatorValue1.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorValue1.TabIndex = 7;
            this.maxFrontAccumulatorValue1.Text = "0";
            // 
            // maxFrontAccumulatorBrick1
            // 
            this.maxFrontAccumulatorBrick1.AutoSize = true;
            this.maxFrontAccumulatorBrick1.Location = new System.Drawing.Point(99, 21);
            this.maxFrontAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorBrick1.Name = "maxFrontAccumulatorBrick1";
            this.maxFrontAccumulatorBrick1.Size = new System.Drawing.Size(41, 19);
            this.maxFrontAccumulatorBrick1.TabIndex = 6;
            this.maxFrontAccumulatorBrick1.Text = "Max:";
            // 
            // minFrontAccumulatorValue1
            // 
            this.minFrontAccumulatorValue1.AutoSize = true;
            this.minFrontAccumulatorValue1.Location = new System.Drawing.Point(59, 21);
            this.minFrontAccumulatorValue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue1.Name = "minFrontAccumulatorValue1";
            this.minFrontAccumulatorValue1.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue1.TabIndex = 5;
            this.minFrontAccumulatorValue1.Text = "0";
            // 
            // minFrontAccumulatorBrick1
            // 
            this.minFrontAccumulatorBrick1.AutoSize = true;
            this.minFrontAccumulatorBrick1.Location = new System.Drawing.Point(15, 21);
            this.minFrontAccumulatorBrick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorBrick1.Name = "minFrontAccumulatorBrick1";
            this.minFrontAccumulatorBrick1.Size = new System.Drawing.Size(38, 19);
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
            this.rearAccumulatorGroupBox.Location = new System.Drawing.Point(33, 276);
            this.rearAccumulatorGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorGroupBox.Name = "rearAccumulatorGroupBox";
            this.rearAccumulatorGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rearAccumulatorGroupBox.Size = new System.Drawing.Size(187, 203);
            this.rearAccumulatorGroupBox.TabIndex = 1;
            this.rearAccumulatorGroupBox.TabStop = false;
            this.rearAccumulatorGroupBox.Text = "Rear Accumulators";
            // 
            // avgRearAccumulatorValue
            // 
            this.avgRearAccumulatorValue.AutoSize = true;
            this.avgRearAccumulatorValue.Location = new System.Drawing.Point(85, 143);
            this.avgRearAccumulatorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorValue.Name = "avgRearAccumulatorValue";
            this.avgRearAccumulatorValue.Size = new System.Drawing.Size(17, 19);
            this.avgRearAccumulatorValue.TabIndex = 5;
            this.avgRearAccumulatorValue.Text = "0";
            // 
            // maxRearAccumulatorValue
            // 
            this.maxRearAccumulatorValue.AutoSize = true;
            this.maxRearAccumulatorValue.Location = new System.Drawing.Point(85, 92);
            this.maxRearAccumulatorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorValue.Name = "maxRearAccumulatorValue";
            this.maxRearAccumulatorValue.Size = new System.Drawing.Size(17, 19);
            this.maxRearAccumulatorValue.TabIndex = 4;
            this.maxRearAccumulatorValue.Text = "0";
            // 
            // minRearAccumulatorValue
            // 
            this.minRearAccumulatorValue.AutoSize = true;
            this.minRearAccumulatorValue.Location = new System.Drawing.Point(85, 45);
            this.minRearAccumulatorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorValue.Name = "minRearAccumulatorValue";
            this.minRearAccumulatorValue.Size = new System.Drawing.Size(17, 19);
            this.minRearAccumulatorValue.TabIndex = 3;
            this.minRearAccumulatorValue.Text = "0";
            // 
            // avgRearAccumulatorLabel
            // 
            this.avgRearAccumulatorLabel.AutoSize = true;
            this.avgRearAccumulatorLabel.Location = new System.Drawing.Point(20, 143);
            this.avgRearAccumulatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgRearAccumulatorLabel.Name = "avgRearAccumulatorLabel";
            this.avgRearAccumulatorLabel.Size = new System.Drawing.Size(37, 19);
            this.avgRearAccumulatorLabel.TabIndex = 2;
            this.avgRearAccumulatorLabel.Text = "Avg:";
            // 
            // maxRearAccumulatorLabel
            // 
            this.maxRearAccumulatorLabel.AutoSize = true;
            this.maxRearAccumulatorLabel.Location = new System.Drawing.Point(20, 92);
            this.maxRearAccumulatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRearAccumulatorLabel.Name = "maxRearAccumulatorLabel";
            this.maxRearAccumulatorLabel.Size = new System.Drawing.Size(41, 19);
            this.maxRearAccumulatorLabel.TabIndex = 1;
            this.maxRearAccumulatorLabel.Text = "Max:";
            // 
            // minRearAccumulatorLabel
            // 
            this.minRearAccumulatorLabel.AutoSize = true;
            this.minRearAccumulatorLabel.Location = new System.Drawing.Point(20, 45);
            this.minRearAccumulatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minRearAccumulatorLabel.Name = "minRearAccumulatorLabel";
            this.minRearAccumulatorLabel.Size = new System.Drawing.Size(38, 19);
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
            this.frontAccumulatorGroupBox.Location = new System.Drawing.Point(33, 25);
            this.frontAccumulatorGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorGroupBox.Name = "frontAccumulatorGroupBox";
            this.frontAccumulatorGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.frontAccumulatorGroupBox.Size = new System.Drawing.Size(187, 203);
            this.frontAccumulatorGroupBox.TabIndex = 0;
            this.frontAccumulatorGroupBox.TabStop = false;
            this.frontAccumulatorGroupBox.Text = "Front Accumulators";
            // 
            // AvgFrontAccumulatorValue
            // 
            this.AvgFrontAccumulatorValue.AutoSize = true;
            this.AvgFrontAccumulatorValue.Location = new System.Drawing.Point(85, 143);
            this.AvgFrontAccumulatorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvgFrontAccumulatorValue.Name = "AvgFrontAccumulatorValue";
            this.AvgFrontAccumulatorValue.Size = new System.Drawing.Size(17, 19);
            this.AvgFrontAccumulatorValue.TabIndex = 5;
            this.AvgFrontAccumulatorValue.Text = "0";
            // 
            // maxFrontAccumulatorsValue
            // 
            this.maxFrontAccumulatorsValue.AutoSize = true;
            this.maxFrontAccumulatorsValue.Location = new System.Drawing.Point(85, 92);
            this.maxFrontAccumulatorsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorsValue.Name = "maxFrontAccumulatorsValue";
            this.maxFrontAccumulatorsValue.Size = new System.Drawing.Size(17, 19);
            this.maxFrontAccumulatorsValue.TabIndex = 4;
            this.maxFrontAccumulatorsValue.Text = "0";
            // 
            // minFrontAccumulatorValue
            // 
            this.minFrontAccumulatorValue.AutoSize = true;
            this.minFrontAccumulatorValue.Location = new System.Drawing.Point(85, 45);
            this.minFrontAccumulatorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorValue.Name = "minFrontAccumulatorValue";
            this.minFrontAccumulatorValue.Size = new System.Drawing.Size(17, 19);
            this.minFrontAccumulatorValue.TabIndex = 3;
            this.minFrontAccumulatorValue.Text = "0";
            // 
            // avgFrontAccumulatorLabel
            // 
            this.avgFrontAccumulatorLabel.AutoSize = true;
            this.avgFrontAccumulatorLabel.Location = new System.Drawing.Point(20, 143);
            this.avgFrontAccumulatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgFrontAccumulatorLabel.Name = "avgFrontAccumulatorLabel";
            this.avgFrontAccumulatorLabel.Size = new System.Drawing.Size(37, 19);
            this.avgFrontAccumulatorLabel.TabIndex = 2;
            this.avgFrontAccumulatorLabel.Text = "Avg:";
            // 
            // maxFrontAccumulatorsLabel
            // 
            this.maxFrontAccumulatorsLabel.AutoSize = true;
            this.maxFrontAccumulatorsLabel.Location = new System.Drawing.Point(20, 92);
            this.maxFrontAccumulatorsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFrontAccumulatorsLabel.Name = "maxFrontAccumulatorsLabel";
            this.maxFrontAccumulatorsLabel.Size = new System.Drawing.Size(41, 19);
            this.maxFrontAccumulatorsLabel.TabIndex = 1;
            this.maxFrontAccumulatorsLabel.Text = "Max:";
            // 
            // minFrontAccumulatorsLabel
            // 
            this.minFrontAccumulatorsLabel.AutoSize = true;
            this.minFrontAccumulatorsLabel.Location = new System.Drawing.Point(20, 45);
            this.minFrontAccumulatorsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFrontAccumulatorsLabel.Name = "minFrontAccumulatorsLabel";
            this.minFrontAccumulatorsLabel.Size = new System.Drawing.Size(38, 19);
            this.minFrontAccumulatorsLabel.TabIndex = 0;
            this.minFrontAccumulatorsLabel.Text = "Min:";
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
            this.TorqueVectoring_Tab.BackgroundImage = global::QEV1_Windows_Updated.Properties.Resources.car_outline1;
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
            this.dataGridView1.Size = new System.Drawing.Size(240, 149);
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
            this.GLV_Tab.Location = new System.Drawing.Point(4, 28);
            this.GLV_Tab.Name = "GLV_Tab";
            this.GLV_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.GLV_Tab.Size = new System.Drawing.Size(1245, 644);
            this.GLV_Tab.TabIndex = 4;
            this.GLV_Tab.Text = "Power Management";
            this.GLV_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.54749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.45251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1235, 638);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PMnameBox4
            // 
            this.PMnameBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox4.Location = new System.Drawing.Point(98, 197);
            this.PMnameBox4.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox4.MaxLength = 16;
            this.PMnameBox4.Name = "PMnameBox4";
            this.PMnameBox4.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox4.TabIndex = 68;
            // 
            // PMnameBox3
            // 
            this.PMnameBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox3.Location = new System.Drawing.Point(98, 153);
            this.PMnameBox3.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox3.MaxLength = 16;
            this.PMnameBox3.Name = "PMnameBox3";
            this.PMnameBox3.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox3.TabIndex = 65;
            // 
            // PMnameBox2
            // 
            this.PMnameBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox2.Location = new System.Drawing.Point(98, 109);
            this.PMnameBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox2.MaxLength = 16;
            this.PMnameBox2.Name = "PMnameBox2";
            this.PMnameBox2.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox2.TabIndex = 62;
            // 
            // PMtypeLabel2
            // 
            this.PMtypeLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel2.AutoSize = true;
            this.PMtypeLabel2.Location = new System.Drawing.Point(253, 113);
            this.PMtypeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel2.Name = "PMtypeLabel2";
            this.PMtypeLabel2.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel2.TabIndex = 51;
            this.PMtypeLabel2.Text = "High Current";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1133, 9);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 38);
            this.label28.TabIndex = 6;
            this.label28.Text = "Current Draw (Amps)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1056, 19);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 19);
            this.label27.TabIndex = 5;
            this.label27.Text = "Status";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(832, 19);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 19);
            this.label26.TabIndex = 4;
            this.label26.Text = "Effort";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(468, 19);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 19);
            this.label23.TabIndex = 3;
            this.label23.Text = "Trip Current";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Channel";
            // 
            // PMnameBox1
            // 
            this.PMnameBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox1.Location = new System.Drawing.Point(98, 65);
            this.PMnameBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox1.MaxLength = 16;
            this.PMnameBox1.Name = "PMnameBox1";
            this.PMnameBox1.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox1.TabIndex = 7;
            // 
            // PMchannelLabel1
            // 
            this.PMchannelLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel1.AutoSize = true;
            this.PMchannelLabel1.Location = new System.Drawing.Point(39, 69);
            this.PMchannelLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel1.Name = "PMchannelLabel1";
            this.PMchannelLabel1.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel1.TabIndex = 8;
            this.PMchannelLabel1.Text = "1";
            // 
            // PMchannelLabel2
            // 
            this.PMchannelLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel2.AutoSize = true;
            this.PMchannelLabel2.Location = new System.Drawing.Point(39, 113);
            this.PMchannelLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel2.Name = "PMchannelLabel2";
            this.PMchannelLabel2.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel2.TabIndex = 9;
            this.PMchannelLabel2.Text = "2";
            // 
            // PMchannelLabel3
            // 
            this.PMchannelLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel3.AutoSize = true;
            this.PMchannelLabel3.Location = new System.Drawing.Point(39, 157);
            this.PMchannelLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel3.Name = "PMchannelLabel3";
            this.PMchannelLabel3.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel3.TabIndex = 10;
            this.PMchannelLabel3.Text = "3";
            // 
            // PMchannelLabel4
            // 
            this.PMchannelLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel4.AutoSize = true;
            this.PMchannelLabel4.Location = new System.Drawing.Point(39, 201);
            this.PMchannelLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel4.Name = "PMchannelLabel4";
            this.PMchannelLabel4.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel4.TabIndex = 11;
            this.PMchannelLabel4.Text = "4";
            // 
            // PMchannelLabel5
            // 
            this.PMchannelLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel5.AutoSize = true;
            this.PMchannelLabel5.Location = new System.Drawing.Point(39, 245);
            this.PMchannelLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel5.Name = "PMchannelLabel5";
            this.PMchannelLabel5.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel5.TabIndex = 12;
            this.PMchannelLabel5.Text = "5";
            // 
            // PMchannelLabel6
            // 
            this.PMchannelLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel6.AutoSize = true;
            this.PMchannelLabel6.Location = new System.Drawing.Point(39, 289);
            this.PMchannelLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel6.Name = "PMchannelLabel6";
            this.PMchannelLabel6.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel6.TabIndex = 13;
            this.PMchannelLabel6.Text = "6";
            // 
            // PMchannelLabel7
            // 
            this.PMchannelLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel7.AutoSize = true;
            this.PMchannelLabel7.Location = new System.Drawing.Point(39, 333);
            this.PMchannelLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel7.Name = "PMchannelLabel7";
            this.PMchannelLabel7.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel7.TabIndex = 14;
            this.PMchannelLabel7.Text = "7";
            // 
            // PMchannelLabel8
            // 
            this.PMchannelLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel8.AutoSize = true;
            this.PMchannelLabel8.Location = new System.Drawing.Point(39, 377);
            this.PMchannelLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel8.Name = "PMchannelLabel8";
            this.PMchannelLabel8.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel8.TabIndex = 15;
            this.PMchannelLabel8.Text = "8";
            // 
            // PMchannelLabel9
            // 
            this.PMchannelLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel9.AutoSize = true;
            this.PMchannelLabel9.Location = new System.Drawing.Point(39, 421);
            this.PMchannelLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel9.Name = "PMchannelLabel9";
            this.PMchannelLabel9.Size = new System.Drawing.Size(17, 19);
            this.PMchannelLabel9.TabIndex = 16;
            this.PMchannelLabel9.Text = "9";
            // 
            // PMchannelLabel10
            // 
            this.PMchannelLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel10.AutoSize = true;
            this.PMchannelLabel10.Location = new System.Drawing.Point(35, 465);
            this.PMchannelLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel10.Name = "PMchannelLabel10";
            this.PMchannelLabel10.Size = new System.Drawing.Size(25, 19);
            this.PMchannelLabel10.TabIndex = 17;
            this.PMchannelLabel10.Text = "10";
            // 
            // PMchannelLabel11
            // 
            this.PMchannelLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel11.AutoSize = true;
            this.PMchannelLabel11.Location = new System.Drawing.Point(35, 509);
            this.PMchannelLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel11.Name = "PMchannelLabel11";
            this.PMchannelLabel11.Size = new System.Drawing.Size(25, 19);
            this.PMchannelLabel11.TabIndex = 18;
            this.PMchannelLabel11.Text = "11";
            // 
            // PMchannelLabel12
            // 
            this.PMchannelLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel12.AutoSize = true;
            this.PMchannelLabel12.Location = new System.Drawing.Point(35, 553);
            this.PMchannelLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel12.Name = "PMchannelLabel12";
            this.PMchannelLabel12.Size = new System.Drawing.Size(25, 19);
            this.PMchannelLabel12.TabIndex = 19;
            this.PMchannelLabel12.Text = "12";
            // 
            // PMchannelLabel13
            // 
            this.PMchannelLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel13.AutoSize = true;
            this.PMchannelLabel13.Location = new System.Drawing.Point(35, 602);
            this.PMchannelLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMchannelLabel13.Name = "PMchannelLabel13";
            this.PMchannelLabel13.Size = new System.Drawing.Size(25, 19);
            this.PMchannelLabel13.TabIndex = 20;
            this.PMchannelLabel13.Text = "13";
            // 
            // PMcurrentDrawLabel1
            // 
            this.PMcurrentDrawLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel1.AutoSize = true;
            this.PMcurrentDrawLabel1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel1.Location = new System.Drawing.Point(1155, 62);
            this.PMcurrentDrawLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel1.Name = "PMcurrentDrawLabel1";
            this.PMcurrentDrawLabel1.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel1.TabIndex = 21;
            this.PMcurrentDrawLabel1.Text = "0.0";
            // 
            // PMcurrentDrawLabel2
            // 
            this.PMcurrentDrawLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel2.AutoSize = true;
            this.PMcurrentDrawLabel2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel2.Location = new System.Drawing.Point(1155, 106);
            this.PMcurrentDrawLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel2.Name = "PMcurrentDrawLabel2";
            this.PMcurrentDrawLabel2.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel2.TabIndex = 22;
            this.PMcurrentDrawLabel2.Text = "0.0";
            // 
            // PMcurrentDrawLabel3
            // 
            this.PMcurrentDrawLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel3.AutoSize = true;
            this.PMcurrentDrawLabel3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel3.Location = new System.Drawing.Point(1155, 150);
            this.PMcurrentDrawLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel3.Name = "PMcurrentDrawLabel3";
            this.PMcurrentDrawLabel3.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel3.TabIndex = 23;
            this.PMcurrentDrawLabel3.Text = "0.0";
            // 
            // PMcurrentDrawLabel4
            // 
            this.PMcurrentDrawLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel4.AutoSize = true;
            this.PMcurrentDrawLabel4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel4.Location = new System.Drawing.Point(1155, 194);
            this.PMcurrentDrawLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel4.Name = "PMcurrentDrawLabel4";
            this.PMcurrentDrawLabel4.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel4.TabIndex = 24;
            this.PMcurrentDrawLabel4.Text = "0.0";
            // 
            // PMcurrentDrawLabel5
            // 
            this.PMcurrentDrawLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel5.AutoSize = true;
            this.PMcurrentDrawLabel5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel5.Location = new System.Drawing.Point(1155, 238);
            this.PMcurrentDrawLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel5.Name = "PMcurrentDrawLabel5";
            this.PMcurrentDrawLabel5.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel5.TabIndex = 25;
            this.PMcurrentDrawLabel5.Text = "0.0";
            // 
            // PMcurrentDrawLabel6
            // 
            this.PMcurrentDrawLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel6.AutoSize = true;
            this.PMcurrentDrawLabel6.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel6.Location = new System.Drawing.Point(1155, 282);
            this.PMcurrentDrawLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel6.Name = "PMcurrentDrawLabel6";
            this.PMcurrentDrawLabel6.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel6.TabIndex = 26;
            this.PMcurrentDrawLabel6.Text = "0.0";
            // 
            // PMcurrentDrawLabel7
            // 
            this.PMcurrentDrawLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel7.AutoSize = true;
            this.PMcurrentDrawLabel7.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel7.Location = new System.Drawing.Point(1155, 326);
            this.PMcurrentDrawLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel7.Name = "PMcurrentDrawLabel7";
            this.PMcurrentDrawLabel7.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel7.TabIndex = 27;
            this.PMcurrentDrawLabel7.Text = "0.0";
            // 
            // PMcurrentDrawLabel8
            // 
            this.PMcurrentDrawLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel8.AutoSize = true;
            this.PMcurrentDrawLabel8.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel8.Location = new System.Drawing.Point(1155, 370);
            this.PMcurrentDrawLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel8.Name = "PMcurrentDrawLabel8";
            this.PMcurrentDrawLabel8.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel8.TabIndex = 28;
            this.PMcurrentDrawLabel8.Text = "0.0";
            // 
            // PMcurrentDrawLabel9
            // 
            this.PMcurrentDrawLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel9.AutoSize = true;
            this.PMcurrentDrawLabel9.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel9.Location = new System.Drawing.Point(1155, 414);
            this.PMcurrentDrawLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel9.Name = "PMcurrentDrawLabel9";
            this.PMcurrentDrawLabel9.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel9.TabIndex = 29;
            this.PMcurrentDrawLabel9.Text = "0.0";
            // 
            // PMcurrentDrawLabel10
            // 
            this.PMcurrentDrawLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel10.AutoSize = true;
            this.PMcurrentDrawLabel10.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel10.Location = new System.Drawing.Point(1155, 458);
            this.PMcurrentDrawLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel10.Name = "PMcurrentDrawLabel10";
            this.PMcurrentDrawLabel10.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel10.TabIndex = 30;
            this.PMcurrentDrawLabel10.Text = "0.0";
            // 
            // PMcurrentDrawLabel11
            // 
            this.PMcurrentDrawLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel11.AutoSize = true;
            this.PMcurrentDrawLabel11.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel11.Location = new System.Drawing.Point(1155, 502);
            this.PMcurrentDrawLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel11.Name = "PMcurrentDrawLabel11";
            this.PMcurrentDrawLabel11.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel11.TabIndex = 31;
            this.PMcurrentDrawLabel11.Text = "0.0";
            // 
            // PMcurrentDrawLabel12
            // 
            this.PMcurrentDrawLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel12.AutoSize = true;
            this.PMcurrentDrawLabel12.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel12.Location = new System.Drawing.Point(1155, 546);
            this.PMcurrentDrawLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel12.Name = "PMcurrentDrawLabel12";
            this.PMcurrentDrawLabel12.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel12.TabIndex = 32;
            this.PMcurrentDrawLabel12.Text = "0.0";
            // 
            // PMcurrentDrawLabel13
            // 
            this.PMcurrentDrawLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel13.AutoSize = true;
            this.PMcurrentDrawLabel13.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel13.Location = new System.Drawing.Point(1155, 595);
            this.PMcurrentDrawLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMcurrentDrawLabel13.Name = "PMcurrentDrawLabel13";
            this.PMcurrentDrawLabel13.Size = new System.Drawing.Size(50, 33);
            this.PMcurrentDrawLabel13.TabIndex = 33;
            this.PMcurrentDrawLabel13.Text = "0.0";
            // 
            // PMstatusLabel1
            // 
            this.PMstatusLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel1.AutoSize = true;
            this.PMstatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PMstatusLabel1.ForeColor = System.Drawing.Color.Green;
            this.PMstatusLabel1.Location = new System.Drawing.Point(1065, 69);
            this.PMstatusLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel1.Name = "PMstatusLabel1";
            this.PMstatusLabel1.Size = new System.Drawing.Size(30, 19);
            this.PMstatusLabel1.TabIndex = 34;
            this.PMstatusLabel1.Text = "ON";
            // 
            // PMstatusLabel2
            // 
            this.PMstatusLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel2.AutoSize = true;
            this.PMstatusLabel2.Location = new System.Drawing.Point(1063, 113);
            this.PMstatusLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel2.Name = "PMstatusLabel2";
            this.PMstatusLabel2.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel2.TabIndex = 35;
            this.PMstatusLabel2.Text = "OFF";
            // 
            // PMstatusLabel3
            // 
            this.PMstatusLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel3.AutoSize = true;
            this.PMstatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PMstatusLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.PMstatusLabel3.Location = new System.Drawing.Point(1044, 157);
            this.PMstatusLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel3.Name = "PMstatusLabel3";
            this.PMstatusLabel3.Size = new System.Drawing.Size(73, 19);
            this.PMstatusLabel3.TabIndex = 36;
            this.PMstatusLabel3.Text = "DISABLED";
            // 
            // PMstatusLabel4
            // 
            this.PMstatusLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel4.AutoSize = true;
            this.PMstatusLabel4.BackColor = System.Drawing.Color.Red;
            this.PMstatusLabel4.ForeColor = System.Drawing.Color.White;
            this.PMstatusLabel4.Location = new System.Drawing.Point(1061, 201);
            this.PMstatusLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel4.Name = "PMstatusLabel4";
            this.PMstatusLabel4.Size = new System.Drawing.Size(38, 19);
            this.PMstatusLabel4.TabIndex = 37;
            this.PMstatusLabel4.Text = "TRIP";
            // 
            // PMstatusLabel5
            // 
            this.PMstatusLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel5.AutoSize = true;
            this.PMstatusLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PMstatusLabel5.ForeColor = System.Drawing.Color.Red;
            this.PMstatusLabel5.Location = new System.Drawing.Point(1056, 245);
            this.PMstatusLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel5.Name = "PMstatusLabel5";
            this.PMstatusLabel5.Size = new System.Drawing.Size(48, 19);
            this.PMstatusLabel5.TabIndex = 38;
            this.PMstatusLabel5.Text = "FAULT";
            // 
            // PMstatusLabel6
            // 
            this.PMstatusLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel6.AutoSize = true;
            this.PMstatusLabel6.Location = new System.Drawing.Point(1063, 289);
            this.PMstatusLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel6.Name = "PMstatusLabel6";
            this.PMstatusLabel6.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel6.TabIndex = 39;
            this.PMstatusLabel6.Text = "OFF";
            // 
            // PMstatusLabel7
            // 
            this.PMstatusLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel7.AutoSize = true;
            this.PMstatusLabel7.Location = new System.Drawing.Point(1063, 333);
            this.PMstatusLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel7.Name = "PMstatusLabel7";
            this.PMstatusLabel7.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel7.TabIndex = 40;
            this.PMstatusLabel7.Text = "OFF";
            // 
            // PMstatusLabel8
            // 
            this.PMstatusLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel8.AutoSize = true;
            this.PMstatusLabel8.Location = new System.Drawing.Point(1063, 377);
            this.PMstatusLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel8.Name = "PMstatusLabel8";
            this.PMstatusLabel8.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel8.TabIndex = 41;
            this.PMstatusLabel8.Text = "OFF";
            // 
            // PMstatusLabel9
            // 
            this.PMstatusLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel9.AutoSize = true;
            this.PMstatusLabel9.Location = new System.Drawing.Point(1063, 421);
            this.PMstatusLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel9.Name = "PMstatusLabel9";
            this.PMstatusLabel9.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel9.TabIndex = 42;
            this.PMstatusLabel9.Text = "OFF";
            // 
            // PMstatusLabel10
            // 
            this.PMstatusLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel10.AutoSize = true;
            this.PMstatusLabel10.Location = new System.Drawing.Point(1063, 465);
            this.PMstatusLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel10.Name = "PMstatusLabel10";
            this.PMstatusLabel10.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel10.TabIndex = 43;
            this.PMstatusLabel10.Text = "OFF";
            // 
            // PMstatusLabel11
            // 
            this.PMstatusLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel11.AutoSize = true;
            this.PMstatusLabel11.Location = new System.Drawing.Point(1063, 509);
            this.PMstatusLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel11.Name = "PMstatusLabel11";
            this.PMstatusLabel11.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel11.TabIndex = 44;
            this.PMstatusLabel11.Text = "OFF";
            // 
            // PMstatusLabel12
            // 
            this.PMstatusLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel12.AutoSize = true;
            this.PMstatusLabel12.Location = new System.Drawing.Point(1063, 553);
            this.PMstatusLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel12.Name = "PMstatusLabel12";
            this.PMstatusLabel12.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel12.TabIndex = 45;
            this.PMstatusLabel12.Text = "OFF";
            // 
            // PMstatusLabel13
            // 
            this.PMstatusLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel13.AutoSize = true;
            this.PMstatusLabel13.Location = new System.Drawing.Point(1063, 602);
            this.PMstatusLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMstatusLabel13.Name = "PMstatusLabel13";
            this.PMstatusLabel13.Size = new System.Drawing.Size(34, 19);
            this.PMstatusLabel13.TabIndex = 46;
            this.PMstatusLabel13.Text = "OFF";
            // 
            // PMtypeLabel1
            // 
            this.PMtypeLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel1.AutoSize = true;
            this.PMtypeLabel1.Location = new System.Drawing.Point(253, 69);
            this.PMtypeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel1.Name = "PMtypeLabel1";
            this.PMtypeLabel1.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel1.TabIndex = 47;
            this.PMtypeLabel1.Text = "High Current";
            // 
            // PMtypeLabel4
            // 
            this.PMtypeLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel4.AutoSize = true;
            this.PMtypeLabel4.Location = new System.Drawing.Point(253, 201);
            this.PMtypeLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel4.Name = "PMtypeLabel4";
            this.PMtypeLabel4.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel4.TabIndex = 54;
            this.PMtypeLabel4.Text = "High Current";
            // 
            // PMtypeLabel3
            // 
            this.PMtypeLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel3.AutoSize = true;
            this.PMtypeLabel3.Location = new System.Drawing.Point(253, 157);
            this.PMtypeLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel3.Name = "PMtypeLabel3";
            this.PMtypeLabel3.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel3.TabIndex = 50;
            this.PMtypeLabel3.Text = "High Current";
            // 
            // PMtypeLabel5
            // 
            this.PMtypeLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel5.AutoSize = true;
            this.PMtypeLabel5.Location = new System.Drawing.Point(253, 245);
            this.PMtypeLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel5.Name = "PMtypeLabel5";
            this.PMtypeLabel5.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel5.TabIndex = 52;
            this.PMtypeLabel5.Text = "High Current";
            // 
            // PMtypeLabel6
            // 
            this.PMtypeLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel6.AutoSize = true;
            this.PMtypeLabel6.Location = new System.Drawing.Point(253, 289);
            this.PMtypeLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel6.Name = "PMtypeLabel6";
            this.PMtypeLabel6.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel6.TabIndex = 53;
            this.PMtypeLabel6.Text = "High Current";
            // 
            // PMtypeLabel7
            // 
            this.PMtypeLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel7.AutoSize = true;
            this.PMtypeLabel7.Location = new System.Drawing.Point(253, 333);
            this.PMtypeLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel7.Name = "PMtypeLabel7";
            this.PMtypeLabel7.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel7.TabIndex = 49;
            this.PMtypeLabel7.Text = "High Current";
            // 
            // PMtypeLabel8
            // 
            this.PMtypeLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel8.AutoSize = true;
            this.PMtypeLabel8.Location = new System.Drawing.Point(253, 377);
            this.PMtypeLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel8.Name = "PMtypeLabel8";
            this.PMtypeLabel8.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel8.TabIndex = 48;
            this.PMtypeLabel8.Text = "High Current";
            // 
            // PMtypeLabel9
            // 
            this.PMtypeLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel9.AutoSize = true;
            this.PMtypeLabel9.Location = new System.Drawing.Point(253, 421);
            this.PMtypeLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel9.Name = "PMtypeLabel9";
            this.PMtypeLabel9.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel9.TabIndex = 55;
            this.PMtypeLabel9.Text = "High Current";
            // 
            // PMtypeLabel10
            // 
            this.PMtypeLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel10.AutoSize = true;
            this.PMtypeLabel10.Location = new System.Drawing.Point(253, 465);
            this.PMtypeLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel10.Name = "PMtypeLabel10";
            this.PMtypeLabel10.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel10.TabIndex = 56;
            this.PMtypeLabel10.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel11
            // 
            this.PMtypeLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel11.AutoSize = true;
            this.PMtypeLabel11.Location = new System.Drawing.Point(253, 509);
            this.PMtypeLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel11.Name = "PMtypeLabel11";
            this.PMtypeLabel11.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel11.TabIndex = 57;
            this.PMtypeLabel11.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel12
            // 
            this.PMtypeLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel12.AutoSize = true;
            this.PMtypeLabel12.Location = new System.Drawing.Point(253, 553);
            this.PMtypeLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel12.Name = "PMtypeLabel12";
            this.PMtypeLabel12.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel12.TabIndex = 58;
            this.PMtypeLabel12.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel13
            // 
            this.PMtypeLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel13.AutoSize = true;
            this.PMtypeLabel13.Location = new System.Drawing.Point(253, 602);
            this.PMtypeLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PMtypeLabel13.Name = "PMtypeLabel13";
            this.PMtypeLabel13.Size = new System.Drawing.Size(91, 19);
            this.PMtypeLabel13.TabIndex = 59;
            this.PMtypeLabel13.Text = "Push/Pull 5A";
            // 
            // PMnameBox5
            // 
            this.PMnameBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox5.Location = new System.Drawing.Point(98, 241);
            this.PMnameBox5.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox5.MaxLength = 16;
            this.PMnameBox5.Name = "PMnameBox5";
            this.PMnameBox5.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox5.TabIndex = 60;
            // 
            // PMnameBox6
            // 
            this.PMnameBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox6.Location = new System.Drawing.Point(98, 285);
            this.PMnameBox6.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox6.MaxLength = 16;
            this.PMnameBox6.Name = "PMnameBox6";
            this.PMnameBox6.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox6.TabIndex = 63;
            // 
            // PMnameBox7
            // 
            this.PMnameBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox7.Location = new System.Drawing.Point(98, 329);
            this.PMnameBox7.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox7.MaxLength = 16;
            this.PMnameBox7.Name = "PMnameBox7";
            this.PMnameBox7.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox7.TabIndex = 66;
            // 
            // PMnameBox8
            // 
            this.PMnameBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox8.Location = new System.Drawing.Point(98, 373);
            this.PMnameBox8.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox8.MaxLength = 16;
            this.PMnameBox8.Name = "PMnameBox8";
            this.PMnameBox8.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox8.TabIndex = 61;
            // 
            // PMnameBox9
            // 
            this.PMnameBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox9.Location = new System.Drawing.Point(98, 417);
            this.PMnameBox9.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox9.MaxLength = 16;
            this.PMnameBox9.Name = "PMnameBox9";
            this.PMnameBox9.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox9.TabIndex = 73;
            // 
            // PMnameBox10
            // 
            this.PMnameBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox10.Location = new System.Drawing.Point(98, 461);
            this.PMnameBox10.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox10.MaxLength = 16;
            this.PMnameBox10.Name = "PMnameBox10";
            this.PMnameBox10.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox10.TabIndex = 72;
            // 
            // PMnameBox11
            // 
            this.PMnameBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox11.Location = new System.Drawing.Point(98, 505);
            this.PMnameBox11.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox11.MaxLength = 16;
            this.PMnameBox11.Name = "PMnameBox11";
            this.PMnameBox11.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox11.TabIndex = 71;
            // 
            // PMnameBox12
            // 
            this.PMnameBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox12.Location = new System.Drawing.Point(98, 549);
            this.PMnameBox12.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox12.MaxLength = 16;
            this.PMnameBox12.Name = "PMnameBox12";
            this.PMnameBox12.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox12.TabIndex = 69;
            // 
            // PMnameBox13
            // 
            this.PMnameBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox13.Location = new System.Drawing.Point(98, 598);
            this.PMnameBox13.Margin = new System.Windows.Forms.Padding(2);
            this.PMnameBox13.MaxLength = 16;
            this.PMnameBox13.Name = "PMnameBox13";
            this.PMnameBox13.Size = new System.Drawing.Size(149, 27);
            this.PMnameBox13.TabIndex = 70;
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
            this.CANrichTextBox.Size = new System.Drawing.Size(518, 504);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 27);
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
            // guiUpdateTimer
            // 
            this.guiUpdateTimer.Enabled = true;
            this.guiUpdateTimer.Tick += new System.EventHandler(this.guiUpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 770);
            this.Controls.Add(this.mainScreenTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1425, 830);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(879, 471);
            this.Name = "Form1";
            this.Text = "QUT Motorsport - QEV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainScreenTabControl.ResumeLayout(false);
            this.Overview_Tab.ResumeLayout(false);
            this.groupBoxInverter4.ResumeLayout(false);
            this.groupBoxInverter4.PerformLayout();
            this.groupBoxInverter3.ResumeLayout(false);
            this.groupBoxInverter3.PerformLayout();
            this.groupBoxInverter2.ResumeLayout(false);
            this.groupBoxInverter2.PerformLayout();
            this.groupBoxGeneralStats.ResumeLayout(false);
            this.groupBoxGeneralStats.PerformLayout();
            this.groupBoxAcc2.ResumeLayout(false);
            this.groupBoxAcc2.PerformLayout();
            this.groupBoxCAN.ResumeLayout(false);
            this.groupBoxCAN.PerformLayout();
            this.groupBoxSerialTimer.ResumeLayout(false);
            this.groupBoxSerialTimer.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBoxInverter1.ResumeLayout(false);
            this.groupBoxInverter1.PerformLayout();
            this.groupBoxAcc1.ResumeLayout(false);
            this.groupBoxAcc1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripErrorFlag;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTorqueSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTorqueSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanForSerialPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToTelemetryServerToolStripMenuItem;
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
        private System.Windows.Forms.Timer serialTimer;
        private System.Windows.Forms.TabPage IOsetup_Tab;
        private System.Windows.Forms.TabPage Firmware_Tab;
        private System.Windows.Forms.Button firmwareLaunch;
        private System.Windows.Forms.RichTextBox firmwareTextBox;
        private System.Windows.Forms.Button balancingButton;
        private System.Windows.Forms.Label balancingLabel;
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
        private System.Windows.Forms.Label PMcurrentDrawLabel5;
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
        private System.Windows.Forms.GroupBox groupBoxInverter4;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label lblInv4Temp;
        private System.Windows.Forms.Label lblInv4Current;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.GroupBox groupBoxInverter3;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label lblInv3Temp;
        private System.Windows.Forms.Label lblInv3Current;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.GroupBox groupBoxInverter2;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label lblInv2Temp;
        private System.Windows.Forms.Label lblInv2Current;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.GroupBox groupBoxGeneralStats;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblOverviewYawRate;
        private System.Windows.Forms.Label lblOverviewLatG;
        private System.Windows.Forms.Label lblOverviewLongG;
        private System.Windows.Forms.Label lblOverviewSteeringAngle;
        private System.Windows.Forms.Label lblOverviewBrakeFrontPressure;
        private System.Windows.Forms.Label lblOverviewBrakePedal;
        private System.Windows.Forms.Label lblOverviewAcceleratorPedal;
        private System.Windows.Forms.Label lblOverviewSpeed;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBoxAcc2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAcc2AvTemp;
        private System.Windows.Forms.Label lblAcc2MaxTemp;
        private System.Windows.Forms.Label lblAcc2MinTemp;
        private System.Windows.Forms.Label lblAcc2AvVolts;
        private System.Windows.Forms.Label lblAcc2MaxVolts;
        private System.Windows.Forms.Label lblAcc2MinVolts;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button loggingStopStartButton;
        private System.Windows.Forms.GroupBox groupBoxCAN;
        private System.Windows.Forms.Label rx_status_label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBoxSerialTimer;
        private System.Windows.Forms.Label serialLinkSpeedLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label vehicleProfileLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button editProfilesButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox profileStartupCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox profileCurrentCombo;
        private System.Windows.Forms.GroupBox groupBoxInverter1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label lblInv1Temp;
        private System.Windows.Forms.Label lblInv1Current;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.GroupBox groupBoxAcc1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label lblAcc1AvTemp;
        private System.Windows.Forms.Label lblAcc1MaxTemp;
        private System.Windows.Forms.Label lblAcc1MinTemp;
        private System.Windows.Forms.Label lblAcc1AvVolts;
        private System.Windows.Forms.Label lblAcc1MaxVolts;
        private System.Windows.Forms.Label lblAcc1MinVolts;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Timer guiUpdateTimer;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label lblOverviewBrakeRearPressure;
        private System.Windows.Forms.Label label61;
    }
}