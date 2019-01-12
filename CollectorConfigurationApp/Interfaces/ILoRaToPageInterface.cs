using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CollectorConfigurationApp.Managers.LoRa_Constants;

namespace CollectorConfigurationApp.Managers
{
    public interface ILoRaToPageInterface
    {
        void SendLoRaMessageToPage(byte sourceUnit, RadioMessageType messageType, byte[] data, int rssi );
    }
}
