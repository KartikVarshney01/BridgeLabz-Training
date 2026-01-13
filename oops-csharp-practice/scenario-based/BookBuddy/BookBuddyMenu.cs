using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.BookBuddy
{
    // Containg Menu of our program that shows user menu and call other functions
    internal class BookBuddyMenu
    {
        IBook utility;

        public void Menu()
        {
            utility = new BookBuddyUtilityImpl();

            // Infinite While Loop
            while (true)
            {
                Console.WriteLine("\n====Book Buddy====");
                Console.WriteLine("1. Add A New Book");
                Console.WriteLine("2. Search A Book By Author");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Display All Books");
                Console.WriteLine("5. Exit The Book Buddy");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddBook();
                        break;
                    case 2:
                        utility.SearchBookByAuthor();
                        break;
                    case 3:
                        utility.SortBooksAlphabetically();
                        break;
                    case 4:
                        utility.DisplayAllBooks();
                        break;
                    case 5:
                        Console.WriteLine("Exiting The Book Buddy");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
