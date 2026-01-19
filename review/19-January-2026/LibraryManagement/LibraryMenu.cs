using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Review.LibraryManagement
{
    internal class LibraryMenu
    {
        private LibraryManagementUtilityImpl LibraryUtility;
        public void Menu()
        {
            LibraryUtility = new LibraryManagementUtilityImpl();

            while (true)
            {
                Console.WriteLine("Welcome To Library");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Edit Book");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. Sort Book");
                Console.WriteLine("6. Display Books");
                Console.WriteLine("7. Exit Library");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LibraryUtility.AddBook();
                        break;
                    case 2:
                        LibraryUtility.EditBook();
                        break;
                    case 3:
                        LibraryUtility.RemoveBook();
                        break;
                    case 4:
                        LibraryUtility.SearchBook();
                        break;
                    case 5:
                        LibraryUtility.SortBooks();
                        break;
                    case 6:
                        LibraryUtility.DisplayBooks();
                        break;
                    case 7:
                        Console.WriteLine("Exiting Library");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
