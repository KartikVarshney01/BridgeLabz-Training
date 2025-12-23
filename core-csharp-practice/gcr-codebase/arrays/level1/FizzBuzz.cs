using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class FizzBuzz
    {
        static void Main(String[] args)
        {
            // Taking input and initializing the array.
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            String[] ans = new string[num + 1];

            // Finding Output
            for (int i = 0; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) ans[i] = "FizzBuzz";
                else if (i % 3 == 0) ans[i] = "Fizz";
                else if (i % 5 == 0) ans[i] = "Buzz";
                else ans[i] = i.ToString();
            }

            // Displaying Output
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine($"Position {i} = {ans[i]}");
            }
        }
    }
}
