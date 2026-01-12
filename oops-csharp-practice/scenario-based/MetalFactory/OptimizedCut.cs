using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.MetalFactoryAndFurniture
{
    internal class OptimizedCut : ICutting
    {
        public int CutRod(Rod rod, PriceChart chart)
        {
            int length = rod.GetLength();
            int bestRevenue = 0;

            for (int i = 0; i <= length; i++)
            {
                int revenue = chart.GetPrice(i) + chart.GetPrice(length - i);
                if (revenue > bestRevenue)
                    bestRevenue = revenue;
            }

            return bestRevenue;
        }
    }
}
