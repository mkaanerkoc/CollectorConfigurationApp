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
using static CollectorConfigurationApp.Managers.LoRa_Constants;
using static CollectorConfigurationApp.Managers.Ethernet_Constants;

namespace CollectorConfigurationApp.TabPages
{
    public partial class VeriKanaliOkumaPage : UserControl, IEthernetToPagesInterface, ILoRaToPageInterface
    {
        private const byte MAX_CHANNEL_NUMBER_ON_SINGLE_DEVICE = 40;

        private static volatile VeriKanaliOkumaPage instance;
        private static object syncRoot = new Object();

        BindingSource allChannelsBindingSource ;
        BindingSource channelsToReadBindingSource;

        public VeriKanaliOkumaPage()
        {
            InitializeComponent();
            InitializeListViews();
            channelResponseListView.View = View.Details;
            LoRaManager.Instance.SetLoRaPageInterface(Application_TypesConstants.VeriOkumaPageID, this);
            ((ListBox)channelsToReadCbList).DataSource = new BindingSource(DeviceChannelsDict, null);
            ((ListBox)channelsToReadCbList).DisplayMember = "Value";
            ((ListBox)channelsToReadCbList).ValueMember = "Key";

        }

        public static VeriKanaliOkumaPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new VeriKanaliOkumaPage();
                    }
                }
                return instance;
            }
        }

        public void GetReceivedPackage(Ethernet_MessageIDs_t msgID, byte[] rxBuffer)
        {
            throw new NotImplementedException();
        }

        public void SendLoRaMessageToPage(byte sourceUnit, RadioMessageType messageType, byte[] data, int rssi )
        {
            switch( messageType )
            {
                case RadioMessageType.DATA_CHANNEL_RESPONSE:
                    parseDataChannelResponse(data,rssi);
                    break;
                default:
                    break;
            }
        }



        /* parser functions */
        private void parseDataChannelResponse(byte[] data,int rssi)
        {

            byte channelCount =  (byte) ( data[0] & 0x7F );
            byte operationType = (byte) (( data[0] & 0x80 ) >> 7 );

            if ( 0 == operationType ) /* read result */
            {
                float[] channelValues = new float[channelCount];
                DeviceChannelStatus[] channelStatus = new DeviceChannelStatus[channelCount];
                DeviceChannelTypes[] channelIDs = new DeviceChannelTypes[channelCount];
                /* clear listView */
                channelResponseListView.Items.Clear();
                for (int i = 0; i < channelCount; i++)
                {
                    channelIDs[i] = (DeviceChannelTypes)data[1 + i * 6];
                    channelStatus[i] = (DeviceChannelStatus)data[6 + i * 6];
                    byte[] floatByteArrayTemp = new byte[4];
                    Array.Copy(data, (2 + i * 6), floatByteArrayTemp, 0, 4);
                    channelValues[i] = System.BitConverter.ToSingle(floatByteArrayTemp, 0);

                    /* list view binding */
                    string[] channelDataRow = new string[3];
                    DeviceChannelsDict.TryGetValue(channelIDs[i],out  channelDataRow[0]);
                    channelDataRow[1] = channelValues[i].ToString();
                    channelDataRow[2] = channelStatus[i].ToString(); // KAANBAK status string list tanimla
                    ListViewItem channelDataItem = new ListViewItem(channelDataRow);
                    channelResponseListView.Invoke((MethodInvoker)delegate
                    {
                        channelResponseListView.Items.Add(channelDataItem);
                        /* fill labels */
                        signalRssiLabel.Text = rssi.ToString();

                        responseReceiveTimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    });
                }
            }
            else if ( 1 == operationType) /* write result */
            {

            }
        }

    



        private void SendResponseBtn_Click(object sender, EventArgs e)
        {
            byte destinationID = 0x00;
            UInt16 msgTimeOut = 0x00;
            byte retryCount = 0x00;
            byte messageType = 0; /* data channel request */
           
            byte serviceType = 0; /* unicast service */

            // reset data //
            channelResponseListView.Items.Clear();
            signalRssiLabel.Text = "---";
            responseReceiveTimeLabel.Text = "---";

            byte msgLength = (byte)( 1 + channelsToReadCbList.CheckedItems.Count );
            if ( msgLength < 2)
            {
                MessageBox.Show("Lütfen en az 1 adet kanal giriniz...");
                return;
            }

            byte[] msgData = new byte[msgLength];
            byte[] packageData = new byte[msgLength + 7];
            try
            {
                destinationID = Convert.ToByte(destinationUnitTb.Text);
                msgTimeOut = Convert.ToUInt16(timeoutInMilisTb.Text);
                retryCount = Convert.ToByte(msgRetryCountTb.Text);
                msgData[0] = 0;
                msgData[0] = (byte)(msgData[0] | (byte)channelsToReadCbList.CheckedItems.Count); /* kanal sayisi...*/
                for (int i = 0; i < channelsToReadCbList.CheckedItems.Count; i++)
                {
                    var checkItemTemp = (KeyValuePair<DeviceChannelTypes, string>)channelsToReadCbList.CheckedItems[i];
                    msgData[1 + i] = Convert.ToByte( DeviceChannelsDict.FirstOrDefault(x => x.Value == checkItemTemp.Value).Key );
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz  "+ee.Message);
                return;
            }

            packageData[0] = (byte)(destinationID);
            packageData[1] = messageType;
            packageData[2] = serviceType;
            packageData[3] = (byte)(msgTimeOut >> 8);
            packageData[4] = (byte)(msgTimeOut & 0xFF);
            packageData[5] = retryCount;
            packageData[6] = msgLength;
            Array.Copy(msgData, 0, packageData, 7, msgLength);
            EthernetManager.Instance.SendRemoteDeviceCmd(Ethernet_MessageIDs_t.INCOMING_CMD_LORA_SEND_PACKAGE_REQUEST, (ushort)(msgLength + 7), packageData);
        }

        private void clearReceivedResponseBtn_Click(object sender, EventArgs e)
        {
            channelResponseListView.Items.Clear();
            signalRssiLabel.Text = "---";
            responseReceiveTimeLabel.Text = "---";
        }


        /* Initializers */
        private void InitializeListViews()
        {
            
        }
    }
}
