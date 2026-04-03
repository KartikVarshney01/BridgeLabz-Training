using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal class Electronics : Warehouse
    {
        public int WarrantyYears { get; set; }

        public Electronics(string Name, int Quantity, int WarrantyYears) : base(Name, Quantity)
        {
            WarrantyYears = WarrantyYears;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electronics : Name : {Name}, Quantity : {Quantity}, Warranty Years : {WarrantyYears}");
        }
    }
}
