using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    /// <summary>
    /// The Program of Implementing Queue Using Stack is done to show or see if we can implement a queue using stacks.
    /// we are using two stacks for enqueue and dequeue operations
    /// 
    /// </summary>
    internal class QueueUsingStack
    {
        static void Main(String[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine($"Size : {q.Size()}");
            Console.WriteLine($"Front : {q.Front()}");

            q.Dequeue();

            Console.WriteLine($"Size : {q.Size()}");
            Console.WriteLine($"Front : {q.Front()}");

        }
    }
    // Queue Class
    class Queue
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        public void Enqueue(int num)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(num);
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public void Dequeue()
        {
            if (s1.Count == 0)
            {
                return;
            }
            s1.Pop();
        }

        public int Front()
        {
            if (s1.Count == 0)
            {
                return -1;
            }
            return s1.Peek();
        }

        public int Size()
        {
            return s1.Count;
        }
    }
}
