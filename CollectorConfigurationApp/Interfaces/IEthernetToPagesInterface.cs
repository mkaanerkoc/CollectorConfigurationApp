using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CollectorConfigurationApp.Managers.Ethernet_Constants;

namespace CollectorConfigurationApp.Managers
{
    public interface IEthernetToPagesInterface
    {
        void GetReceivedPackage(Ethernet_MessageIDs_t msgID, byte[] rxBuffer);
    }
}
