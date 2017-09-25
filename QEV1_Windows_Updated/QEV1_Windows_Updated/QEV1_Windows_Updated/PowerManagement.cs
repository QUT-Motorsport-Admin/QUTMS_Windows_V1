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
        private int FirstNameAddress;
        private int FirstConfigAddress;
        private int NameAddressSeperation;
        private int ConfigAddressSeperation;

        public PowerManagement()
        {
            // Set address variables.
            FirstNameAddress = 200;
            FirstConfigAddress = 390;
            NameAddressSeperation = 16;
            ConfigAddressSeperation = 1;
        }

        // Get address variables.
        public int GetChannelNameAddress(int ChannelNumber)
        {
            return FirstNameAddress + (ChannelNumber - 1) * NameAddressSeperation;
        }

        public int GetChannelConfigAddress(int ChannelNumber)
        {
            return FirstConfigAddress + (ChannelNumber - 1) * ConfigAddressSeperation;
        }
    }
}
