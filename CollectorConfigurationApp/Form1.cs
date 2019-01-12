using CollectorConfigurationApp.Managers;
using CollectorConfigurationApp.TabPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectorConfigurationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPage2.Controls.Add(LoRaTestiPage.Instance);
            tabPage3.Controls.Add(VeriKanallariPage.Instance);
            tabPage4.Controls.Add(CihazKonfigurasyonPage.Instance);
            tabPage5.Controls.Add(EndPointConfigPage.Instance);
            tabPage6.Controls.Add(VeriKanaliOkumaPage.Instance);
            tabPage7.Controls.Add(CihazTaramaPage.Instance);
            tabPage1.Controls.Add(DosyaIslemleriPage.Instance);
        }

        private void tcpConnectBtn_Click(object sender, EventArgs e)
        {
            string ipAddr;
            int portNum;
            if (!EthernetManager.Instance.IsClientConnected())
            {
                try
                {
                    ipAddr = tcpIpAddrTb.Text;
                    portNum = Convert.ToUInt16(tcpPortTb.Text);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("IP adresini ve Port numarasını kontrol ediniz!");
                    return;
                }
                if (EthernetManager.Instance.Connect(ipAddr, portNum))
                {
                    if (!EthernetManager.Instance.initialized)
                    {
                        EthernetManager.Instance.Initialize();
                    }
                    tcpConnectBtn.Text = "Disconnect";
                }
            }
            else
            {
                if (EthernetManager.Instance.Disconnect())
                {
                    tcpConnectBtn.Text = "Connect";
                }
            }
        }
    }
}
