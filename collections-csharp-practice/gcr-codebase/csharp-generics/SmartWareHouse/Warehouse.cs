using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal abstract class Warehouse
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Warehouse(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }

        public abstract void DisplayInfo();
    }
}
