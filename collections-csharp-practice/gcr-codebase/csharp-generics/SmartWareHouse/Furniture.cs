using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal class Furniture : Warehouse
    {
        public string Material { get; set; }

        public Furniture(String Name, int Quantity, string Material) : base(Name, Quantity)
        {
            Material = Material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Furniture : Name : {Name}, Quantity : {Quantity}, Material : {Material}");
        }
    }
}
