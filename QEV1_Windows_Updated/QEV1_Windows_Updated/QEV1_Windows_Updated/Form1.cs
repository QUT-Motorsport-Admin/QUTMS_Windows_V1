using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.IO;



namespace QEV1_Windows_Updated
{
    public partial class Form1 : Form
    {
        //vars
        Serial serial;

        const int CONNECT = 128;
        const int DISCONNECT = 1;
        
        bool errorsEnabled = true;
        bool errorsDisabled = false;
                
        byte[] incomingString = new byte[60];
        int stringIndex = 0;
        ushort stringMode = 0;
        ushort packetMode = 0;
        public List<string[]> TVtable_1;

        byte loggingTrue = 0;

        public const int OVERVIEW = 1;

        private Label[] overviewValues;

        private Label[,] frontAccumulatorValues;
        private Label[,] rearAccumulatorValues;

        SerialCommunication qevSerialCom;

        public Form1()
        {
            InitializeComponent();
            InitialiseLabelArrays();

        }

        private void InitialiseLabelArrays() {
            overviewValues = new Label[]
            {
                lblAcc1MinVolts, lblAcc1MaxVolts, lblAcc1AvVolts,
                lblAcc1MinTemp, lblAcc1MaxTemp, lblAcc1AvTemp,
                lblAcc2MinVolts, lblAcc2MaxVolts, lblAcc2AvVolts,
                lblAcc2MinTemp, lblAcc2MaxTemp, lblAcc2AvTemp,

                lblOverviewSpeed, lblOverviewAcceleratorPedal, lblOverviewBrakePedal,
                lblOverviewBrakeFrontPressure, lblOverviewBrakeRearPressure, lblOverviewSteeringAngle,

                lblInv1Current, lblInv1Temp,
                lblInv2Current, lblInv2Temp,
                lblInv3Current, lblInv3Temp,
                lblInv4Current, lblInv4Temp,

                lblOverviewLongG, lblOverviewLatG, lblOverviewYawRate
            };
            frontAccumulatorValues = new Label[6, 3]{ { minFrontAccumulatorValue1, maxFrontAccumulatorValue1, avgFrontAccumulatorValue1 },
                                                        { minFrontAccumulatorValue2, maxFrontAccumulatorValue2, avgFrontAccumulatorValue2 },
                                                        { minFrontAccumulatorValue3, maxFrontAccumulatorValue3, avgFrontAccumulatorValue3 },
                                                        { minFrontAccumulatorValue4, maxFrontAccumulatorValue4, avgFrontAccumulatorValue4 },
                                                        { minFrontAccumulatorValue5, maxFrontAccumulatorValue5, avgFrontAccumulatorValue5 },
                                                        { minFrontAccumulatorValue6, maxFrontAccumulatorValue6, avgFrontAccumulatorValue6 }};
            rearAccumulatorValues = new Label[6, 3] { { minRearAccumulatorValue1, maxRearAccumulatorValue1, avgRearAccumulatorValue1 },
                                                        { minRearAccumulatorValue2, maxRearAccumulatorValue2, avgRearAccumulatorValue2 },
                                                        { minRearAccumulatorValue3, maxRearAccumulatorValue3, avgRearAccumulatorValue3 },
                                                        { minRearAccumulatorValue4, maxRearAccumulatorValue4, avgRearAccumulatorValue4 },
                                                        { minRearAccumulatorValue5, maxRearAccumulatorValue5, avgRearAccumulatorValue5 },
                                                        { minRearAccumulatorValue6, maxRearAccumulatorValue6, avgRearAccumulatorValue6 }};

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qevSerialCom = new SerialCommunication(serialPort1, getDataTimer);
        }

        private void statusCOMnumber_Click(object sender, EventArgs e)
        {
            statusCOMnumber.Text = qevSerialCom.incrementPort();
        }

        private void statusConnectionStatus_Click(object sender, EventArgs e)
        {
            if (qevSerialCom.isECUConnected())
            {
                qevSerialCom.connectSerial(DISCONNECT, statusCOMnumber.Text);
            }

            else
            {
                qevSerialCom.connectSerial(CONNECT, statusCOMnumber.Text);
            }
        }

        private void scanSerials(bool errorMode)
        {

            if (qevSerialCom.scanSerials(errorMode))
            {
                // Set starting point for port searching
                qevSerialCom.resetPort();

                // Update GUI to show number of ports
                statusCOMnumber.Text = qevSerialCom.getNumberofPorts();

                // Set SerialPort properties
                qevSerialCom.setTimeoutAndBaud(10000, 19200);
            }

            else
            {
                // Update GUI to show no ports
                statusConnectionStatus.Text = "No Ports";
                statusConnectionStatus.BackColor = Color.Yellow;

                qevSerialCom.connectECU(false);
                connectSerial(DISCONNECT);
                
                if (errorMode)
                {
                    MessageBox.Show("No Ports Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    statusConnectionStatus.Text = "No Ports";
                }
            }
        }

        private void connectSerial(int request)
        {
            try
            {
                int connectResponse = qevSerialCom.connectSerial(request, statusCOMnumber.Text);
                switch (connectResponse) {
                    case (int)SerialCommunication.connectSerialCodes.connectPorts:
                        statusConnectionStatus.Text = "Connected";
                        statusConnectionStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
                        break;
                    case (int)SerialCommunication.connectSerialCodes.connectNoPorts:
                        statusConnectionStatus.Text = "Disconnected";
                        statusConnectionStatus.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    case (int)SerialCommunication.connectSerialCodes.disconnect:
                        MessageBox.Show("No Ports Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        statusConnectionStatus.Text = "No Ports";
                        break;
                    default: throw new Exception();
                }
            }

            catch
            {
                MessageBox.Show("Port Error", "OS Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                statusConnectionStatus.Text = "Port Fault";
                statusConnectionStatus.BackColor = Color.Red;
                qevSerialCom.connectSerial(DISCONNECT, null);
            }
        }

        private void getDataTimer_Tick(object sender, EventArgs e)
        {
            try
            {                                
                // Send Data to the CC depending on opened tab
                if (mainScreenTabControl.SelectedTab == Accumulators_Tab) qevSerialCom.sendDataToSerial(2);            //packet type 2
                else if (mainScreenTabControl.SelectedTab == Inverters_Tab) qevSerialCom.sendDataToSerial(3);          //packet type 3
                else if (mainScreenTabControl.SelectedTab == TorqueVectoring_Tab) qevSerialCom.sendDataToSerial(4);    //packet type 4
                else if (mainScreenTabControl.SelectedTab == GLV_Tab) qevSerialCom.sendDataToSerial(5);                //packet type 5
                else if (mainScreenTabControl.SelectedTab == Cooling_Tab) qevSerialCom.sendDataToSerial(6);            //packet type 6
                else if (mainScreenTabControl.SelectedTab == Safety_Tab) qevSerialCom.sendDataToSerial(7);             //packet type 7
                else if (mainScreenTabControl.SelectedTab == Safety_Tab) qevSerialCom.sendDataToSerial(8);             //packet type 8
                else if (mainScreenTabControl.SelectedTab == Diagnostics_Tab) qevSerialCom.sendDataToSerial(9);        //packet type 9
                else qevSerialCom.sendDataToSerial(1);

                // Thread Sleep called from serial function

                // Read data from the CC
                qevSerialCom.processIncomingBytestream();

            }

            catch
            {
                qevSerialCom.connectECU(false);
                qevSerialCom.connectSerial(DISCONNECT, null);
                statusConnectionStatus.BackColor = Color.Red;
                MessageBox.Show("Serial Port Access Error", "Comms Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TorqueVectoring_Tab_Enter(object sender, EventArgs e)
        {
            DataTable newTable = new DataTable();

            try
            {
                foreach (string column in TVtable_1[0])
                {
                    newTable.Columns.Add();
                }

                foreach (string[] row in TVtable_1)
                {
                    newTable.Rows.Add(row);
                }

                dataGridView1.DataSource = newTable;
            }

            catch
            {
                MessageBox.Show("No Dynamics Data Available", "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Overview_Tab_Click(object sender, EventArgs e)
        {

        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ant\Documents\Visual Studio 2013\Projects\QEV1_config\QEV1_config\Resources\aw_crap.wav");
            simpleSound.Play();
        }


        private void drawTab(byte tabNumber, byte headerNumber)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            // This sample assumes that you have a folder named "c:\temp" on your computer.
            string filePath = @"c:\pctools\4C031_106.gi4";

            /*
            // Delete the file if it exists.
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            // Create the file.
            using (FileStream fs = File.Create(filePath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            */
            // Open the stream and read it back.
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    firmwareTextBox.AppendText(temp.GetString(b));
                }

                try
                {
                    // Try to write to the file.
                    fs.Write(b, 0, b.Length);
                }
                catch
                {
                    Console.WriteLine("Writing was disallowed, as expected: {0}", e.ToString());
                }
            }


        }

        private void balancingButton_Click(object sender, EventArgs e)
        {
            if (balancingLabel.Text == "Balancing Off")
            {
                qevSerialCom.setAddressChunk(200);
                qevSerialCom.setDataChunk(1);
                balancingLabel.Text = "Balancing On";
            }

            else
            {
                qevSerialCom.setAddressChunk(200);
                qevSerialCom.setDataChunk(200);
                balancingLabel.Text = "Balancing Off";
            }
        }
        #region Front Accumulator Event handlers
        private void frontAccumulatorBrick1_Click(object sender, EventArgs e) {
            MessageBox.Show("front Accumulator 1 success");
        }
        private void frontAccumulatorBrick2_Click(object sender, EventArgs e) {
            MessageBox.Show("front Accumulator 2 success");
        }
        private void frontAccumulatorBrick3_Click(object sender, EventArgs e) {
            MessageBox.Show("front Accumulator 3 success");
        }
        private void frontAccumulatorBrick4_Click(object sender, EventArgs e) {
            MessageBox.Show("front Accumulator 4 success");
        }
        private void frontAccumulatorBrick5_Click(object sender, EventArgs e) {
            MessageBox.Show("front Accumulator 5 success");
        }
        private void frontAccumulatorBrick6_Click(object sender, EventArgs e) {
            MessageBox.Show("front Accumulator 6 success");
        }
        #endregion
        #region Rear Accumulator Event handlers
        private void rearAccumulatorBrick1_Click(object sender, EventArgs e) {
            MessageBox.Show("rear Accumulator 1 success");
        }

        private void rearAccumulatorBrick2_Click(object sender, EventArgs e) {
            MessageBox.Show("rear Accumulator 2 success");
        }

        private void rearAccumulatorBrick3_Click(object sender, EventArgs e) {
            MessageBox.Show("rear Accumulator 3 success");
        }

        private void rearAccumulatorBrick4_Click(object sender, EventArgs e) {
            MessageBox.Show("rear Accumulator 4 success");
        }

        private void rearAccumulatorBrick5_Click(object sender, EventArgs e) {
            MessageBox.Show("rear Accumulator 5 success");
        }

        private void rearAccumulatorBrick6_Click(object sender, EventArgs e) {
            MessageBox.Show("rear Accumulator 6 success");
        }
        #endregion

        private void guiUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Test GUI code here for now until packets are avaliable to read.
            Packet testPacket = new Packet(0,0,10,5,1,0,0,0,0);
            testPacket.AddMessage(2);
            if (mainScreenTabControl.SelectedIndex == 4)
            {
                byte[] packetData = testPacket.getMessagesAsArray();
                switch (packetData[0])
                {
                    case 0:
                        PMstatusLabel6.Text = "ON";
                        PMstatusLabel6.ForeColor = System.Drawing.Color.Green;
                        PMstatusLabel6.BackColor = Color.FromArgb(192, 255, 192);
                        break;

                    case 1:
                        PMstatusLabel6.Text = "OFF";
                        PMstatusLabel6.ForeColor = System.Drawing.Color.Black;
                        PMstatusLabel6.BackColor = System.Drawing.Color.Transparent;
                        break;

                    case 2:
                        PMstatusLabel6.Text = "DISABLED";
                        PMstatusLabel6.ForeColor = System.Drawing.Color.DimGray;
                        PMstatusLabel6.BackColor = Color.FromArgb(224, 224, 224);
                        break;

                    case 3:
                        PMstatusLabel6.Text = "TRIP";
                        PMstatusLabel6.ForeColor = System.Drawing.Color.White;
                        PMstatusLabel6.BackColor = System.Drawing.Color.Red;
                        break;

                    case 4:
                        PMstatusLabel6.Text = "FAULT";
                        PMstatusLabel6.ForeColor = System.Drawing.Color.DimGray;
                        PMstatusLabel6.BackColor = Color.FromArgb(255, 192, 192);
                        break;
                }
            }

            // Read the next packet
            try
            {
                Packet currentPacket = qevSerialCom.GetNextPacket();
                statusStripErrorFlag.Text = "No Errors";

                // Update the GUI depending on packet contents and current tab index
            }

            catch
            {
                // Could not retrieve a packet
                statusStripErrorFlag.Text = "Could Not Retrieve Next Packet";
            }
        }
    }
}
