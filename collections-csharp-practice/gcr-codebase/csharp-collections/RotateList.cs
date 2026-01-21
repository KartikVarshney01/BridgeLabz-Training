using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class RotateList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 10, 20, 30, 40, 50 };
            int k = 2;

            Console.Write("Original List: ");
            PrintList(list);

            RotateLeft(list, k);

            Console.Write("List after rotating by " + k + ": ");
            PrintList(list);
        }

        static void RotateLeft(List<int> list, int k)
        {
            int n = list.Count;
            k = k % n;   // handle k > n

            List<int> rotated = new List<int>();

            // Add elements from k to end
            for (int i = k; i < n; i++)
            {
                rotated.Add(list[i]);
            }

            // Add first k elements
            for (int i = 0; i < k; i++)
            {
                rotated.Add(list[i]);
            }

            // Copy back to original list
            for (int i = 0; i < n; i++)
            {
                list[i] = rotated[i];
            }
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
