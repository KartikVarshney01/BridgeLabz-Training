using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class VehicleSystem
    {
        static void Main(String[] args)
        {
            Vehicle[] vehicles =
            {
            new Car(180, "Petrol", 5),
            new Truck(120, "Diesel", 5000),
            new Motorcycle(160, "Petrol", false)
        };

            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine();
            }
        }
        class Vehicle
        {
            public int MaxSpeed;
            public string FuelType;

            public Vehicle(int maxSpeed, string fuelType)
            {
                MaxSpeed = maxSpeed;
                FuelType = fuelType;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine("Max Speed : " + MaxSpeed);
                Console.WriteLine("Fuel Type: " + FuelType);
            }
        }

        class Car : Vehicle
        {
            public int SeatCapacity;

            public Car(int maxSpeed, string fuelType, int seatCapacity)
                : base(maxSpeed, fuelType)
            {
                SeatCapacity = seatCapacity;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Seats     : " + SeatCapacity);
            }
        }

        class Truck : Vehicle
        {
            public int PayloadCapacity;

            public Truck(int maxSpeed, string fuelType, int payloadCapacity)
                : base(maxSpeed, fuelType)
            {
                PayloadCapacity = payloadCapacity;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Payload   : " + PayloadCapacity + " kg");
            }
        }

        class Motorcycle : Vehicle
        {
            public bool HasSidecar;

            public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
                : base(maxSpeed, fuelType)
            {
                HasSidecar = hasSidecar;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Sidecar   : " + HasSidecar);
            }
        }
    }
}

