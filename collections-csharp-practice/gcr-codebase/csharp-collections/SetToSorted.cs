using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class SetToSorted
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

            Console.Write("Original Set: ");
            foreach (int item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List<int> sortedList = ConvertToSortedList(set);

            Console.Write("Sorted List: ");
            foreach (int item in sortedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static List<int> ConvertToSortedList(HashSet<int> set)
        {
            List<int> list = new List<int>(set);
            list.Sort();
            return list;
        }
    }
}
