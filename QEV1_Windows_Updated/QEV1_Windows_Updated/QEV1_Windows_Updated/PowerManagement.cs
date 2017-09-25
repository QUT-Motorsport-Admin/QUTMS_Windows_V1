using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEV1_Windows_Updated
{
    public class PowerManagement
    {
        // Declare address variables.
        private int NameAddress_First;
        private int ConfigAddress_First;
        private int TCBAddress_First;
        private int NameAddress_Seperation;
        private int ConfigAddress_Seperation;
        private int TCBAddress_Seperation;

        public PowerManagement()
        {
            // Set address variables.
            NameAddress_First = 200;
            ConfigAddress_First = 390;
            TCBAddress_First = 410;
            NameAddress_Seperation = 16;
            ConfigAddress_Seperation = 1;
            TCBAddress_Seperation = 1;
    }

        // Get address variables.
        public int GetChannelNameAddress(int ChannelNumber)
        {
            return NameAddress_First + (ChannelNumber - 1) * NameAddress_Seperation;
        }

        public int GetChannelConfigAddress(int ChannelNumber)
        {
            return ConfigAddress_First + (ChannelNumber - 1) * ConfigAddress_Seperation;
        }

        public int GetTCBAddress(int ChannelNumber)
        {
            return TCBAddress_First + (ChannelNumber - 1) * TCBAddress_Seperation;
        }
    }
}
