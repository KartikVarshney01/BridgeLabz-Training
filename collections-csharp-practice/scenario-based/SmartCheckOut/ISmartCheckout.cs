using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.SmartCheckOut
{
    // Interface Class
    // Defines operations for smart checkout system
    internal interface ISmartCheckout
    {
        // Adds items to the catalog
        void AddCatalog();

        // Updates item price or quantity
        void UpdateCatalog();

        // Removes an item from catalog
        void RemoveItem();

        // Adds customer to checkout queue
        void AddCustomer();

        // Processes customer checkout
        void Checkout();

        // Displays available items
        void DisplayCatalog();
    }
}
