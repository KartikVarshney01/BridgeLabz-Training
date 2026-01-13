using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class StringBuilderReverse
    {
        static void Main(string[] args)
        {
            StringBuilderReverse start = new StringBuilderReverse();

            string original = "Hello";
            Console.WriteLine($"Original String : {original}");

            Console.WriteLine($"Reversed String : {start.ReverseString(original)}");
        }

        string ReverseString(string s)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }
            return reversed.ToString();
        }
    }
}
