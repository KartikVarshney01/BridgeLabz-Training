using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class SubstringOccurence
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();

            Console.Write("Enter the substring you want to find : ");
            string pattern = Console.ReadLine();

            // Initializing the count variable
            int count = 0;

            for (int i = 0; i <= s.Length - pattern.Length;)
            {
                bool check = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (s[i + j] != pattern[j])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    count++;
                    i += pattern.Length;
                }
                else i++;
            }

            // Display Output
            Console.WriteLine($"The Occurence of substring you want to find is : {count}");
        }
    }
}
