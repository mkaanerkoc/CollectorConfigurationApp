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
using System.Net;
using static CollectorConfigurationApp.Managers.Ethernet_Constants;

namespace CollectorConfigurationApp.TabPages
{
    public partial class CihazBaglantisiPage : UserControl,IEthernetToPagesInterface
    {
        private static volatile CihazBaglantisiPage instance;
        private static object syncRoot = new Object();
        

        public CihazBaglantisiPage()
        {
            InitializeComponent();
            EthernetManager.Instance.SetPageInterface(Application_TypesConstants.CihazBaglantisiPageID, this);
        }

        public static CihazBaglantisiPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new CihazBaglantisiPage();
                    }
                }
                return instance;
            }
        }

        public void GetReceivedPackage(Ethernet_MessageIDs_t msgID, byte[] rxBuffer)
        {
            throw new NotImplementedException();
        }

        private void tcpConnectBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
