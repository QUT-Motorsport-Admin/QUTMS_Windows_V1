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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TorqueVectoring_Tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.GLV_Tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PMtripControl6 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl5 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl4 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl3 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl2 = new System.Windows.Forms.NumericUpDown();
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
            this.PMtripControl1 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl7 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl8 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl9 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl10 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl11 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl12 = new System.Windows.Forms.NumericUpDown();
            this.PMtripControl13 = new System.Windows.Forms.NumericUpDown();
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
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label79 = new System.Windows.Forms.Label();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.label91 = new System.Windows.Forms.Label();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.label101 = new System.Windows.Forms.Label();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.checkBox35 = new System.Windows.Forms.CheckBox();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.checkBox38 = new System.Windows.Forms.CheckBox();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown22 = new System.Windows.Forms.NumericUpDown();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.numericUpDown23 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown24 = new System.Windows.Forms.NumericUpDown();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
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
            this.Inverters_Tab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.TorqueVectoring_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.GLV_Tab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl13)).BeginInit();
            this.Diagnostics_Tab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Firmware_Tab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).BeginInit();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConnectionStatus,
            this.statusCOMnumber,
            this.statusStripErrorFlag});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1073);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1898, 38);
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
            this.statusConnectionStatus.Size = new System.Drawing.Size(200, 33);
            this.statusConnectionStatus.Text = "DISCONNECTED";
            this.statusConnectionStatus.Click += new System.EventHandler(this.statusConnectionStatus_Click);
            // 
            // statusCOMnumber
            // 
            this.statusCOMnumber.AutoSize = false;
            this.statusCOMnumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCOMnumber.Name = "statusCOMnumber";
            this.statusCOMnumber.Size = new System.Drawing.Size(200, 33);
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
            this.statusStripErrorFlag.Size = new System.Drawing.Size(400, 33);
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
            this.mainScreenTabControl.Size = new System.Drawing.Size(1880, 1040);
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
            this.Overview_Tab.Location = new System.Drawing.Point(4, 38);
            this.Overview_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Overview_Tab.Name = "Overview_Tab";
            this.Overview_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Overview_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.groupBoxInverter4.Location = new System.Drawing.Point(1059, 478);
            this.groupBoxInverter4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter4.Name = "groupBoxInverter4";
            this.groupBoxInverter4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter4.Size = new System.Drawing.Size(308, 195);
            this.groupBoxInverter4.TabIndex = 11;
            this.groupBoxInverter4.TabStop = false;
            this.groupBoxInverter4.Text = "Inverter 4";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(267, 82);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(34, 29);
            this.label73.TabIndex = 41;
            this.label73.Text = "°C";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(267, 52);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(27, 29);
            this.label75.TabIndex = 39;
            this.label75.Text = "A";
            // 
            // lblInv4Temp
            // 
            this.lblInv4Temp.AutoSize = true;
            this.lblInv4Temp.Location = new System.Drawing.Point(201, 82);
            this.lblInv4Temp.Name = "lblInv4Temp";
            this.lblInv4Temp.Size = new System.Drawing.Size(25, 29);
            this.lblInv4Temp.TabIndex = 37;
            this.lblInv4Temp.Text = "0";
            // 
            // lblInv4Current
            // 
            this.lblInv4Current.AutoSize = true;
            this.lblInv4Current.Location = new System.Drawing.Point(201, 52);
            this.lblInv4Current.Name = "lblInv4Current";
            this.lblInv4Current.Size = new System.Drawing.Size(25, 29);
            this.lblInv4Current.TabIndex = 36;
            this.lblInv4Current.Text = "0";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(14, 82);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(146, 29);
            this.label80.TabIndex = 34;
            this.label80.Text = "Temperature:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(14, 52);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(99, 29);
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
            this.groupBoxInverter3.Location = new System.Drawing.Point(728, 478);
            this.groupBoxInverter3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter3.Name = "groupBoxInverter3";
            this.groupBoxInverter3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter3.Size = new System.Drawing.Size(309, 195);
            this.groupBoxInverter3.TabIndex = 12;
            this.groupBoxInverter3.TabStop = false;
            this.groupBoxInverter3.Text = "Inverter 3";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(258, 82);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(34, 29);
            this.label64.TabIndex = 41;
            this.label64.Text = "°C";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(258, 52);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(27, 29);
            this.label66.TabIndex = 39;
            this.label66.Text = "A";
            // 
            // lblInv3Temp
            // 
            this.lblInv3Temp.AutoSize = true;
            this.lblInv3Temp.Location = new System.Drawing.Point(192, 82);
            this.lblInv3Temp.Name = "lblInv3Temp";
            this.lblInv3Temp.Size = new System.Drawing.Size(25, 29);
            this.lblInv3Temp.TabIndex = 37;
            this.lblInv3Temp.Text = "0";
            // 
            // lblInv3Current
            // 
            this.lblInv3Current.AutoSize = true;
            this.lblInv3Current.Location = new System.Drawing.Point(192, 52);
            this.lblInv3Current.Name = "lblInv3Current";
            this.lblInv3Current.Size = new System.Drawing.Size(25, 29);
            this.lblInv3Current.TabIndex = 36;
            this.lblInv3Current.Text = "0";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(4, 82);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(146, 29);
            this.label71.TabIndex = 34;
            this.label71.Text = "Temperature:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(4, 52);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(94, 29);
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
            this.groupBoxInverter2.Location = new System.Drawing.Point(728, 278);
            this.groupBoxInverter2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter2.Name = "groupBoxInverter2";
            this.groupBoxInverter2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter2.Size = new System.Drawing.Size(309, 183);
            this.groupBoxInverter2.TabIndex = 13;
            this.groupBoxInverter2.TabStop = false;
            this.groupBoxInverter2.Text = "Inverter 2";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(260, 68);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(34, 29);
            this.label55.TabIndex = 41;
            this.label55.Text = "°C";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(260, 38);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(27, 29);
            this.label57.TabIndex = 39;
            this.label57.Text = "A";
            // 
            // lblInv2Temp
            // 
            this.lblInv2Temp.AutoSize = true;
            this.lblInv2Temp.Location = new System.Drawing.Point(194, 68);
            this.lblInv2Temp.Name = "lblInv2Temp";
            this.lblInv2Temp.Size = new System.Drawing.Size(25, 29);
            this.lblInv2Temp.TabIndex = 37;
            this.lblInv2Temp.Text = "0";
            // 
            // lblInv2Current
            // 
            this.lblInv2Current.AutoSize = true;
            this.lblInv2Current.Location = new System.Drawing.Point(194, 38);
            this.lblInv2Current.Name = "lblInv2Current";
            this.lblInv2Current.Size = new System.Drawing.Size(25, 29);
            this.lblInv2Current.TabIndex = 36;
            this.lblInv2Current.Text = "0";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 68);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(146, 29);
            this.label62.TabIndex = 34;
            this.label62.Text = "Temperature:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 38);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(94, 29);
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
            this.groupBoxGeneralStats.Location = new System.Drawing.Point(728, 9);
            this.groupBoxGeneralStats.Name = "groupBoxGeneralStats";
            this.groupBoxGeneralStats.Size = new System.Drawing.Size(718, 238);
            this.groupBoxGeneralStats.TabIndex = 18;
            this.groupBoxGeneralStats.TabStop = false;
            this.groupBoxGeneralStats.Text = "General Overview";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(291, 195);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(62, 29);
            this.label59.TabIndex = 26;
            this.label59.Text = "units";
            // 
            // lblOverviewBrakeRearPressure
            // 
            this.lblOverviewBrakeRearPressure.AutoSize = true;
            this.lblOverviewBrakeRearPressure.Location = new System.Drawing.Point(237, 195);
            this.lblOverviewBrakeRearPressure.Name = "lblOverviewBrakeRearPressure";
            this.lblOverviewBrakeRearPressure.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewBrakeRearPressure.TabIndex = 25;
            this.lblOverviewBrakeRearPressure.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 195);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(212, 29);
            this.label61.TabIndex = 24;
            this.label61.Text = "Rear Brake Pressure:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(662, 154);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(62, 29);
            this.label45.TabIndex = 23;
            this.label45.Text = "units";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(662, 111);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(28, 29);
            this.label44.TabIndex = 22;
            this.label44.Text = "G";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(662, 72);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(28, 29);
            this.label43.TabIndex = 21;
            this.label43.Text = "G";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(662, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(21, 29);
            this.label42.TabIndex = 20;
            this.label42.Text = "°";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(290, 154);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 29);
            this.label41.TabIndex = 19;
            this.label41.Text = "units";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(290, 111);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(30, 29);
            this.label40.TabIndex = 18;
            this.label40.Text = "%";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(290, 72);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 29);
            this.label39.TabIndex = 17;
            this.label39.Text = "%";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(290, 35);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(65, 29);
            this.label38.TabIndex = 16;
            this.label38.Text = "km/h";
            // 
            // lblOverviewYawRate
            // 
            this.lblOverviewYawRate.AutoSize = true;
            this.lblOverviewYawRate.Location = new System.Drawing.Point(616, 154);
            this.lblOverviewYawRate.Name = "lblOverviewYawRate";
            this.lblOverviewYawRate.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewYawRate.TabIndex = 15;
            this.lblOverviewYawRate.Text = "0";
            // 
            // lblOverviewLatG
            // 
            this.lblOverviewLatG.AutoSize = true;
            this.lblOverviewLatG.Location = new System.Drawing.Point(616, 111);
            this.lblOverviewLatG.Name = "lblOverviewLatG";
            this.lblOverviewLatG.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewLatG.TabIndex = 14;
            this.lblOverviewLatG.Text = "0";
            // 
            // lblOverviewLongG
            // 
            this.lblOverviewLongG.AutoSize = true;
            this.lblOverviewLongG.Location = new System.Drawing.Point(616, 72);
            this.lblOverviewLongG.Name = "lblOverviewLongG";
            this.lblOverviewLongG.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewLongG.TabIndex = 13;
            this.lblOverviewLongG.Text = "0";
            // 
            // lblOverviewSteeringAngle
            // 
            this.lblOverviewSteeringAngle.AutoSize = true;
            this.lblOverviewSteeringAngle.Location = new System.Drawing.Point(616, 35);
            this.lblOverviewSteeringAngle.Name = "lblOverviewSteeringAngle";
            this.lblOverviewSteeringAngle.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewSteeringAngle.TabIndex = 12;
            this.lblOverviewSteeringAngle.Text = "0";
            // 
            // lblOverviewBrakeFrontPressure
            // 
            this.lblOverviewBrakeFrontPressure.AutoSize = true;
            this.lblOverviewBrakeFrontPressure.Location = new System.Drawing.Point(236, 154);
            this.lblOverviewBrakeFrontPressure.Name = "lblOverviewBrakeFrontPressure";
            this.lblOverviewBrakeFrontPressure.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewBrakeFrontPressure.TabIndex = 11;
            this.lblOverviewBrakeFrontPressure.Text = "0";
            // 
            // lblOverviewBrakePedal
            // 
            this.lblOverviewBrakePedal.AutoSize = true;
            this.lblOverviewBrakePedal.Location = new System.Drawing.Point(236, 111);
            this.lblOverviewBrakePedal.Name = "lblOverviewBrakePedal";
            this.lblOverviewBrakePedal.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewBrakePedal.TabIndex = 10;
            this.lblOverviewBrakePedal.Text = "0";
            // 
            // lblOverviewAcceleratorPedal
            // 
            this.lblOverviewAcceleratorPedal.AutoSize = true;
            this.lblOverviewAcceleratorPedal.Location = new System.Drawing.Point(236, 72);
            this.lblOverviewAcceleratorPedal.Name = "lblOverviewAcceleratorPedal";
            this.lblOverviewAcceleratorPedal.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewAcceleratorPedal.TabIndex = 9;
            this.lblOverviewAcceleratorPedal.Text = "0";
            // 
            // lblOverviewSpeed
            // 
            this.lblOverviewSpeed.AutoSize = true;
            this.lblOverviewSpeed.Location = new System.Drawing.Point(236, 35);
            this.lblOverviewSpeed.Name = "lblOverviewSpeed";
            this.lblOverviewSpeed.Size = new System.Drawing.Size(25, 29);
            this.lblOverviewSpeed.TabIndex = 8;
            this.lblOverviewSpeed.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(369, 154);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(113, 29);
            this.label37.TabIndex = 7;
            this.label37.Text = "Yaw Rate: ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(369, 111);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(168, 29);
            this.label36.TabIndex = 6;
            this.label36.Text = "Lateral G-Force:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(369, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(205, 29);
            this.label29.TabIndex = 5;
            this.label29.Text = "Longitudal G-Force:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Steering Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Front Brake Pressure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Brake Pedal:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(192, 29);
            this.label25.TabIndex = 1;
            this.label25.Text = "Accelerator Pedal:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 29);
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
            this.groupBoxAcc2.Location = new System.Drawing.Point(362, 337);
            this.groupBoxAcc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAcc2.Name = "groupBoxAcc2";
            this.groupBoxAcc2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAcc2.Size = new System.Drawing.Size(328, 337);
            this.groupBoxAcc2.TabIndex = 9;
            this.groupBoxAcc2.TabStop = false;
            this.groupBoxAcc2.Text = "Rear Accumulator";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 29);
            this.label14.TabIndex = 35;
            this.label14.Text = "°C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 29);
            this.label15.TabIndex = 34;
            this.label15.Text = "°C";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(274, 203);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 29);
            this.label19.TabIndex = 33;
            this.label19.Text = "°C";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(274, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 29);
            this.label21.TabIndex = 32;
            this.label21.Text = "V";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(274, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 29);
            this.label22.TabIndex = 31;
            this.label22.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "V";
            // 
            // lblAcc2AvTemp
            // 
            this.lblAcc2AvTemp.AutoSize = true;
            this.lblAcc2AvTemp.Location = new System.Drawing.Point(208, 262);
            this.lblAcc2AvTemp.Name = "lblAcc2AvTemp";
            this.lblAcc2AvTemp.Size = new System.Drawing.Size(25, 29);
            this.lblAcc2AvTemp.TabIndex = 29;
            this.lblAcc2AvTemp.Text = "0";
            // 
            // lblAcc2MaxTemp
            // 
            this.lblAcc2MaxTemp.AutoSize = true;
            this.lblAcc2MaxTemp.Location = new System.Drawing.Point(208, 232);
            this.lblAcc2MaxTemp.Name = "lblAcc2MaxTemp";
            this.lblAcc2MaxTemp.Size = new System.Drawing.Size(25, 29);
            this.lblAcc2MaxTemp.TabIndex = 28;
            this.lblAcc2MaxTemp.Text = "0";
            // 
            // lblAcc2MinTemp
            // 
            this.lblAcc2MinTemp.AutoSize = true;
            this.lblAcc2MinTemp.Location = new System.Drawing.Point(208, 203);
            this.lblAcc2MinTemp.Name = "lblAcc2MinTemp";
            this.lblAcc2MinTemp.Size = new System.Drawing.Size(25, 29);
            this.lblAcc2MinTemp.TabIndex = 27;
            this.lblAcc2MinTemp.Text = "0";
            // 
            // lblAcc2AvVolts
            // 
            this.lblAcc2AvVolts.AutoSize = true;
            this.lblAcc2AvVolts.Location = new System.Drawing.Point(208, 105);
            this.lblAcc2AvVolts.Name = "lblAcc2AvVolts";
            this.lblAcc2AvVolts.Size = new System.Drawing.Size(25, 29);
            this.lblAcc2AvVolts.TabIndex = 26;
            this.lblAcc2AvVolts.Text = "0";
            // 
            // lblAcc2MaxVolts
            // 
            this.lblAcc2MaxVolts.AutoSize = true;
            this.lblAcc2MaxVolts.Location = new System.Drawing.Point(208, 75);
            this.lblAcc2MaxVolts.Name = "lblAcc2MaxVolts";
            this.lblAcc2MaxVolts.Size = new System.Drawing.Size(25, 29);
            this.lblAcc2MaxVolts.TabIndex = 25;
            this.lblAcc2MaxVolts.Text = "0";
            // 
            // lblAcc2MinVolts
            // 
            this.lblAcc2MinVolts.AutoSize = true;
            this.lblAcc2MinVolts.Location = new System.Drawing.Point(208, 46);
            this.lblAcc2MinVolts.Name = "lblAcc2MinVolts";
            this.lblAcc2MinVolts.Size = new System.Drawing.Size(25, 29);
            this.lblAcc2MinVolts.TabIndex = 24;
            this.lblAcc2MinVolts.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(21, 262);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(158, 29);
            this.label30.TabIndex = 23;
            this.label30.Text = "Average Temp:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(21, 232);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(121, 29);
            this.label31.TabIndex = 22;
            this.label31.Text = "Max Temp:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(21, 203);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(118, 29);
            this.label32.TabIndex = 21;
            this.label32.Text = "Min Temp:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(21, 105);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(179, 29);
            this.label33.TabIndex = 20;
            this.label33.Text = "Average Voltage:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(21, 75);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(142, 29);
            this.label34.TabIndex = 19;
            this.label34.Text = "Max Voltage:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(21, 46);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(139, 29);
            this.label35.TabIndex = 18;
            this.label35.Text = "Min Voltage:";
            // 
            // loggingStopStartButton
            // 
            this.loggingStopStartButton.Location = new System.Drawing.Point(429, 258);
            this.loggingStopStartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loggingStopStartButton.Name = "loggingStopStartButton";
            this.loggingStopStartButton.Size = new System.Drawing.Size(184, 43);
            this.loggingStopStartButton.TabIndex = 17;
            this.loggingStopStartButton.Text = "Start Logging";
            this.loggingStopStartButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxCAN
            // 
            this.groupBoxCAN.Controls.Add(this.rx_status_label);
            this.groupBoxCAN.Controls.Add(this.label20);
            this.groupBoxCAN.Location = new System.Drawing.Point(429, 134);
            this.groupBoxCAN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCAN.Name = "groupBoxCAN";
            this.groupBoxCAN.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCAN.Size = new System.Drawing.Size(261, 115);
            this.groupBoxCAN.TabIndex = 16;
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
            this.groupBoxSerialTimer.Location = new System.Drawing.Point(429, 9);
            this.groupBoxSerialTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSerialTimer.Name = "groupBoxSerialTimer";
            this.groupBoxSerialTimer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSerialTimer.Size = new System.Drawing.Size(261, 115);
            this.groupBoxSerialTimer.TabIndex = 15;
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
            this.groupBox4.Location = new System.Drawing.Point(12, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(405, 317);
            this.groupBox4.TabIndex = 14;
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
            this.label16.Location = new System.Drawing.Point(10, 111);
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
            this.groupBoxInverter1.Controls.Add(this.label46);
            this.groupBoxInverter1.Controls.Add(this.label48);
            this.groupBoxInverter1.Controls.Add(this.lblInv1Temp);
            this.groupBoxInverter1.Controls.Add(this.lblInv1Current);
            this.groupBoxInverter1.Controls.Add(this.label53);
            this.groupBoxInverter1.Controls.Add(this.label54);
            this.groupBoxInverter1.Location = new System.Drawing.Point(1059, 278);
            this.groupBoxInverter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter1.Name = "groupBoxInverter1";
            this.groupBoxInverter1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInverter1.Size = new System.Drawing.Size(308, 183);
            this.groupBoxInverter1.TabIndex = 10;
            this.groupBoxInverter1.TabStop = false;
            this.groupBoxInverter1.Text = "Inverter 1";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(264, 68);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(34, 29);
            this.label46.TabIndex = 41;
            this.label46.Text = "°C";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(264, 38);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(27, 29);
            this.label48.TabIndex = 39;
            this.label48.Text = "A";
            // 
            // lblInv1Temp
            // 
            this.lblInv1Temp.AutoSize = true;
            this.lblInv1Temp.Location = new System.Drawing.Point(196, 68);
            this.lblInv1Temp.Name = "lblInv1Temp";
            this.lblInv1Temp.Size = new System.Drawing.Size(25, 29);
            this.lblInv1Temp.TabIndex = 37;
            this.lblInv1Temp.Text = "0";
            // 
            // lblInv1Current
            // 
            this.lblInv1Current.AutoSize = true;
            this.lblInv1Current.Location = new System.Drawing.Point(196, 38);
            this.lblInv1Current.Name = "lblInv1Current";
            this.lblInv1Current.Size = new System.Drawing.Size(25, 29);
            this.lblInv1Current.TabIndex = 36;
            this.lblInv1Current.Text = "0";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(10, 68);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(146, 29);
            this.label53.TabIndex = 34;
            this.label53.Text = "Temperature:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(10, 38);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(94, 29);
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
            this.groupBoxAcc1.Location = new System.Drawing.Point(12, 337);
            this.groupBoxAcc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAcc1.Name = "groupBoxAcc1";
            this.groupBoxAcc1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAcc1.Size = new System.Drawing.Size(314, 337);
            this.groupBoxAcc1.TabIndex = 8;
            this.groupBoxAcc1.TabStop = false;
            this.groupBoxAcc1.Text = "Front Accumulator";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 29);
            this.label13.TabIndex = 17;
            this.label13.Text = "°C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 29);
            this.label12.TabIndex = 16;
            this.label12.Text = "°C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "°C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "V";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(267, 37);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(27, 29);
            this.label47.TabIndex = 12;
            this.label47.Text = "V";
            // 
            // lblAcc1AvTemp
            // 
            this.lblAcc1AvTemp.AutoSize = true;
            this.lblAcc1AvTemp.Location = new System.Drawing.Point(201, 252);
            this.lblAcc1AvTemp.Name = "lblAcc1AvTemp";
            this.lblAcc1AvTemp.Size = new System.Drawing.Size(25, 29);
            this.lblAcc1AvTemp.TabIndex = 11;
            this.lblAcc1AvTemp.Text = "0";
            // 
            // lblAcc1MaxTemp
            // 
            this.lblAcc1MaxTemp.AutoSize = true;
            this.lblAcc1MaxTemp.Location = new System.Drawing.Point(201, 223);
            this.lblAcc1MaxTemp.Name = "lblAcc1MaxTemp";
            this.lblAcc1MaxTemp.Size = new System.Drawing.Size(25, 29);
            this.lblAcc1MaxTemp.TabIndex = 10;
            this.lblAcc1MaxTemp.Text = "0";
            // 
            // lblAcc1MinTemp
            // 
            this.lblAcc1MinTemp.AutoSize = true;
            this.lblAcc1MinTemp.Location = new System.Drawing.Point(201, 194);
            this.lblAcc1MinTemp.Name = "lblAcc1MinTemp";
            this.lblAcc1MinTemp.Size = new System.Drawing.Size(25, 29);
            this.lblAcc1MinTemp.TabIndex = 9;
            this.lblAcc1MinTemp.Text = "0";
            // 
            // lblAcc1AvVolts
            // 
            this.lblAcc1AvVolts.AutoSize = true;
            this.lblAcc1AvVolts.Location = new System.Drawing.Point(201, 95);
            this.lblAcc1AvVolts.Name = "lblAcc1AvVolts";
            this.lblAcc1AvVolts.Size = new System.Drawing.Size(25, 29);
            this.lblAcc1AvVolts.TabIndex = 8;
            this.lblAcc1AvVolts.Text = "0";
            // 
            // lblAcc1MaxVolts
            // 
            this.lblAcc1MaxVolts.AutoSize = true;
            this.lblAcc1MaxVolts.Location = new System.Drawing.Point(201, 66);
            this.lblAcc1MaxVolts.Name = "lblAcc1MaxVolts";
            this.lblAcc1MaxVolts.Size = new System.Drawing.Size(25, 29);
            this.lblAcc1MaxVolts.TabIndex = 7;
            this.lblAcc1MaxVolts.Text = "0";
            // 
            // lblAcc1MinVolts
            // 
            this.lblAcc1MinVolts.AutoSize = true;
            this.lblAcc1MinVolts.Location = new System.Drawing.Point(201, 37);
            this.lblAcc1MinVolts.Name = "lblAcc1MinVolts";
            this.lblAcc1MinVolts.Size = new System.Drawing.Size(25, 29);
            this.lblAcc1MinVolts.TabIndex = 6;
            this.lblAcc1MinVolts.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(14, 252);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(158, 29);
            this.label49.TabIndex = 5;
            this.label49.Text = "Average Temp:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(14, 223);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(121, 29);
            this.label50.TabIndex = 4;
            this.label50.Text = "Max Temp:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(14, 194);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(118, 29);
            this.label51.TabIndex = 3;
            this.label51.Text = "Min Temp:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(14, 95);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(179, 29);
            this.label52.TabIndex = 2;
            this.label52.Text = "Average Voltage:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(14, 66);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(142, 29);
            this.label56.TabIndex = 1;
            this.label56.Text = "Max Voltage:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(14, 37);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(139, 29);
            this.label58.TabIndex = 0;
            this.label58.Text = "Min Voltage:";
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
            this.Accumulators_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.rearAccumulatorBricksGroupBox.Size = new System.Drawing.Size(458, 480);
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
            this.rearAccumulatorBrick6.Click += new System.EventHandler(this.rearAccumulatorBrick6_Click);
            // 
            // avgRearAccumulatorValue6
            // 
            this.avgRearAccumulatorValue6.AutoSize = true;
            this.avgRearAccumulatorValue6.Location = new System.Drawing.Point(350, 32);
            this.avgRearAccumulatorValue6.Name = "avgRearAccumulatorValue6";
            this.avgRearAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue6.TabIndex = 45;
            this.avgRearAccumulatorValue6.Text = "0";
            // 
            // minRearAccumulatorBrick6
            // 
            this.minRearAccumulatorBrick6.AutoSize = true;
            this.minRearAccumulatorBrick6.Location = new System.Drawing.Point(22, 32);
            this.minRearAccumulatorBrick6.Name = "minRearAccumulatorBrick6";
            this.minRearAccumulatorBrick6.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick6.TabIndex = 40;
            this.minRearAccumulatorBrick6.Text = "Min:";
            // 
            // avgRearAccumulatorBrick6
            // 
            this.avgRearAccumulatorBrick6.AutoSize = true;
            this.avgRearAccumulatorBrick6.Location = new System.Drawing.Point(285, 32);
            this.avgRearAccumulatorBrick6.Name = "avgRearAccumulatorBrick6";
            this.avgRearAccumulatorBrick6.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick6.TabIndex = 44;
            this.avgRearAccumulatorBrick6.Text = "Avg:";
            // 
            // minRearAccumulatorValue6
            // 
            this.minRearAccumulatorValue6.AutoSize = true;
            this.minRearAccumulatorValue6.Location = new System.Drawing.Point(88, 32);
            this.minRearAccumulatorValue6.Name = "minRearAccumulatorValue6";
            this.minRearAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue6.TabIndex = 41;
            this.minRearAccumulatorValue6.Text = "0";
            // 
            // maxRearAccumulatorValue6
            // 
            this.maxRearAccumulatorValue6.AutoSize = true;
            this.maxRearAccumulatorValue6.Location = new System.Drawing.Point(214, 32);
            this.maxRearAccumulatorValue6.Name = "maxRearAccumulatorValue6";
            this.maxRearAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue6.TabIndex = 43;
            this.maxRearAccumulatorValue6.Text = "0";
            // 
            // maxRearAccumulatorBrick6
            // 
            this.maxRearAccumulatorBrick6.AutoSize = true;
            this.maxRearAccumulatorBrick6.Location = new System.Drawing.Point(148, 32);
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
            this.rearAccumulatorBrick5.Click += new System.EventHandler(this.rearAccumulatorBrick5_Click);
            // 
            // avgRearAccumulatorValue5
            // 
            this.avgRearAccumulatorValue5.AutoSize = true;
            this.avgRearAccumulatorValue5.Location = new System.Drawing.Point(350, 32);
            this.avgRearAccumulatorValue5.Name = "avgRearAccumulatorValue5";
            this.avgRearAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue5.TabIndex = 39;
            this.avgRearAccumulatorValue5.Text = "0";
            // 
            // minRearAccumulatorBrick5
            // 
            this.minRearAccumulatorBrick5.AutoSize = true;
            this.minRearAccumulatorBrick5.Location = new System.Drawing.Point(22, 32);
            this.minRearAccumulatorBrick5.Name = "minRearAccumulatorBrick5";
            this.minRearAccumulatorBrick5.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick5.TabIndex = 34;
            this.minRearAccumulatorBrick5.Text = "Min:";
            // 
            // avgRearAccumulatorBrick5
            // 
            this.avgRearAccumulatorBrick5.AutoSize = true;
            this.avgRearAccumulatorBrick5.Location = new System.Drawing.Point(285, 32);
            this.avgRearAccumulatorBrick5.Name = "avgRearAccumulatorBrick5";
            this.avgRearAccumulatorBrick5.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick5.TabIndex = 38;
            this.avgRearAccumulatorBrick5.Text = "Avg:";
            // 
            // minRearAccumulatorValue5
            // 
            this.minRearAccumulatorValue5.AutoSize = true;
            this.minRearAccumulatorValue5.Location = new System.Drawing.Point(88, 32);
            this.minRearAccumulatorValue5.Name = "minRearAccumulatorValue5";
            this.minRearAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue5.TabIndex = 35;
            this.minRearAccumulatorValue5.Text = "0";
            // 
            // maxRearAccumulatorValue5
            // 
            this.maxRearAccumulatorValue5.AutoSize = true;
            this.maxRearAccumulatorValue5.Location = new System.Drawing.Point(214, 32);
            this.maxRearAccumulatorValue5.Name = "maxRearAccumulatorValue5";
            this.maxRearAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue5.TabIndex = 37;
            this.maxRearAccumulatorValue5.Text = "0";
            // 
            // maxRearAccumulatorBrick5
            // 
            this.maxRearAccumulatorBrick5.AutoSize = true;
            this.maxRearAccumulatorBrick5.Location = new System.Drawing.Point(148, 32);
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
            this.rearAccumulatorBrick4.Click += new System.EventHandler(this.rearAccumulatorBrick4_Click);
            // 
            // avgRearAccumulatorValue4
            // 
            this.avgRearAccumulatorValue4.AutoSize = true;
            this.avgRearAccumulatorValue4.Location = new System.Drawing.Point(350, 32);
            this.avgRearAccumulatorValue4.Name = "avgRearAccumulatorValue4";
            this.avgRearAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue4.TabIndex = 33;
            this.avgRearAccumulatorValue4.Text = "0";
            // 
            // minRearAccumulatorBrick4
            // 
            this.minRearAccumulatorBrick4.AutoSize = true;
            this.minRearAccumulatorBrick4.Location = new System.Drawing.Point(22, 32);
            this.minRearAccumulatorBrick4.Name = "minRearAccumulatorBrick4";
            this.minRearAccumulatorBrick4.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick4.TabIndex = 28;
            this.minRearAccumulatorBrick4.Text = "Min:";
            // 
            // avgRearAccumulatorBrick4
            // 
            this.avgRearAccumulatorBrick4.AutoSize = true;
            this.avgRearAccumulatorBrick4.Location = new System.Drawing.Point(285, 32);
            this.avgRearAccumulatorBrick4.Name = "avgRearAccumulatorBrick4";
            this.avgRearAccumulatorBrick4.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick4.TabIndex = 32;
            this.avgRearAccumulatorBrick4.Text = "Avg:";
            // 
            // minRearAccumulatorValue4
            // 
            this.minRearAccumulatorValue4.AutoSize = true;
            this.minRearAccumulatorValue4.Location = new System.Drawing.Point(88, 32);
            this.minRearAccumulatorValue4.Name = "minRearAccumulatorValue4";
            this.minRearAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue4.TabIndex = 29;
            this.minRearAccumulatorValue4.Text = "0";
            // 
            // maxRearAccumulatorValue4
            // 
            this.maxRearAccumulatorValue4.AutoSize = true;
            this.maxRearAccumulatorValue4.Location = new System.Drawing.Point(214, 32);
            this.maxRearAccumulatorValue4.Name = "maxRearAccumulatorValue4";
            this.maxRearAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue4.TabIndex = 31;
            this.maxRearAccumulatorValue4.Text = "0";
            // 
            // maxRearAccumulatorBrick4
            // 
            this.maxRearAccumulatorBrick4.AutoSize = true;
            this.maxRearAccumulatorBrick4.Location = new System.Drawing.Point(148, 32);
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
            this.rearAccumulatorBrick3.Location = new System.Drawing.Point(28, 185);
            this.rearAccumulatorBrick3.Name = "rearAccumulatorBrick3";
            this.rearAccumulatorBrick3.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick3.TabIndex = 2;
            this.rearAccumulatorBrick3.TabStop = false;
            this.rearAccumulatorBrick3.Text = "Rear Accumulator Brick 3";
            this.rearAccumulatorBrick3.Click += new System.EventHandler(this.rearAccumulatorBrick3_Click);
            // 
            // avgRearAccumulatorValue3
            // 
            this.avgRearAccumulatorValue3.AutoSize = true;
            this.avgRearAccumulatorValue3.Location = new System.Drawing.Point(350, 35);
            this.avgRearAccumulatorValue3.Name = "avgRearAccumulatorValue3";
            this.avgRearAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue3.TabIndex = 27;
            this.avgRearAccumulatorValue3.Text = "0";
            // 
            // minRearAccumulatorBrick3
            // 
            this.minRearAccumulatorBrick3.AutoSize = true;
            this.minRearAccumulatorBrick3.Location = new System.Drawing.Point(22, 35);
            this.minRearAccumulatorBrick3.Name = "minRearAccumulatorBrick3";
            this.minRearAccumulatorBrick3.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick3.TabIndex = 22;
            this.minRearAccumulatorBrick3.Text = "Min:";
            // 
            // avgRearAccumulatorBrick3
            // 
            this.avgRearAccumulatorBrick3.AutoSize = true;
            this.avgRearAccumulatorBrick3.Location = new System.Drawing.Point(285, 35);
            this.avgRearAccumulatorBrick3.Name = "avgRearAccumulatorBrick3";
            this.avgRearAccumulatorBrick3.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick3.TabIndex = 26;
            this.avgRearAccumulatorBrick3.Text = "Avg:";
            // 
            // minRearAccumulatorValue3
            // 
            this.minRearAccumulatorValue3.AutoSize = true;
            this.minRearAccumulatorValue3.Location = new System.Drawing.Point(88, 35);
            this.minRearAccumulatorValue3.Name = "minRearAccumulatorValue3";
            this.minRearAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue3.TabIndex = 23;
            this.minRearAccumulatorValue3.Text = "0";
            // 
            // maxRearAccumulatorValue3
            // 
            this.maxRearAccumulatorValue3.AutoSize = true;
            this.maxRearAccumulatorValue3.Location = new System.Drawing.Point(214, 35);
            this.maxRearAccumulatorValue3.Name = "maxRearAccumulatorValue3";
            this.maxRearAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue3.TabIndex = 25;
            this.maxRearAccumulatorValue3.Text = "0";
            // 
            // maxRearAccumulatorBrick3
            // 
            this.maxRearAccumulatorBrick3.AutoSize = true;
            this.maxRearAccumulatorBrick3.Location = new System.Drawing.Point(148, 35);
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
            this.rearAccumulatorBrick2.Location = new System.Drawing.Point(28, 109);
            this.rearAccumulatorBrick2.Name = "rearAccumulatorBrick2";
            this.rearAccumulatorBrick2.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick2.TabIndex = 1;
            this.rearAccumulatorBrick2.TabStop = false;
            this.rearAccumulatorBrick2.Text = "Rear Accumulator Brick 2";
            this.rearAccumulatorBrick2.Click += new System.EventHandler(this.rearAccumulatorBrick2_Click);
            // 
            // avgRearAccumulatorValue2
            // 
            this.avgRearAccumulatorValue2.AutoSize = true;
            this.avgRearAccumulatorValue2.Location = new System.Drawing.Point(350, 32);
            this.avgRearAccumulatorValue2.Name = "avgRearAccumulatorValue2";
            this.avgRearAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue2.TabIndex = 21;
            this.avgRearAccumulatorValue2.Text = "0";
            // 
            // minRearAccumulatorBrick2
            // 
            this.minRearAccumulatorBrick2.AutoSize = true;
            this.minRearAccumulatorBrick2.Location = new System.Drawing.Point(22, 32);
            this.minRearAccumulatorBrick2.Name = "minRearAccumulatorBrick2";
            this.minRearAccumulatorBrick2.Size = new System.Drawing.Size(59, 29);
            this.minRearAccumulatorBrick2.TabIndex = 16;
            this.minRearAccumulatorBrick2.Text = "Min:";
            // 
            // avgRearAccumulatorBrick2
            // 
            this.avgRearAccumulatorBrick2.AutoSize = true;
            this.avgRearAccumulatorBrick2.Location = new System.Drawing.Point(285, 32);
            this.avgRearAccumulatorBrick2.Name = "avgRearAccumulatorBrick2";
            this.avgRearAccumulatorBrick2.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick2.TabIndex = 20;
            this.avgRearAccumulatorBrick2.Text = "Avg:";
            // 
            // minRearAccumulatorValue2
            // 
            this.minRearAccumulatorValue2.AutoSize = true;
            this.minRearAccumulatorValue2.Location = new System.Drawing.Point(88, 32);
            this.minRearAccumulatorValue2.Name = "minRearAccumulatorValue2";
            this.minRearAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue2.TabIndex = 17;
            this.minRearAccumulatorValue2.Text = "0";
            // 
            // maxRearAccumulatorValue2
            // 
            this.maxRearAccumulatorValue2.AutoSize = true;
            this.maxRearAccumulatorValue2.Location = new System.Drawing.Point(214, 32);
            this.maxRearAccumulatorValue2.Name = "maxRearAccumulatorValue2";
            this.maxRearAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue2.TabIndex = 19;
            this.maxRearAccumulatorValue2.Text = "0";
            // 
            // maxRearAccumulatorBrick2
            // 
            this.maxRearAccumulatorBrick2.AutoSize = true;
            this.maxRearAccumulatorBrick2.Location = new System.Drawing.Point(148, 32);
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
            this.rearAccumulatorBrick1.Location = new System.Drawing.Point(28, 35);
            this.rearAccumulatorBrick1.Name = "rearAccumulatorBrick1";
            this.rearAccumulatorBrick1.Size = new System.Drawing.Size(405, 68);
            this.rearAccumulatorBrick1.TabIndex = 0;
            this.rearAccumulatorBrick1.TabStop = false;
            this.rearAccumulatorBrick1.Text = "Rear Accumulator Brick 1";
            this.rearAccumulatorBrick1.Click += new System.EventHandler(this.rearAccumulatorBrick1_Click);
            // 
            // avgRearAccumulatorValue1
            // 
            this.avgRearAccumulatorValue1.AutoSize = true;
            this.avgRearAccumulatorValue1.Location = new System.Drawing.Point(350, 32);
            this.avgRearAccumulatorValue1.Name = "avgRearAccumulatorValue1";
            this.avgRearAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.avgRearAccumulatorValue1.TabIndex = 15;
            this.avgRearAccumulatorValue1.Text = "0";
            // 
            // avgRearAccumulatorBrick1
            // 
            this.avgRearAccumulatorBrick1.AutoSize = true;
            this.avgRearAccumulatorBrick1.Location = new System.Drawing.Point(285, 32);
            this.avgRearAccumulatorBrick1.Name = "avgRearAccumulatorBrick1";
            this.avgRearAccumulatorBrick1.Size = new System.Drawing.Size(55, 29);
            this.avgRearAccumulatorBrick1.TabIndex = 14;
            this.avgRearAccumulatorBrick1.Text = "Avg:";
            // 
            // maxRearAccumulatorValue1
            // 
            this.maxRearAccumulatorValue1.AutoSize = true;
            this.maxRearAccumulatorValue1.Location = new System.Drawing.Point(214, 32);
            this.maxRearAccumulatorValue1.Name = "maxRearAccumulatorValue1";
            this.maxRearAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue1.TabIndex = 13;
            this.maxRearAccumulatorValue1.Text = "0";
            // 
            // maxRearAccumulatorBrick1
            // 
            this.maxRearAccumulatorBrick1.AutoSize = true;
            this.maxRearAccumulatorBrick1.Location = new System.Drawing.Point(148, 32);
            this.maxRearAccumulatorBrick1.Name = "maxRearAccumulatorBrick1";
            this.maxRearAccumulatorBrick1.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorBrick1.TabIndex = 12;
            this.maxRearAccumulatorBrick1.Text = "Max:";
            // 
            // minRearAccumulatorValue1
            // 
            this.minRearAccumulatorValue1.AutoSize = true;
            this.minRearAccumulatorValue1.Location = new System.Drawing.Point(88, 32);
            this.minRearAccumulatorValue1.Name = "minRearAccumulatorValue1";
            this.minRearAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.minRearAccumulatorValue1.TabIndex = 11;
            this.minRearAccumulatorValue1.Text = "0";
            // 
            // minRearAccumulatorBrick1
            // 
            this.minRearAccumulatorBrick1.AutoSize = true;
            this.minRearAccumulatorBrick1.Location = new System.Drawing.Point(22, 32);
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
            this.frontAccumulatorBricksGroupBox.Size = new System.Drawing.Size(458, 483);
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
            this.avgFrontAccumulatorValue6.Location = new System.Drawing.Point(350, 32);
            this.avgFrontAccumulatorValue6.Name = "avgFrontAccumulatorValue6";
            this.avgFrontAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue6.TabIndex = 39;
            this.avgFrontAccumulatorValue6.Text = "0";
            // 
            // minFrontAccumulatorBrick6
            // 
            this.minFrontAccumulatorBrick6.AutoSize = true;
            this.minFrontAccumulatorBrick6.Location = new System.Drawing.Point(22, 32);
            this.minFrontAccumulatorBrick6.Name = "minFrontAccumulatorBrick6";
            this.minFrontAccumulatorBrick6.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick6.TabIndex = 34;
            this.minFrontAccumulatorBrick6.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick6
            // 
            this.avgFrontAccumulatorBrick6.AutoSize = true;
            this.avgFrontAccumulatorBrick6.Location = new System.Drawing.Point(285, 32);
            this.avgFrontAccumulatorBrick6.Name = "avgFrontAccumulatorBrick6";
            this.avgFrontAccumulatorBrick6.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick6.TabIndex = 38;
            this.avgFrontAccumulatorBrick6.Text = "Avg:";
            // 
            // minFrontAccumulatorValue6
            // 
            this.minFrontAccumulatorValue6.AutoSize = true;
            this.minFrontAccumulatorValue6.Location = new System.Drawing.Point(88, 32);
            this.minFrontAccumulatorValue6.Name = "minFrontAccumulatorValue6";
            this.minFrontAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue6.TabIndex = 35;
            this.minFrontAccumulatorValue6.Text = "0";
            // 
            // maxFrontAccumulatorValue6
            // 
            this.maxFrontAccumulatorValue6.AutoSize = true;
            this.maxFrontAccumulatorValue6.Location = new System.Drawing.Point(214, 32);
            this.maxFrontAccumulatorValue6.Name = "maxFrontAccumulatorValue6";
            this.maxFrontAccumulatorValue6.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue6.TabIndex = 37;
            this.maxFrontAccumulatorValue6.Text = "0";
            // 
            // maxFrontAccumulatorBrick6
            // 
            this.maxFrontAccumulatorBrick6.AutoSize = true;
            this.maxFrontAccumulatorBrick6.Location = new System.Drawing.Point(148, 32);
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
            this.avgFrontAccumulatorValue5.Location = new System.Drawing.Point(350, 32);
            this.avgFrontAccumulatorValue5.Name = "avgFrontAccumulatorValue5";
            this.avgFrontAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue5.TabIndex = 33;
            this.avgFrontAccumulatorValue5.Text = "0";
            // 
            // minFrontAccumulatorBrick5
            // 
            this.minFrontAccumulatorBrick5.AutoSize = true;
            this.minFrontAccumulatorBrick5.Location = new System.Drawing.Point(22, 32);
            this.minFrontAccumulatorBrick5.Name = "minFrontAccumulatorBrick5";
            this.minFrontAccumulatorBrick5.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick5.TabIndex = 28;
            this.minFrontAccumulatorBrick5.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick5
            // 
            this.avgFrontAccumulatorBrick5.AutoSize = true;
            this.avgFrontAccumulatorBrick5.Location = new System.Drawing.Point(285, 32);
            this.avgFrontAccumulatorBrick5.Name = "avgFrontAccumulatorBrick5";
            this.avgFrontAccumulatorBrick5.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick5.TabIndex = 32;
            this.avgFrontAccumulatorBrick5.Text = "Avg:";
            // 
            // minFrontAccumulatorValue5
            // 
            this.minFrontAccumulatorValue5.AutoSize = true;
            this.minFrontAccumulatorValue5.Location = new System.Drawing.Point(88, 32);
            this.minFrontAccumulatorValue5.Name = "minFrontAccumulatorValue5";
            this.minFrontAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue5.TabIndex = 29;
            this.minFrontAccumulatorValue5.Text = "0";
            // 
            // maxFrontAccumulatorValue5
            // 
            this.maxFrontAccumulatorValue5.AutoSize = true;
            this.maxFrontAccumulatorValue5.Location = new System.Drawing.Point(214, 32);
            this.maxFrontAccumulatorValue5.Name = "maxFrontAccumulatorValue5";
            this.maxFrontAccumulatorValue5.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue5.TabIndex = 31;
            this.maxFrontAccumulatorValue5.Text = "0";
            // 
            // maxFrontAccumulatorBrick5
            // 
            this.maxFrontAccumulatorBrick5.AutoSize = true;
            this.maxFrontAccumulatorBrick5.Location = new System.Drawing.Point(148, 32);
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
            this.avgFrontAccumulatorValue4.Location = new System.Drawing.Point(350, 32);
            this.avgFrontAccumulatorValue4.Name = "avgFrontAccumulatorValue4";
            this.avgFrontAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue4.TabIndex = 27;
            this.avgFrontAccumulatorValue4.Text = "0";
            // 
            // minFrontAccumulatorBrick4
            // 
            this.minFrontAccumulatorBrick4.AutoSize = true;
            this.minFrontAccumulatorBrick4.Location = new System.Drawing.Point(22, 32);
            this.minFrontAccumulatorBrick4.Name = "minFrontAccumulatorBrick4";
            this.minFrontAccumulatorBrick4.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick4.TabIndex = 22;
            this.minFrontAccumulatorBrick4.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick4
            // 
            this.avgFrontAccumulatorBrick4.AutoSize = true;
            this.avgFrontAccumulatorBrick4.Location = new System.Drawing.Point(285, 32);
            this.avgFrontAccumulatorBrick4.Name = "avgFrontAccumulatorBrick4";
            this.avgFrontAccumulatorBrick4.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick4.TabIndex = 26;
            this.avgFrontAccumulatorBrick4.Text = "Avg:";
            // 
            // minFrontAccumulatorValue4
            // 
            this.minFrontAccumulatorValue4.AutoSize = true;
            this.minFrontAccumulatorValue4.Location = new System.Drawing.Point(88, 32);
            this.minFrontAccumulatorValue4.Name = "minFrontAccumulatorValue4";
            this.minFrontAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue4.TabIndex = 23;
            this.minFrontAccumulatorValue4.Text = "0";
            // 
            // maxFrontAccumulatorValue4
            // 
            this.maxFrontAccumulatorValue4.AutoSize = true;
            this.maxFrontAccumulatorValue4.Location = new System.Drawing.Point(214, 32);
            this.maxFrontAccumulatorValue4.Name = "maxFrontAccumulatorValue4";
            this.maxFrontAccumulatorValue4.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue4.TabIndex = 25;
            this.maxFrontAccumulatorValue4.Text = "0";
            // 
            // maxFrontAccumulatorBrick4
            // 
            this.maxFrontAccumulatorBrick4.AutoSize = true;
            this.maxFrontAccumulatorBrick4.Location = new System.Drawing.Point(148, 32);
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
            this.frontAccumulatorBrick3.Location = new System.Drawing.Point(28, 185);
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
            this.avgFrontAccumulatorValue3.Location = new System.Drawing.Point(350, 32);
            this.avgFrontAccumulatorValue3.Name = "avgFrontAccumulatorValue3";
            this.avgFrontAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue3.TabIndex = 21;
            this.avgFrontAccumulatorValue3.Text = "0";
            // 
            // minFrontAccumulatorBrick3
            // 
            this.minFrontAccumulatorBrick3.AutoSize = true;
            this.minFrontAccumulatorBrick3.Location = new System.Drawing.Point(22, 32);
            this.minFrontAccumulatorBrick3.Name = "minFrontAccumulatorBrick3";
            this.minFrontAccumulatorBrick3.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorBrick3.TabIndex = 16;
            this.minFrontAccumulatorBrick3.Text = "Min:";
            // 
            // avgFrontAccumulatorBrick3
            // 
            this.avgFrontAccumulatorBrick3.AutoSize = true;
            this.avgFrontAccumulatorBrick3.Location = new System.Drawing.Point(285, 32);
            this.avgFrontAccumulatorBrick3.Name = "avgFrontAccumulatorBrick3";
            this.avgFrontAccumulatorBrick3.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick3.TabIndex = 20;
            this.avgFrontAccumulatorBrick3.Text = "Avg:";
            // 
            // minFrontAccumulatorValue3
            // 
            this.minFrontAccumulatorValue3.AutoSize = true;
            this.minFrontAccumulatorValue3.Location = new System.Drawing.Point(88, 32);
            this.minFrontAccumulatorValue3.Name = "minFrontAccumulatorValue3";
            this.minFrontAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue3.TabIndex = 17;
            this.minFrontAccumulatorValue3.Text = "0";
            // 
            // maxFrontAccumulatorValue3
            // 
            this.maxFrontAccumulatorValue3.AutoSize = true;
            this.maxFrontAccumulatorValue3.Location = new System.Drawing.Point(214, 32);
            this.maxFrontAccumulatorValue3.Name = "maxFrontAccumulatorValue3";
            this.maxFrontAccumulatorValue3.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue3.TabIndex = 19;
            this.maxFrontAccumulatorValue3.Text = "0";
            // 
            // maxFrontAccumulatorBrick3
            // 
            this.maxFrontAccumulatorBrick3.AutoSize = true;
            this.maxFrontAccumulatorBrick3.Location = new System.Drawing.Point(148, 32);
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
            this.frontAccumulatorBrick2.Location = new System.Drawing.Point(28, 109);
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
            this.avgFrontAccumulatorValue2.Location = new System.Drawing.Point(350, 32);
            this.avgFrontAccumulatorValue2.Name = "avgFrontAccumulatorValue2";
            this.avgFrontAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue2.TabIndex = 15;
            this.avgFrontAccumulatorValue2.Text = "0";
            // 
            // avgFrontAccumulatorBrick2
            // 
            this.avgFrontAccumulatorBrick2.AutoSize = true;
            this.avgFrontAccumulatorBrick2.Location = new System.Drawing.Point(285, 32);
            this.avgFrontAccumulatorBrick2.Name = "avgFrontAccumulatorBrick2";
            this.avgFrontAccumulatorBrick2.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick2.TabIndex = 14;
            this.avgFrontAccumulatorBrick2.Text = "Avg:";
            // 
            // maxFrontAccumulatorValue2
            // 
            this.maxFrontAccumulatorValue2.AutoSize = true;
            this.maxFrontAccumulatorValue2.Location = new System.Drawing.Point(214, 32);
            this.maxFrontAccumulatorValue2.Name = "maxFrontAccumulatorValue2";
            this.maxFrontAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue2.TabIndex = 13;
            this.maxFrontAccumulatorValue2.Text = "0";
            // 
            // maxFrontAccumulatorBrick2
            // 
            this.maxFrontAccumulatorBrick2.AutoSize = true;
            this.maxFrontAccumulatorBrick2.Location = new System.Drawing.Point(148, 32);
            this.maxFrontAccumulatorBrick2.Name = "maxFrontAccumulatorBrick2";
            this.maxFrontAccumulatorBrick2.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick2.TabIndex = 12;
            this.maxFrontAccumulatorBrick2.Text = "Max:";
            // 
            // minFrontAccumulatorValue2
            // 
            this.minFrontAccumulatorValue2.AutoSize = true;
            this.minFrontAccumulatorValue2.Location = new System.Drawing.Point(88, 32);
            this.minFrontAccumulatorValue2.Name = "minFrontAccumulatorValue2";
            this.minFrontAccumulatorValue2.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue2.TabIndex = 11;
            this.minFrontAccumulatorValue2.Text = "0";
            // 
            // minFrontAccumulatorBrick2
            // 
            this.minFrontAccumulatorBrick2.AutoSize = true;
            this.minFrontAccumulatorBrick2.Location = new System.Drawing.Point(22, 32);
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
            this.frontAccumulatorBrick1.Location = new System.Drawing.Point(28, 35);
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
            this.avgFrontAccumulatorValue1.Location = new System.Drawing.Point(350, 32);
            this.avgFrontAccumulatorValue1.Name = "avgFrontAccumulatorValue1";
            this.avgFrontAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.avgFrontAccumulatorValue1.TabIndex = 9;
            this.avgFrontAccumulatorValue1.Text = "0";
            // 
            // avgFrontAccumulatorBrick1
            // 
            this.avgFrontAccumulatorBrick1.AutoSize = true;
            this.avgFrontAccumulatorBrick1.Location = new System.Drawing.Point(285, 32);
            this.avgFrontAccumulatorBrick1.Name = "avgFrontAccumulatorBrick1";
            this.avgFrontAccumulatorBrick1.Size = new System.Drawing.Size(55, 29);
            this.avgFrontAccumulatorBrick1.TabIndex = 8;
            this.avgFrontAccumulatorBrick1.Text = "Avg:";
            // 
            // maxFrontAccumulatorValue1
            // 
            this.maxFrontAccumulatorValue1.AutoSize = true;
            this.maxFrontAccumulatorValue1.Location = new System.Drawing.Point(214, 32);
            this.maxFrontAccumulatorValue1.Name = "maxFrontAccumulatorValue1";
            this.maxFrontAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorValue1.TabIndex = 7;
            this.maxFrontAccumulatorValue1.Text = "0";
            // 
            // maxFrontAccumulatorBrick1
            // 
            this.maxFrontAccumulatorBrick1.AutoSize = true;
            this.maxFrontAccumulatorBrick1.Location = new System.Drawing.Point(148, 32);
            this.maxFrontAccumulatorBrick1.Name = "maxFrontAccumulatorBrick1";
            this.maxFrontAccumulatorBrick1.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorBrick1.TabIndex = 6;
            this.maxFrontAccumulatorBrick1.Text = "Max:";
            // 
            // minFrontAccumulatorValue1
            // 
            this.minFrontAccumulatorValue1.AutoSize = true;
            this.minFrontAccumulatorValue1.Location = new System.Drawing.Point(88, 32);
            this.minFrontAccumulatorValue1.Name = "minFrontAccumulatorValue1";
            this.minFrontAccumulatorValue1.Size = new System.Drawing.Size(25, 29);
            this.minFrontAccumulatorValue1.TabIndex = 5;
            this.minFrontAccumulatorValue1.Text = "0";
            // 
            // minFrontAccumulatorBrick1
            // 
            this.minFrontAccumulatorBrick1.AutoSize = true;
            this.minFrontAccumulatorBrick1.Location = new System.Drawing.Point(22, 32);
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
            this.rearAccumulatorGroupBox.Location = new System.Drawing.Point(50, 425);
            this.rearAccumulatorGroupBox.Name = "rearAccumulatorGroupBox";
            this.rearAccumulatorGroupBox.Size = new System.Drawing.Size(280, 312);
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
            this.maxRearAccumulatorValue.Location = new System.Drawing.Point(128, 142);
            this.maxRearAccumulatorValue.Name = "maxRearAccumulatorValue";
            this.maxRearAccumulatorValue.Size = new System.Drawing.Size(25, 29);
            this.maxRearAccumulatorValue.TabIndex = 4;
            this.maxRearAccumulatorValue.Text = "0";
            // 
            // minRearAccumulatorValue
            // 
            this.minRearAccumulatorValue.AutoSize = true;
            this.minRearAccumulatorValue.Location = new System.Drawing.Point(128, 69);
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
            this.maxRearAccumulatorLabel.Location = new System.Drawing.Point(30, 142);
            this.maxRearAccumulatorLabel.Name = "maxRearAccumulatorLabel";
            this.maxRearAccumulatorLabel.Size = new System.Drawing.Size(62, 29);
            this.maxRearAccumulatorLabel.TabIndex = 1;
            this.maxRearAccumulatorLabel.Text = "Max:";
            // 
            // minRearAccumulatorLabel
            // 
            this.minRearAccumulatorLabel.AutoSize = true;
            this.minRearAccumulatorLabel.Location = new System.Drawing.Point(30, 69);
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
            this.frontAccumulatorGroupBox.Location = new System.Drawing.Point(50, 38);
            this.frontAccumulatorGroupBox.Name = "frontAccumulatorGroupBox";
            this.frontAccumulatorGroupBox.Size = new System.Drawing.Size(280, 312);
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
            this.maxFrontAccumulatorsValue.Location = new System.Drawing.Point(128, 142);
            this.maxFrontAccumulatorsValue.Name = "maxFrontAccumulatorsValue";
            this.maxFrontAccumulatorsValue.Size = new System.Drawing.Size(25, 29);
            this.maxFrontAccumulatorsValue.TabIndex = 4;
            this.maxFrontAccumulatorsValue.Text = "0";
            // 
            // minFrontAccumulatorValue
            // 
            this.minFrontAccumulatorValue.AutoSize = true;
            this.minFrontAccumulatorValue.Location = new System.Drawing.Point(128, 69);
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
            this.maxFrontAccumulatorsLabel.Location = new System.Drawing.Point(30, 142);
            this.maxFrontAccumulatorsLabel.Name = "maxFrontAccumulatorsLabel";
            this.maxFrontAccumulatorsLabel.Size = new System.Drawing.Size(62, 29);
            this.maxFrontAccumulatorsLabel.TabIndex = 1;
            this.maxFrontAccumulatorsLabel.Text = "Max:";
            // 
            // minFrontAccumulatorsLabel
            // 
            this.minFrontAccumulatorsLabel.AutoSize = true;
            this.minFrontAccumulatorsLabel.Location = new System.Drawing.Point(30, 69);
            this.minFrontAccumulatorsLabel.Name = "minFrontAccumulatorsLabel";
            this.minFrontAccumulatorsLabel.Size = new System.Drawing.Size(59, 29);
            this.minFrontAccumulatorsLabel.TabIndex = 0;
            this.minFrontAccumulatorsLabel.Text = "Min:";
            // 
            // Inverters_Tab
            // 
            this.Inverters_Tab.Controls.Add(this.tableLayoutPanel2);
            this.Inverters_Tab.Location = new System.Drawing.Point(4, 38);
            this.Inverters_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inverters_Tab.Name = "Inverters_Tab";
            this.Inverters_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inverters_Tab.Size = new System.Drawing.Size(1872, 998);
            this.Inverters_Tab.TabIndex = 2;
            this.Inverters_Tab.Text = "Inverters";
            this.Inverters_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1866, 998);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front Left";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox15);
            this.groupBox2.Controls.Add(this.groupBox17);
            this.groupBox2.Location = new System.Drawing.Point(3, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rear Left";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.groupBox13);
            this.groupBox3.Location = new System.Drawing.Point(936, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(927, 493);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Front Right";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox19);
            this.groupBox6.Controls.Add(this.groupBox21);
            this.groupBox6.Location = new System.Drawing.Point(936, 502);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(927, 488);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rear Right";
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
            this.TorqueVectoring_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 229);
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
            this.GLV_Tab.Size = new System.Drawing.Size(1872, 998);
            this.GLV_Tab.TabIndex = 4;
            this.GLV_Tab.Text = "Power Management";
            this.GLV_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.54749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.45251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl2, 3, 2);
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
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl8, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl9, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl10, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl11, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl12, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.PMtripControl13, 3, 13);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1852, 982);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PMtripControl6
            // 
            this.PMtripControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl6.DecimalPlaces = 1;
            this.PMtripControl6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl6.Location = new System.Drawing.Point(543, 443);
            this.PMtripControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl6.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl6.Name = "PMtripControl6";
            this.PMtripControl6.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl6.TabIndex = 84;
            this.PMtripControl6.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl5
            // 
            this.PMtripControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl5.DecimalPlaces = 1;
            this.PMtripControl5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl5.Location = new System.Drawing.Point(543, 375);
            this.PMtripControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl5.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl5.Name = "PMtripControl5";
            this.PMtripControl5.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl5.TabIndex = 82;
            this.PMtripControl5.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl4
            // 
            this.PMtripControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl4.DecimalPlaces = 1;
            this.PMtripControl4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl4.Location = new System.Drawing.Point(543, 307);
            this.PMtripControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl4.Name = "PMtripControl4";
            this.PMtripControl4.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl4.TabIndex = 80;
            this.PMtripControl4.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl3
            // 
            this.PMtripControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl3.DecimalPlaces = 1;
            this.PMtripControl3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl3.Location = new System.Drawing.Point(543, 239);
            this.PMtripControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl3.Name = "PMtripControl3";
            this.PMtripControl3.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl3.TabIndex = 78;
            this.PMtripControl3.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl2
            // 
            this.PMtripControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl2.DecimalPlaces = 1;
            this.PMtripControl2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl2.Location = new System.Drawing.Point(543, 171);
            this.PMtripControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl2.Name = "PMtripControl2";
            this.PMtripControl2.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl2.TabIndex = 76;
            this.PMtripControl2.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMnameBox4
            // 
            this.PMnameBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox4.Location = new System.Drawing.Point(146, 307);
            this.PMnameBox4.MaxLength = 16;
            this.PMnameBox4.Name = "PMnameBox4";
            this.PMnameBox4.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox4.TabIndex = 68;
            // 
            // PMnameBox3
            // 
            this.PMnameBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox3.Location = new System.Drawing.Point(146, 239);
            this.PMnameBox3.MaxLength = 16;
            this.PMnameBox3.Name = "PMnameBox3";
            this.PMnameBox3.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox3.TabIndex = 65;
            // 
            // PMnameBox2
            // 
            this.PMnameBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox2.Location = new System.Drawing.Point(146, 171);
            this.PMnameBox2.MaxLength = 16;
            this.PMnameBox2.Name = "PMnameBox2";
            this.PMnameBox2.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox2.TabIndex = 62;
            // 
            // PMtypeLabel2
            // 
            this.PMtypeLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel2.AutoSize = true;
            this.PMtypeLabel2.Location = new System.Drawing.Point(375, 175);
            this.PMtypeLabel2.Name = "PMtypeLabel2";
            this.PMtypeLabel2.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel2.TabIndex = 51;
            this.PMtypeLabel2.Text = "High Current";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1598, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(219, 29);
            this.label28.TabIndex = 6;
            this.label28.Text = "Current Draw (Amps)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1453, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 29);
            this.label27.TabIndex = 5;
            this.label27.Text = "Status";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1049, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 29);
            this.label26.TabIndex = 4;
            this.label26.Text = "Effort";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(567, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 29);
            this.label23.TabIndex = 3;
            this.label23.Text = "Trip Current";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 29);
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
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Channel";
            // 
            // PMnameBox1
            // 
            this.PMnameBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox1.Location = new System.Drawing.Point(146, 103);
            this.PMnameBox1.MaxLength = 16;
            this.PMnameBox1.Name = "PMnameBox1";
            this.PMnameBox1.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox1.TabIndex = 7;
            // 
            // PMchannelLabel1
            // 
            this.PMchannelLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel1.AutoSize = true;
            this.PMchannelLabel1.Location = new System.Drawing.Point(59, 107);
            this.PMchannelLabel1.Name = "PMchannelLabel1";
            this.PMchannelLabel1.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel1.TabIndex = 8;
            this.PMchannelLabel1.Text = "1";
            // 
            // PMchannelLabel2
            // 
            this.PMchannelLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel2.AutoSize = true;
            this.PMchannelLabel2.Location = new System.Drawing.Point(59, 175);
            this.PMchannelLabel2.Name = "PMchannelLabel2";
            this.PMchannelLabel2.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel2.TabIndex = 9;
            this.PMchannelLabel2.Text = "2";
            // 
            // PMchannelLabel3
            // 
            this.PMchannelLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel3.AutoSize = true;
            this.PMchannelLabel3.Location = new System.Drawing.Point(59, 243);
            this.PMchannelLabel3.Name = "PMchannelLabel3";
            this.PMchannelLabel3.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel3.TabIndex = 10;
            this.PMchannelLabel3.Text = "3";
            // 
            // PMchannelLabel4
            // 
            this.PMchannelLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel4.AutoSize = true;
            this.PMchannelLabel4.Location = new System.Drawing.Point(59, 311);
            this.PMchannelLabel4.Name = "PMchannelLabel4";
            this.PMchannelLabel4.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel4.TabIndex = 11;
            this.PMchannelLabel4.Text = "4";
            // 
            // PMchannelLabel5
            // 
            this.PMchannelLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel5.AutoSize = true;
            this.PMchannelLabel5.Location = new System.Drawing.Point(59, 379);
            this.PMchannelLabel5.Name = "PMchannelLabel5";
            this.PMchannelLabel5.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel5.TabIndex = 12;
            this.PMchannelLabel5.Text = "5";
            // 
            // PMchannelLabel6
            // 
            this.PMchannelLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel6.AutoSize = true;
            this.PMchannelLabel6.Location = new System.Drawing.Point(59, 447);
            this.PMchannelLabel6.Name = "PMchannelLabel6";
            this.PMchannelLabel6.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel6.TabIndex = 13;
            this.PMchannelLabel6.Text = "6";
            // 
            // PMchannelLabel7
            // 
            this.PMchannelLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel7.AutoSize = true;
            this.PMchannelLabel7.Location = new System.Drawing.Point(59, 515);
            this.PMchannelLabel7.Name = "PMchannelLabel7";
            this.PMchannelLabel7.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel7.TabIndex = 14;
            this.PMchannelLabel7.Text = "7";
            // 
            // PMchannelLabel8
            // 
            this.PMchannelLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel8.AutoSize = true;
            this.PMchannelLabel8.Location = new System.Drawing.Point(59, 583);
            this.PMchannelLabel8.Name = "PMchannelLabel8";
            this.PMchannelLabel8.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel8.TabIndex = 15;
            this.PMchannelLabel8.Text = "8";
            // 
            // PMchannelLabel9
            // 
            this.PMchannelLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel9.AutoSize = true;
            this.PMchannelLabel9.Location = new System.Drawing.Point(59, 651);
            this.PMchannelLabel9.Name = "PMchannelLabel9";
            this.PMchannelLabel9.Size = new System.Drawing.Size(25, 29);
            this.PMchannelLabel9.TabIndex = 16;
            this.PMchannelLabel9.Text = "9";
            // 
            // PMchannelLabel10
            // 
            this.PMchannelLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel10.AutoSize = true;
            this.PMchannelLabel10.Location = new System.Drawing.Point(53, 719);
            this.PMchannelLabel10.Name = "PMchannelLabel10";
            this.PMchannelLabel10.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel10.TabIndex = 17;
            this.PMchannelLabel10.Text = "10";
            // 
            // PMchannelLabel11
            // 
            this.PMchannelLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel11.AutoSize = true;
            this.PMchannelLabel11.Location = new System.Drawing.Point(53, 787);
            this.PMchannelLabel11.Name = "PMchannelLabel11";
            this.PMchannelLabel11.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel11.TabIndex = 18;
            this.PMchannelLabel11.Text = "11";
            // 
            // PMchannelLabel12
            // 
            this.PMchannelLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel12.AutoSize = true;
            this.PMchannelLabel12.Location = new System.Drawing.Point(53, 855);
            this.PMchannelLabel12.Name = "PMchannelLabel12";
            this.PMchannelLabel12.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel12.TabIndex = 19;
            this.PMchannelLabel12.Text = "12";
            // 
            // PMchannelLabel13
            // 
            this.PMchannelLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMchannelLabel13.AutoSize = true;
            this.PMchannelLabel13.Location = new System.Drawing.Point(53, 928);
            this.PMchannelLabel13.Name = "PMchannelLabel13";
            this.PMchannelLabel13.Size = new System.Drawing.Size(37, 29);
            this.PMchannelLabel13.TabIndex = 20;
            this.PMchannelLabel13.Text = "13";
            // 
            // PMcurrentDrawLabel1
            // 
            this.PMcurrentDrawLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel1.AutoSize = true;
            this.PMcurrentDrawLabel1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel1.Location = new System.Drawing.Point(1672, 97);
            this.PMcurrentDrawLabel1.Name = "PMcurrentDrawLabel1";
            this.PMcurrentDrawLabel1.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel1.TabIndex = 21;
            this.PMcurrentDrawLabel1.Text = "0.0";
            // 
            // PMcurrentDrawLabel2
            // 
            this.PMcurrentDrawLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel2.AutoSize = true;
            this.PMcurrentDrawLabel2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel2.Location = new System.Drawing.Point(1672, 165);
            this.PMcurrentDrawLabel2.Name = "PMcurrentDrawLabel2";
            this.PMcurrentDrawLabel2.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel2.TabIndex = 22;
            this.PMcurrentDrawLabel2.Text = "0.0";
            // 
            // PMcurrentDrawLabel3
            // 
            this.PMcurrentDrawLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel3.AutoSize = true;
            this.PMcurrentDrawLabel3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel3.Location = new System.Drawing.Point(1672, 233);
            this.PMcurrentDrawLabel3.Name = "PMcurrentDrawLabel3";
            this.PMcurrentDrawLabel3.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel3.TabIndex = 23;
            this.PMcurrentDrawLabel3.Text = "0.0";
            // 
            // PMcurrentDrawLabel4
            // 
            this.PMcurrentDrawLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel4.AutoSize = true;
            this.PMcurrentDrawLabel4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel4.Location = new System.Drawing.Point(1672, 301);
            this.PMcurrentDrawLabel4.Name = "PMcurrentDrawLabel4";
            this.PMcurrentDrawLabel4.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel4.TabIndex = 24;
            this.PMcurrentDrawLabel4.Text = "0.0";
            // 
            // PMcurrentDrawLabel5
            // 
            this.PMcurrentDrawLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel5.AutoSize = true;
            this.PMcurrentDrawLabel5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel5.Location = new System.Drawing.Point(1672, 369);
            this.PMcurrentDrawLabel5.Name = "PMcurrentDrawLabel5";
            this.PMcurrentDrawLabel5.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel5.TabIndex = 25;
            this.PMcurrentDrawLabel5.Text = "0.0";
            // 
            // PMcurrentDrawLabel6
            // 
            this.PMcurrentDrawLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel6.AutoSize = true;
            this.PMcurrentDrawLabel6.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel6.Location = new System.Drawing.Point(1672, 437);
            this.PMcurrentDrawLabel6.Name = "PMcurrentDrawLabel6";
            this.PMcurrentDrawLabel6.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel6.TabIndex = 26;
            this.PMcurrentDrawLabel6.Text = "0.0";
            // 
            // PMcurrentDrawLabel7
            // 
            this.PMcurrentDrawLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel7.AutoSize = true;
            this.PMcurrentDrawLabel7.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel7.Location = new System.Drawing.Point(1672, 505);
            this.PMcurrentDrawLabel7.Name = "PMcurrentDrawLabel7";
            this.PMcurrentDrawLabel7.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel7.TabIndex = 27;
            this.PMcurrentDrawLabel7.Text = "0.0";
            // 
            // PMcurrentDrawLabel8
            // 
            this.PMcurrentDrawLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel8.AutoSize = true;
            this.PMcurrentDrawLabel8.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel8.Location = new System.Drawing.Point(1672, 573);
            this.PMcurrentDrawLabel8.Name = "PMcurrentDrawLabel8";
            this.PMcurrentDrawLabel8.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel8.TabIndex = 28;
            this.PMcurrentDrawLabel8.Text = "0.0";
            // 
            // PMcurrentDrawLabel9
            // 
            this.PMcurrentDrawLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel9.AutoSize = true;
            this.PMcurrentDrawLabel9.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel9.Location = new System.Drawing.Point(1672, 641);
            this.PMcurrentDrawLabel9.Name = "PMcurrentDrawLabel9";
            this.PMcurrentDrawLabel9.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel9.TabIndex = 29;
            this.PMcurrentDrawLabel9.Text = "0.0";
            // 
            // PMcurrentDrawLabel10
            // 
            this.PMcurrentDrawLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel10.AutoSize = true;
            this.PMcurrentDrawLabel10.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel10.Location = new System.Drawing.Point(1672, 709);
            this.PMcurrentDrawLabel10.Name = "PMcurrentDrawLabel10";
            this.PMcurrentDrawLabel10.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel10.TabIndex = 30;
            this.PMcurrentDrawLabel10.Text = "0.0";
            // 
            // PMcurrentDrawLabel11
            // 
            this.PMcurrentDrawLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel11.AutoSize = true;
            this.PMcurrentDrawLabel11.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel11.Location = new System.Drawing.Point(1672, 777);
            this.PMcurrentDrawLabel11.Name = "PMcurrentDrawLabel11";
            this.PMcurrentDrawLabel11.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel11.TabIndex = 31;
            this.PMcurrentDrawLabel11.Text = "0.0";
            // 
            // PMcurrentDrawLabel12
            // 
            this.PMcurrentDrawLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel12.AutoSize = true;
            this.PMcurrentDrawLabel12.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel12.Location = new System.Drawing.Point(1672, 845);
            this.PMcurrentDrawLabel12.Name = "PMcurrentDrawLabel12";
            this.PMcurrentDrawLabel12.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel12.TabIndex = 32;
            this.PMcurrentDrawLabel12.Text = "0.0";
            // 
            // PMcurrentDrawLabel13
            // 
            this.PMcurrentDrawLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMcurrentDrawLabel13.AutoSize = true;
            this.PMcurrentDrawLabel13.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMcurrentDrawLabel13.Location = new System.Drawing.Point(1672, 918);
            this.PMcurrentDrawLabel13.Name = "PMcurrentDrawLabel13";
            this.PMcurrentDrawLabel13.Size = new System.Drawing.Size(72, 49);
            this.PMcurrentDrawLabel13.TabIndex = 33;
            this.PMcurrentDrawLabel13.Text = "0.0";
            // 
            // PMstatusLabel1
            // 
            this.PMstatusLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel1.AutoSize = true;
            this.PMstatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PMstatusLabel1.ForeColor = System.Drawing.Color.Green;
            this.PMstatusLabel1.Location = new System.Drawing.Point(1468, 107);
            this.PMstatusLabel1.Name = "PMstatusLabel1";
            this.PMstatusLabel1.Size = new System.Drawing.Size(45, 29);
            this.PMstatusLabel1.TabIndex = 34;
            this.PMstatusLabel1.Text = "ON";
            // 
            // PMstatusLabel2
            // 
            this.PMstatusLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel2.AutoSize = true;
            this.PMstatusLabel2.Location = new System.Drawing.Point(1465, 175);
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
            this.PMstatusLabel3.Location = new System.Drawing.Point(1436, 243);
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
            this.PMstatusLabel4.Location = new System.Drawing.Point(1462, 311);
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
            this.PMstatusLabel5.Location = new System.Drawing.Point(1454, 379);
            this.PMstatusLabel5.Name = "PMstatusLabel5";
            this.PMstatusLabel5.Size = new System.Drawing.Size(72, 29);
            this.PMstatusLabel5.TabIndex = 38;
            this.PMstatusLabel5.Text = "FAULT";
            // 
            // PMstatusLabel6
            // 
            this.PMstatusLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel6.AutoSize = true;
            this.PMstatusLabel6.Location = new System.Drawing.Point(1465, 447);
            this.PMstatusLabel6.Name = "PMstatusLabel6";
            this.PMstatusLabel6.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel6.TabIndex = 39;
            this.PMstatusLabel6.Text = "OFF";
            // 
            // PMstatusLabel7
            // 
            this.PMstatusLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel7.AutoSize = true;
            this.PMstatusLabel7.Location = new System.Drawing.Point(1465, 515);
            this.PMstatusLabel7.Name = "PMstatusLabel7";
            this.PMstatusLabel7.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel7.TabIndex = 40;
            this.PMstatusLabel7.Text = "OFF";
            // 
            // PMstatusLabel8
            // 
            this.PMstatusLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel8.AutoSize = true;
            this.PMstatusLabel8.Location = new System.Drawing.Point(1465, 583);
            this.PMstatusLabel8.Name = "PMstatusLabel8";
            this.PMstatusLabel8.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel8.TabIndex = 41;
            this.PMstatusLabel8.Text = "OFF";
            // 
            // PMstatusLabel9
            // 
            this.PMstatusLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel9.AutoSize = true;
            this.PMstatusLabel9.Location = new System.Drawing.Point(1465, 651);
            this.PMstatusLabel9.Name = "PMstatusLabel9";
            this.PMstatusLabel9.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel9.TabIndex = 42;
            this.PMstatusLabel9.Text = "OFF";
            // 
            // PMstatusLabel10
            // 
            this.PMstatusLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel10.AutoSize = true;
            this.PMstatusLabel10.Location = new System.Drawing.Point(1465, 719);
            this.PMstatusLabel10.Name = "PMstatusLabel10";
            this.PMstatusLabel10.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel10.TabIndex = 43;
            this.PMstatusLabel10.Text = "OFF";
            // 
            // PMstatusLabel11
            // 
            this.PMstatusLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel11.AutoSize = true;
            this.PMstatusLabel11.Location = new System.Drawing.Point(1465, 787);
            this.PMstatusLabel11.Name = "PMstatusLabel11";
            this.PMstatusLabel11.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel11.TabIndex = 44;
            this.PMstatusLabel11.Text = "OFF";
            // 
            // PMstatusLabel12
            // 
            this.PMstatusLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel12.AutoSize = true;
            this.PMstatusLabel12.Location = new System.Drawing.Point(1465, 855);
            this.PMstatusLabel12.Name = "PMstatusLabel12";
            this.PMstatusLabel12.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel12.TabIndex = 45;
            this.PMstatusLabel12.Text = "OFF";
            // 
            // PMstatusLabel13
            // 
            this.PMstatusLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMstatusLabel13.AutoSize = true;
            this.PMstatusLabel13.Location = new System.Drawing.Point(1465, 928);
            this.PMstatusLabel13.Name = "PMstatusLabel13";
            this.PMstatusLabel13.Size = new System.Drawing.Size(51, 29);
            this.PMstatusLabel13.TabIndex = 46;
            this.PMstatusLabel13.Text = "OFF";
            // 
            // PMtypeLabel1
            // 
            this.PMtypeLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel1.AutoSize = true;
            this.PMtypeLabel1.Location = new System.Drawing.Point(375, 107);
            this.PMtypeLabel1.Name = "PMtypeLabel1";
            this.PMtypeLabel1.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel1.TabIndex = 47;
            this.PMtypeLabel1.Text = "High Current";
            // 
            // PMtypeLabel4
            // 
            this.PMtypeLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel4.AutoSize = true;
            this.PMtypeLabel4.Location = new System.Drawing.Point(375, 311);
            this.PMtypeLabel4.Name = "PMtypeLabel4";
            this.PMtypeLabel4.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel4.TabIndex = 54;
            this.PMtypeLabel4.Text = "High Current";
            // 
            // PMtypeLabel3
            // 
            this.PMtypeLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel3.AutoSize = true;
            this.PMtypeLabel3.Location = new System.Drawing.Point(375, 243);
            this.PMtypeLabel3.Name = "PMtypeLabel3";
            this.PMtypeLabel3.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel3.TabIndex = 50;
            this.PMtypeLabel3.Text = "High Current";
            // 
            // PMtypeLabel5
            // 
            this.PMtypeLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel5.AutoSize = true;
            this.PMtypeLabel5.Location = new System.Drawing.Point(375, 379);
            this.PMtypeLabel5.Name = "PMtypeLabel5";
            this.PMtypeLabel5.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel5.TabIndex = 52;
            this.PMtypeLabel5.Text = "High Current";
            // 
            // PMtypeLabel6
            // 
            this.PMtypeLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel6.AutoSize = true;
            this.PMtypeLabel6.Location = new System.Drawing.Point(375, 447);
            this.PMtypeLabel6.Name = "PMtypeLabel6";
            this.PMtypeLabel6.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel6.TabIndex = 53;
            this.PMtypeLabel6.Text = "High Current";
            // 
            // PMtypeLabel7
            // 
            this.PMtypeLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel7.AutoSize = true;
            this.PMtypeLabel7.Location = new System.Drawing.Point(375, 515);
            this.PMtypeLabel7.Name = "PMtypeLabel7";
            this.PMtypeLabel7.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel7.TabIndex = 49;
            this.PMtypeLabel7.Text = "High Current";
            // 
            // PMtypeLabel8
            // 
            this.PMtypeLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel8.AutoSize = true;
            this.PMtypeLabel8.Location = new System.Drawing.Point(375, 583);
            this.PMtypeLabel8.Name = "PMtypeLabel8";
            this.PMtypeLabel8.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel8.TabIndex = 48;
            this.PMtypeLabel8.Text = "High Current";
            // 
            // PMtypeLabel9
            // 
            this.PMtypeLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel9.AutoSize = true;
            this.PMtypeLabel9.Location = new System.Drawing.Point(375, 651);
            this.PMtypeLabel9.Name = "PMtypeLabel9";
            this.PMtypeLabel9.Size = new System.Drawing.Size(138, 29);
            this.PMtypeLabel9.TabIndex = 55;
            this.PMtypeLabel9.Text = "High Current";
            // 
            // PMtypeLabel10
            // 
            this.PMtypeLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel10.AutoSize = true;
            this.PMtypeLabel10.Location = new System.Drawing.Point(375, 719);
            this.PMtypeLabel10.Name = "PMtypeLabel10";
            this.PMtypeLabel10.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel10.TabIndex = 56;
            this.PMtypeLabel10.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel11
            // 
            this.PMtypeLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel11.AutoSize = true;
            this.PMtypeLabel11.Location = new System.Drawing.Point(375, 787);
            this.PMtypeLabel11.Name = "PMtypeLabel11";
            this.PMtypeLabel11.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel11.TabIndex = 57;
            this.PMtypeLabel11.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel12
            // 
            this.PMtypeLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel12.AutoSize = true;
            this.PMtypeLabel12.Location = new System.Drawing.Point(375, 855);
            this.PMtypeLabel12.Name = "PMtypeLabel12";
            this.PMtypeLabel12.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel12.TabIndex = 58;
            this.PMtypeLabel12.Text = "Push/Pull 5A";
            // 
            // PMtypeLabel13
            // 
            this.PMtypeLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtypeLabel13.AutoSize = true;
            this.PMtypeLabel13.Location = new System.Drawing.Point(375, 928);
            this.PMtypeLabel13.Name = "PMtypeLabel13";
            this.PMtypeLabel13.Size = new System.Drawing.Size(137, 29);
            this.PMtypeLabel13.TabIndex = 59;
            this.PMtypeLabel13.Text = "Push/Pull 5A";
            // 
            // PMnameBox5
            // 
            this.PMnameBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox5.Location = new System.Drawing.Point(146, 375);
            this.PMnameBox5.MaxLength = 16;
            this.PMnameBox5.Name = "PMnameBox5";
            this.PMnameBox5.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox5.TabIndex = 60;
            // 
            // PMnameBox6
            // 
            this.PMnameBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox6.Location = new System.Drawing.Point(146, 443);
            this.PMnameBox6.MaxLength = 16;
            this.PMnameBox6.Name = "PMnameBox6";
            this.PMnameBox6.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox6.TabIndex = 63;
            // 
            // PMnameBox7
            // 
            this.PMnameBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox7.Location = new System.Drawing.Point(146, 511);
            this.PMnameBox7.MaxLength = 16;
            this.PMnameBox7.Name = "PMnameBox7";
            this.PMnameBox7.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox7.TabIndex = 66;
            // 
            // PMnameBox8
            // 
            this.PMnameBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox8.Location = new System.Drawing.Point(146, 579);
            this.PMnameBox8.MaxLength = 16;
            this.PMnameBox8.Name = "PMnameBox8";
            this.PMnameBox8.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox8.TabIndex = 61;
            // 
            // PMnameBox9
            // 
            this.PMnameBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox9.Location = new System.Drawing.Point(146, 647);
            this.PMnameBox9.MaxLength = 16;
            this.PMnameBox9.Name = "PMnameBox9";
            this.PMnameBox9.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox9.TabIndex = 73;
            // 
            // PMnameBox10
            // 
            this.PMnameBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox10.Location = new System.Drawing.Point(146, 715);
            this.PMnameBox10.MaxLength = 16;
            this.PMnameBox10.Name = "PMnameBox10";
            this.PMnameBox10.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox10.TabIndex = 72;
            // 
            // PMnameBox11
            // 
            this.PMnameBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox11.Location = new System.Drawing.Point(146, 783);
            this.PMnameBox11.MaxLength = 16;
            this.PMnameBox11.Name = "PMnameBox11";
            this.PMnameBox11.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox11.TabIndex = 71;
            // 
            // PMnameBox12
            // 
            this.PMnameBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox12.Location = new System.Drawing.Point(146, 851);
            this.PMnameBox12.MaxLength = 16;
            this.PMnameBox12.Name = "PMnameBox12";
            this.PMnameBox12.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox12.TabIndex = 69;
            // 
            // PMnameBox13
            // 
            this.PMnameBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMnameBox13.Location = new System.Drawing.Point(146, 924);
            this.PMnameBox13.MaxLength = 16;
            this.PMnameBox13.Name = "PMnameBox13";
            this.PMnameBox13.Size = new System.Drawing.Size(221, 37);
            this.PMnameBox13.TabIndex = 70;
            // 
            // PMtripControl1
            // 
            this.PMtripControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl1.DecimalPlaces = 1;
            this.PMtripControl1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl1.Location = new System.Drawing.Point(543, 103);
            this.PMtripControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl1.Name = "PMtripControl1";
            this.PMtripControl1.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl1.TabIndex = 74;
            this.PMtripControl1.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl7
            // 
            this.PMtripControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl7.DecimalPlaces = 1;
            this.PMtripControl7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl7.Location = new System.Drawing.Point(543, 511);
            this.PMtripControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl7.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl7.Name = "PMtripControl7";
            this.PMtripControl7.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl7.TabIndex = 75;
            this.PMtripControl7.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl8
            // 
            this.PMtripControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl8.DecimalPlaces = 1;
            this.PMtripControl8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl8.Location = new System.Drawing.Point(543, 579);
            this.PMtripControl8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl8.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl8.Name = "PMtripControl8";
            this.PMtripControl8.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl8.TabIndex = 77;
            this.PMtripControl8.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl9
            // 
            this.PMtripControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl9.DecimalPlaces = 1;
            this.PMtripControl9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl9.Location = new System.Drawing.Point(543, 647);
            this.PMtripControl9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl9.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl9.Name = "PMtripControl9";
            this.PMtripControl9.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl9.TabIndex = 79;
            this.PMtripControl9.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl10
            // 
            this.PMtripControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl10.DecimalPlaces = 1;
            this.PMtripControl10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl10.Location = new System.Drawing.Point(543, 715);
            this.PMtripControl10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl10.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl10.Name = "PMtripControl10";
            this.PMtripControl10.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl10.TabIndex = 81;
            this.PMtripControl10.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl11
            // 
            this.PMtripControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl11.DecimalPlaces = 1;
            this.PMtripControl11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl11.Location = new System.Drawing.Point(543, 783);
            this.PMtripControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl11.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl11.Name = "PMtripControl11";
            this.PMtripControl11.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl11.TabIndex = 83;
            this.PMtripControl11.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl12
            // 
            this.PMtripControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl12.DecimalPlaces = 1;
            this.PMtripControl12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl12.Location = new System.Drawing.Point(543, 851);
            this.PMtripControl12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl12.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl12.Name = "PMtripControl12";
            this.PMtripControl12.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl12.TabIndex = 86;
            this.PMtripControl12.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // PMtripControl13
            // 
            this.PMtripControl13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMtripControl13.DecimalPlaces = 1;
            this.PMtripControl13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PMtripControl13.Location = new System.Drawing.Point(543, 924);
            this.PMtripControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PMtripControl13.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PMtripControl13.Name = "PMtripControl13";
            this.PMtripControl13.Size = new System.Drawing.Size(180, 37);
            this.PMtripControl13.TabIndex = 85;
            this.PMtripControl13.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
            // 
            // Cooling_Tab
            // 
            this.Cooling_Tab.Location = new System.Drawing.Point(4, 38);
            this.Cooling_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cooling_Tab.Name = "Cooling_Tab";
            this.Cooling_Tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cooling_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.Safety_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.IOsetup_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.Diagnostics_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.balancingButton.Location = new System.Drawing.Point(878, 69);
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
            this.groupBox5.Location = new System.Drawing.Point(26, 9);
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
            this.CANrichTextBox.Size = new System.Drawing.Size(775, 773);
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
            this.Firmware_Tab.Size = new System.Drawing.Size(1872, 998);
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
            this.menuStrip1.Size = new System.Drawing.Size(1898, 39);
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
            // guiUpdateTimer
            // 
            this.guiUpdateTimer.Enabled = true;
            this.guiUpdateTimer.Tick += new System.EventHandler(this.guiUpdateTimer_Tick);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(242, 151);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(136, 33);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Clockwise";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(320, 263);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(320, 306);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown2.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(320, 349);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown3.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(320, 392);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown4.TabIndex = 12;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(16, 265);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(133, 29);
            this.label60.TabIndex = 5;
            this.label60.Text = "Torque Gain";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(16, 308);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(142, 29);
            this.label65.TabIndex = 6;
            this.label65.Text = "Current Limit";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(16, 351);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(165, 29);
            this.label67.TabIndex = 7;
            this.label67.Text = "Temp Limit Soft";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(16, 394);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(174, 29);
            this.label68.TabIndex = 8;
            this.label68.Text = "Temp Limit Hard";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.LightCyan;
            this.label69.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label69.Location = new System.Drawing.Point(270, 182);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(125, 29);
            this.label69.TabIndex = 9;
            this.label69.Text = "Frontwards";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(26, 43);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(174, 29);
            this.label70.TabIndex = 10;
            this.label70.Text = "Angular Velocity";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(26, 91);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(145, 29);
            this.label74.TabIndex = 11;
            this.label74.Text = "Current Draw";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.label78);
            this.groupBox7.Controls.Add(this.label77);
            this.groupBox7.Controls.Add(this.label70);
            this.groupBox7.Controls.Add(this.label74);
            this.groupBox7.Location = new System.Drawing.Point(476, 36);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(445, 440);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.numericUpDown1);
            this.groupBox8.Controls.Add(this.numericUpDown2);
            this.groupBox8.Controls.Add(this.numericUpDown3);
            this.groupBox8.Controls.Add(this.numericUpDown4);
            this.groupBox8.Controls.Add(this.label60);
            this.groupBox8.Controls.Add(this.label68);
            this.groupBox8.Controls.Add(this.label65);
            this.groupBox8.Controls.Add(this.label67);
            this.groupBox8.Location = new System.Drawing.Point(6, 36);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(464, 440);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Configuration";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(15, 112);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(163, 33);
            this.checkBox12.TabIndex = 3;
            this.checkBox12.Text = "Unused Bit 2";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(15, 151);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(163, 33);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Unused Bit 3";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(15, 73);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(163, 33);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Text = "Unused Bit 1";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(242, 34);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(163, 33);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Unused Bit 4";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(15, 34);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(163, 33);
            this.checkBox11.TabIndex = 1;
            this.checkBox11.Text = "Unused Bit 0";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(242, 73);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(163, 33);
            this.checkBox13.TabIndex = 6;
            this.checkBox13.Text = "Unused Bit 5";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(242, 112);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(163, 33);
            this.checkBox14.TabIndex = 7;
            this.checkBox14.Text = "Unused Bit 6";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(170, 36);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(97, 49);
            this.label76.TabIndex = 12;
            this.label76.Text = "60°C";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(335, 43);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(33, 29);
            this.label77.TabIndex = 13;
            this.label77.Text = "0°";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(335, 95);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(44, 29);
            this.label78.TabIndex = 14;
            this.label78.Text = "0 A";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numericUpDown6);
            this.groupBox9.Controls.Add(this.numericUpDown5);
            this.groupBox9.Controls.Add(this.progressBar1);
            this.groupBox9.Controls.Add(this.label76);
            this.groupBox9.Location = new System.Drawing.Point(6, 294);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(433, 140);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Temperature";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(421, 31);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 60;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(6, 46);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown5.TabIndex = 13;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(307, 46);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown6.TabIndex = 14;
            this.numericUpDown6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox11);
            this.groupBox10.Controls.Add(this.checkBox14);
            this.groupBox10.Controls.Add(this.label69);
            this.groupBox10.Controls.Add(this.checkBox13);
            this.groupBox10.Controls.Add(this.checkBox7);
            this.groupBox10.Controls.Add(this.checkBox12);
            this.groupBox10.Controls.Add(this.checkBox10);
            this.groupBox10.Controls.Add(this.checkBox8);
            this.groupBox10.Controls.Add(this.checkBox9);
            this.groupBox10.Location = new System.Drawing.Point(6, 31);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(452, 220);
            this.groupBox10.TabIndex = 21;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Config Byte";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.numericUpDown7);
            this.groupBox11.Controls.Add(this.numericUpDown8);
            this.groupBox11.Controls.Add(this.numericUpDown9);
            this.groupBox11.Controls.Add(this.numericUpDown10);
            this.groupBox11.Controls.Add(this.label82);
            this.groupBox11.Controls.Add(this.label83);
            this.groupBox11.Controls.Add(this.label84);
            this.groupBox11.Controls.Add(this.label85);
            this.groupBox11.Location = new System.Drawing.Point(6, 26);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(464, 440);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Configuration";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.checkBox15);
            this.groupBox12.Controls.Add(this.checkBox16);
            this.groupBox12.Controls.Add(this.label79);
            this.groupBox12.Controls.Add(this.checkBox17);
            this.groupBox12.Controls.Add(this.checkBox18);
            this.groupBox12.Controls.Add(this.checkBox19);
            this.groupBox12.Controls.Add(this.checkBox20);
            this.groupBox12.Controls.Add(this.checkBox21);
            this.groupBox12.Controls.Add(this.checkBox22);
            this.groupBox12.Location = new System.Drawing.Point(6, 31);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(452, 220);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Config Byte";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(15, 34);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(163, 33);
            this.checkBox15.TabIndex = 18;
            this.checkBox15.Text = "Unused Bit 0";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(242, 112);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(163, 33);
            this.checkBox16.TabIndex = 20;
            this.checkBox16.Text = "Unused Bit 6";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.MistyRose;
            this.label79.ForeColor = System.Drawing.Color.OrangeRed;
            this.label79.Location = new System.Drawing.Point(270, 182);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(118, 29);
            this.label79.TabIndex = 9;
            this.label79.Text = "Backwards";
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(242, 73);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(163, 33);
            this.checkBox17.TabIndex = 19;
            this.checkBox17.Text = "Unused Bit 5";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(242, 151);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(136, 33);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Text = "Clockwise";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(15, 112);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(163, 33);
            this.checkBox19.TabIndex = 14;
            this.checkBox19.Text = "Unused Bit 2";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(242, 34);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(163, 33);
            this.checkBox20.TabIndex = 17;
            this.checkBox20.Text = "Unused Bit 4";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(15, 151);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(163, 33);
            this.checkBox21.TabIndex = 15;
            this.checkBox21.Text = "Unused Bit 3";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(15, 73);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(163, 33);
            this.checkBox22.TabIndex = 16;
            this.checkBox22.Text = "Unused Bit 1";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(320, 263);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown7.TabIndex = 1;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(320, 306);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown8.TabIndex = 2;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(320, 349);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown9.TabIndex = 3;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(320, 392);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown10.TabIndex = 4;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(16, 265);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(133, 29);
            this.label82.TabIndex = 5;
            this.label82.Text = "Torque Gain";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(16, 394);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(174, 29);
            this.label83.TabIndex = 8;
            this.label83.Text = "Temp Limit Hard";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(16, 308);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(142, 29);
            this.label84.TabIndex = 6;
            this.label84.Text = "Current Limit";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(16, 351);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(165, 29);
            this.label85.TabIndex = 7;
            this.label85.Text = "Temp Limit Soft";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.label87);
            this.groupBox13.Controls.Add(this.label88);
            this.groupBox13.Controls.Add(this.label89);
            this.groupBox13.Controls.Add(this.label90);
            this.groupBox13.Location = new System.Drawing.Point(476, 26);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(445, 440);
            this.groupBox13.TabIndex = 15;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Data";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.numericUpDown11);
            this.groupBox14.Controls.Add(this.numericUpDown12);
            this.groupBox14.Controls.Add(this.progressBar2);
            this.groupBox14.Controls.Add(this.label86);
            this.groupBox14.Location = new System.Drawing.Point(6, 294);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(433, 140);
            this.groupBox14.TabIndex = 15;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Temperature";
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(307, 46);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown11.TabIndex = 15;
            this.numericUpDown11.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(6, 46);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown12.TabIndex = 14;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 95);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(421, 31);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 13;
            this.progressBar2.Value = 60;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(170, 36);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(97, 49);
            this.label86.TabIndex = 12;
            this.label86.Text = "60°C";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(335, 95);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(44, 29);
            this.label87.TabIndex = 14;
            this.label87.Text = "0 A";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(335, 43);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(33, 29);
            this.label88.TabIndex = 13;
            this.label88.Text = "0°";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(26, 43);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(174, 29);
            this.label89.TabIndex = 10;
            this.label89.Text = "Angular Velocity";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(26, 91);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(145, 29);
            this.label90.TabIndex = 11;
            this.label90.Text = "Current Draw";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Controls.Add(this.numericUpDown13);
            this.groupBox15.Controls.Add(this.numericUpDown14);
            this.groupBox15.Controls.Add(this.numericUpDown15);
            this.groupBox15.Controls.Add(this.numericUpDown16);
            this.groupBox15.Controls.Add(this.label92);
            this.groupBox15.Controls.Add(this.label93);
            this.groupBox15.Controls.Add(this.label94);
            this.groupBox15.Controls.Add(this.label95);
            this.groupBox15.Location = new System.Drawing.Point(6, 24);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(464, 440);
            this.groupBox15.TabIndex = 16;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Configuration";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.checkBox23);
            this.groupBox16.Controls.Add(this.checkBox24);
            this.groupBox16.Controls.Add(this.label91);
            this.groupBox16.Controls.Add(this.checkBox25);
            this.groupBox16.Controls.Add(this.checkBox26);
            this.groupBox16.Controls.Add(this.checkBox27);
            this.groupBox16.Controls.Add(this.checkBox28);
            this.groupBox16.Controls.Add(this.checkBox29);
            this.groupBox16.Controls.Add(this.checkBox30);
            this.groupBox16.Location = new System.Drawing.Point(6, 31);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(452, 220);
            this.groupBox16.TabIndex = 21;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Config Byte";
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(15, 34);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(163, 33);
            this.checkBox23.TabIndex = 18;
            this.checkBox23.Text = "Unused Bit 0";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(242, 112);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(163, 33);
            this.checkBox24.TabIndex = 20;
            this.checkBox24.Text = "Unused Bit 6";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.LightCyan;
            this.label91.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label91.Location = new System.Drawing.Point(270, 182);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(125, 29);
            this.label91.TabIndex = 9;
            this.label91.Text = "Frontwards";
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(242, 73);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(163, 33);
            this.checkBox25.TabIndex = 19;
            this.checkBox25.Text = "Unused Bit 5";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(242, 151);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(136, 33);
            this.checkBox26.TabIndex = 0;
            this.checkBox26.Text = "Clockwise";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(15, 112);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(163, 33);
            this.checkBox27.TabIndex = 14;
            this.checkBox27.Text = "Unused Bit 2";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(242, 34);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(163, 33);
            this.checkBox28.TabIndex = 17;
            this.checkBox28.Text = "Unused Bit 4";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(15, 151);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(163, 33);
            this.checkBox29.TabIndex = 15;
            this.checkBox29.Text = "Unused Bit 3";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(15, 73);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(163, 33);
            this.checkBox30.TabIndex = 16;
            this.checkBox30.Text = "Unused Bit 1";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(320, 263);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown13.TabIndex = 1;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(320, 306);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown14.TabIndex = 2;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(320, 349);
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown15.TabIndex = 3;
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(320, 392);
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown16.TabIndex = 4;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(16, 265);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(133, 29);
            this.label92.TabIndex = 5;
            this.label92.Text = "Torque Gain";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(16, 394);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(174, 29);
            this.label93.TabIndex = 8;
            this.label93.Text = "Temp Limit Hard";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(16, 308);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(142, 29);
            this.label94.TabIndex = 6;
            this.label94.Text = "Current Limit";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(16, 351);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(165, 29);
            this.label95.TabIndex = 7;
            this.label95.Text = "Temp Limit Soft";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.label97);
            this.groupBox17.Controls.Add(this.label98);
            this.groupBox17.Controls.Add(this.label99);
            this.groupBox17.Controls.Add(this.label100);
            this.groupBox17.Location = new System.Drawing.Point(476, 24);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(445, 440);
            this.groupBox17.TabIndex = 15;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Data";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.numericUpDown17);
            this.groupBox18.Controls.Add(this.numericUpDown18);
            this.groupBox18.Controls.Add(this.progressBar3);
            this.groupBox18.Controls.Add(this.label96);
            this.groupBox18.Location = new System.Drawing.Point(6, 294);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(433, 140);
            this.groupBox18.TabIndex = 15;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Temperature";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(307, 46);
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown17.TabIndex = 15;
            this.numericUpDown17.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(6, 46);
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown18.TabIndex = 14;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 95);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(421, 31);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 13;
            this.progressBar3.Value = 60;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(170, 36);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(97, 49);
            this.label96.TabIndex = 12;
            this.label96.Text = "60°C";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(335, 95);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(44, 29);
            this.label97.TabIndex = 14;
            this.label97.Text = "0 A";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(335, 43);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(33, 29);
            this.label98.TabIndex = 13;
            this.label98.Text = "0°";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(26, 43);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(174, 29);
            this.label99.TabIndex = 10;
            this.label99.Text = "Angular Velocity";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(26, 91);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(145, 29);
            this.label100.TabIndex = 11;
            this.label100.Text = "Current Draw";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.numericUpDown19);
            this.groupBox19.Controls.Add(this.numericUpDown20);
            this.groupBox19.Controls.Add(this.numericUpDown21);
            this.groupBox19.Controls.Add(this.numericUpDown22);
            this.groupBox19.Controls.Add(this.label102);
            this.groupBox19.Controls.Add(this.label103);
            this.groupBox19.Controls.Add(this.label104);
            this.groupBox19.Controls.Add(this.label105);
            this.groupBox19.Location = new System.Drawing.Point(6, 24);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(464, 440);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Configuration";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.checkBox31);
            this.groupBox20.Controls.Add(this.checkBox32);
            this.groupBox20.Controls.Add(this.label101);
            this.groupBox20.Controls.Add(this.checkBox33);
            this.groupBox20.Controls.Add(this.checkBox34);
            this.groupBox20.Controls.Add(this.checkBox35);
            this.groupBox20.Controls.Add(this.checkBox36);
            this.groupBox20.Controls.Add(this.checkBox37);
            this.groupBox20.Controls.Add(this.checkBox38);
            this.groupBox20.Location = new System.Drawing.Point(6, 31);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(452, 220);
            this.groupBox20.TabIndex = 21;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Config Byte";
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(15, 34);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(163, 33);
            this.checkBox31.TabIndex = 18;
            this.checkBox31.Text = "Unused Bit 0";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(242, 112);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(163, 33);
            this.checkBox32.TabIndex = 20;
            this.checkBox32.Text = "Unused Bit 6";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.Color.MistyRose;
            this.label101.ForeColor = System.Drawing.Color.OrangeRed;
            this.label101.Location = new System.Drawing.Point(270, 182);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(118, 29);
            this.label101.TabIndex = 9;
            this.label101.Text = "Backwards";
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.Location = new System.Drawing.Point(242, 73);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(163, 33);
            this.checkBox33.TabIndex = 19;
            this.checkBox33.Text = "Unused Bit 5";
            this.checkBox33.UseVisualStyleBackColor = true;
            // 
            // checkBox34
            // 
            this.checkBox34.AutoSize = true;
            this.checkBox34.Location = new System.Drawing.Point(242, 151);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(136, 33);
            this.checkBox34.TabIndex = 0;
            this.checkBox34.Text = "Clockwise";
            this.checkBox34.UseVisualStyleBackColor = true;
            // 
            // checkBox35
            // 
            this.checkBox35.AutoSize = true;
            this.checkBox35.Location = new System.Drawing.Point(15, 112);
            this.checkBox35.Name = "checkBox35";
            this.checkBox35.Size = new System.Drawing.Size(163, 33);
            this.checkBox35.TabIndex = 14;
            this.checkBox35.Text = "Unused Bit 2";
            this.checkBox35.UseVisualStyleBackColor = true;
            // 
            // checkBox36
            // 
            this.checkBox36.AutoSize = true;
            this.checkBox36.Location = new System.Drawing.Point(242, 34);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(163, 33);
            this.checkBox36.TabIndex = 17;
            this.checkBox36.Text = "Unused Bit 4";
            this.checkBox36.UseVisualStyleBackColor = true;
            // 
            // checkBox37
            // 
            this.checkBox37.AutoSize = true;
            this.checkBox37.Location = new System.Drawing.Point(15, 151);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(163, 33);
            this.checkBox37.TabIndex = 15;
            this.checkBox37.Text = "Unused Bit 3";
            this.checkBox37.UseVisualStyleBackColor = true;
            // 
            // checkBox38
            // 
            this.checkBox38.AutoSize = true;
            this.checkBox38.Location = new System.Drawing.Point(15, 73);
            this.checkBox38.Name = "checkBox38";
            this.checkBox38.Size = new System.Drawing.Size(163, 33);
            this.checkBox38.TabIndex = 16;
            this.checkBox38.Text = "Unused Bit 1";
            this.checkBox38.UseVisualStyleBackColor = true;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(320, 263);
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown19.TabIndex = 1;
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(320, 306);
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown20.TabIndex = 2;
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(320, 349);
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown21.TabIndex = 3;
            // 
            // numericUpDown22
            // 
            this.numericUpDown22.Location = new System.Drawing.Point(320, 392);
            this.numericUpDown22.Name = "numericUpDown22";
            this.numericUpDown22.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown22.TabIndex = 4;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(16, 265);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(133, 29);
            this.label102.TabIndex = 5;
            this.label102.Text = "Torque Gain";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(16, 394);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(174, 29);
            this.label103.TabIndex = 8;
            this.label103.Text = "Temp Limit Hard";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(16, 308);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(142, 29);
            this.label104.TabIndex = 6;
            this.label104.Text = "Current Limit";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(16, 351);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(165, 29);
            this.label105.TabIndex = 7;
            this.label105.Text = "Temp Limit Soft";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.groupBox22);
            this.groupBox21.Controls.Add(this.label107);
            this.groupBox21.Controls.Add(this.label108);
            this.groupBox21.Controls.Add(this.label109);
            this.groupBox21.Controls.Add(this.label110);
            this.groupBox21.Location = new System.Drawing.Point(476, 24);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(445, 440);
            this.groupBox21.TabIndex = 15;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Data";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.numericUpDown23);
            this.groupBox22.Controls.Add(this.numericUpDown24);
            this.groupBox22.Controls.Add(this.progressBar4);
            this.groupBox22.Controls.Add(this.label106);
            this.groupBox22.Location = new System.Drawing.Point(6, 294);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(433, 140);
            this.groupBox22.TabIndex = 15;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Temperature";
            // 
            // numericUpDown23
            // 
            this.numericUpDown23.Location = new System.Drawing.Point(307, 46);
            this.numericUpDown23.Name = "numericUpDown23";
            this.numericUpDown23.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown23.TabIndex = 15;
            this.numericUpDown23.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown24
            // 
            this.numericUpDown24.Location = new System.Drawing.Point(6, 46);
            this.numericUpDown24.Name = "numericUpDown24";
            this.numericUpDown24.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown24.TabIndex = 14;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(6, 95);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(421, 31);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 13;
            this.progressBar4.Value = 60;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(170, 36);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(97, 49);
            this.label106.TabIndex = 12;
            this.label106.Text = "60°C";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(335, 95);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(44, 29);
            this.label107.TabIndex = 14;
            this.label107.Text = "0 A";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(335, 43);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(33, 29);
            this.label108.TabIndex = 13;
            this.label108.Text = "0°";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(26, 43);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(174, 29);
            this.label109.TabIndex = 10;
            this.label109.Text = "Angular Velocity";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(26, 91);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(145, 29);
            this.label110.TabIndex = 11;
            this.label110.Text = "Current Draw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1111);
            this.Controls.Add(this.mainScreenTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2126, 1247);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1308, 694);
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
            this.Inverters_Tab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.TorqueVectoring_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.GLV_Tab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMtripControl13)).EndInit();
            this.Diagnostics_Tab.ResumeLayout(false);
            this.Diagnostics_Tab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Firmware_Tab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).EndInit();
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
        private System.Windows.Forms.NumericUpDown PMtripControl6;
        private System.Windows.Forms.NumericUpDown PMtripControl5;
        private System.Windows.Forms.NumericUpDown PMtripControl4;
        private System.Windows.Forms.NumericUpDown PMtripControl3;
        private System.Windows.Forms.NumericUpDown PMtripControl2;
        private System.Windows.Forms.NumericUpDown PMtripControl1;
        private System.Windows.Forms.NumericUpDown PMtripControl7;
        private System.Windows.Forms.NumericUpDown PMtripControl8;
        private System.Windows.Forms.NumericUpDown PMtripControl9;
        private System.Windows.Forms.NumericUpDown PMtripControl10;
        private System.Windows.Forms.NumericUpDown PMtripControl11;
        private System.Windows.Forms.NumericUpDown PMtripControl12;
        private System.Windows.Forms.NumericUpDown PMtripControl13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.NumericUpDown numericUpDown18;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.CheckBox checkBox33;
        private System.Windows.Forms.CheckBox checkBox34;
        private System.Windows.Forms.CheckBox checkBox35;
        private System.Windows.Forms.CheckBox checkBox36;
        private System.Windows.Forms.CheckBox checkBox37;
        private System.Windows.Forms.CheckBox checkBox38;
        private System.Windows.Forms.NumericUpDown numericUpDown19;
        private System.Windows.Forms.NumericUpDown numericUpDown20;
        private System.Windows.Forms.NumericUpDown numericUpDown21;
        private System.Windows.Forms.NumericUpDown numericUpDown22;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.NumericUpDown numericUpDown23;
        private System.Windows.Forms.NumericUpDown numericUpDown24;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
    }
}