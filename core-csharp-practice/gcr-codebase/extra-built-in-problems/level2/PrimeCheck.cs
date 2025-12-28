using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class PrimeCheck
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number you want to check for being prime : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling function PrimeFun to check whether a num is prime or not.
            bool PrimeCheck = PrimeFun(num);

            // Display Output
            Console.WriteLine(PrimeCheck ? $"The number {num} is a prime." : $"The number {num} is not a prime.");
        }
        static bool PrimeFun(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
