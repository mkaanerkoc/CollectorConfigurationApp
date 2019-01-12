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
    public partial class DosyaIslemleriPage : UserControl, ILoRaToPageInterface
    {


        private static volatile DosyaIslemleriPage instance;
        private static object syncRoot = new Object();

        private const byte GET_LAST_WRITTEN_ROW_INFO = 0x01;
        private const byte GET_LAST_READ_ROW_INFO = 0x02;

        public DosyaIslemleriPage()
        {
            InitializeComponent();
            LoRaManager.Instance.SetLoRaPageInterface(Application_TypesConstants.DosyaIslemleriPageID, this);
        }

        public static DosyaIslemleriPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new DosyaIslemleriPage();
                    }
                }
                return instance;
            }
        }

        public void SendLoRaMessageToPage(byte sourceUnit, LoRa_Constants.RadioMessageType messageType, byte[] data, int rssi)
        {
            byte fileOperationsMsgId = data[0];
            switch ( fileOperationsMsgId )
            {
                case GET_LAST_READ_ROW_INFO:
                    MessageBox.Show("GET_LAST_READ_ROW_INFO");
                    break;
                case GET_LAST_WRITTEN_ROW_INFO:
                    //MessageBox.Show("GET_LAST_WRITTEN_ROW_INFO");
                    ushort bytesWritten = (ushort)((data[1]<< 8 ) | (data[2]));
                    if ( bytesWritten > 240 )
                    {
                        bytesWritten = 240; // upper limit...
                    }
                    char[] writtenCharBuff = new char[bytesWritten];
                    Array.Copy(data, 3, writtenCharBuff, 0, bytesWritten);
                    string writtenString = new string(writtenCharBuff);
                    responseTextLabel.Invoke((MethodInvoker)delegate
                    {
                        responseTextLabel.Text = writtenString;
                    });
                    break;
                default:
                    break;
            }
        }

        private void getLastWrittenBtn_Click(object sender, EventArgs e)
        {
            byte destinationId = 0;
            try
            {
                destinationId = Convert.ToByte(destinationIdTb.Text);
            }
            catch
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz...\n");
                return;
            }

            byte[] messagePayload = new byte[2];
            messagePayload[0] = GET_LAST_WRITTEN_ROW_INFO;

            LoRaManager.Instance.SendLoRaPackageToRemoteDevice( destinationId , RadioMessageType.FILE_OPERATIONS_REQUEST, RadioServiceType.UNICAST_SERVICE, messagePayload, 2, 1000, 0);
        }
    }
}
