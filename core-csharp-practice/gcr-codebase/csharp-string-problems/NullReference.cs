using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class NullReference
    {
        static void Main(String[] args)
        {
            try
            {
                string s = null;
                int length = s.Length;
            }
            catch (Exception err)
            {
                Console.WriteLine("NullReferenceException.");
            }
        }
    }
}
