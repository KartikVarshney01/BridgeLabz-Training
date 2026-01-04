using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class SmartHome
    {
        static void Main(String[] args)
        {
            Thermostat t1 = new Thermostat(101, "ON", 24);
            t1.ThermostatStatus();
        }
    }
    class Device
    {
        public int DeviceId;
        public string Status;

        public Device(int deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Device ID : " + DeviceId);
            Console.WriteLine("Status    : " + Status);
        }
    }

    class Thermostat : Device
    {
        public int TemperatureSetting;

        public Thermostat(int deviceId, string status, int temperature)
            : base(deviceId, status)
        {
            TemperatureSetting = temperature;
        }

        public void ThermostatStatus()
        {
            DisplayStatus();
            Console.WriteLine("Temperature : " + TemperatureSetting + "°C");
        }
    }
}
