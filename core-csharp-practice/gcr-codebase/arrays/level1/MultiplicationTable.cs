using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class MultiplicationTable
    {
        static void Main(String[] args)
        {
            // Taking User input number for which the multiplication table need to be formed.
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Initializing the table array.
            int[] table = new int[10];

            // Running for loop to find multiplication of the number and storing them in the table array.
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = num * (i + 1);
            }

            // Displaying Output
            Console.WriteLine($"The multiplication table of {num} is : ");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"{num} * {i + 1} = {table[i]}");
            }
        }
    }
}
