using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.SmartCheckOut
{
    // Displays User menu
    internal class SmartCheckoutMenu
    {
        private SmartCheckoutUtility CheckoutUtility;

        public SmartCheckoutMenu()
        {
            CheckoutUtility = new SmartCheckoutUtility();
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Smart Mart");
                Console.WriteLine("1. Add Catalog");
                Console.WriteLine("2. Display Catalog");
                Console.WriteLine("3. Update Catalog");
                Console.WriteLine("4. Remove Item From Catalog");
                Console.WriteLine("5. Add Customer");
                Console.WriteLine("6. Customer Checkout");
                Console.WriteLine("7. Exit Mart");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckoutUtility.AddCatalog();
                        break;
                    case 2:
                        CheckoutUtility.DisplayCatalog();
                        break;
                    case 3:
                        CheckoutUtility.UpdateCatalog();
                        break;
                    case 4:
                        CheckoutUtility.RemoveItem();
                        break;
                    case 5:
                        CheckoutUtility.AddCustomer();
                        break;
                    case 6:
                        CheckoutUtility.Checkout();
                        break;
                    case 7:
                        Console.WriteLine("Exiting Mart ...");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
