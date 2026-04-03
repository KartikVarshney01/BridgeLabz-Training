using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FlashDealz
{
    // Menu Class Containing The Menu of Our Program
    internal class FlashDealzMenu
    {
        private FlashDealzUtilityImpl DealzUtility;

        public void Menu()
        {
            DealzUtility = new FlashDealzUtilityImpl();
            while (true)
            {
                Console.WriteLine("Welcome To The Flash Dealz");
                Console.WriteLine("1. Add Products");
                Console.WriteLine("2. Sort Products By Discount");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Exit The Dealz");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DealzUtility.AddProduct();
                        break;
                    case 2:
                        DealzUtility.SortProduct();
                        break;
                    case 3:
                        DealzUtility.DisplayProduct();
                        break;
                    case 4:
                        Console.WriteLine("Exiting The Dealz....");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
          
        }
    }
}
