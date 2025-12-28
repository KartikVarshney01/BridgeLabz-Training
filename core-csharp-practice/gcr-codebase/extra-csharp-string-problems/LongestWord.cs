using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class LongestWord
    {
        static void Main(string[] args)
        {
            // Taking Input
            Console.Write("Enter a sentence : ");
            string sentence = Console.ReadLine();

            // Initializing a array to store words in a sentence to find largest word.
            string[] words = sentence.Split(' ');
            string longest = "";

            foreach (string w in words)
            {
                if (w.Length > longest.Length)
                {
                    longest = w;
                }
            }

            // Display Output
            Console.WriteLine($"Longest word in the sentence is : {longest}");
        }
    }
}
