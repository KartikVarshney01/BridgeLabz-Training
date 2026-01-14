using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_analysis
{
    internal class StringConcatenation
    {
        static void Main(string[] args)
        {
            int iterations = 100000;

            Stopwatch swString = Stopwatch.StartNew();
            string result = "";

            for (int i = 0; i < iterations; i++)
            {
                result += "Kartik";
            }

            swString.Stop();
            Console.WriteLine($"String Time: {swString.ElapsedMilliseconds} ms");

            Stopwatch swBuilder = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("Kartik");
            }

            swBuilder.Stop();
            Console.WriteLine($"StringBuilder Time: {swBuilder.ElapsedMilliseconds} ms");
        }
    }
}
