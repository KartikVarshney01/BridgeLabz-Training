using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_analysis
{
    internal class TargetSearching
    {
        static void Main()
        {
            int[] dataSizes = { 1000, 10000, 1000000, 100000000 };
            //target at the end - worst case
            int target = -1;

            foreach (int size in dataSizes)
            {
                int[] data = FunDataCreate(size);
                data[size - 1] = target;

                Console.WriteLine($"\nDataset Size: {size}");

                // Linear Search
                Stopwatch sw = Stopwatch.StartNew();
                LinearSearch(data, target);
                sw.Stop();
                Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");

                // Binary Search
                Array.Sort(data); // O(N log N)
                sw.Restart();
                BinarySearch(data, target);
                sw.Stop();
                Console.WriteLine($"Binary Search Time: {sw.ElapsedMilliseconds} ms");
            }
        }

        static int[] FunDataCreate(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        // Linear Search
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // Binary Search 
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
