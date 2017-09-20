using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace Low_Level_Functions_Library
{
    public class Serial_Functions
    {
        private static string[] portList;
        private const int connect = 128;
        private const int disconnect = 1;
        private static bool ECUconnected = false;
        private static int portNumberIndex = 0;

        private static int portNumberMax;
        private static bool errorsEnabled = true;
        private static bool errorsDisabled = false;

        private static bool[] SerialConnectBool = new bool[2];

        private static ushort addr_chunk = 0;
        private static long data_chunk = 0;
        //int responseHeader = 0;
        private static byte[] incomingString = new byte[60];
        private static int stringIndex = 0;
        private static ushort stringMode = 0;
        private static ushort packetMode = 0;
        private static List<string[]> TVtable_1;

        private static byte loggingTrue = 0;

        private const int Overview = 1;
        // Test Change


        public static bool IfSerialDetected(bool errorMode) {
            portList = SerialPort.GetPortNames();

            if (portList.Length > 0) {
                portNumberMax = portList.Length - 1;
                portNumberIndex = 0;
                return true;
            }

            else {
                ECUconnected = false;
                return false;
            }
        }
        public static bool connectionStatus() {
            return ECUconnected;
        }
        public static string returnPortNumber() {
            if (portList.Length > 0) {
                return portList[portList.Length - 1];
            }
            else {
                return null;
            }
        }

        public static bool[] connectSerialLogic(int request) {
			if (portList.Length > 0) {
				if (request == connect) {
					ECUconnected = true;
					SerialConnectBool[0] = true; //conection status true means connect, false means disconnect
					SerialConnectBool[1] = true;//true means has ports list
					return SerialConnectBool;
				}
				else {
					ECUconnected = false;
					SerialConnectBool[0] = false;
					SerialConnectBool[1] = true;
					return SerialConnectBool;
				}
			}
			else if (request == connect) {
				SerialConnectBool[0] = true;
				SerialConnectBool[1] = false;
				return SerialConnectBool;
			}
            else{
                SerialConnectBool[0] = false;
                SerialConnectBool[1] = false;
                return SerialConnectBool;
            }
        }
    }
}
