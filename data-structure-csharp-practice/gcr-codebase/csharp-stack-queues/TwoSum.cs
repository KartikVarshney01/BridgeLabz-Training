using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class TwoSum
    {
        static void Main(String[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSumFun(nums, target);

            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        static int[] TwoSumFun(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int required = target - nums[i];

                if (map.ContainsKey(required))
                {
                    return new int[] { map[required], i };
                }

                if (!map.ContainsKey(nums[i]))
                    map[nums[i]] = i;
            }

            return new int[] { -1, -1 };
        }
    }
}
