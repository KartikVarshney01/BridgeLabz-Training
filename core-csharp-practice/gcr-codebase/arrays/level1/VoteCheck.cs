using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class VoteCheck
    {
        static void Main(String[] args)
        {
            // Initializing Input Array.
            int[] nums = new int[10];

            // Taking user input of ages.
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Running a for loop to check which students are eligible for vote and which are not.

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0) Console.WriteLine("Invalid Age");
                else if (nums[i] >= 18) Console.WriteLine($"The Student with the age {nums[i]} can vote.");
                else
                {
                    Console.WriteLine($"The Student with the age {nums[i]} can not vote.");
                }
            }
        }
    }
}
