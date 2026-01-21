using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class HospitalTriage
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>();

            EnqueuePatient(triageQueue, "John", 3);
            EnqueuePatient(triageQueue, "Alice", 5);
            EnqueuePatient(triageQueue, "Bob", 2);

            Console.WriteLine("Treatment Order:");

            while (triageQueue.Count > 0)
            {
                string patient = triageQueue.Dequeue();
                Console.WriteLine(patient);
            }
        }

        static void EnqueuePatient(PriorityQueue<string, int> queue, string name, int severity)
        {
            queue.Enqueue(name, -severity);
        }
    }
}
