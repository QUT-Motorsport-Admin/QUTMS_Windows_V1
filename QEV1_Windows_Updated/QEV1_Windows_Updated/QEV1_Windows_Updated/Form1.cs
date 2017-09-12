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
        //string[] portList;

        const int CONNECT = 128;
        const int DISCONNECT = 1;
        bool ECUconnected = false;
        int portNumberIndex = 0;

        //int portNumberMax;
        bool errorsEnabled = true;
        bool errorsDisabled = false;

        ushort addr_chunk = 0;
        long data_chunk = 0;
        //int responseHeader = 0;
        byte[] incomingString = new byte[60];
        int stringIndex = 0;
        ushort stringMode = 0;
        ushort packetMode = 0;
        public List<string[]> TVtable_1;

        byte loggingTrue = 0;

        public const int OVERVIEW = 1;





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial = new Serial();
            scanSerials(errorsDisabled);

        }

        private void statusCOMnumber_Click(object sender, EventArgs e)
        {
            portNumberIndex++;
            if (portNumberIndex > serial.PortNumberMax) portNumberIndex = 0;
            if (serial.PortsExist()) statusCOMnumber.Text = serial.getPort(portNumberIndex);
            else
            {
                statusCOMnumber.Text = "No Ports";
            }
        }

        private void statusConnectionStatus_Click(object sender, EventArgs e)
        {
            if (ECUconnected) connectSerial(DISCONNECT);
            else connectSerial(CONNECT);
        }

        private void scanSerials(bool errorMode)
        {
            

            if (serial.PortsExist())
            {
                // Set starting point for port searching
                portNumberIndex = 0;

                // Update GUI to show number of ports
                statusCOMnumber.Text = serial.getPort(serial.PortNumberMax);

                // Set SerialPort properties
                serialPort1.ReadTimeout = 10000;
                serialPort1.BaudRate = 19200;
            }

            else
            {
                // Update GUI to show no ports
                statusConnectionStatus.Text = "No Ports";
                statusConnectionStatus.BackColor = Color.Yellow;
                
                ECUconnected = false;
                connectSerial(DISCONNECT);
                getDataTimer.Enabled = false;

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
                if (serial.PortsExist())
                {
                    if (request == CONNECT)
                    {
                        // If there are ports and we want to connect, open the port
                        serialPort1.PortName = statusCOMnumber.Text;
                        serialPort1.Open();

                        // Update GUI
                        statusConnectionStatus.Text = "Connected";
                        statusConnectionStatus.BackColor = System.Drawing.Color.DarkSeaGreen;

                        ECUconnected = true;

                        // Update timer settings
                        getDataTimer.Interval = 50; // normally 50
                        getDataTimer.Enabled = true;
                        Thread.Sleep(500);
                    }

                    else
                    {
                        // If there are ports and we don't want to connect, close the port
                        ECUconnected = false;
                        getDataTimer.Enabled = false;
                        serialPort1.Close();
                        statusConnectionStatus.Text = "Disconnected";
                        statusConnectionStatus.BackColor = System.Drawing.Color.IndianRed;
                    }
                }

                else if (request == CONNECT)
                {
                    // If there are no ports, display an error
                    MessageBox.Show("No Ports Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    statusConnectionStatus.Text = "No Ports";
                }

            }

            catch
            {
                MessageBox.Show("Port Error", "OS Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //statusConnectionStatus.Text = "Port Fault";
                statusConnectionStatus.BackColor = Color.Red;
                ECUconnected = false;
                connectSerial(DISCONNECT);
                getDataTimer.Enabled = false;
            }
        }

        private void getDataTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                /*
                while ((serialPort1.BytesToRead > 0) /*&& (stringIndex < 60))                 //incoming bytes waiting, build the string
                {
                    // Read in the byte
                    byte tempByte = (byte)serialPort1.ReadByte();

                    // If the byte is a 'D' character, switch to string entry mode and begin reading string
                    if (tempByte == 'D')
                    {
                        stringMode = 1;
                        stringIndex = 0;

                    }

                    // If in string entry mode, continue reading in string
                    else if (stringMode == 1)
                    {
                        incomingString[stringIndex] = tempByte;     //copy the byte into incoming buffer
                        stringIndex = stringIndex + 1;              //increment the index
                    }

                    // If we have reached the end of the byte, switch stringMode appropriately
                    if (stringIndex > 31)
                    {
                        stringMode = 2;
                    }
                }

                if (stringMode == 2)                    //buffer complete so process
                {

                    //rebuild the decimal 68 bytes
                    //process the packet
                    stringMode = 0;                     //rest mode to 0 for next time

                    //restore the 68s
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if ((incomingString[i + 28] & (1 << j)) > 0) incomingString[(i * 7) + j] = 68;
                        }
                    }

                    //Decide which packet type is incoming and update the relevant data

                    byte headerType = incomingString[1];

                    if (headerType < 10) drawTab(OVERVIEW, headerType);

                    decimal tempDecimal = (incomingString[2] << 8) + incomingString[3];
                    //AvgVolts.Text = (tempDecimal / 1000).ToString("F3");

                    tempDecimal = (incomingString[4] << 8) + incomingString[5];
                    //AvgTemp.Text = (tempDecimal / 1000).ToString("F1");


                    tempDecimal = (incomingString[2] << 8) + incomingString[3];
                    avgVoltsLabel.Text = (tempDecimal / 1000).ToString("F3");


                    tempDecimal = (incomingString[12] << 8) + incomingString[13];
                    maxCellTempLabel.Text = (tempDecimal).ToString();


                    tempDecimal = ((incomingString[16] << 8) + incomingString[17]) - 500;
                    DCcurrentLabel.Text = (tempDecimal).ToString();

                    tempDecimal = (incomingString[14] << 8) + incomingString[15];
                    inverterTempLabel.Text = (tempDecimal).ToString();


                    tempDecimal = (incomingString[18] << 8) + incomingString[19];
                    coolantTempLabel.Text = (tempDecimal / 10).ToString("F1");
                    tempDecimal = (incomingString[8] << 8) + incomingString[9];
                    //Volts1.Text = (tempDecimal / 1000).ToString("F3");
                    tempDecimal = (incomingString[10] << 8) + incomingString[11];
                    //Volts2.Text = (tempDecimal / 1000).ToString("F3");
                    tempDecimal = (incomingString[12] << 8) + incomingString[13];
                    //Volts3.Text = (tempDecimal / 1000).ToString("F3");
                    tempDecimal = (incomingString[14] << 8) + incomingString[15];
                    //Volts4.Text = (tempDecimal / 1000).ToString("F3");
                    tempDecimal = (incomingString[16] << 8) + incomingString[17];
                    //Volts5.Text = (tempDecimal / 1000).ToString("F3");
                    tempDecimal = (incomingString[18] << 8) + incomingString[19];
                    //Volts6.Text = (tempDecimal / 1000).ToString("F3");
                    tempDecimal = (incomingString[20] << 8) + incomingString[21];
                    //Volts7.Text = (tempDecimal / 1000).ToString("F3");

                    tempDecimal = (incomingString[22] << 8) + incomingString[23];
                    throttleLabel.Text = (tempDecimal * 100 / 512).ToString("F1");
                    tempDecimal = (incomingString[24] << 8) + incomingString[25];
                    RPM.Text = (tempDecimal).ToString();

                    tempDecimal = (incomingString[26]);
                    if (tempDecimal > 0)
                    {
                        Enable1.Text = "True";
                        Enable1.ForeColor = System.Drawing.Color.Green;
                    }

                    else
                    {
                        Enable1.Text = "False";
                        Enable1.ForeColor = System.Drawing.Color.Red;
                    }

                }
                */

                SerialCommunication serialcomm = new SerialCommunication(serialPort1);
                
                /*
                 * TODO: Move the code below to the SerialCommunicaiton Class
                byte[] tempBuffer = new byte[10];

                tempBuffer[0] = 68;                                                                     //capital 'D' in decimal ascii (the preserved character)
                if (mainScreenTabControl.SelectedTab == Accumulators_Tab) tempBuffer[1] = 2;            //packet type 2
                else if (mainScreenTabControl.SelectedTab == Inverters_Tab) tempBuffer[1] = 3;          //packet type 3
                else if (mainScreenTabControl.SelectedTab == TorqueVectoring_Tab) tempBuffer[1] = 4;    //packet type 4
                else if (mainScreenTabControl.SelectedTab == GLV_Tab) tempBuffer[1] = 5;                //packet type 5
                else if (mainScreenTabControl.SelectedTab == Cooling_Tab) tempBuffer[1] = 6;            //packet type 6
                else if (mainScreenTabControl.SelectedTab == Safety_Tab) tempBuffer[1] = 7;             //packet type 7
                else if (mainScreenTabControl.SelectedTab == Safety_Tab) tempBuffer[1] = 8;             //packet type 8
                else if (mainScreenTabControl.SelectedTab == Diagnostics_Tab) tempBuffer[1] = 9;        //packet type 9
                else tempBuffer[1] = 1;                                                                 //packet type 1 is the default

                tempBuffer[2] = (byte)(addr_chunk >> 8);        //address section top byte
                tempBuffer[3] = (byte)addr_chunk;               //address section lower byte
                tempBuffer[4] = (byte)(data_chunk >> 24);       //data section very top byte
                tempBuffer[5] = (byte)(data_chunk >> 16);       //data section very top byte
                tempBuffer[6] = (byte)(data_chunk >> 8);        //data Section second top byte
                tempBuffer[7] = (byte)data_chunk;               //data section second lowest byte

                serialPort1.Write(tempBuffer, 0, 10);

                addr_chunk = 0;
                data_chunk = 0;                                 //reset the temporary holders
                */

                Thread.Sleep(10);
            }

            catch
            {
                statusConnectionStatus.BackColor = Color.Red;
                ECUconnected = false;
                connectSerial(DISCONNECT);
                getDataTimer.Enabled = false;
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
                addr_chunk = 200;
                data_chunk = 1;
                balancingLabel.Text = "Balancing On";
            }

            else
            {
                addr_chunk = 200;
                data_chunk = 0;
                balancingLabel.Text = "Balancing Off";
            }
        }

    }

}
