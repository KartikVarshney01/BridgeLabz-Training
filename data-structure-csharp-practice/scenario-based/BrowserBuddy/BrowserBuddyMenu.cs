using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BrowserBuddy
{
    internal class BrowserBuddyMenu
    {
        // Menu Class COntaining the menu of our program
        public void Menu()
        {
            Browser browser = new Browser();

            while (true)
            {
                Console.WriteLine("\n=== BrowserBuddy ===");
                Console.WriteLine("1. Visit Page");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Exit");
                Console.Write("Choose: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        string url = Console.ReadLine();
                        browser.Visit(url);
                        break;

                    case 2:
                        browser.Back();
                        break;

                    case 3:
                        browser.Forward();
                        break;

                    case 4:
                        browser.CloseTab();
                        break;

                    case 5:
                        browser.RestoreTab();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
