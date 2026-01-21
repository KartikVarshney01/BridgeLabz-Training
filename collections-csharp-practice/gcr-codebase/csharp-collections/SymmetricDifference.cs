using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class SymmetricDifference
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            Console.Write("Set 1: ");
            PrintSet(set1);

            Console.Write("Set 2: ");
            PrintSet(set2);

            HashSet<int> symmetricDiff = new HashSet<int>(set1);
            symmetricDiff.SymmetricExceptWith(set2);

            Console.Write("Symmetric Difference: ");
            PrintSet(symmetricDiff);
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
