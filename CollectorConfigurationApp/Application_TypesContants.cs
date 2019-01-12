using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorConfigurationApp
{
    public static class Application_TypesConstants
    {
        public const ushort CihazBaglantisiPageID = 0x10;
        public const ushort CihazKonfigurasyonPageID = 0x11;
        public const ushort VeriKanallariPageID = 0x12;
        public const ushort LoRaTestPageID = 0x14;
        public const ushort EndPointConfigPageID = 0x15;
        
        public const ushort VeriOkumaPageID = 0x16;
        public const ushort CihazTaramaPageID = 0x17;
        public const ushort DosyaIslemleriPageID = 0x18;

        public static uint MAX_STATIC_ROUTING_TABLE_SIZE = 10;
        public static uint STATIC_ROUTING_TABLE_ELEMENT_SIZE = 3;
        public static uint MAX_UNIT_NUMBER_IN_NET = 200;


        public static string[] MessageType_StringList = new string[]{   "Data Channel Request", /* 0 */
                                                                        "Device Information Request",    /* 1 */                                                               
                                                                        "Operational Request",/* 2 */
                                                                        "Ping Message",/* 3 */
                                                                        "Data Channel Response",/* 4 */
                                                                        "Device Information Response", /* 5 */
                                                                        "Operational Response",/* 6 */
                                                                        "Pong Message", /* 7 */
                                                                        "Discover Neighbours Request",/* 8 */
                                                                        "Discover Neighbours Response",/* 9 */
                                                                        "Uncategorized Unrel Message", /* 10 */
                                                                        "Uncategorized Rel. Request", /* 11 */
                                                                        "Uncategorized Rel. Response", /* 12 */
                                                                        "Echo Message Request ", /* 13 */
                                                                        "Echo Message Response ", /* 14*/
                                                                        "File Operations Request", /* 15 */
                                                                        "File Operations Response" /* 16*/
                                                                    };

    }
}
