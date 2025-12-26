using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class SubstringFind
    {
        static void Main(string[] args)
        {
            // Taking Input for string, start index and end index
            Console.WriteLine("Enter the String, Start Index and the End Index : ");
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();
            Console.Write("Enter the starting index : ");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the ending index : ");
            int endIndex = Convert.ToInt32(Console.ReadLine());

            // calling function to find substring using charAt
            string substring = SubstringFun(s, startIndex, endIndex);

            // calling built-in function to find substring
            string substringBuilt = s.Substring(startIndex, endIndex - startIndex + 1);

            // Display Output
            Console.WriteLine("The results of finding substring using charAt and built-in method are : ");
            Console.WriteLine($"The substring using charAt : {substring}");
            Console.WriteLine($"The substring using built-in method : {substringBuilt}");
            Console.WriteLine($"The comparison between two is : {string.Equals(substring, substringBuilt)}");
        }

        static string SubstringFun(string s, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > s.Length || startIndex > endIndex) return "Invalid Indexes.";

            StringBuilder sub = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                sub.Append(s[i]);
            }
            return sub.ToString();
        }
    }
}
