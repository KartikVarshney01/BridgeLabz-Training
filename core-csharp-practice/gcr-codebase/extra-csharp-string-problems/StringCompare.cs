using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class StringCompare
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the 1st String : ");
            string s1 = Console.ReadLine();

            Console.Write("Enter the 2nd String : ");
            string s2 = Console.ReadLine();

            int min = s1.Length < s2.Length ? s1.Length : s2.Length; // To find minimum length

            bool check = false;

            for (int i = 0; i < min; i++)
            {
                if (s1[i] < s2[i])
                {
                    Console.WriteLine($"\"{s1}\" comes before \"{s2}\" in lexicographical order");
                    check = true;
                    break;
                }
                else if (s1[i] > s2[i])
                {
                    Console.WriteLine($"\"{s2}\" comes before \"{s1}\" in lexicographical order");
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                if (s1.Length < s2.Length) Console.WriteLine($"\"{s1}\" comes before \"{s2}\" in lexicographical order");
                else if (s1.Length > s2.Length) Console.WriteLine($"\"{s2}\" comes before \"{s1}\" in lexicographical order");
                else Console.WriteLine("Both Strings are equal");
            }
        }
    }
}
