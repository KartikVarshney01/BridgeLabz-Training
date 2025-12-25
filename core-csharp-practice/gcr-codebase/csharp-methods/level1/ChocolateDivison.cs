using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class ChocolateDivison
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter two numbers : ");
            Console.Write("Enter number of chocolates : ");
            int numberofchocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of Childrens : ");
            int numberofchildrens = Convert.ToInt32(Console.ReadLine());

            // Calling the function tom find quotient and remainder 
            int[] ans = FindRemainderAndQuotient(numberofchocolates, numberofchildrens);

            // Display Output
            Console.WriteLine($"The number of chocolates each student get is {ans[0]} and the remaining chocolates are {ans[1]}.");
        }

        static int[] FindRemainderAndQuotient(int chocolates, int children)
        {
            // ans array to store quotient and remainder
            int[] ans = new int[2];
            ans[0] = chocolates / children;
            ans[1] = chocolates % children;
            return ans;

        }
    }
}
