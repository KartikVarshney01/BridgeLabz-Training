using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class LargestAndSecondLargestTwo
    {
        static void Main(String[] args)
        {
            // Initialize the digits array and take user input for number.
            Console.Write("Enter the number : ");
            long num = Convert.ToInt64(Console.ReadLine());

            int maxDigits = 10;
            int[] values = new int[maxDigits];

            int idx = 0;

            while (num > 0)
            {
                if (idx == maxDigits)
                {
                    maxDigits += 10;
                    int[] temp = new int[maxDigits];
                    for (int j = 0; j < values.Length; j++) temp[j] = values[j];
                    values = temp;
                }

                int remainder = (int)num % 10;
                values[idx++] = remainder;
                num /= 10;

            }

            // Initializing Largest and Second Largest elements
            int Largest = 0;
            int SecondLargest = 0;

            for (int i = 0; i < maxDigits; i++)
            {
                if (values[i] > Largest)
                {
                    SecondLargest = Largest;
                    Largest = values[i];
                }
                else if (values[i] > SecondLargest && values[i] != Largest) SecondLargest = values[i];
            }

            // Output

            Console.WriteLine($"The Largest Element is : {Largest}");
            Console.WriteLine($"The Second Largest Element is {SecondLargest}");
        }
    }
}
