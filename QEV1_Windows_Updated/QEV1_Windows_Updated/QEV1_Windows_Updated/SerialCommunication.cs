using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        SerialPort readingSerialPort;
        int messageMode;
        int messageIndex;
        byte[] incomingMessage;

        public SerialCommunication (SerialPort serialPortIn)
        {
            readingSerialPort = serialPortIn;
            incomingMessage = new byte[MESSAGESIZE];
            processIncomingBytestream();
        }

        public void processIncomingBytestream()
        {
            byte tempByte;
            
            // While there is still information to be processed
            while (readingSerialPort.BytesToRead > 0)
            {
                tempByte = (byte)readingSerialPort.ReadByte();
                if (messageMode == READYMODE)
                {
                    // Wait for the signal to start reading (a 'D' character)
                    if (tempByte == 'D')
                    {
                        messageMode = READINGMODE;
                        messageIndex = 0;
                    }
                } else if (messageMode == READINGMODE)
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
            }

            
        }

        
    }
}
