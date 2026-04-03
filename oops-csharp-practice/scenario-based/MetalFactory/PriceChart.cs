using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.MetalFactoryAndFurniture
{
    internal class PriceChart
    {
        private int[,] chart;

        public PriceChart(int size)
        {
            // Chart Array To hold the rod size and their prices 
            chart = new int[size, 2]; // 0-size, 1-price

            for (int i = 0; i < chart.GetLength(0); i++)
            {
                Console.WriteLine("Enter The Rod Size and its Revenue : ");

                Console.Write("Enter the Rod Size : ");
                chart[i, 0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Revenue : ");
                chart[i, 1] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public int GetPrice(int length)
        {
            for (int i = 0; i < chart.GetLength(0); i++)
            {
                if (chart[i, 0] == length)
                {
                    return chart[i, 1];
                }
            }
            return 0;
        }
    }
}
