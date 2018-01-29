using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEV1_Windows_Updated
{
    class SerialCommunication
    {
        private const int READYMODE = 0;
        private const int READINGMODE = 1;
        private const int PROCESSINGMODE = 2;
        private const int MESSAGESIZE = 60;

        private byte headerType;
        private const int INDEX_HEADERTYPE = 1;

        private decimal avgVolts;
        private const int INDEX_AVGVOLTS = 2;

        private decimal avgTemp;
        private const int INDEX_AVGTEMP = 4;

        private decimal maxCellTemp;
        private const int INDEX_MAXCELLTEMP = 12;

        private decimal DCCurrent;
        private const int INDEX_DCCURRENT = 16;

        private decimal inverterTemp;
        private const int INDEX_INVERTERTEMP = 14;

        private decimal coolantTemp;
        private const int INDEX_COOLANTTEMP = 18;

        private decimal volts1;
        private const int INDEX_VOLTS1 = 8;

        private decimal volts2;
        private const int INDEX_VOLTS2 = 10;

        private decimal volts3;
        private const int INDEX_VOLTS3 = 12;

        private decimal volts4;
        private const int INDEX_VOLTS4 = 14;

        private decimal volts5;
        private const int INDEX_VOLTS5 = 16;

        private decimal volts6;
        private const int INDEX_VOLTS6 = 18;

        private decimal volts7;
        private const int INDEX_VOLTS7 = 20;

        private decimal throttle;
        private const int INDEX_THROTTLE = 22;

        private decimal rpm;
        private const int INDEX_RPM = 24;

        private decimal enable;
        private const int INDEX_ENABLE = 26;

        public const int DISCONNECT = 1;
        public const int CONNECT = 128;

        public enum packetFormat
        {
            header = 0,
            sequence = 1,
            packetLength = 2,
            viewPage = 3,
            viewData = 4,
            parameter = 5,
            data0 = 7
            // Variable data length, therefore no check sum here due to varying position
        }

        public enum connectSerialCodes {
            connectNoPorts, 
            connectPorts,
            disconnect
        }

        SerialPort qevSerialPort;
        System.Windows.Forms.Timer qevDataTimer;
        Serial qevSerial;

        private Queue<Packet> packetQueue;

        private int portNumberIndex;
        private bool ECUconnected;

        ushort addr_chunk;
        long data_chunk;

        int messageMode;
        int messageIndex;
        byte[] incomingMessage;

        /// <summary>
        /// Handles all of the serial communications made by the class
        /// </summary>
        /// <param name="serialPortIn">The input serial port object from the GUI</param>
        /// <param name="timerIn">The input timer object from the GUI</param>
        public SerialCommunication (SerialPort serialPortIn, System.Windows.Forms.Timer timerIn)
        {   
            // Initialise objects
            qevSerial = new Serial();
            portNumberIndex = 0;
            ECUconnected = false;

            qevSerialPort = serialPortIn;
            qevDataTimer = timerIn;

            packetQueue = new Queue<Packet>();

            incomingMessage = new byte[MESSAGESIZE];
            //processIncomingBytestream();
        }

        /// <summary>
        /// Checks to see if there are any available serial ports
        /// </summary>
        /// <param name="errorMode">Nothing so far</param>
        /// <returns>True if ports exist, false otherwise</returns>
        public bool scanSerials(bool errorMode)
        {
            return qevSerial.PortsExist();
        }

        /// <summary>
        /// Sets the serial port's timeout rate and baud rate
        /// </summary>
        /// <param name="timeout">The serial port's timeout rate</param>
        /// <param name="baud">The serial port's baud rate</param>
        public void setTimeoutAndBaud(int timeout, int baud)
        {
            qevSerialPort.ReadTimeout = timeout;
            qevSerialPort.BaudRate = baud;
        }

        /// <summary>
        /// Resets where to look for ports
        /// </summary>
        public void resetPort()
        {
            portNumberIndex = 0;
        }

        /// <summary>
        /// Gets the number of available ports
        /// </summary>
        /// <returns>The number of available ports</returns>
        public string getNumberofPorts()
        {
            return qevSerial.getPort(qevSerial.PortNumberMax);
        }

        /// <summary>
        /// Increments the port to look at when analysing ports
        /// </summary>
        /// <returns>The current port name as a string, or "No Ports" if there are none</returns>
        public string incrementPort()
        {
            portNumberIndex++;
            if (portNumberIndex > qevSerial.PortNumberMax) resetPort();
            if (qevSerial.PortsExist())
            {
                return qevSerial.getPort(portNumberIndex);
            } else
            {
                return "No Ports";
            }
        }

        public void connectToSerial(int request) 
        {
            
        }

        /// <summary>
        /// Reads and analyses an incoming stream of bytes
        /// </summary>
        public void processIncomingBytestream()
        {
            try
            {
                byte tempByte;
                Packet newPacket;

                // While there is still information to be processed
                while (qevSerialPort.BytesToRead > 0)
                {
                    tempByte = (byte)qevSerialPort.ReadByte();
                    if (messageMode == READYMODE)
                    {
                        // Wait for the signal to start reading (a 'D' character)
                        if (tempByte == 'D')
                        {
                            messageMode = READINGMODE;
                            messageIndex = 0;
                        }
                    }
                    else if (messageMode == READINGMODE)
                    {
                        // Read the incoming message
                        incomingMessage[messageIndex] = tempByte;
                        messageIndex++;
                    }

                    // If we have reached the end of the message, jump to processing mode
                    if (messageIndex > 31)
                    {
                        messageMode = PROCESSINGMODE;
                        break;
                    }
                }

                if (messageMode == PROCESSINGMODE)
                {
                    // Return to ready mode for next time
                    messageMode = READYMODE;

                    /*
                    // Restore the 68's (???)
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if ((incomingMessage[i + 28] & (1 << j)) > 0) incomingMessage[(i * 7) + j] = 68;
                        }
                    }

                    
                    headerType = incomingMessage[INDEX_HEADERTYPE];

                    // Do something based on headertype

                    avgVolts = (incomingMessage[INDEX_AVGVOLTS] << 8) + incomingMessage[INDEX_AVGVOLTS + 1];
                    avgTemp = (incomingMessage[INDEX_AVGTEMP] << 8) + incomingMessage[INDEX_AVGTEMP + 1];
                    maxCellTemp = (incomingMessage[INDEX_MAXCELLTEMP] << 8) + incomingMessage[INDEX_MAXCELLTEMP + 1];
                    DCCurrent = (incomingMessage[INDEX_DCCURRENT] << 8) + incomingMessage[INDEX_DCCURRENT + 1];
                    inverterTemp = (incomingMessage[INDEX_INVERTERTEMP] << 8) + incomingMessage[INDEX_INVERTERTEMP + 1];
                    coolantTemp = (incomingMessage[INDEX_COOLANTTEMP] << 8) + incomingMessage[INDEX_COOLANTTEMP + 1];

                    volts1 = (incomingMessage[INDEX_VOLTS1] << 8) + incomingMessage[INDEX_VOLTS1 + 1];
                    volts2 = (incomingMessage[INDEX_VOLTS2] << 8) + incomingMessage[INDEX_VOLTS2 + 1];
                    volts3 = (incomingMessage[INDEX_VOLTS3] << 8) + incomingMessage[INDEX_VOLTS3 + 1];
                    volts4 = (incomingMessage[INDEX_VOLTS4] << 8) + incomingMessage[INDEX_VOLTS4 + 1];
                    volts5 = (incomingMessage[INDEX_VOLTS5] << 8) + incomingMessage[INDEX_VOLTS5 + 1];
                    volts6 = (incomingMessage[INDEX_VOLTS6] << 8) + incomingMessage[INDEX_VOLTS6 + 1];
                    volts7 = (incomingMessage[INDEX_VOLTS7] << 8) + incomingMessage[INDEX_VOLTS7 + 1];

                    throttle = (incomingMessage[INDEX_THROTTLE] << 8) + incomingMessage[INDEX_THROTTLE + 1];
                    rpm = (incomingMessage[INDEX_RPM] << 8) + incomingMessage[INDEX_RPM + 1];
                    enable = incomingMessage[INDEX_ENABLE];
                    // If enable == 0 do something, else to something else
                    */
                    newPacket = new Packet(
                        incomingMessage[(int)packetFormat.header], // Packet Header
                        incomingMessage[(int)packetFormat.sequence], // Packet Sequence
                        incomingMessage[(int)packetFormat.packetLength], // Packet Length
                        incomingMessage[(int)packetFormat.viewPage], // Packet View Page
                        incomingMessage[(int)packetFormat.viewData], // Packet View Data
                        incomingMessage[(int)packetFormat.parameter], // Packet Parameter Byte 1
                        incomingMessage[(int)packetFormat.parameter + 1], // Packet Parameter Byte 2
                        incomingMessage[incomingMessage[(int)packetFormat.packetLength] - 2], // Packet Check Sum Byte 1
                        incomingMessage[incomingMessage[(int)packetFormat.packetLength] - 1]); // Packet Check Sum Byte 2

                    for (int i = incomingMessage[(int)packetFormat.data0]; i < newPacket.PacketLength - 3; i++)
                    {
                        newPacket.AddMessage(incomingMessage[i]);
                    }
                    
                    // Add Packet to the Queue
                    packetQueue.Enqueue(newPacket);
                }
            }
            catch
            {
                MessageBox.Show("Error reading ports", "Port Error");
            }
        }

        public void setAddressChunk(ushort value)
        {
            addr_chunk = value;
        }

        public void setDataChunk(long value)
        {
            data_chunk = value;
        }

        /// <summary>
        /// Send data to the serial port
        /// </summary>
        /// <param name="putVal">Value to put into buffer 1</param>
        /// <param name="addr_chunk">Address section value</param>
        /// <param name="data_chunk">Data section value</param>
        public void sendDataToSerial(byte putVal)
        {
            // Initialise the buffer to send to the serial port
            byte[] tempBuffer = new byte[10];

            // Initialise buffer zero to 68 (why?)
            tempBuffer[0] = 68;

            // Put the input value to buffer one
            tempBuffer[1] = putVal;

            // Put the addr_chunk data into the buffer
            tempBuffer[2] = (byte)(addr_chunk >> 8);        //address section top byte
            tempBuffer[3] = (byte)addr_chunk;               //address section lower byte

            // Put the data chunck into the buffer
            tempBuffer[4] = (byte)(data_chunk >> 24);       //data section very top byte
            tempBuffer[5] = (byte)(data_chunk >> 16);       //data section second top byte
            tempBuffer[6] = (byte)(data_chunk >> 8);        //data Section second lowest byte
            tempBuffer[7] = (byte)data_chunk;               //data section very lowest byte

            // Write the data to the serial port
            qevSerialPort.Write(tempBuffer, 0, 10);

            // Sleep for a moment
            Thread.Sleep(10);
        }

        /// <summary>
        /// Inform the program whether the ECU is connected or not, and turn the data timer on/off accordingly
        /// </summary>
        /// <param name="isConnected">Value to set ECU connection status</param>
        public void connectECU(bool isConnected)
        {
            ECUconnected = isConnected;
            qevDataTimer.Enabled = isConnected;
        }

        /// <summary>
        /// Determine whether the ECU is connected or not
        /// </summary>
        /// <returns>True if ECU is connected, false otherwise</returns>
        public bool isECUConnected()
        {
            return ECUconnected;
        }

        /// <summary>
        /// Connect/Disconnect ECU
        /// </summary>
        /// <param name="request">Value to determine whether the ECU is connecting or disconnecting</param>
        /// <param name="portText">Name to assign to port</param>
        /// <returns>Status code depending on whether ports existed, and on connect/disconnect request</returns>
        public int connectSerial(int request, string portText)
        {
            if (qevSerial.PortsExist())
            {
                if (request == CONNECT)
                {
                    qevSerialPort.PortName = portText;
                    qevSerialPort.Open();

                    qevDataTimer.Interval = 50;
                    qevDataTimer.Enabled = true;
                    connectECU(true);
                    Thread.Sleep(500);
                    return (int)connectSerialCodes.connectPorts;
                }

                else
                {
                    connectECU(false);
                    qevDataTimer.Enabled = false;
                    qevSerialPort.Close();
                    return (int)connectSerialCodes.connectNoPorts;
                }
            }

            else
            {
                connectECU(false);
                qevDataTimer.Enabled = false;
                qevSerialPort.Close();
                return (int)connectSerialCodes.disconnect;
            }
        }

        public Packet GetNextPacket()
        {
            return packetQueue.Dequeue();
        }
    }
}
