using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectorConfigurationApp.TabPages;
using static CollectorConfigurationApp.Managers.LoRa_Constants;
using static CollectorConfigurationApp.Managers.Ethernet_Constants;

namespace CollectorConfigurationApp.Managers
{
    

    public sealed class LoRaManager
    {

        //Singletone objects
        private static volatile LoRaManager instance;
        private static object syncRoot = new Object();

        private ILoRaToPageInterface veriKanaliOkumaPageInterface, cihazTaramaPageInterface, dosyaIslemleriPageInterface, cihazConfigPageInterface;

        public static LoRaManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new LoRaManager();
                    }
                }
                return instance;
            }
        }


        public void SendLoRaPackageToRemoteDevice(byte destinationIdParam, RadioMessageType messageTypeParam, RadioServiceType serviceTypeParam, byte[] dataParam, UInt16 lengthParam, ushort timeoutParam, byte retryCountParam )
        {
            byte[] packageData = new byte[lengthParam + 7];
            packageData[0] = (byte)(destinationIdParam);
            packageData[1] = (byte)messageTypeParam;
            packageData[2] = (byte)serviceTypeParam;
            packageData[3] = (byte)(timeoutParam >> 8);
            packageData[4] = (byte)(timeoutParam & 0xFF);
            packageData[5] = retryCountParam;
            packageData[6] = (byte)lengthParam;
            Array.Copy(dataParam, 0, packageData, 7, lengthParam );
            EthernetManager.Instance.SendRemoteDeviceCmd(Ethernet_MessageIDs_t.INCOMING_CMD_LORA_SEND_PACKAGE_REQUEST, (ushort)(lengthParam + 7), packageData);
        }

        public void SendLoRaPackageToResponsiblePage(byte[] data, UInt16 length )
        {
            RadioMessageType messageIdTemp = (RadioMessageType) ( ( data[5] & 0xF8 ) >> 3 );
            RadioRoutingHeaderType routingHeaderTypeTemp = (RadioRoutingHeaderType)(data[5] & 0x03);
            byte sourceUnit = 0;
            byte routingHeaderLength = 0;
            Int16 signalRssiValue = 0;
            signalRssiValue = (Int16)((data[length - 5] << 8) | (data[length - 4]));
            //kaanbak burada generic parsing yapilmali... sonra interface'e param olarak verilmeli
            if (routingHeaderTypeTemp == RadioRoutingHeaderType.UNICAST_DIRECT_HEADER)
            {
                sourceUnit = data[6];
                routingHeaderLength = 3;  /* 1 byte main + 2 byte routing header */
            }
            else if (routingHeaderTypeTemp == RadioRoutingHeaderType.UNICAST_ROUTED_HEADER)
            {
                sourceUnit = data[6];
                routingHeaderLength = 6; /* 1 byte main + 5 byte routing header */
            }
            else
            {
                // not implemented yet...
                return;
            }
            byte[] loraMessageData = new byte[length - 5 - routingHeaderLength ];
            Array.Copy( data, (5 + routingHeaderLength), loraMessageData, 0, length - 5 - routingHeaderLength);
            switch( messageIdTemp )
            {
                case RadioMessageType.DATA_CHANNEL_REQUEST:
                    break;
                case RadioMessageType.DATA_CHANNEL_RESPONSE:
                    veriKanaliOkumaPageInterface.SendLoRaMessageToPage( sourceUnit, messageIdTemp, loraMessageData ,signalRssiValue);
                    break;
                case RadioMessageType.DEVICE_INFORMATION_REQUEST:
                    break;
                case RadioMessageType.DEVICE_INFORMATION_RESPONSE:
                    break;
                case RadioMessageType.DISCOVER_NEIGHBOUR_REQUEST:
                    break;
                case RadioMessageType.DISCOVER_NEIGHBOUR_RESPONSE:
                    cihazTaramaPageInterface.SendLoRaMessageToPage( sourceUnit, messageIdTemp, loraMessageData, signalRssiValue);
                    break;
                case RadioMessageType.ECHO_MESSAGE_REQUEST:
                    break;
                case RadioMessageType.ECHO_MESSAGE_RESPONSE:
                    break;
                case RadioMessageType.OPERATIONAL_REQUEST:
                    break;
                case RadioMessageType.OPERATIONAL_RESPONSE:
                    cihazConfigPageInterface.SendLoRaMessageToPage(sourceUnit, messageIdTemp, loraMessageData, signalRssiValue);
                    break;
                case RadioMessageType.PING_MESSAGE:
                    break;
                case RadioMessageType.PONG_MESSAGE:
                    break;
                case RadioMessageType.UNCATEGORIZED_REL_MSG_REQUEST:
                    break;
                case RadioMessageType.UNCATEGORIZED_REL_MSG_RESPONSE:
                    break;
                case RadioMessageType.FILE_OPERATIONS_REQUEST:
                    break;
                case RadioMessageType.FILE_OPERATIONS_RESPONSE:
                    dosyaIslemleriPageInterface.SendLoRaMessageToPage(sourceUnit, messageIdTemp, loraMessageData, signalRssiValue);
                    break;
            }
        }
        public void SetLoRaPageInterface( ushort pageID , ILoRaToPageInterface interfaceParam )
        {
            switch ( pageID )
            {
                case Application_TypesConstants.CihazTaramaPageID:
                    this.cihazTaramaPageInterface = interfaceParam;
                    break;
                case Application_TypesConstants.VeriOkumaPageID:
                    this.veriKanaliOkumaPageInterface = interfaceParam;
                    break;
                case Application_TypesConstants.DosyaIslemleriPageID:
                    this.dosyaIslemleriPageInterface = interfaceParam;
                    break;
                case Application_TypesConstants.EndPointConfigPageID:
                    this.cihazConfigPageInterface = interfaceParam;
                    break;
                default:
                    break;
            }
        }
    }

   
}
