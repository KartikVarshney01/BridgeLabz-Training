using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class ZeroSumSubarray
    {
        static void Main(String[] args)
        {
            int[] nums = { 4, 2, -3, 1, 6, 5, -5 };
            ZeroSumSubarrayFun(nums);
        }
        static void ZeroSumSubarrayFun(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int sum = 0;

            map[0] = -1;
            bool check = false;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (map.ContainsKey(sum))
                {
                    Console.WriteLine($"Zero-sum subarray from index {map[sum] + 1} to {i}");
                    check = true;
                }
                map[sum] = i;
            }

            if (!check) Console.WriteLine("No zero-sum subarray found");
        }
    }
}
