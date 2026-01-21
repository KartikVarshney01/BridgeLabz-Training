using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class GenerateBinary
    {
        static void Main(string[] args)
        {
            int N = 5;

            List<string> result = GenerateFun(N);

            Console.Write("Binary Numbers: ");
            PrintList(result);
        }

        static List<string> GenerateFun(int n)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                result.Add(current);

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            return result;
        }

        static void PrintList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
