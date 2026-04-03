using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class GivenSumPair
    {
        static void Main()
        {
            int[] nums = { 8, 7, 2, 5, 3, 1 };
            int target = 15;

            Console.WriteLine(PairFind(nums, target) ? "Pair exists" : "Pair does not exist");
        }
        static bool PairFind(int[] nums, int target)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            foreach (int num in nums)
            {
                int remainder = target - num;

                if (map.ContainsKey(remainder))
                    return true;

                if (!map.ContainsKey(num))
                    map[num] = true;
            }
            return false;
        }
    }
}
