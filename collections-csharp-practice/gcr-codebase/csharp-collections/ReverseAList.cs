using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class ReverseAList
    {
        static void Main(string[] args)
        {
            // ---------- Reverse List<int> ----------
            List<int> arrayList = new List<int> { 1, 2, 3, 4, 5 };

            Console.Write("Original List: ");
            PrintList(arrayList);

            ReverseList(arrayList);

            Console.Write("Reversed List: ");
            PrintList(arrayList);
            Console.WriteLine();

            // ---------- Reverse LinkedList<int> ----------
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            Console.Write("Original LinkedList: ");
            PrintLinkedList(linkedList);

            LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);

            Console.Write("Reversed LinkedList: ");
            PrintLinkedList(reversedLinkedList);
        }

        // Reverse List<T> using two-pointer approach
        static void ReverseList(List<int> list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                int temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }

        // Reverse LinkedList<T> using AddFirst
        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversed = new LinkedList<int>();

            foreach (int item in list)
            {
                reversed.AddFirst(item);
            }

            return reversed;
        }

        // Print List<T> 
        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Print LinkedList<T>
        static void PrintLinkedList(LinkedList<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
