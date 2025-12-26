using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.leet_code_codebase
{
    internal class Palindrome
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int res = 0;
            while (num > 0)
            {
                int rem = num % 10;
                res = res * 10 + rem;
                num /= 10;
            }

            Console.WriteLine($"The number {original} is a palindrome : {original == res}");
        }
    }
}
