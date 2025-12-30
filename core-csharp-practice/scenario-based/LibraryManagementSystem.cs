using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    /* Creating a Library management system which have a number of books with their details of like title, author and status and 
     * we can  search for books , display them and check for their availability.
     * We use csharp with basics like array, methods, access modifiers, etc
     * 
     * version - 1.0
     */
    internal class LibraryManagementSystem
    {
        // Creating a Book Details array to store details regarding a book with indexing as 0-title, 1-author, 2-status
        string[,] bookDetails;
        // Initializing an Book Index variable to store book count and their index.
        int bookIdx = 0;

        void LibraryManagementStart()
        {
            BookDetailsCreate();
            // Using a infinite while loop to make sure the menu option is there after every option for user help. untill he is done. 
            while (true)
            {
                // Writing User Menu
                Console.WriteLine("\n=================================");
                Console.WriteLine("LIBRARY MANAGEMENT SYSTEM");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Update Book Status");
                Console.WriteLine("3. Search Book");
                Console.WriteLine("4. Display Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        UpdateBook();
                        break;
                    case 3:
                        SearchBook();
                        break;
                    case 4:
                        int idx = SearchBook();
                        DisplayBook(idx);
                        break;
                    case 5:
                        Console.WriteLine("\n The Program has ended. Thank You");
                        return;
                    default:
                        Console.WriteLine("Enter a valid choice (1-5)");
                        break;
                }
            }

        }
        // Taking Input of the array size for initializing the books details array
        void BookDetailsCreate()
        {
            Console.Write("Enter the amount of book you need in the library : ");
            int size = Convert.ToInt32(Console.ReadLine());
            bookDetails = new string[size, 3];
        }
        // Helps in adding a new book details in the system
        void AddBook()
        {
            // checking if book details array is already full or not.
            if (bookIdx >= bookDetails.GetLength(0))
            {
                Console.WriteLine("Library is full. Cannot add more books.");
                return;
            }
            // Taking User Details for new Book
            Console.WriteLine("Enter the book details in the order of title and author");
            for (int i = 0; i < bookDetails.GetLength(1) - 1; i++)
            {
                bookDetails[bookIdx, i] = Console.ReadLine();
            }
            bookDetails[bookIdx, bookDetails.GetLength(1) - 1] = "Available";
            bookIdx++;

            Console.WriteLine("Book Added Successfully.");
        }
        // Used for updating a book
        void UpdateBook()
        {
            // Checking if their is any book in the array for it to search or not.
            if (bookIdx <= 0)
            {
                Console.WriteLine("Library is Empty. Please Add More Books.");
                return;
            }
            // Take User Input for the book he wants to update
            int Index = SearchBook();
            if (Index == -1) return;

            // Taking a bool updateDone variable to check if the update work is done or not
            bool updateDone = false;
            while (!updateDone)
            {
                // Taking User Input for the choice of status update he want to make
                Console.WriteLine("Enter the choices of status : ");
                Console.WriteLine("1. Available");
                Console.WriteLine("2. Checked-Out");
                Console.WriteLine("Enter the status ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bookDetails[Index, 2] = "Available";
                        updateDone = true;
                        break;
                    case 2:
                        bookDetails[Index, 2] = "Checked-Out";
                        updateDone = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Choose among 1 and 2.");
                        break;
                }
            }
            DisplayBook(Index);

        }
        // Function to Search for a book based on its title
        int SearchBook()
        {
            // Checking if the array contains any number of books.
            if (bookIdx <= 0)
            {
                Console.WriteLine("Library is Empty. Please Add More Books.");
                return -1;
            }
            // Take user input for book to search
            Console.Write("Enter the book name you want to search : ");
            string bookTitle = Console.ReadLine();
            for (int i = 0; i < bookIdx; i++)
            {
                // Using contains and tolower to check for title and ignore case.
                if (bookDetails[i, 0].ToLower().Contains(bookTitle.ToLower()))
                {
                    DisplayBook(i);
                    return i;
                }
            }
            Console.WriteLine("Book Not Found.");
            return -1;
        }
        // Function to help with display a book details.
        void DisplayBook(int bookID)
        {
            if (bookIdx <= 0)
            {
                Console.WriteLine("Library is Empty. Please Add More Books.");
                return;
            }

            if (bookID > bookIdx || bookID < 0)
            {
                Console.WriteLine("Invalid! Book Index");
                return;
            }
            // Display Book Details
            Console.WriteLine("\n BOOK DETAILS ");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Title  : {bookDetails[bookID, 0]}");
            Console.WriteLine($"Author : {bookDetails[bookID, 1]}");
            Console.WriteLine($"Status : {bookDetails[bookID, 2]}");
            Console.WriteLine("---------------------------");
        }
        static void Main(String[] args)
        {
            LibraryManagementSystem Start = new LibraryManagementSystem();
            Start.LibraryManagementStart();
        }
    }
}
