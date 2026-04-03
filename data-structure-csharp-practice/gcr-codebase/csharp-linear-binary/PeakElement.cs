using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class PeakElement
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 10, 20, 40, 25, 10, 5, 2 };

            int peakIndex = FindPeakElement(nums);

            Console.WriteLine($"Peak Element : {nums[peakIndex]}");
        }
        static int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] < nums[mid + 1])
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }
    }
}
