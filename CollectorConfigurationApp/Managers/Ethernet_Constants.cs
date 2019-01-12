﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorConfigurationApp.Managers
{
    public static class Ethernet_Constants
    {
        public enum Ethernet_MessageIDs_t
        {
             INCOMING_CMD_DEVICE_CONNECTING_REQUEST = 0,
             OUTGOING_CMD_DEVICE_CONNECTING_RESPONSE = 1,


            INCOMING_CMD_DEVICE_UNIQUE_ID_SET_REQUEST = 2,
            INCOMING_CMD_DEVICE_UNIQUE_ID_GET_REQUEST = 3,
            OUTGOING_CMD_DEVICE_UNIQUE_ID_RESPONSE = 4,


            INCOMING_CMD_DEVICE_LORA_ID_SET_REQUEST = 5,

            INCOMING_CMD_DEVICE_LORA_ID_GET_REQUEST = 6,

            OUTGOING_CMD_DEVICE_LORA_ID_RESPONSE = 7,


            INCOMING_CMD_DEVICE_LORA_GATEWAY_ID_SET_REQUEST = 8,
            INCOMING_CMD_DEVICE_LORA_GATEWAY_ID_GET_REQUEST = 9,
            OUTGOING_CMD_DEVICE_LORA_GATEWAY_ID_RESPONSE = 10,

            /*LORA CONFIGS */
            INCOMING_CMD_LORA_CODING_RATE_SET_REQUEST = 11,
            INCOMING_CMD_LORA_CODING_RATE_GET_REQUEST = 12,
            OUTGOING_CMD_LORA_CODING_RATE_RESPONSE = 13,

            INCOMING_CMD_LORA_BANDWIDTH_SET_REQUEST = 14,
            INCOMING_CMD_LORA_BANDWIDTH_GET_REQUEST = 15,
            OUTGOING_CMD_LORA_BANDWIDTH_RESPONSE = 16,

            INCOMING_CMD_LORA_SPREADING_FACTOR_SET_REQUEST = 17,
            INCOMING_CMD_LORA_SPREADING_FACTOR_GET_REQUEST = 18,
            OUTGOING_CMD_LORA_SPREADING_FACTOR_RESPONSE = 19,

            INCOMING_CMD_LORA_FREQUENCY_SET_REQUEST = 20,
            INCOMING_CMD_LORA_FREQUENCY_GET_REQUEST = 21,
            OUTGOING_CMD_LORA_FREQUENCY_RESPONSE = 22,

            INCOMING_CMD_LORA_TX_POWER_SET_REQUEST = 23,
            INCOMING_CMD_LORA_TX_POWER_GET_REQUEST = 24,
            OUTGOING_CMD_LORA_TX_POWER_RESPONSE = 25,

            INCOMING_CMD_LORA_CONFIG_SET_REQUEST = 26,
            INCOMING_CMD_LORA_CONFIG_GET_REQUEST = 27,
            OUTGOING_CMD_LORA_CONFIG_RESPONSE = 28,

            /* ECHO MONITORS */
            INCOMING_CMD_LORA_ECHO_MONITOR_SET_REQUEST = 29,
            INCOMING_CMD_LORA_ECHO_MONITOR_GET_REQUEST = 30,
            OUTGOING_CMD_LORA_ECHO_MONITOR_REPONSE = 31,

            /* ROUTING TABLE */
            INCOMING_CMD_LORA_STATIC_ROUTING_TABLE_SET_REQUEST = 35,
            INCOMING_CMD_LORA_STATIC_ROUTING_TABLE_GET_REQUEST = 36,
            OUTGOING_CMD_LORA_STATIC_ROUTING_TABLE_RESPONSE = 37,

            /* NEIGHBOUR_LIST */
            INCOMING_CMD_NEIGHBOUR_LIST_GET_REQUEST = 38,
            OUTGOING_CMD_NEIGHBOUR_LIST_RESPONSE = 39,

            INCOMING_CMD_LORA_SEND_PACKAGE_REQUEST = 44,
            OUTGOING_CMD_LORA_RECEIVED_PACKAGE = 45,
            /*DATE-TIME SETTING */
            INCOMING_CMD_DATE_SET_REQUEST = 100,
            INCOMING_CMD_DATE_GET_REQUEST = 101,
            OUTGOING_CMD_DATE_RESPONSE = 102,

            INCOMING_CMD_TIME_SET_REQUEST = 103,
            INCOMING_CMD_TIME_GET_REQUEST = 104,
            OUTGOING_CMD_TIME_RESPONSE = 105,


            //COLLECTOR SPECIAL CODES// GATEWAY SPECIFIC CODES //
            INCOMING_CMD_DATA_CHANNELS_ALL_SET_REQUEST = 900,
            INCOMING_CMD_DATA_CHANNELS_ALL_GET_REQUEST = 901,
            OUTGOING_CMD_DATA_CHANNELS_ALL_RESPONSE = 902,

            INCOMING_CMD_DATA_CHANNEL_SET_REQUEST = 903,
            INCOMING_CMD_DATA_CHANNEL_GET_REQUEST = 904,
            OUTGOING_CMD_DATA_CHANNEL_RESPONSE = 905,

            OUTGOING_CMD_ACK = 400
    }
       
    }
}