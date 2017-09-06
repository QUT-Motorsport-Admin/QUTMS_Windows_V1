using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Functions_Library;
using System.Threading;

namespace QEV1_Windows {
    public partial class Form1 : Form {
        //variables
        const int disconect = 1;
        const int connect = 128;
        bool[] connectSerialBool = new bool[2] { true, true };

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ScanSerial(true);
        }

        private void ScanSerial(bool errorMode) {
            bool serialDetected = Serial_Functions.IfSerialDetected(errorMode);
            string portNum = Serial_Functions.returnPortNumber();

            if (serialDetected == true) {
                ComPortNumber.Text = Serial_Functions.returnPortNumber();
                serialPort.ReadTimeout = 10000;
                serialPort.BaudRate = 19200;
            }
            else {
                SerialConnectionStatus.Text = "No Ports";
                SerialConnectionStatus.BackColor = Color.Yellow;
                serialConnect(disconect);
            }
        }

        private void serialConnect(int request){
            connectSerialBool = Serial_Functions.connectSerialLogic(request);
            if (connectSerialBool[0] && connectSerialBool[1]) {
                serialPort.PortName = ComPortNumber.Text;
                serialPort.Open();
                SerialConnectionStatus.Text = "Connected";
                SerialConnectionStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
                Thread.Sleep(500);
            }
            if (!connectSerialBool[0] && connectSerialBool[1]) {
                serialPort.Close();
                SerialConnectionStatus.Text = "Disconnected";
                SerialConnectionStatus.BackColor = System.Drawing.Color.IndianRed;
            }
            if(connectSerialBool[0] && !connectSerialBool[1]) {
                MessageBox.Show("No Ports Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SerialConnectionStatus.Text = "No Ports";
            }

            if(!connectSerialBool[0] && !connectSerialBool[1]) {
                MessageBox.Show("Port Error", "OS Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //statusConnectionStatus.Text = "Port Fault";
                SerialConnectionStatus.BackColor = Color.Red;
            }
        }

        private void SerialConnectionStatus_Click(object sender, EventArgs e) {
            if (Serial_Functions.connectionStatus()) {
                serialConnect(disconect);
            }
            else {
                serialConnect(connect);
            }
        }
    }
}