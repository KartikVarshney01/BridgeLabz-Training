using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.MetalFactoryAndFurniture
{
    internal class OptimizedCutB
    {
        public int CutRod(Rod rod, PriceChart chart)
        {
            Console.Write("Enter the reserved size of split: ");
            int reservedSize = Convert.ToInt32(Console.ReadLine());

            int rodLength = rod.GetLength();

            if (reservedSize <= 0 || reservedSize > rodLength)
            {
                Console.WriteLine("Invalid reserved size");
                return 0;
            }

            int reservedRevenue = chart.GetPrice(reservedSize);
            int remainingRodSize = rodLength - reservedSize;

            int bestRevenue = 0;
            for (int i = 0; i <= remainingRodSize; i++)
            {
                int revenue = chart.GetPrice(i) + chart.GetPrice(remainingRodSize - i);
                if (revenue > bestRevenue)
                    bestRevenue = revenue;
            }

            return reservedRevenue + bestRevenue;
        }

    }
}
