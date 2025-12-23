using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class Frequency
    {
        static void Main()
        {
            // Taking Input
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Initializing a temp variable to hold number
            int temp = num;

            // Initializing count variable
            int count = 0;

            // Counting number of digits
            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            // Creating digits array
            int[] values = new int[count];
            
            // Reassigning number to temp
            temp = num;

            for (int i = 0; i < count; i++)
            {
                values[i] = temp % 10;
                temp /= 10;
            }

            // Creating frequency array
            int[] freq = new int[10];

            for (int i = 0; i < count; i++) freq[values[i]]++;

            // Display Output
            for (int i = 0; i < 10; i++)
            {
                if (freq[i] > 0) Console.WriteLine($"{i} : {freq[i]}");
            }
        }
    }
}
