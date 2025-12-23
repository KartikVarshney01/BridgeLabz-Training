using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class Factors
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Initializing MaxFactor variable
            int MaxFactor = 10;

            // Initializing factors array.
            int[] factors = new int[MaxFactor];

            // Initializing index for iteration in factors array
            int idx = 0;

            // For loop to find factors
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) factors[idx++] = i;
                if (idx >= MaxFactor)
                {
                    MaxFactor *= 2;
                    int[] temp = new int[MaxFactor];
                    for (int j = 0; j < factors.Length; j++) temp[j] = factors[j];
                    factors = temp;
                }
            }

            // Output
            Console.Write($"The factors of number are : ");
            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] == 0) break;
                Console.Write(factors[i] + " ");
            }
        }
    }
}
