using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class Anagrams
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter 1st string: ");
            string s1 = Console.ReadLine().ToLower();

            Console.Write("Enter 2nd string: ");
            string s2 = Console.ReadLine().ToLower();

            s1 = s1.Replace(" ", "");
            s2 = s2.Replace(" ", "");

            // Checking to see if length differes between two stringa
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("The strings are not anagrams");
                return;
            }

            int[] freq = new int[256];

            foreach (char ch in s1)
            {
                freq[ch]++;
            }

            foreach (char ch in s2)
            {
                freq[ch]--;
            }

            foreach (int count in freq)
            {
                if (count != 0)
                {
                    Console.WriteLine("The strings are not anagrams");
                    return;
                }
            }

            Console.WriteLine("The strings are anagrams");
        }
    }
}
