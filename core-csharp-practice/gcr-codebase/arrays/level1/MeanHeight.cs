using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class MeanHeight
    {
        static void Main(String[] args)
        {
            // Initializing Input Height Arrat.
            double[] height = new double[11];

            // Initializing sum variable.
            double sum = 0;

            for (int i = 0; i < height.Length; i++)
            {
                height[i] = Convert.ToDouble(Console.ReadLine());
                sum += height[i];
            }

            // Initializing mean variable and finding mean height of 11 players.
            double mean = sum / 11;

            // Giving Output
            Console.WriteLine($"The mean height of 11 players is {mean}");
        }
    }
}
