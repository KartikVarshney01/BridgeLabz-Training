using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class MaximumSlidingWindow
    {
        static void Main(String[] args)
        {
            int[] nums = { 1, 5, 6, 1, 2, 9, 4, 8 };
            int k = 3;

            int[] result = MaxSlidingWindow(nums, k);

            Console.WriteLine("Sliding Window Maximum : ");
            foreach (int max in result)
                Console.Write(max + " ");
        }
        static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k <= 0)
                return new int[0];

            int n = nums.Length;
            int[] result = new int[n - k + 1];
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                    deque.RemoveFirst();

                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                    deque.RemoveLast();

                deque.AddLast(i);

                if (i >= k - 1)
                    result[i - k + 1] = nums[deque.First.Value];
            }

            return result;
        }
    }
}
