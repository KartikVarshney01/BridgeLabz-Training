using BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf
{
    internal class LibraryUtility
    {
        // Creating the Dictionary To Store the books with their genre : Genre - Books
        Dictionary<string, BookUtilityImpl> Library;

        // Constructor To initialize a new Dictionary
        public LibraryUtility()
        {
            Library = new Dictionary<string, BookUtilityImpl>();
        }

        // Add Method To Add New Genre and Books 
        public void AddBook()
        {
            Console.Write("Enter The Name Of The genre : ");
            string genre = Console.ReadLine().ToLower();

            if (!Library.ContainsKey(genre))
            {
                Library[genre.ToLower()] = new BookUtilityImpl();
            }
            Library[genre].AddBook();
        }

        // CheckOut Method To Check A book out of the library
        public void CheckOut()
        {
            if(Library.Count == 0)
            {
                Console.WriteLine("Library Is Empty.");
                return;
            }
            Console.Write("Enter The Name Of The genre : ");
            string genre = Console.ReadLine().ToLower();

            if (!Library.ContainsKey(genre))
            {
                Console.WriteLine("This Genre Does Not Contains Any Book");
                return;
            }

            Library[genre].BookCheckOut();
        }

        // Return Book Method to return a book to the library
        public void ReturnBook()
        {
            if (Library.Count == 0)
            {
                Console.WriteLine("Library Is Empty.");
                return;
            }
            Console.Write("Enter The Name Of The genre : ");
            string genre = Console.ReadLine().ToLower();

            if (!Library.ContainsKey(genre))
            {
                Console.WriteLine("This Genre Does Not Contains Any Book");
                return;
            }

            Library[genre].BookReturned();
        }
    }
}