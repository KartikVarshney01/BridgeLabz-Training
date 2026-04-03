using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class VehicleRegistration
    {
        // Instance variables
        string ownerName;
        string vehicleType;

        // Class variable that is fixed for all vehicles
        static double registrationFee = 4000;

        // Parameterized constructor
        public VehicleRegistration(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Instance method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name        : " + ownerName);
            Console.WriteLine("Vehicle Type      : " + vehicleType);
            Console.WriteLine("Registration Fee  : " + registrationFee);
        }

        // Class method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }

        static void Main()
        {
            VehicleRegistration v1 = new VehicleRegistration("Harsh", "Two Wheeler");
            VehicleRegistration v2 = new VehicleRegistration("Satyam", "Four Wheeler");

            Console.WriteLine("Vehicle Details Before Fee Update");
            v1.DisplayVehicleDetails();
            Console.WriteLine();
            v2.DisplayVehicleDetails();

            Console.WriteLine();

            VehicleRegistration.UpdateRegistrationFee(6500);

            Console.WriteLine("Vehicle Details After Fee Update");
            v1.DisplayVehicleDetails();
            Console.WriteLine();
            v2.DisplayVehicleDetails();
        }
    }
}
