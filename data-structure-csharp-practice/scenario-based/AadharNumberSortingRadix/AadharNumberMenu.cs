using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AadharNumberSortingRadix
{
    // Menu Class Containing User Menu
    internal class AadharNumberMenu
    {
        // Private Reference For The Aadhar Utility 
        private AadharNumberUtilityImpl AadharUtility;

        public AadharNumberMenu()
        {
            AadharUtility = new AadharNumberUtilityImpl();
        }
        public void Menu()
        {
            // Infinite While Loop
            while (true)
            {
                Console.WriteLine("\nThe Aadhar Number Sort (Radix Sort)");
                Console.WriteLine("1. Add Aadhar");
                Console.WriteLine("2. Sort Aadhar");
                Console.WriteLine("3. Search Aadhar");
                Console.WriteLine("4. Exit The Aadhar Search");
                Console.Write("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AadharUtility.AddAadhar();
                        break;
                    case 2:
                        AadharUtility.SortAadhar();
                        break;
                    case 3:
                        AadharUtility.SearchAadhar();
                        break;
                    case 4:
                        Console.WriteLine("Exiting .... ");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice !");
                        break;
                }
            }
        }
    }
}

