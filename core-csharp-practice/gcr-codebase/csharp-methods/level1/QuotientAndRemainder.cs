using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class QuotientAndRemainder
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter two numbers : ");
            Console.Write("Enter 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calling the function tom find quotient and remainder 
            int[] ans = FindRemainderAndQuotient(num1, num2);

            // Display Output
            Console.WriteLine($"The quotient is {ans[0]} and the remainder is {ans[1]}.");
        }

        static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            // ans array to store quotient and remainder
            int[] ans = new int[2];
            ans[0] = number / divisor;
            ans[1] = number % divisor;
            return ans;

        }
    }
}
