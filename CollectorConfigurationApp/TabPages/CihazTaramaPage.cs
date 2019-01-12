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

namespace CollectorConfigurationApp.TabPages
{
    public partial class CihazTaramaPage : UserControl, ILoRaToPageInterface
    {
        private static volatile CihazTaramaPage instance;
        private static object syncRoot = new Object();
        
        private static ushort CurrentProgressBarTimerTickCount = 0;
        private static ushort ProgressBarTimerTickCount = 0;

        public CihazTaramaPage()
        {
            InitializeComponent();
            foundDevicesListView.View = View.Details;
            LoRaManager.Instance.SetLoRaPageInterface(Application_TypesConstants.CihazTaramaPageID, this);
            label2.Text = "";
        }

        public static CihazTaramaPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new CihazTaramaPage();
                    }
                }
                return instance;
            }
        }

        //
        public void SendLoRaMessageToPage(byte sourceUnit,  RadioMessageType messageType, byte[] data, int rssi)
        {
            switch( messageType)
            {
                case RadioMessageType.DISCOVER_NEIGHBOUR_RESPONSE:
                    Parse_DiscoverNeighbourResponse(sourceUnit ,data, rssi);
                    break;
                default:
                    // independent with current page..
                    break;
            }
        }

        /* parser methods */
        private void Parse_DiscoverNeighbourResponse(byte sourceUnitParam, byte[] data, int rssi)
        {
            string deviceDateTimeStr = string.Format("{0:00}:{1:00}:{2:00} {3:00}/{4:00}/{5}", data[2], data[3], data[4], data[5], data[6], (2000 + data[7]));
            byte deviceTypeTemp = data[1];
            string[] newRowToAddStr = new string[5];
            newRowToAddStr[0] = sourceUnitParam.ToString();
            newRowToAddStr[1] = rssi.ToString();
            newRowToAddStr[2] = deviceDateTimeStr;
            newRowToAddStr[3] = deviceTypeTemp.ToString(); //kaanbak dictionary den cek..
            newRowToAddStr[4] = ""; // gerek yok buna sanki..
            ListViewItem newRowItem = new ListViewItem(newRowToAddStr);
            foundDevicesListView.Invoke((MethodInvoker)delegate
            {
                foundDevicesListView.Items.Add(newRowItem);
            });
        }

        private void startScanBtn_Click(object sender, EventArgs e)
        {
            foundDevicesListView.Items.Clear();
            ushort responseTime = 0;

            try
            {
                responseTime = Convert.ToUInt16(responseTimeTb.Text);
            
            }
            catch(Exception eee)
            {
                MessageBox.Show("Yanıt süresinin değerini kontrol ediniz..");
                return;
            }
            RadioMessageType messageType = RadioMessageType.DISCOVER_NEIGHBOUR_REQUEST;
            RadioServiceType serviceType = RadioServiceType.BROADCAST_SERVICE;
            byte[] messagePayload = new byte[10];
            DateTime dateTime = DateTime.Now;
            if( syncClocksCb.Checked )
            {
                messagePayload[0] = 0x01; // sync clock
            }
            else
            {
                messagePayload[0] = 0x00; // dont sync clock
            }
            messagePayload[1] = 12; // DeviceType -> GATEWAY
            messagePayload[2] = (byte)(responseTime >> 8);
            messagePayload[3] = (byte)(responseTime & 0xFF);
            messagePayload[4] = (byte)dateTime.Hour;/* Cihaz Saati */ //kaanbak : burada gateway'in saatini de kontrol etmemiz gerekiyor..
            messagePayload[5] = (byte)dateTime.Minute;
            messagePayload[6] = (byte)dateTime.Second;
            messagePayload[7] = (byte)dateTime.Day;
            messagePayload[8] = (byte)dateTime.Month;
            messagePayload[9] = (byte)(dateTime.Year-2000);

            LoRaManager.Instance.SendLoRaPackageToRemoteDevice(255, messageType, serviceType, messagePayload, 10, responseTime, 0);
            try
            {
                ProgressBarTimerTickCount = (ushort)(responseTime / progressBarTimer.Interval);
                CurrentProgressBarTimerTickCount =  ProgressBarTimerTickCount;
                scanningProgresBar.Maximum = responseTime;
                scanningProgresBar.Minimum = 0;
                scanningProgresBar.Value = 0;
                progressBarTimer.Start();
                startScanBtn.Enabled = false;
                label2.Text = "Tarama Devam ediyor..";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            foundDevicesListView.Items.Clear();
            label2.Text = "";
            scanningProgresBar.Value = 0;
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {

            CurrentProgressBarTimerTickCount = (ushort)(CurrentProgressBarTimerTickCount - 1);
            scanningProgresBar.Value += (scanningProgresBar.Maximum - scanningProgresBar.Minimum) / ProgressBarTimerTickCount;
            if (CurrentProgressBarTimerTickCount == 0)
            {
                startScanBtn.Enabled = true;
                progressBarTimer.Stop();
                label2.Text = "Tarama Tamamlandı..";
            }
        }
    }
}
