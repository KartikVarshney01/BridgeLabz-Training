using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class LongestConsecutiveSequence
    {
        static void Main(String[] args)
        {
            int[] nums = { 15, 2, 1, 9, 3, 20, 4, 10, 11, 12, 13, 14, 8, 7, 6, 5 };
            Console.WriteLine($"Longest consecutive sequence length : {LongestConsecutive(nums)}");
        }
        static int LongestConsecutive(int[] nums)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                    map[num] = true;
            }

            int longest = 0;

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num - 1))
                {
                    int current = num;
                    int length = 1;

                    while (map.ContainsKey(current + 1))
                    {
                        current++;
                        length++;
                    }

                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }
    }
}
