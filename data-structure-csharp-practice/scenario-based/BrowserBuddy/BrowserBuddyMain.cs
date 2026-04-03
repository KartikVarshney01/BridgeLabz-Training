using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BrowserBuddy
{
    /// <summary>
    /// Browser Buddy Program Helps us is learning how double linked list and stack works in project works and how a we can use them to make a 
    /// browser work. We use linked list to connect different tabs and then we use stack to store closed tabs or easily reopening them.
    /// 
    /// version - 1.0
    /// </summary>
    internal class BrowserBuddyMain
    {
        // Main Class Containing the start point of the program
        static void Main(String[] args)
        {
            BrowserBuddyMenu start = new BrowserBuddyMenu();
            start.Menu();
        }
    }
}
