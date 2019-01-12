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
using static CollectorConfigurationApp.Managers.LoRa_Constants;

namespace CollectorConfigurationApp.TabPages
{
    public partial class EndPointConfigPage : UserControl, ILoRaToPageInterface
    {

        private static volatile EndPointConfigPage instance;
        private static object syncRoot = new Object();

        public EndPointConfigPage()
        {
            InitializeComponent();
            LoRaManager.Instance.SetLoRaPageInterface(Application_TypesConstants.EndPointConfigPageID, this);
        }

        public static EndPointConfigPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new EndPointConfigPage();
                    }
                }
                return instance;
            }
        }
        public void SendLoRaMessageToPage(byte sourceUnit, LoRa_Constants.RadioMessageType messageType, byte[] data, int rssi)
        {
            if ( messageType == RadioMessageType.OPERATIONAL_RESPONSE )
            {
                Operational_Message_Cmds operationalMsgCmd = (Operational_Message_Cmds)data[0];
                if (operationalMsgCmd == Operational_Message_Cmds.GET_UTC_OFFSET)
                {
                    utcTimeZoneTb.Invoke((MethodInvoker)delegate
                    {
                        sbyte utcValueTemp = (sbyte)data[1];
                        utcTimeZoneTb.Text = utcValueTemp.ToString();
                    });
                }
            }
        }


        private void setTimeZoneBtn_Click(object sender, EventArgs e)
        {
            byte destinationId = 0;
            byte retryCount = 0;
            ushort timeOutMillis = 0;


            byte[] messagePayload = new byte[2];

            try
            {
                destinationId = Convert.ToByte(cihazIdTb.Text);
                timeOutMillis = Convert.ToUInt16(timeOutTb.Text);
                retryCount = Convert.ToByte(retryCountTb.Text);

                messagePayload[0] = (byte)Operational_Message_Cmds.SET_UTC_OFFSET;
                messagePayload[1] = Convert.ToByte(utcTimeZoneTb.Text);
            }
            catch
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz...\n");
                return;
            }


            LoRaManager.Instance.SendLoRaPackageToRemoteDevice(destinationId, RadioMessageType.OPERATIONAL_REQUEST, RadioServiceType.UNICAST_SERVICE, messagePayload, 2, timeOutMillis, retryCount);
        }

        private void getTimeZoneBtn_Click(object sender, EventArgs e)
        {
            byte destinationId = 0;
            byte retryCount = 0;
            ushort timeOutMillis = 0;

            try
            {
                destinationId = Convert.ToByte(cihazIdTb.Text);
                timeOutMillis = Convert.ToUInt16(timeOutTb.Text);
                retryCount = Convert.ToByte(retryCountTb.Text);
            }
            catch
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz...\n");
                return;
            }

            byte[] messagePayload = new byte[2];
            messagePayload[0] = (byte)Operational_Message_Cmds.GET_UTC_OFFSET;
            messagePayload[1] = 0;

            LoRaManager.Instance.SendLoRaPackageToRemoteDevice(destinationId, RadioMessageType.OPERATIONAL_REQUEST, RadioServiceType.UNICAST_SERVICE, messagePayload, 2, timeOutMillis, retryCount);
        }

        private void setDevicePositionBtn_Click(object sender, EventArgs e)
        {

        }

        private void getDevicePositionBtn_Click(object sender, EventArgs e)
        {

        }

        private void setDeviceRadiusBtn_Click(object sender, EventArgs e)
        {

        }

        private void getDeviceRadiusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
