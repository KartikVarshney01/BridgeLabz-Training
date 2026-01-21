using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.SmartCheckOut
{
    // Encapsulated Customer Class
    // Represents a customer waiting in the checkout queue
    internal class Customer
    {
        private static int NextID = 1;

        // Auto Generated Customer Unique Id
        public string CustomerId { get; set; }

        // List of Items Purchased By the Customer
        public List<Item> CustomerItemList;

        public Customer()
        {
            CustomerId = "C-"+NextID++;
            CustomerItemList = new List<Item>();
        }
    }
}
