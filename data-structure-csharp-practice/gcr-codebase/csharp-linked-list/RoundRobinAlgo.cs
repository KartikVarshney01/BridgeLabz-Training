using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class RoundRobinAlgo
    {
        static void Main(String[] args)
        {
            int quantum = 4;
            RoundRobinScheduler scheduler = new RoundRobinScheduler(quantum);

            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);

            Console.WriteLine("Initial Circular Queue:");
            scheduler.ExecuteScheduling();
        }
    }
    // Process class (node)
    class Process
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;
        public Process Next;

        public Process(int id, int burstTime, int priority)
        {
            ProcessId = id;
            BurstTime = burstTime;
            RemainingTime = burstTime;
            Priority = priority;
            Next = null;
        }
    }

    // Circular Linked List for Round Robin
    class RoundRobinScheduler
    {
        private Process head;
        private int timeQuantum;

        public RoundRobinScheduler(int quantum)
        {
            head = null;
            timeQuantum = quantum;
        }

        // Add process at end
        public void AddProcess(int id, int burstTime, int priority)
        {
            Process newProcess = new Process(id, burstTime, priority);

            if (head == null)
            {
                head = newProcess;
                newProcess.Next = head;
                return;
            }

            Process temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newProcess;
            newProcess.Next = head;
        }

        // Remove process by ID
        private void RemoveProcess(int id)
        {
            if (head == null)
                return;

            Process temp = head;
            Process prev = null;

            // Find the process
            do
            {
                if (temp.ProcessId == id)
                {
                    if (prev != null)
                        prev.Next = temp.Next;
                    else // removing head
                    {
                        Process last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = temp.Next;
                        last.Next = head;

                        if (head == temp) // Only one process
                            head = null;
                    }
                    return;
                }
                prev = temp;
                temp = temp.Next;
            } while (temp != head);
        }

        // Display processes in circular queue
        private void DisplayQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Process temp = head;
            do
            {
                Console.Write($"P{temp.ProcessId}({temp.RemainingTime}) -> ");
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine("HEAD");
        }

        // Simulate Round Robin
        public void ExecuteScheduling()
        {
            if (head == null)
            {
                Console.WriteLine("No processes to schedule.");
                return;
            }

            int totalTime = 0;
            int n = CountProcesses();
            int[] waitingTime = new int[n];
            int[] turnaroundTime = new int[n];
            int index = 0;

            // Map process IDs to indices for time calculation
            Process temp = head;
            int[] processIds = new int[n];
            do
            {
                processIds[index++] = temp.ProcessId;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("\n--- Round Robin Execution Start ---");

            while (head != null)
            {
                Process current = head;
                do
                {
                    if (current.RemainingTime > 0)
                    {
                        int timeSpent = Math.Min(timeQuantum, current.RemainingTime);
                        current.RemainingTime -= timeSpent;
                        totalTime += timeSpent;

                        Console.WriteLine($"Process P{current.ProcessId} executes for {timeSpent} units (Remaining: {current.RemainingTime})");

                        DisplayQueue();

                        if (current.RemainingTime == 0)
                        {
                            int idx = Array.IndexOf(processIds, current.ProcessId);
                            turnaroundTime[idx] = totalTime;
                            waitingTime[idx] = turnaroundTime[idx] - current.BurstTime;

                            // Remove process after completion
                            int completedId = current.ProcessId;
                            current = current.Next;
                            RemoveProcess(completedId);
                            if (head == null) break; // all done
                            continue; // skip increment
                        }
                    }
                    current = current.Next;
                } while (current != head && head != null);
            }

            // Display Average Times
            double avgWT = 0, avgTAT = 0;
            for (int i = 0; i < n; i++)
            {
                avgWT += waitingTime[i];
                avgTAT += turnaroundTime[i];
            }

            Console.WriteLine("\n--- Scheduling Completed ---");
            Console.WriteLine($"Average Waiting Time: {avgWT / n:F2}");
            Console.WriteLine($"Average Turnaround Time: {avgTAT / n:F2}");
        }

        // Count total processes
        private int CountProcesses()
        {
            if (head == null) return 0;
            int count = 0;
            Process temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);
            return count;
        }
    }
}
