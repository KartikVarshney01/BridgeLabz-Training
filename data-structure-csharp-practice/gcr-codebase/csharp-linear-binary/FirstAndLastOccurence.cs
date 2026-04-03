using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class FirstAndLastOccurence
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 2, 3, 4, 5 };
            int target = 2;

            int first = FindFirst(nums, target);
            int last = FindLast(nums, target);

            if (first == -1)
            {
                Console.WriteLine("Target not found.");
            }
            else
            {
                Console.WriteLine($"First Occurrence Index: {first}");
                Console.WriteLine($"Last Occurrence Index: {last}");
            }
        }

        static int FindFirst(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        static int FindLast(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    left = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
