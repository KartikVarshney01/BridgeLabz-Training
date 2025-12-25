using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class SmallestAndLargest
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter the 3 numbers : ");
            Console.Write("Enter the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //  Calling the function to find the smallest and largest number among three.

            int[] ans = FindSmallestAndLargest(num1, num2, num3);

            // Displaying Output
            Console.WriteLine($"The smallest number : {ans[0]}, And the largest number : {ans[1]}");
        }

        static int[] FindSmallestAndLargest(int num1, int num2, int num3)
        {
            int[] ans = new int[2];
            ans[0] = Math.Min(num1, Math.Min(num2, num3));
            ans[1] = Math.Max(num1, Math.Max(num2, num3));
            return ans;
        }

    }
}
