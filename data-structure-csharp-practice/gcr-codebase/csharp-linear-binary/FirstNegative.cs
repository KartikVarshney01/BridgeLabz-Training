using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class FirstNegative
    {
        static void Main(string[] args)
        {
            FirstNegative start = new FirstNegative();
            int[] nums = { 1, 5, 20, 65, -7, 51, -5, 85 };
            Console.Write("Nums Array : ");
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"First Negative Number is : {start.LinearSearch(nums)}");
        }
        int LinearSearch(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] < 0)) return nums[i];
            }
            return 0;
        }
    }
}
