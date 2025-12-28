using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class VowelsAndConsonants
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the string : ");
            string s = Console.ReadLine().ToLower();

            // Initializing variables of vowels and consonants to count their numbers
            int vowelcount = 0;
            int consonantcount = 0;

            foreach (char ch in s)
            {
                if (char.IsLetter(ch))
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') vowelcount++;
                    else consonantcount++;
                }
            }

            // Display Output
            Console.WriteLine($"The number of vowels is : {vowelcount}\n" +
                $"The number of consonants is : {consonantcount}");
        }
    }
}
