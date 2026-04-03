using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.BookBuddy
{
    internal class ComparePerformance
    {
        static void Main(string[] args)
        {
            int iterations = 100000;

            Stopwatch swString = Stopwatch.StartNew();
            string result = "";

            for (int i = 0; i < iterations; i++)
            {
                result += "A";
            }

            swString.Stop();
            Console.WriteLine($"String Time: {swString.ElapsedMilliseconds} ms");

            Stopwatch swBuilder = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("A");
            }

            swBuilder.Stop();
            Console.WriteLine($"StringBuilder Time: {swBuilder.ElapsedMilliseconds} ms");
        }
    }
}
