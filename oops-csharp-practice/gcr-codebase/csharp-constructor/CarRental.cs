using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class CarRental
    {
        string customerName;
        string carModel;
        int rentalDays;
        int costPerDay;

        // Default constructor
        public CarRental()
        {
            customerName = "Jon Doe";
            carModel = "Audi";
            rentalDays = 1;
            costPerDay = 3000;
        }

        // Parameterized constructor
        public CarRental(string customerName, string carModel, int rentalDays, int costPerDay)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            this.costPerDay = costPerDay;
        }

        // Method to calculate total cost
        public int CalculateTotalCost()
        {
            return rentalDays * costPerDay;
        }

        public void Display()
        {
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Car Model     : " + carModel);
            Console.WriteLine("Rental Days   : " + rentalDays);
            Console.WriteLine("Total Cost    : " + CalculateTotalCost());
        }

        static void Main()
        {
            // Default rental
            CarRental r1 = new CarRental();
            Console.WriteLine("Default Rental");
            r1.Display();

            Console.WriteLine();

            // Parameterized rental
            CarRental r2 = new CarRental("Kartik", "Sedan", 3, 1500);
            Console.WriteLine("Parameterized Rental");
            r2.Display();
        }
    }
}
