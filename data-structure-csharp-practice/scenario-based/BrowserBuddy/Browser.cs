using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BrowserBuddy
{
    internal class Browser
    {
        private Tab currentTab;
        private Stack<Tab> closedTabs;

        public Browser()
        {
            closedTabs = new Stack<Tab>();
            currentTab = new Tab("home.com");
        }

        public void Visit(string url)
        {
            currentTab.Visit(url);
        }

        public void Back()
        {
            currentTab.Back();
        }

        public void Forward()
        {
            currentTab.Forward();
        }

        public void CloseTab()
        {
            closedTabs.Push(currentTab);
            Console.WriteLine("Tab closed.");

            currentTab = new Tab("home.com");
        }

        public void RestoreTab()
        {
            if (closedTabs.Count > 0)
            {
                currentTab = closedTabs.Pop();
                Console.WriteLine($"Restored tab at: {currentTab.GetCurrentPage()}");
            }
            else
            {
                Console.WriteLine("No closed tabs to restore.");
            }
        }
    }
}
