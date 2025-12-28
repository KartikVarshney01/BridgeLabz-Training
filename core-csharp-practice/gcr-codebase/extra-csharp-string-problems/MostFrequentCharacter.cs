using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class MostFrequentCharacter
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter The String : ");
            string s = Console.ReadLine();

            // Initializing the frequency array to store characters frequency
            int[] freq = new int[256];

            foreach (char ch in s)
            {
                if (ch != ' ') freq[ch]++;
            }

            char mostfreq = '\0';
            int max = 0;

            foreach (char ch in s)
            {
                if (freq[ch] > max)
                {
                    max = freq[ch];
                    mostfreq = ch;
                }
            }

            // Display Output
            Console.WriteLine($"Most Frequent Character : '{mostfreq}'");
        }
    }
}
