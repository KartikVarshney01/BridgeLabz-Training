using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class RemoveDuplicates
    {
        static void Main(string[] args)
        {
            RemoveDuplicates duplicates = new RemoveDuplicates();
            string original = "HelloWorldAll";
            Console.WriteLine($"Original String : {original}");

            Console.WriteLine($"Duplicate Character Removed String : {duplicates.DuplicateRemoved(original)}");
        }

        string DuplicateRemoved(string s)
        {
            StringBuilder result = new StringBuilder();
            HashSet<Char> removed = new HashSet<Char>();
            foreach (char c in s)
            {
                if (!removed.Contains(c))
                {
                    result.Append(c);
                    removed.Add(c);
                }
            }
            return result.ToString();
        }
    }
}
