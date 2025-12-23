using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class OddEvenArray
    {
        static void Main(String[] args)
        {
            // Taking Input number from the user.
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // checking if the inputed number is natural or not.
            if (num < 1)
            {
                Console.Error.WriteLine("Invalid Number");
                Environment.Exit(0);
            }

            // Calculating the even and odd array sizes
            int size = (num / 2) + 1;

            // Initializing Even and Odd Array.
            int[] even = new int[size];
            int[] odd = new int[size];

            // Taking index variable for storing value in array
            int idxe = 0;
            int idxo = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0) even[idxe++] = i;
                else odd[idxo++] = i;
            }

            // Showing Output
            Console.WriteLine("The Even array is : ");
            foreach (int i in even) Console.Write(i + " ");
            Console.WriteLine("\nThe Odd array is : ");
            foreach (int j in odd) Console.Write(j + " ");
        }
    }
}
