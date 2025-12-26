using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class IndexOutOfRangeArray
    {
        static void Main(String[] args)
        {
            try
            {
                int[] temp = { 1, 2, 3, 4 };
                Console.Write(temp[4]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRange Exception for Array.");
            }
        }
    }
}
