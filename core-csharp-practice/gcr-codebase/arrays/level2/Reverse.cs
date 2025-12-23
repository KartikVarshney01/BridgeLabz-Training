using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class Reverse
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num; // Temporary storing num value
            int count = 0; // Count variable to count digits

            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            // Initializing digits array
            int[] values = new int[count];
            int idx = 0;

            temp = num;

            while (temp > 0)
            {
                values[idx++] = temp % 10;
                temp /= 10;

            }

            // Displaying Output

            Console.WriteLine("The reverse array : ");
            for (int i = 0; i < count; i++) Console.Write(values[i] + " ");
        }
    }
}
