using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class UserSum
    {
        static void Main(String[] args)
        {
            // Initializing the array and sum variable.
            double[] nums = new double[10];
            double sum = 0;
            int i = 0;

            // Using while loop for input.
            Console.WriteLine("Enter multiple numbers : ");
            while (true)
            {
                if (i == 10) break;
                double n = Convert.ToDouble(Console.ReadLine());
                if (n <= 0) break;
                else
                {
                    nums[i++] = n;
                }
            }

            // Finding the sum.
            foreach (double k in nums) sum += k;

            Console.WriteLine($"The sum for the input numbers are {sum}.");
        }
    }
}
