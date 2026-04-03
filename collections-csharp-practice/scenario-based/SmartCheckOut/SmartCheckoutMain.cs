using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.SmartCheckOut
{
    /// <summary>
    /// The Program of SmartCheckout is a supermart billing system using queue and dictionary.
    /// Customers are managed in a queue to ensure FIFO billing order, while a dictionary is used to store items details for easy
    /// access. The System allows adding and removing items, adding customers,fetching item prices and updating stocks quantities upon
    /// purchase.
    /// 
    /// version - 1.0
    /// </summary>
    internal class SmartCheckoutMain
    {
        static void Main(string[] args)
        {
            SmartCheckoutMenu start = new SmartCheckoutMenu();
            start.Menu();
        }
    }
}
