using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.MetalFactoryAndFurniture
{
    internal class MetalFactoryMenu
    {
        public static void Menu()
        {
            Console.Write("Enter the Price Chart Size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            PriceChart chart = new PriceChart(size);

            Rod rod = null;

            while (true)
            {
                Console.WriteLine("\n==== METAL FACTORY ====");
                Console.WriteLine("1. Enter Rod Length");
                Console.WriteLine("2. Optimized Cut Revenue");
                Console.WriteLine("3. Non-Optimized Cut Revenue");
                Console.WriteLine("4. Custom Order Revenue (OptimizedB)");
                Console.WriteLine("5. Check Revenue for Rod Size 8");
                Console.WriteLine("6. Exit");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Rod Length: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        rod = new Rod(length);
                        break;

                    case 2:
                        if (rod == null)
                        {
                            Console.WriteLine("Enter the rod length first (Option 1).");
                            break;
                        }
                        int optimizedRevenue = new OptimizedCut().CutRod(rod, chart);
                        Console.WriteLine($"Total Revenue: {optimizedRevenue}");
                        break;

                    case 3:
                        if (rod == null)
                        {
                            Console.WriteLine("Enter the rod length first (Option 1).");
                            break;
                        }
                        int nonOptimizedRevenue = new NotOptimizedCut().CutRod(rod, chart);
                        Console.WriteLine($"Total Revenue: {nonOptimizedRevenue}");
                        break;

                    case 4:
                        if (rod == null)
                        {
                            Console.WriteLine("Enter the rod length first (Option 1).");
                            break;
                        }
                        int customRevenue = new OptimizedCutB().CutRod(rod, chart);
                        Console.WriteLine($"Total Revenue: {customRevenue}");
                        break;

                    case 5:
                        int rod8Revenue = new OptimizedCut().CutRod(new Rod(8), chart);
                        Console.WriteLine($"Total Revenue: {rod8Revenue}");
                        break;

                    case 6:
                        Console.WriteLine("Exiting The Program");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
