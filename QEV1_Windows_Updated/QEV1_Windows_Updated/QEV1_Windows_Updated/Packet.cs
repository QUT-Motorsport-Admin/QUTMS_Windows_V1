using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QEV1_Windows_Updated
{
    class Packet
    {
        private byte header;
        private byte sequence;
        private byte packetLength;
        private byte viewPage;
        private byte viewData;
        private byte[] parameter;
        private ArrayList message;
        private byte[] checkSum;

        public Packet(byte header, byte sequence, byte packetLength, byte viewPage, 
            byte viewData, byte parameter1, byte parameter2, byte checksum1, byte checksum2)
        {
            this.header = header;
            this.sequence = sequence;
            this.packetLength = packetLength;
            this.viewPage = viewPage;
            this.viewData = viewData;

            this.parameter = new byte[2];
            this.parameter[0] = parameter1;
            this.parameter[1] = parameter2;

            this.checkSum = new byte[2];
            this.checkSum[0] = checksum1;
            this.checkSum[1] = checksum2;

            this.message = new ArrayList();
            this.message.Capacity = this.packetLength - 9;
        }

        public void AddMessage(byte messageByte)
        {
            message.Add(messageByte);
        }

        public byte[] getMessagesAsArray()
        {
            byte[] temp = new byte[message.Count];
            for (int i = 0; i < message.Count; i++)
            {
                temp[i] = (byte)message[i];
            }
            return temp;
        }

        public void clearMessages()
        {
            message.Clear();
        }

        public byte Header {
            get 
            {
                return header;
            }
        }

        public byte Sequence {
            get {
                return sequence;
            }
        }

        public byte PacketLength {
            get {
                return packetLength;
            }
        }

        public byte ViewPage {
            get {
                return viewPage;
            }
        }

        public byte ViewData {
            get {
                return viewData;
            }
        }

        public byte[] Parameter {
            get {
                return parameter;
            }
        }

        public byte[] CheckSum {
            get {
                return checkSum;
            }
        }

    }
}
