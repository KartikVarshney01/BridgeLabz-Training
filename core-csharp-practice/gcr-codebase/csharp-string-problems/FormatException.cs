using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class FormatException
    {
        static void Main(String[] args)
        {
            try
            {
                string s = "hi";
                int a = int.Parse(s);
            }
            catch
            {
                Console.WriteLine("FormatException.");
            }
        }
    }
}
