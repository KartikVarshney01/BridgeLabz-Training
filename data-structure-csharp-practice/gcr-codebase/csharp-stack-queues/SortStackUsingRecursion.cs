using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class SortStackUsingRecursion
    {
        static void Main(string[] args)
        {
            SortStackUsingRecursion st = new SortStackUsingRecursion();
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(10);

            Console.WriteLine("Original Stack");
            st.DisplayStack(stack);

            st.Sort(stack);

            Console.WriteLine("Sorted Stack in ascending");
            st.DisplayStack(stack);
        }

        void DisplayStack(Stack<int> stack)
        {
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        void Sort(Stack<int> stack)
        {
            if (stack.Count <= 1) return;

            int top = stack.Pop();

            Sort(stack);

            SortInsert(stack, top);
        }

        void SortInsert(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int top = stack.Pop();
            SortInsert(stack, value);
            stack.Push(top);

        }
    }
}
