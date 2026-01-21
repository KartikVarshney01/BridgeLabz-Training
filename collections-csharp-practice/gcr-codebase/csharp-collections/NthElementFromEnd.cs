using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class NthElementFromEnd
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");

            int n = 2;

            Console.Write("LinkedList: ");
            PrintLinkedList(list);

            string result = FindNthFromEnd(list, n);

            Console.WriteLine("Nth element from end (N = " + n + "): " + result);
        }

        static string FindNthFromEnd(LinkedList<string> list, int n)
        {
            if (list.First == null || n <= 0)
            {
                return "Invalid Input";
            }

            LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;

            for (int i = 0; i < n; i++)
            {
                if (first == null)
                {
                    return "N is greater than list length";
                }
                first = first.Next;
            }

            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return second.Value;
        }

        static void PrintLinkedList(LinkedList<string> list)
        {
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
