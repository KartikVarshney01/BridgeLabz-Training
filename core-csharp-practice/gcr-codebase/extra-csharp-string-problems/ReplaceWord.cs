using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class ReplaceWord
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter a sentence : ");
            string sentence = Console.ReadLine();

            Console.Write("Enter word to replace : ");
            string oldword = Console.ReadLine();

            Console.Write("Enter new word : ");
            string newword = Console.ReadLine();

            // Calling function to replace old word with new word.
            string result = ReplaceFun(sentence, oldword, newword);

            // Display Result
            Console.WriteLine("Modified sentence: " + result);
        }

        static string ReplaceFun(string sentence, string oldword, string newword)
        {
            string[] words = sentence.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word == oldword)
                    result.Append(newword);
                else
                    result.Append(word);

                result.Append(" ");
            }

            return result.ToString().Trim();
        }
    }
}
