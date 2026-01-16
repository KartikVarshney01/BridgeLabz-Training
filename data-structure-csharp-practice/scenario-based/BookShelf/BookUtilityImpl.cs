using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf
{
    internal class BookUtilityImpl : IBook
    {
        // Creating a reference for the Master and Last BookNode
        private BookNode MasterBookNode;

        private BookNode LastBook;

        // method to add books in the linked list
        public void AddBook()
        {
            BookNode newBook = new BookNode();

            Console.WriteLine("Enter The New Book Entries : ");
            Console.Write("Enter Book Title : ");
            newBook.BookTitle = Console.ReadLine();
            Console.Write("Enter Book Author : ");
            newBook.BookAuthor = Console.ReadLine();
            Console.Write("Enter Book Genre : ");
            newBook.BookGenre = Console.ReadLine();

            if (MasterBookNode == null)
            {
                MasterBookNode = newBook;
                LastBook = newBook;
            }
            else
            {
                LastBook.NextBook = newBook;
                LastBook = newBook;
            }

            Console.WriteLine(newBook);
            Console.WriteLine("New Book Data Added Successfully");
        }

        // Method to check a book out of the library
        public void BookCheckOut()
        {
            // Checking if there is any books in the library or not
            if(MasterBookNode == null)
            {
                Console.WriteLine("Library is Empty. Please Add New Books First");
                return;
            }
            Console.Write("Enter the Book You Want To CheckOut : ");
            string bookName = Console.ReadLine().Trim();

            BookNode temp = MasterBookNode;

            while(temp != null)
            {
                if (temp.BookTitle.Trim().Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    if(temp.BookStatus.Equals("Available", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Confirm Your Check-Out [1. Yes | 2. No ] : ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            temp.BookStatus = "Not Available";

                            Console.WriteLine(temp);
                            Console.WriteLine("Book Check-Out Successfully");
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Book Not Available.");
                        return;
                    }
                }
                temp = temp.NextBook;
            }
        }

        // Return Method to return a book
        public void BookReturned()
        {
            if (MasterBookNode == null)
            {
                Console.WriteLine("Library is Empty. Please Add New Books First");
                return;
            }
            Console.Write("Enter the Book You Want To Return : ");
            string bookName = Console.ReadLine().Trim();

            BookNode temp = MasterBookNode;

            while (temp != null)
            {
                if (temp.BookTitle.Trim().Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp.BookStatus.Equals("Available", StringComparison.OrdinalIgnoreCase))
                    {
                        temp.BookStatus = "Available";
                        Console.WriteLine(temp);
                        Console.WriteLine("Book Returned Successfully.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Book Already Available.");
                        return;
                    }
                }

                temp = temp.NextBook;
            }
            Console.WriteLine("No Book For Current Title Found.");
        }
    }
}
