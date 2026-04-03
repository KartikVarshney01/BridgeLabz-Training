using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.SmartCheckOut
{
    // Encapsulated Item Class
    //Represents an item available in the supermarket
    internal class Item
    {
        private static int NextItemID = 1;
        public int ItemId { get; set; } // Unique Id For each Item
        public string ItemName { get; set; } //Item Name
        public int ItemPrice { get; set; } // Price of the Item
        public int AvailableQuantity { get; set; } // Stock of the item

        public Item()
        {
            ItemId = NextItemID++;
        }
    }
}
