using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QEV1_Windows_Updated
{
    class Serial
    {
        private string[] portList;
        private int portNumberMax;

        public Serial()
        {
            portList = SerialPort.GetPortNames();
            portNumberMax = portList.Length - 1;
        }

        public string[] PortList {
            get {
                return portList;
            } 
        }

        public int PortNumberMax {
            get {
                return portNumberMax;
            }
        }

        public bool PortsExist()
        {
            return portList.Length > 0;
        }

        public int getNumPorts()
        {
            return portList.Length;
        }

        public string getPort(int index)
        {
            return portList[index];
        }
    }
}
