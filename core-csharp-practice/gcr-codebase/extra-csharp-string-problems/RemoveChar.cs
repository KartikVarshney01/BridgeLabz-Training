using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class RemoveChar
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();

            Console.Write("Enter the character : ");
            char removech = Convert.ToChar(Console.ReadLine());

            StringBuilder ans = new StringBuilder();

            foreach (char ch in s)
            {
                if (ch != removech) ans.Append(ch);
            }

            // Display Output
            Console.WriteLine($"Modified String : \"{ans}\"");
        }
    }
}
