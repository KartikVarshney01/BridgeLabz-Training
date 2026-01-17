using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FlashDealz
{
    // Encapsulated Product Class
    internal class Product
    {
        private static int nextId = 101;
        public int ProductId { get; set; }

        //public string ProductName { get; set; }
        public double ProductDiscount { get; set; }

        public Product()
        {
            this.ProductId = nextId++;
        }

        public override string ToString()
        {
            return $"{ProductId} ---> {ProductDiscount}%";
        }
    }
}
