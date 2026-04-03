using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.BookBuddy
{
    // Utility Class Containg Implementation of all the functions of the interface
    internal class BookBuddyUtilityImpl : IBook
    {
        // Creating a book array to store books
        Book[] booksList;
        // Initializing a Index variable to help in iterating through the book array
        int Idx = 0;

        // Add Book Function to help in Adding a new book and initializing the book list array
        public void AddBook()
        {
            // Checking if the books list array is initialized or not
            if(booksList == null)
            {
                Console.Write("Enter the number of books you can hold : ");
                int size = Convert.ToInt32(Console.ReadLine());

                booksList = new Book[size];
            }

            // Checking if there is any space in array for new book
            if(Idx >= booksList.Length)
            {
                Console.WriteLine("Books Capacity is currently full. Try Again");
                return;
            }

            // Creating new Book and taking user input for title and author
            Book newBook = new Book();
            Console.Write("Enter the Book Title And Author (title-author) : ");

            // Using split() method to split between title and author in user input 
            string[] bookDetails = Console.ReadLine().Split("-");
            newBook.bookTitle = bookDetails[0].Trim();
            newBook.bookAuthor = bookDetails[1].Trim();

            // Adding the new book inside the books array
            booksList[Idx++] = newBook;
            Console.WriteLine("New Book Added Successfully\n");
        }

        // Function that implement the Search Book in the book list by author.
        public void SearchBookByAuthor()
        {
            // Checking if there is any book in the system
            if(booksList == null)
            {
                Console.WriteLine("Book List is empty. Enter Book First");
                return;
            }

            // Taking user input for the author he wants to search
            Console.Write("Enter The Author you want to search : ");
            string searchAuthor = Console.ReadLine();
            bool isFound = false;


            for(int i = 0; i < Idx; i++)
            {
                if (booksList[i].bookAuthor.Contains(searchAuthor, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(booksList[i]);
                    isFound = true;
                }
            }
            if(!isFound) Console.WriteLine("There is No Book by that author in the database");
        }

        // Sorting Books By their title Alphabetically 
        public void SortBooksAlphabetically()
        {
            if(booksList == null)
            {
                Console.WriteLine("Databse is Empty. Enter a book Details first");
                return;
            }

            Console.WriteLine("Sorting Books Alphabetically .... ");

            //using bubble sort for sorting
            for(int i = 0;i < Idx; i++)
            {
                bool isSort = false;
                for(int j = 0;j < Idx-1; j++)
                {
                    // Calling CompareBook Function to find if the book need sorting 
                    if (CompareBook(booksList[j].bookTitle, booksList[j + 1].bookAuthor))
                    {
                        Book temp = booksList[j];
                        booksList[j] = booksList[j+1];
                        booksList[j + 1] = temp;
                        isSort = true; 
                    }
                    if (!isSort) break;
                }
            }
            Console.WriteLine("Sorting is Complete\n");
        }

        // Checking which of the two books is first alphabetically
        private bool CompareBook(string a,string b)
        {
            int length = Math.Min(a.Length,b.Length);
            int i = 0;
            while (i < length)
            {
                if (a[i] > b[i]) return true;
                if (b[i] > a[i]) return false;
                i++;
            }
            if (a.Length > b.Length) return true;
            else return false;
        }

        // Function to display all the books in the database
        public void DisplayAllBooks()
        {
            if (booksList == null)
            {
                Console.WriteLine("Book DataBase Is Empty!!!\n");
                return;
            }

            Console.WriteLine("Displayig All Books!!!!\n");
            for (int i = 0; i < Idx; i++)
            {
                Console.WriteLine(booksList[i]);
            }
        }
    }
}
