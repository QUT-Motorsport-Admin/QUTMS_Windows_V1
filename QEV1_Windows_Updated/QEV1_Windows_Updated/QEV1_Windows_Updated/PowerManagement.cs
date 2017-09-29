using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEV1_Windows_Updated
{
    static class PowerManagement
    {
        // Get address variables.
        public static int GetAddress(int ChannelNumber, int FirstAddress, int Address_Seperation)
        {
            return FirstAddress + (ChannelNumber - 1) * Address_Seperation;
        }

        public static int GetChannelNameAddress(int ChannelNumber)
        {
            return GetAddress(ChannelNumber, 200, 16);
        }

        public static int GetChannelConfigAddress(int ChannelNumber)
        {
            return GetAddress(ChannelNumber, 390, 1);
        }

        public static int GetTCBAddress(int ChannelNumber)
        {
            return GetAddress(ChannelNumber, 410, 1);
        }
    }
}
