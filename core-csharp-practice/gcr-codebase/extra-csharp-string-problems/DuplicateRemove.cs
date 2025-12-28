using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class DuplicateRemove
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();

            // Initializing a hashset to find duplicates characters
            HashSet<char> set = new HashSet<char>();
            StringBuilder result = new StringBuilder();

            foreach (char ch in s)
            {
                if (!set.Contains(ch))
                {
                    set.Add(ch);
                    result.Append(ch);
                }
            }

            // Display Output
            Console.WriteLine($"The final string after duplicate characters are removed is : {result.ToString()}");
        }
    }
}
