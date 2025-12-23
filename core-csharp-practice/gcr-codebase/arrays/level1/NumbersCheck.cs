using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class NumbersCheck
    {
        static void Main(string[] args)
        {
            // Initializing Input Array.
            int[] nums = new int[5];

            // Taking Input Array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Running For loop to check for positive,negative and zero of a number.
            for (int i = 0; i < nums.Length; i++)
            {
                // Check to see if number is positive.
                if (nums[i] > 0)
                {
                    Console.WriteLine($"The number {nums[i]} is a positive number");
                    // Checking if the positive number is even or odd.
                    if (nums[i] % 2 == 0) Console.WriteLine($"The number {nums[i]} is a even number.");
                    else Console.WriteLine($"The number {nums[i]} is a odd number");
                }
                // Check to see if number is negative.
                else if (nums[i] < 0) Console.WriteLine($"The number {nums[i]} is a negative number.");
                else Console.WriteLine("The number is zero");
            }

            // Comparison of first and last element of nums.
            if (nums[0] == nums[nums.Length - 1]) Console.WriteLine("The numbers at first and last position are equal");
            else if (nums[0] > nums[nums.Length - 1]) Console.WriteLine("The number at first position is greater than the number at last position");
            else Console.WriteLine("The number at the last position is greater than the number at first position.");
        }
    }
}
