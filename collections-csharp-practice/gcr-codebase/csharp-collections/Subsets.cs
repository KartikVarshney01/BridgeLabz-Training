using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class Subsets
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

            Console.Write("Set 1: ");
            PrintSet(set1);

            Console.Write("Set 2: ");
            PrintSet(set2);

            bool isSubset = IsSubset(set1, set2);

            Console.WriteLine("Is Set1 a subset of Set2? " + isSubset);
        }

        static bool IsSubset(HashSet<int> subset, HashSet<int> superset)
        {
            return subset.IsSubsetOf(superset);
        }

        static void PrintSet(HashSet<int> set)
        {
            foreach (int item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
