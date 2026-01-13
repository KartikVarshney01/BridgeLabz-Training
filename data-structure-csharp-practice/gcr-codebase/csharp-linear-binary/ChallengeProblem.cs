using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class ChallengeProblem
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, -2, 5};
            int target = 4;

            int missing = FirstMissingPositive(nums);
            Console.WriteLine($"First Missing Positive Integer: {missing}");

            Array.Sort(nums);

            int index = BinarySearch(nums, target);
            Console.WriteLine($"Index of target {target}: {index}");
        }
        static int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;
            bool[] visited = new bool[n + 1];

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0 && nums[i] <= n)
                {
                    visited[nums[i]] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    return i;
                }
            }

            return n + 1;
        }

        static int BinarySearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
