using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal class Groceries : Warehouse
    {
        public int ExpiryDate { get; set; }
        public Groceries(String Name, int Quantity, int ExpiryDate) : base(Name, Quantity)
        {
            ExpiryDate = ExpiryDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Groceries : Name {Name}, Quantity : {Quantity}, ExpiryDate : {ExpiryDate}");
        }
    }
}
