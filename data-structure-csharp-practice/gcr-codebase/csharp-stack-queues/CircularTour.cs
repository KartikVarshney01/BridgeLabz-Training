using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class CircularTour
    {
        static void Main(String[] args)
        {
            int[] petrol = { 6, 3, 7 };
            int[] distance = { 4, 6, 3 };

            int start = FindStartingPump(petrol, distance);

            Console.WriteLine(
                start == -1 ? "No possible tour" : $"Start at pump index : {start}"
            );
        }
        static int FindStartingPump(int[] petrol, int[] distance)
        {
            int n = petrol.Length;

            for (int start = 0; start < n; start++)
            {
                Queue<int> queue = new Queue<int>();
                int currentPetrol = 0;
                int visited = 0;

                queue.Enqueue(start);

                while (queue.Count > 0)
                {
                    int i = queue.Dequeue();
                    currentPetrol += petrol[i] - distance[i];
                    visited++;

                    if (currentPetrol < 0)
                        break;

                    if (visited == n)
                        return start;

                    queue.Enqueue((i + 1) % n);
                }
            }
            return -1;
        }
    }
}
