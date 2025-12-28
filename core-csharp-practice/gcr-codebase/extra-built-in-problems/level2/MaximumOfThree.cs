using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class MaximumOfThree
    {
        static void Main(String[] args)
        {
            // Calling Input Function to take user input
            int a = InputFun();
            int b = InputFun();
            int c = InputFun();

            // Calling Max Function to find maximum among the three inputted numbers
            int max = MaxFun(a, b, c);

            // Display Output
            Console.WriteLine($"The Maximum among {a},{b} and {c} is : {max}");
        }

        static int InputFun()
        {
            Console.Write("Enter the number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int MaxFun(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
    }
}
