using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class Factorial
    {
        static void Main(String[] args)
        {
            // Calling Input function for taking input
            int num = InputFun();

            // Calling Function Factorial to find factorial using recursion
            long ans = FactorialFun(num);

            // Dsiplay Output
            Display(num, ans);
        }
        static int InputFun()
        {
            Console.Write("Enter a number : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static long FactorialFun(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * FactorialFun(num - 1);
        }
        static void Display(int num, long ans)
        {
            Console.WriteLine($"Factorial of {num} is {ans}.");
        }
    }
}
