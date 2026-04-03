using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.MetalFactoryAndFurniture
{
    internal class NotOptimizedCut : ICutting
    {
        public int CutRod(Rod rod, PriceChart chart)
        {
            int rodLength = rod.GetLength();
            int revenue = 0;

            for (int size = rodLength; size > 0; size--)
            {
                int price = chart.GetPrice(size);
                if (price > 0)
                {
                    revenue = price;
                    break;
                }
            }

            return revenue;
        }
    }
}
