using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class FibonacciGenerator
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number of terms : ");
            int term = Convert.ToInt32(Console.ReadLine());

            // Display Output
            Console.WriteLine($"The Fibonacci Sequence upto the term : {term}");
            FibonacciFun(term);
        }
        static void FibonacciFun(int term)
        {
            int a = 0;
            int b = 1;

            for (int i = 1; i <= term; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
