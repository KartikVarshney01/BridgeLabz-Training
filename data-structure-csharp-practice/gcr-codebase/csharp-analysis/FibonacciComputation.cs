using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_analysis
{
    internal class FibonacciComputation
    {
        public static void Main(string[] args)
        {
            int n = 40;
            Stopwatch watch = new Stopwatch();

            watch.Start();
            RecursiveFibo(n);
            watch.Stop();

            Console.WriteLine($"Recursive Approach Time : {watch.ElapsedMilliseconds} ms");

            watch.Restart();
            IterativeFibo(n);
            watch.Stop();

            Console.WriteLine($"Iterative Approach Time : {watch.ElapsedMilliseconds} ms");
        }

        public static int RecursiveFibo(int n)
        {
            if (n <= 1) return n;
            return RecursiveFibo(n - 1) + RecursiveFibo(n - 2);

        }

        public static int IterativeFibo(int n)
        {
            int a = 0, b = 1;
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
