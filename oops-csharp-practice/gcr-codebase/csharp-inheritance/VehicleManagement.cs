using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class VehicleManagement
    {
        static void Main(String[] args)
        {
            ElectricVehicle ev = new ElectricVehicle(160, "Tesla");
            PetrolVehicle pv = new PetrolVehicle(180, "Honda");

            ev.DisplayInfo();
            ev.Charge();

            Console.WriteLine();

            pv.DisplayInfo();
            pv.Refuel();
        }
    }
    interface IRefuelable
    {
        void Refuel();
    }

    // Superclass
    class Vehicle
    {
        public int MaxSpeed;
        public string Model;

        public Vehicle(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Model     : " + Model);
            Console.WriteLine("Max Speed : " + MaxSpeed);
        }
    }

    // Electric vehicle
    class ElectricVehicle : Vehicle
    {
        public ElectricVehicle(int maxSpeed, string model)
            : base(maxSpeed, model) { }

        public void Charge()
        {
            Console.WriteLine("Electric vehicle is charging");
        }
    }

    // Petrol vehicle with interface
    class PetrolVehicle : Vehicle, IRefuelable
    {
        public PetrolVehicle(int maxSpeed, string model)
            : base(maxSpeed, model) { }

        public void Refuel()
        {
            Console.WriteLine("Petrol vehicle is being refueled");
        }
    }
}
