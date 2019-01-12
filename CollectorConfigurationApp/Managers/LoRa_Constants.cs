using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorConfigurationApp.Managers
{
    public static class LoRa_Constants
    {
        public enum RadioMessageType // 5 bit
        {
            //Requests
            DATA_CHANNEL_REQUEST = 0,
            DEVICE_INFORMATION_REQUEST = 1,

            OPERATIONAL_REQUEST = 2,
            PING_MESSAGE = 3, 
            DATA_CHANNEL_RESPONSE = 4,
            DEVICE_INFORMATION_RESPONSE = 5,
            OPERATIONAL_RESPONSE = 6,
            PONG_MESSAGE = 7,

            DISCOVER_NEIGHBOUR_REQUEST = 8,
            DISCOVER_NEIGHBOUR_RESPONSE = 9,

            UNCATEGORIZED_UNREL_MSG_REQUEST = 10,

            UNCATEGORIZED_REL_MSG_REQUEST = 11,
            UNCATEGORIZED_REL_MSG_RESPONSE = 12,

            ECHO_MESSAGE_REQUEST = 13,
            ECHO_MESSAGE_RESPONSE = 14,

            FILE_OPERATIONS_REQUEST = 15,
            FILE_OPERATIONS_RESPONSE = 16,

            RADIO_MESSAGE_TYPE_COUNT = 17
        };


        public enum RadioServiceType
        {
            UNICAST_SERVICE = 0x00,
            MULTICAST_SERVICE = 0x01,
            BROADCAST_SERVICE = 0x02,
            RADIO_SERVICE_TYPE_COUNT = 0x03
        };

        public enum RadioRoutingHeaderType
        {
            UNICAST_DIRECT_HEADER = 0x00,
            UNICAST_ROUTED_HEADER = 0x01,
            MULTICAST_DIRECT_HEADER = 0x02,
            MULTICAST_ROUTED_HEADER = 0x03,
            BROADCAST_HEADER = 0x04,
            ROUTING_HEADER_TYPES_COUNT = 0x05
        };


        public enum DeviceChannelTypes
        {
            BME280_TEMPERATURE = 1,
            BME280_HUMIDITY = 2,
            BME280_AIR_PRESSURE = 3,
            BME280_ALTITUDE = 4,

            MAX31865_1_TEMPERATURE = 5,
            MAX31865_2_TEMPERATURE = 6,

            GPS_LONGTITUDE = 7,
            GPS_LATITUDE = 8,
            GPS_NOS = 9,

            INA219_MAIN_BATTERY_CURRENT = 10,
            INA219_BACKUP_BATTERY_CURRENT = 11,

            INA219_MAIN_BATTERY_VOLTAGE = 12,
            INA219_BACKUP_BATTERY_VOLTAGE = 13
        };

        public enum Operational_Message_Cmds
        {
            GET_UTC_OFFSET = 0,
            SET_UTC_OFFSET = 1,
            GET_GATEWAY_ID = 2,
            SET_GATEWAY_ID = 3,
            GET_DATETIME = 4,
            SET_DATETIME = 5,
            SET_DEVICE_DEFAULT_POSITION = 6,
            GET_DEVICE_DEFAULT_POSITION = 7,
            SET_DEVICE_RADIUS = 8,
            GET_DEVICE_RADIUS = 9
        };

        public static readonly Dictionary<DeviceChannelTypes, string> DeviceChannelsDict = new Dictionary<DeviceChannelTypes, string>
        {
            { DeviceChannelTypes.BME280_TEMPERATURE, "BME280_TEMPERATURE" },
            { DeviceChannelTypes.BME280_HUMIDITY, "BME280_HUMIDITY" },
            { DeviceChannelTypes.BME280_AIR_PRESSURE, "BME280_AIR_PRESSURE" },
            { DeviceChannelTypes.BME280_ALTITUDE, "BME280_ALTITUDE" },

            { DeviceChannelTypes.MAX31865_1_TEMPERATURE, "MAX31865_1_TEMPERATURE" },
            { DeviceChannelTypes.MAX31865_2_TEMPERATURE, "MAX31865_2_TEMPERATURE" },

            { DeviceChannelTypes.GPS_NOS  , "GPS_NOS" },
            { DeviceChannelTypes.GPS_LONGTITUDE, "GPS_LONGTITUDE" },
            { DeviceChannelTypes.GPS_LATITUDE, "GPS_LATITUDE" },

            { DeviceChannelTypes.INA219_BACKUP_BATTERY_CURRENT, "INA219_BACKUP_CURRENT" },
            { DeviceChannelTypes.INA219_MAIN_BATTERY_CURRENT, "INA219_MAIN_CURRENT" },

            { DeviceChannelTypes.INA219_MAIN_BATTERY_VOLTAGE, "INA219_MAIN_VOLTAGE" },
            { DeviceChannelTypes.INA219_BACKUP_BATTERY_VOLTAGE, "INA219_BACKUP_VOLTAGE" }
        };


        public static readonly Dictionary<RadioMessageType, string> RadioMessagesDict = new Dictionary<RadioMessageType, string>
        {
            {RadioMessageType.DATA_CHANNEL_REQUEST, "DATA CHANNEL REQUEST" },
            {RadioMessageType.DATA_CHANNEL_RESPONSE, "DATA CHANNEL RESPONSE" },

            {RadioMessageType.OPERATIONAL_REQUEST, " OPERATIONAL REQUEST" },
            {RadioMessageType.OPERATIONAL_RESPONSE, " OPERATIONAL RESPONSE" },

        };


        public enum ChannelTypes_Enum
        {
            DIGITAL_INPUT = 0,
            DIGITAL_OUTPUT = 1,
            ANALOG_INPUT = 2,
            ANALOG_OUTPUT = 3,
        };

        public static readonly Dictionary<ChannelTypes_Enum, string> ChannelTypes_Dict = new Dictionary<ChannelTypes_Enum, string>
        {
            {ChannelTypes_Enum.DIGITAL_INPUT, "DIGITAL INPUT" },
            {ChannelTypes_Enum.DIGITAL_OUTPUT, "DIGITAL OUTPUT" },

            {ChannelTypes_Enum.ANALOG_INPUT, " ANALOG INPUT" },
            {ChannelTypes_Enum.ANALOG_OUTPUT, " ANALOG OUTPUT" },
        };

        public enum ChannelDataTypes_Enum
        {
            S16_TYPE = 0,
            U16_TYPE = 1,
            FLOAT_TYPE = 2,
            BIT_TYPE = 3
        };


        public static readonly Dictionary<ChannelDataTypes_Enum, string> ChannelDataTypes_Dict = new Dictionary<ChannelDataTypes_Enum, string>
        {
            {ChannelDataTypes_Enum.S16_TYPE, "S16_TYPE" },
            {ChannelDataTypes_Enum.U16_TYPE, "U16_TYPE" },

            {ChannelDataTypes_Enum.FLOAT_TYPE, "FLOAT_TYPE" },
            {ChannelDataTypes_Enum.BIT_TYPE, "BIT_TYPE" },
        };


        public enum DeviceChannelStatus
        {
            SUCCESS = 0,
            DEVICE_NOT_EXIST = 1,
            ALARM = 2
        }
    }
}
