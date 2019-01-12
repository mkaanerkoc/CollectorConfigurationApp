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
    public partial class VeriKanallariPage : UserControl,IEthernetToPagesInterface
    {

        private static volatile VeriKanallariPage instance;
        private static object syncRoot = new Object();
       

        public VeriKanallariPage()
        {
            InitializeComponent();
            EthernetManager.Instance.SetPageInterface(Application_TypesConstants.VeriKanallariPageID, this);
            
            dataChannelListView.View = View.Details;
            InitializeComboBoxes();
        }

        public static VeriKanallariPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new VeriKanallariPage();
                    }
                }
                return instance;
            }
        }

        public void GetReceivedPackage(Ethernet_MessageIDs_t msgID, byte[] rxBuffer)
        {
            switch(msgID)
            {
                case Ethernet_MessageIDs_t.OUTGOING_CMD_DATA_CHANNELS_ALL_RESPONSE:
                    parseDataChannelsResponse(rxBuffer);
                    break;
                default:
                    break; // not related with that page...
                   
            }
        }

        private void VeriKanallariPage_Load(object sender, EventArgs e)
        {

        }


        /* parser functions */
        private void parseDataChannelsResponse(byte[] dataParam )
        {
            DeviceChannelTypes deviceChannel;
            ushort readPeriod;
            ushort timeoutTime;
            ushort modbusRegister;
        }

        /* ui events */
        private void addNewChannel_Click(object sender, EventArgs e)
        {
            bool isChannelAddedBefore = false;
            byte deviceLoraID = 0 ;
            int gatewayChannelID = 0;
            DeviceChannelTypes deviceChannelID = 0;
            ChannelTypes_Enum channelType = 0;
            ChannelDataTypes_Enum channelDataType = 0;
            UInt16 readPeriod = 0;
            UInt16 readTimeout = 0;
            UInt16 modbusRegister = 0;
            byte retryCount = 0;
            try
            {
                gatewayChannelID = dataChannelListView.Items.Count+1;
                deviceLoraID = Convert.ToByte(uzakCihazIDTb.Text);

                var checkItemTemp1 = (KeyValuePair<DeviceChannelTypes, string>)deviceChannelTypeCb.SelectedItem;
                var checkItemTemp2 = (KeyValuePair<ChannelTypes_Enum, string>)channelTypeCb.SelectedItem;
                var checkItemTemp3 = (KeyValuePair<ChannelDataTypes_Enum, string>)dataTypeCb.SelectedItem;

                deviceChannelID = checkItemTemp1.Key;
                channelType = checkItemTemp2.Key;
                channelDataType = checkItemTemp3.Key;


                readPeriod = Convert.ToUInt16(readPeriodTb.Text);
                readTimeout = Convert.ToUInt16(readTimeoutTb.Text);
                retryCount = Convert.ToByte(retryCountTb.Text);
                modbusRegister = Convert.ToUInt16(modbusRegisterTb.Text);

                // search for an old channel...
                for (int k = 0; k < dataChannelListView.Items.Count; k++)
                {
                    if (    Convert.ToByte(dataChannelListView.Items[k].SubItems[1].Text) == deviceLoraID
                        &&  (dataChannelListView.Items[k].SubItems[2].Text.Equals(deviceChannelID.ToString())))
                    {
                        MessageBox.Show("Daha Önce olan bi kanalı eklemeye çalıştınız..");
                        isChannelAddedBefore = true;
                        return;
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(" Error ! " + ee.Message);
            }
          
            string[] newChannelToAdd = new string[dataChannelListView.Columns.Count];
            newChannelToAdd[0] = gatewayChannelID.ToString();
            newChannelToAdd[1] = deviceLoraID.ToString();
            newChannelToAdd[2] = deviceChannelID.ToString();
            newChannelToAdd[3] = channelType.ToString();
            newChannelToAdd[4] = channelDataType.ToString();
            newChannelToAdd[5] = readPeriod.ToString();
            newChannelToAdd[6] = readTimeout.ToString();
            newChannelToAdd[7] = retryCount.ToString();
            newChannelToAdd[8] = modbusRegister.ToString();

            ListViewItem listViewItemTemp = new ListViewItem(newChannelToAdd);
            if( !dataChannelListView.Items.Contains(listViewItemTemp))
            {
                dataChannelListView.Items.Add(listViewItemTemp);
            }
        }

        private void saveChannelBtn_Click(object sender, EventArgs e)
        {
            byte deviceLoraID;
            byte deviceChannelID;
            byte gatewayChannelID;
            byte channelType;
            byte channelDataType;
            UInt16 timeoutPeriod;

        }

        private void removeChannelBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeComboBoxes()
        {
            channelTypeCb.Items.Clear();
            dataTypeCb.Items.Clear();
            deviceChannelTypeCb.Items.Clear();

            deviceChannelTypeCb.DataSource = new BindingSource( DeviceChannelsDict, null);
            deviceChannelTypeCb.DisplayMember = "Key";
            deviceChannelTypeCb.ValueMember = "Value";

            channelTypeCb.DataSource = new BindingSource( ChannelTypes_Dict, null);
            channelTypeCb.DisplayMember = "Key";
            channelTypeCb.ValueMember = "Value";

            dataTypeCb.DataSource = new BindingSource( ChannelDataTypes_Dict, null);
            dataTypeCb.DisplayMember = "Key";
            dataTypeCb.ValueMember = "Value";

        }

        private void dataChannelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( dataChannelListView.SelectedItems.Count > 0 )
            {
                ListViewItem listViewItemTemp = dataChannelListView.SelectedItems[0];
                
                uzakCihazIDTb.Text = listViewItemTemp.SubItems[1].Text;
                deviceChannelTypeCb.Text = listViewItemTemp.SubItems[2].Text;

                channelTypeCb.Text = listViewItemTemp.SubItems[3].Text;
                dataTypeCb.Text = listViewItemTemp.SubItems[4].Text;


                readPeriodTb.Text = listViewItemTemp.SubItems[5].Text;
                readTimeoutTb.Text = listViewItemTemp.SubItems[6].Text;
                retryCountTb.Text = listViewItemTemp.SubItems[7].Text;
                modbusRegisterTb.Text = listViewItemTemp.SubItems[8].Text;
            }
        }

        /* private class */
        private class DataChannel
        {
            public byte deviceLoraID { get; set; }
            public byte deviceChannelID { get; set; }
            public byte gatewayChannelID { get; set; }
            public byte channelType { get; set; }
            public byte channelDataType { get; set; }
            public UInt16 readPeriod { get; set; }
            public UInt16 readTimeout { get; set; }
            public UInt16 modbusRegister { get; set; }
            public byte retryCount { get; set; }
        }

        private void getAllDataChannelsBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            EthernetManager.Instance.SendRemoteDeviceCmd(Ethernet_MessageIDs_t.INCOMING_CMD_DATA_CHANNELS_ALL_GET_REQUEST, 0, outputData);
        }

        private void setAllDataChannelsBtn_Click(object sender, EventArgs e)
        {
            ushort outputDataLength = (ushort)(1 + dataChannelListView.Items.Count * 11) ;
            byte[] outputData = new byte[ outputDataLength ];

            outputData[0] = (byte)dataChannelListView.Items.Count;

            for (int i = 0; i < dataChannelListView.Items.Count; i++)
            {
                byte deviceLoraID = 0;
                DeviceChannelTypes deviceChannelID = 0;
                ChannelTypes_Enum channelType = 0;
                ChannelDataTypes_Enum channelDataType = 0;
                UInt16 readPeriod = 0;
                UInt16 readTimeout = 0;
                UInt16 modbusRegister = 0;
                byte retryCount = 0;


                try
                {
                    deviceLoraID = Convert.ToByte( dataChannelListView.Items[i].SubItems[1].Text );
                    deviceChannelID = (DeviceChannelTypes)Enum.Parse(typeof(DeviceChannelTypes), dataChannelListView.Items[i].SubItems[2].Text);
                    channelType = (ChannelTypes_Enum)Enum.Parse(typeof(ChannelTypes_Enum), dataChannelListView.Items[i].SubItems[3].Text);
                    channelDataType = (ChannelDataTypes_Enum)Enum.Parse(typeof(ChannelDataTypes_Enum), dataChannelListView.Items[i].SubItems[4].Text);
                    readPeriod = Convert.ToUInt16(readPeriodTb.Text);
                    readTimeout = Convert.ToUInt16(readTimeoutTb.Text);
                    retryCount = Convert.ToByte(retryCountTb.Text);
                    modbusRegister = Convert.ToUInt16(modbusRegisterTb.Text);
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
                outputData[1 + 11 * i] = deviceLoraID; // device lora id
                outputData[2 + 11 * i] = (byte)deviceChannelID; // device channel type
                outputData[3 + 11 * i] = (byte)channelType; // 
                outputData[4 + 11 * i] = (byte)channelDataType;
                outputData[5 + 11 * i] = (byte)(readPeriod>>8);
                outputData[6 + 11 * i] = (byte)readPeriod;
                outputData[7 + 11 * i] = (byte)(readTimeout>>8);
                outputData[8 + 11 * i] = (byte)readTimeout;
                outputData[9 + 11 * i] = retryCount;
                outputData[10 + 11 * i] = (byte)(modbusRegister>>8);
                outputData[11 + 11 * i] = (byte)modbusRegister;
            }
            EthernetManager.Instance.SendRemoteDeviceCmd(Ethernet_MessageIDs_t.INCOMING_CMD_DATA_CHANNELS_ALL_SET_REQUEST, outputDataLength , outputData);
        }
    }
}
