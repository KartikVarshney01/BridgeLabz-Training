using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class QueueReverse
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.Write("Original Queue: ");
            PrintQueue(queue);

            Reverse(queue);

            Console.Write("Reversed Queue: ");
            PrintQueue(queue);
        }

        static void Reverse(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

            int front = queue.Dequeue();

            Reverse(queue);

            queue.Enqueue(front);
        }

        static void PrintQueue(Queue<int> queue)
        {
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
