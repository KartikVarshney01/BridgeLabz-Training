using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.CustomFurniture
{
    internal class FurnitureMenu
    {

        public static void Show()
        {
            CuttingUtility utility = new CuttingUtility();

            while (true)
            {
                Console.WriteLine("\n==== FURNITURE FACTORY ====");
                Console.WriteLine("1. Add Price Chart");
                Console.WriteLine("2. Scenario A: Max Revenue");
                Console.WriteLine("3. Scenario B: Mandatory Piece");
                Console.WriteLine("4. Scenario C: Max Revenue + Waste");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddPriceChart();
                        break;
                    case 2:
                        utility.ScenarioA();
                        break;
                    case 3:
                        utility.ScenarioB();
                        break;
                    case 4:
                        utility.ScenarioC();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
