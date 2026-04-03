using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BrowserBuddy
{
    internal class Tab
    {
        private PageNode head;
        private PageNode current;

        public Tab(string homepage)
        {
            head = new PageNode(homepage);
            current = head;
        }

        public void Visit(string url)
        {
            // Creating new PageNode
            PageNode newNode = new PageNode(url);

            // clear forward history
            current.Next = null;
            newNode.Prev = current;
            current.Next = newNode;
            current = newNode;

            Console.WriteLine($"Visited: {url}");
        }

        public void Back()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine($"Back to: {current.Url}");
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        public void Forward()
        {
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine($"Forward to: {current.Url}");
            }
            else
            {
                Console.WriteLine("No forward page.");
            }
        }

        public string GetCurrentPage()
        {
            return current.Url;
        }
    }
}
