using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class VehicleRental
    {
        // Main Function to call or start the program
        static void Main(string[] args)
        {
            Console.Write("Enter Customer Name: ");
            string customName = Console.ReadLine();

            Customer customer = new Customer(customName);

            // Infinite While loop for menu 
            while (true)
            {
                Console.WriteLine("\n1. Rent A Bike");
                Console.WriteLine("2. Rent A Car");
                Console.WriteLine("3. Rent A Truck");
                Console.WriteLine("4. Exit The Program");
                Console.Write("Please Choose option : ");

                // Taking user choice for input
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4) break;

                Console.Write("Enter The Vehicle Number: ");
                string vehiclenum = Console.ReadLine();

                Console.Write("Enter The Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Enter Number of Rental Days: ");
                int days = Convert.ToInt32(Console.ReadLine());

                Vehicle vehicle = null;

                switch (choice)
                {
                    case 1:
                        vehicle = new Bike(vehiclenum, brand);
                        break;
                    case 2:
                        vehicle = new Car(vehiclenum, brand);
                        break;
                    case 3:
                        vehicle = new Truck(vehiclenum, brand);
                        break;
                    default:
                        Console.WriteLine("Invalid option! Choose between 1-4.");
                        continue;
                }

                customer.RentVehicle(vehicle, days);
            }

            Console.WriteLine("Thank you for using Vehicle Rental System");
        }
    }

    // Interface IRentable 
    interface IRentable
    {
        double CalculateRent(int days);
    }
    
    // Abstract Class 
    abstract class Vehicle : IRentable
    {
        protected string vehicleNumber;
        protected string brand;
        protected double rentPerDay;

        public Vehicle(string vehicleNumber, string brand, double rentPerDay)
        {
            this.vehicleNumber = vehicleNumber;
            this.brand = brand;
            this.rentPerDay = rentPerDay;
        }

        public abstract double CalculateRent(int days);

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle No: {vehicleNumber}");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Rent per day: {rentPerDay}");
        }
    }

    // Class Bike
    class Bike : Vehicle
    {
        public Bike(string vehicleNumber, string brand)
            : base(vehicleNumber, brand, 300)
        {
        }

        public override double CalculateRent(int days)
        {
            return days * rentPerDay;
        }
    }

    // Class Car
    class Car : Vehicle
    {
        public Car(string vehicleNumber, string brand)
            : base(vehicleNumber, brand, 1000)
        {
        }

        public override double CalculateRent(int days)
        {
            return (days * rentPerDay) + 500;
        }
    }

    // Class Vehicle
    class Truck : Vehicle
    {
        public Truck(string vehicleNumber, string brand)
            : base(vehicleNumber, brand, 2000)
        {
        }

        public override double CalculateRent(int days)
        {
            return (days * rentPerDay) + (days * 300);
        }
    }

    // Class Customer
    class Customer
    {
        string customerName;

        public Customer(string name)
        {
            customerName = name;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            Console.WriteLine("\n--- RENT DETAILS ---");
            Console.WriteLine($"Customer Name: {customerName}");
            vehicle.DisplayInfo();
            Console.WriteLine($"Days: {days}");
            Console.WriteLine($"Total Rent: {vehicle.CalculateRent(days)}");
        }
    }
}
