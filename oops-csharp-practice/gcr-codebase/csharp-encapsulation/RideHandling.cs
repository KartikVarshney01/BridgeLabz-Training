using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    internal class RideHandling
    {
        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car(1, "Kartik", 15);
            vehicles[1] = new Bike(2, "Aryan", 10);
            vehicles[2] = new Auto(3, "Ram", 18);

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for 10 km: {vehicle.CalculateFare(10)}");

                if (vehicle is IGPS gps)
                {
                    gps.UpdateLocation("Delhi");
                    Console.WriteLine($"Current Location: {gps.GetCurrentLocation()}");
                }

                Console.WriteLine();
            }
        }
    }

    // Interface IGPS
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    // Abstract Class Vehicle
    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
        }

        public string DriverName
        {
            get { return driverName; }
        }

        protected double RatePerKm
        {
            get { return ratePerKm; }
        }

        protected Vehicle(int vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID: " + vehicleId);
            Console.WriteLine("Driver Name: " + driverName);
            Console.WriteLine("Rate Per Km: " + ratePerKm);
        }
    }

    // Derived Car Class
    class Car : Vehicle, IGPS
    {
        private string currentLocation;

        public Car(int id, string driver, double rate)
            : base(id, driver, rate)
        {
            currentLocation = "Not Available";
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm + 50;
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
        }
    }

    // Derived Bike Class
    class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(int id, string driver, double rate)
            : base(id, driver, rate)
        {
            currentLocation = "Not Available";
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
        }
    }

    // Derived Auto Class
    class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(int id, string driver, double rate)
            : base(id, driver, rate)
        {
            currentLocation = "Not Available";
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm + 20;
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
        }
    }
}
