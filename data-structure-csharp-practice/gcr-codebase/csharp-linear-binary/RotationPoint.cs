using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class RotationPoint
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 8, 9, 1, 2, 3 };

            int index = FindRotationPoint(nums);

            Console.WriteLine($"Rotation point index: {index}");
            Console.WriteLine($"Smallest element: {nums[index]}");
        }
        static int FindRotationPoint(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            if (nums[left] <= nums[right])
            {
                return left;
            }

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (mid > 0 && nums[mid] < nums[mid - 1]) return mid;
                if (nums[mid] >= nums[left]) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}
