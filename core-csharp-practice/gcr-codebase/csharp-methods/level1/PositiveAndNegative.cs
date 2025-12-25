using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class PositiveAndNegative
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Display Output
            Console.WriteLine($"The number {num} is : {Fun(num)}");
        }

        static int Fun(int num)
        {
            if (num == 0) return 0;
            else if (num > 1) return 1;
            else return -1;
        }
    }
}
