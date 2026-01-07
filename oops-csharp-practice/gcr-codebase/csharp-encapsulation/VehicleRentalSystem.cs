using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    internal class VehicleRentalSystem
    {
        public static void Main(String[] args)
        {
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car(101, 1000, "CAR-INS-01");
            vehicles[1] = new Bike(202, 300, "BIKE-INS-02");
            vehicles[2] = new Truck(303, 2000, "TRUCK-INS-03");

            int days = 5;

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("Vehicle Number : " + vehicle.VehicleNumber);
                Console.WriteLine("Vehicle Type   : " + vehicle.VehicleType);
                Console.WriteLine("Rental Cost   : " + vehicle.CalculateRentalCost(days));

                if (vehicle is IInsurable insurable)
                {
                    Console.WriteLine("Insurance Cost: " + insurable.CalculateInsurance());
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }

                Console.WriteLine("-----------------------------------");
            }
        }
    }

    // Interface IInsurable
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    // Abstract Class Vehicle
    abstract class Vehicle
    {
        private int vehicleNumber;
        private string vehicleType;
        private double rentalRate;

        protected Vehicle(int vehicleNumber, string vehicleType, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.rentalRate = rentalRate;
        }

        public int VehicleNumber
        {
            get { return vehicleNumber; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
        }

        protected double RentalRate
        {
            get { return rentalRate; }
        }


        public abstract double CalculateRentalCost(int days);
    }

    // Class Car
    class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(int vehicleNumber, double rentalRate, string policyNumber)
            : base(vehicleNumber, "Car", rentalRate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * RentalRate;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public string GetInsuranceDetails()
        {
            return $"Car Insurance Policy Number: {insurancePolicyNumber}";
        }
    }

    // Class Bike
    class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Bike(int vehicleNumber, double rentalRate, string policyNumber)
            : base(vehicleNumber, "Bike", rentalRate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * RentalRate * 0.9;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public string GetInsuranceDetails()
        {
            return $"Bike Insurance Policy Number: {insurancePolicyNumber}";
        }
    }

    // Class Truck
    class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Truck(int vehicleNumber, double rentalRate, string policyNumber)
            : base(vehicleNumber, "Truck", rentalRate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * RentalRate * 1.2;
        }

        public double CalculateInsurance()
        {
            return 2000;
        }

        public string GetInsuranceDetails()
        {
            return $"Truck Insurance Policy Number: {insurancePolicyNumber}";
        }
    }
}
