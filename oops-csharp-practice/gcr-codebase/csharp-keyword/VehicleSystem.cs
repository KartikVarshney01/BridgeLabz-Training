using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class VehicleSystem
    {
        public static double RegistrationFee = 1500;

        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;

        public VehicleSystem(string RegistrationNumber, string OwnerName, string VehicleType)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }

        public static void DisplayVehicleDetails(object obj)
        {
            if (obj is VehicleSystem v)
            {
                Console.WriteLine("Reg Number : " + v.RegistrationNumber);
                Console.WriteLine("Owner      : " + v.OwnerName);
                Console.WriteLine("Type       : " + v.VehicleType);
                Console.WriteLine("Fee        : " + RegistrationFee);
            }
            else
            {
                Console.WriteLine("Invalid Vehicle Object");
            }
        }
        static void Main(String[] args)
        {
            UpdateRegistrationFee(2000);

            VehicleSystem v1 = new VehicleSystem("MH12AB1234", "Rohit", "Car");
            VehicleSystem v2 = new VehicleSystem("DL09XY5678", "Priya", "Bike");

            DisplayVehicleDetails(v1);
            Console.WriteLine();
            DisplayVehicleDetails(v2);
        }
    }
}
