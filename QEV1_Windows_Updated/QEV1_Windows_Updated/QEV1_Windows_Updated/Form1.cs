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
            // TODO Move anything serial to the SerialCommunication class, so that it 
            // is completely abstracted from the GUI
            serial = new Serial();
            scanSerials(errorsDisabled);

        }

        private void statusCOMnumber_Click(object sender, EventArgs e)
        {
            // TODO Move anything serial to the SerialCommunication class, so that it 
            // is completely abstracted from the GUI
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
            // TODO Move anything serial to the SerialCommunication class, so that it 
            // is completely abstracted from the GUI
            if (ECUconnected) connectSerial(DISCONNECT);
            else connectSerial(CONNECT);
        }

        private void scanSerials(bool errorMode)
        {

            // TODO Move anything serial to the SerialCommunication class, so that it 
            // is completely abstracted from the GUI

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
            // TODO Move anything to the SerialCommunication class, so that it 
            // is completely abstracted from the GUI
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
                SerialCommunication serialcomm = new SerialCommunication(serialPort1);
                
                if (mainScreenTabControl.SelectedTab == Accumulators_Tab) serialcomm.sendDataToSerial(2, addr_chunk, data_chunk);            //packet type 2
                else if (mainScreenTabControl.SelectedTab == Inverters_Tab) serialcomm.sendDataToSerial(3, addr_chunk, data_chunk);          //packet type 3
                else if (mainScreenTabControl.SelectedTab == TorqueVectoring_Tab) serialcomm.sendDataToSerial(4, addr_chunk, data_chunk);    //packet type 4
                else if (mainScreenTabControl.SelectedTab == GLV_Tab) serialcomm.sendDataToSerial(5, addr_chunk, data_chunk);                //packet type 5
                else if (mainScreenTabControl.SelectedTab == Cooling_Tab) serialcomm.sendDataToSerial(6, addr_chunk, data_chunk);            //packet type 6
                else if (mainScreenTabControl.SelectedTab == Safety_Tab) serialcomm.sendDataToSerial(7, addr_chunk, data_chunk);             //packet type 7
                else if (mainScreenTabControl.SelectedTab == Safety_Tab) serialcomm.sendDataToSerial(8, addr_chunk, data_chunk);             //packet type 8
                else if (mainScreenTabControl.SelectedTab == Diagnostics_Tab) serialcomm.sendDataToSerial(9, addr_chunk, data_chunk);        //packet type 9
                else serialcomm.sendDataToSerial(1, addr_chunk, data_chunk);

                addr_chunk = 0;
                data_chunk = 0;

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
