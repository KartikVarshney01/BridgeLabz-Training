using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class ToggleCharactera
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();

            // Initializing the final result string.
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (ch >= 'A' && ch <= 'Z')
                    result.Append((char)(ch + 32));
                else if (ch >= 'a' && ch <= 'z')
                    result.Append((char)(ch - 32));
                else
                    result.Append(ch);
            }

            // Display Output
            Console.WriteLine($"The Toggled string is : {result}");
        }
    }
}
