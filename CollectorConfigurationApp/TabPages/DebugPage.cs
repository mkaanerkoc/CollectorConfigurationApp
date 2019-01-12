using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollectorConfigurationApp.Managers;
using static CollectorConfigurationApp.Managers.Ethernet_Constants;

namespace CollectorConfigurationApp.TabPages
{
    public partial class DebugPage : UserControl, IEthernetToPagesInterface
    {
        public DebugPage()
        {
            InitializeComponent();
        }

        public void GetReceivedPackage(Ethernet_MessageIDs_t msgID, byte[] rxBuffer)
        {
            //throw new NotImplementedException();
        }

    }
}
