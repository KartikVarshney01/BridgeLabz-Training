using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays
{
    internal class NestedArray
    {
        static void Main(String[] args)
        {
            // Taking Input and Initializing 2-D Array
            Console.Write("Enter number of rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns : ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] NestedArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    NestedArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Initializing 1-D Array and copying elements from 2-D array to it.
            int[] nums = new int[rows * cols];

            int idx = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nums[idx++] = NestedArray[i, j];
                }
            }

            // Output Display
            Console.WriteLine("The 2-D array converted into 1-D array is :");
            for (int i = 0; i < nums.Length; i++) Console.Write(nums[i] + " ");
        }
    }
}
