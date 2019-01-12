using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CollectorConfigurationApp.Managers.Ethernet_Constants;

namespace CollectorConfigurationApp.Managers
{
    public sealed class EthernetManager
    {
        //Singletone objects
        private static volatile EthernetManager instance;
        private static object syncRoot = new Object();


        public IEthernetToPagesInterface cihazBaglantisiPageInterface, veriKanallariPageInterface, cihazKonfigurasyonPageInterface,
                                  loraTestiPageInterface, EndPointConfigPageInterface, veriOkumaPageInterface;

        Socket tcpClient;
        Stream tcpStream;
        public bool initialized;

        private const byte COMMAND_STARTER_BYTE_1 = 0x03;
        private const byte COMMAND_STARTER_BYTE_2 = 0x04;
        private const byte COMMAND_FINISH_BYTE_1 = 0x33;
        private const byte COMMAND_FINISH_BYTE_2 = 0x34;

        public EthernetManager()
        {
            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static EthernetManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new EthernetManager();
                    }
                }
                return instance;
            }
        }

        // State object for receiving data from remote device.
        public class StateObject
        {
            // Client socket.
            public Socket workSocket = null;
            // Size of receive buffer.
            public const int BufferSize = 1024;
            // Receive buffer.
            public byte[] buffer = new byte[BufferSize];
            // Received data string.
            public StringBuilder sb = new StringBuilder();
        }


        public bool Initialize()
        {
            if (!initialized)
            {
                initialized = true;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Stop()
        {
            if (initialized)
            {
                initialized = false;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Connect(string ipAddr, int PortNum)
        {
            if (tcpClient == null)
            {
                Console.WriteLine("TCP Client not generated before , some buggy initializations");
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            if (tcpClient.Connected)
            {
                Console.WriteLine("TCP Client is already connected some buggy calls");
                return false;
            }
            try
            {
                tcpClient.BeginConnect(ipAddr, PortNum, new AsyncCallback(ConnectCallback), tcpClient);

                return true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("TCP Client cannot connect to server -> " + ee.Message);
                return false;
            }
        }


        private void ConnectCallback(IAsyncResult result)
        {
            Console.WriteLine("Connect Callback");

            Receive(tcpClient);
        }



        private void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            Console.WriteLine("Receive Callback");
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                Ethernet_MessageIDs_t msgID;
                // Read data from the remote device.
                if ( client == null )
                {
                    Disconnect();
                }
                int bytesRead = client.EndReceive(ar);
                
                if (bytesRead > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        Console.Write("{0} ", state.buffer[i]);
                    }
                    Console.WriteLine("");
                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                    msgID = (Ethernet_MessageIDs_t)((state.buffer[1] << 8) | state.buffer[2]);
                    EthernetManager.Instance.ParseIncomingPackage(msgID, state.buffer);
                }
                //kaanbak, buraya parse islemleri gelecek...
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                
            }
        }

        public bool Disconnect()
        {
            bool retVal = false;
            if (tcpClient.Connected)
            {
                tcpClient.Shutdown(SocketShutdown.Both);
                tcpClient.Close();
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                retVal = true;
            }
            else
            {
                retVal = false;
            }
            return retVal;
        }

        private void ParseIncomingPackage(Ethernet_MessageIDs_t msgID, byte[] package)
        {
            Console.WriteLine("ParseIncomingPackage Received ID : {0}",msgID);
            ushort messageLength = (ushort)((( package[3]<< 8) | ( package[4])) + 8); /* ethernet message and header + footers */
            switch (msgID)
            {
                case Ethernet_MessageIDs_t.OUTGOING_CMD_ACK:
                    Console.WriteLine("CMD_ACK Received ! Result : {0}, Cmd : {1}", package[5], package[6]);
                    break;
                case Ethernet_MessageIDs_t.OUTGOING_CMD_DATE_RESPONSE:
                    cihazBaglantisiPageInterface.GetReceivedPackage(msgID, package);
                    //Console.WriteLine("OUTGOING_CMD_DATE_RESPONSE received");
                    break;
                case Ethernet_MessageIDs_t.OUTGOING_CMD_TIME_RESPONSE:
                    //Console.WriteLine("OUTGOING_CMD_TIME_RESPONSE received");
                    cihazBaglantisiPageInterface.GetReceivedPackage(msgID, package);
                    break;
                case Ethernet_MessageIDs_t.OUTGOING_CMD_DEVICE_UNIQUE_ID_RESPONSE:
                case Ethernet_MessageIDs_t.OUTGOING_CMD_DEVICE_LORA_ID_RESPONSE:
                case Ethernet_MessageIDs_t.OUTGOING_CMD_DEVICE_LORA_GATEWAY_ID_RESPONSE:
                case Ethernet_MessageIDs_t.OUTGOING_CMD_LORA_CODING_RATE_RESPONSE:
                case Ethernet_MessageIDs_t.OUTGOING_CMD_LORA_CONFIG_RESPONSE:
                case Ethernet_MessageIDs_t.OUTGOING_CMD_LORA_STATIC_ROUTING_TABLE_RESPONSE:
                    
                    cihazKonfigurasyonPageInterface.GetReceivedPackage(msgID, package);
                    break;
                case Ethernet_MessageIDs_t.OUTGOING_CMD_NEIGHBOUR_LIST_RESPONSE:
                case Ethernet_MessageIDs_t.OUTGOING_CMD_LORA_ECHO_MONITOR_REPONSE:
                    loraTestiPageInterface.GetReceivedPackage(msgID, package);
                    break;
                case Ethernet_MessageIDs_t.OUTGOING_CMD_LORA_RECEIVED_PACKAGE:
                    loraTestiPageInterface.GetReceivedPackage(msgID, package); /* for monitoring  packages on list view*/
                    LoRaManager.Instance.SendLoRaPackageToResponsiblePage(package, messageLength );
                    break;
                default:
                    break;
            }
        }

        public void SendRemoteDeviceCmd(Ethernet_MessageIDs_t msgID,UInt16 length, byte[] package)
        {
            byte[] outputBuffer = new byte[length + 8];
            outputBuffer[0] = COMMAND_STARTER_BYTE_1;
            outputBuffer[1] = COMMAND_STARTER_BYTE_2;
            outputBuffer[2] = (byte)((ushort)msgID >> 8);
            outputBuffer[3] = (byte)((ushort)msgID & 0xFF);
            outputBuffer[4] = (byte)(length >> 8);
            outputBuffer[5] = (byte)(length & 0xFF);
            package.CopyTo(outputBuffer, 6);
            //kaanbak ADD CRC HERE//
            outputBuffer[length + 6] = 0x32;
            outputBuffer[length + 7] = 0x33;
            SendDataToDevice(outputBuffer, (ushort)(length + 8));
        }

        public void SendDataToDevice(byte[] data, ushort length)
        {
            SocketFlags sf = new SocketFlags();
            if(tcpClient == null)
            {
                MessageBox.Show("TCP Client is null");
                return;
            }
            if (tcpClient.Connected)
            {
                tcpClient.Send(data, 0, length, sf);
            }
            else
            {
                MessageBox.Show("TCP Client bağlı  değil !", "Hata");
            }
        }

        public void SetPageInterface(ushort PageID,IEthernetToPagesInterface pageInterface)
        {
            switch (PageID)
            {
                case Application_TypesConstants.CihazBaglantisiPageID:
                    cihazBaglantisiPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.LoRaTestPageID:
                    loraTestiPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.CihazKonfigurasyonPageID:
                    cihazKonfigurasyonPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.VeriKanallariPageID:
                    veriKanallariPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.EndPointConfigPageID:
                    EndPointConfigPageInterface = pageInterface;
                    break;
                default:
                    break;
            }
        }

        public bool IsClientConnected()
        {
            if(tcpClient == null)
            {
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            return tcpClient.Connected;
        }

    }
    
}

