using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.CustomFurniture
{
    internal class PriceChart
    {
        private int[] sizes;
        private int[] prices;
        private int count;

        public PriceChart(int n)
        {
            sizes = new int[n];
            prices = new int[n];
            count = n;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Rod Size and Revenue:");
                Console.Write("Size: ");
                sizes[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Revenue: ");
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public int GetPrice(int length)
        {
            for (int i = 0; i < count; i++)
                if (sizes[i] == length) return prices[i];
            return 0;
        }

        public int GetBestSize(int maxLength)
        {
            int bestSize = 0;
            int bestPrice = 0;
            for (int i = 0; i < count; i++)
            {
                if (sizes[i] <= maxLength && prices[i] > bestPrice)
                {
                    bestPrice = prices[i];
                    bestSize = sizes[i];
                }
            }
            return bestSize;
        }
    }
}
