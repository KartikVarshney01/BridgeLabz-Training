using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class FindWordInSentence
    {
        static void Main(string[] args)
        {
            String[] words =
            {
                "Hello My Name is John",
                "Hi There Everyone",
                "Today is a beautiful day",
                "Yes It is",
                "Good Morning"
            };

            string targetWord = "Morning";

            int index = LinearSearch(words, targetWord);

            if (index == -1)
            {
                Console.WriteLine("The Target Word is not in the sentences ");
            }
            else
            {
                Console.WriteLine($"The Target Word {targetWord} is at index : {index}");
            }
        }
        static int LinearSearch(string[] words, string target)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(target, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
