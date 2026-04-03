using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class RemoveDuplicates
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };

            Console.Write("Original List: ");
            PrintList(list);

            List<int> result = DuplicatesFun(list);

            Console.Write("After Removing Duplicates: ");
            PrintList(result);
        }

        static List<int> DuplicatesFun(List<int> list)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int item in list)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    result.Add(item);
                }
            }

            return result;
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
