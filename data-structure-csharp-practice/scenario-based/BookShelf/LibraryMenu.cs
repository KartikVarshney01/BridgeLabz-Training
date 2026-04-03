using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf
{
    internal class LibraryMenu
    {
        // Private reference to the Library Utility.
        private LibraryUtility library;

        // Menu Class Containing the menu access by the user
        public void Menu()
        {
            library = new LibraryUtility();

            Console.WriteLine("Welcome To The Library");
            while (true)
            {
                Console.WriteLine("Library Menu");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Book CheckOut");
                Console.WriteLine("3. Book Return");
                Console.WriteLine("4. Exit The Program");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.CheckOut();
                        break;
                    case 3:
                        library.ReturnBook();
                        break;
                    case 4:
                        Console.WriteLine("Exiting The Library");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
