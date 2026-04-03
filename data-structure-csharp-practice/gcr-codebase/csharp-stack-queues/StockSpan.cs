using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class StockSpan
    {
        static void Main(String[] args)
        {
            int[] prices = { 165, 90, 60, 70, 65, 75, 85 };
            int[] span = CalculateSpan(prices);

            Console.WriteLine("Stock Prices:");
            foreach (int price in prices)
                Console.Write(price + " ");

            Console.WriteLine("\nStock Span:");
            foreach (int s in span)
                Console.Write(s + " ");
        }

        static int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

                stack.Push(i);
            }

            return span;
        }
    }
}
