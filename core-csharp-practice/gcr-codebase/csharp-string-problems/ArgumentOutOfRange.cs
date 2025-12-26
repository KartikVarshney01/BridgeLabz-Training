using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class ArgumentOutOfRange
    {
        static void Main(String[] args)
        {
            try
            {
                string s = "hello";
                s.Substring(5, 4);

            }
            catch
            {
                Console.WriteLine("ArgumentOutOFRangeException.");
            }
        }
    }
}
