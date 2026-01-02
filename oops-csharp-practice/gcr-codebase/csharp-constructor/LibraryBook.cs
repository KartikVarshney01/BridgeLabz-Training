using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class LibraryBook
    {
        string title;
        string author;
        int price;
        string availability;

        // Default Constructor
        public LibraryBook()
        {
            title = "PlaceHolder";
            author = "Jon Doe";
            price = 100;
            availability = "available";
        }

        // Parameterized Constructor
        public LibraryBook(string title, string author, int price, string availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }

        void BorrowBook()
        {
            if (this.availability == "Not Available")
            {
                Console.WriteLine("Book Not Available");
                return;
            }
            Console.WriteLine("Enjoy Your Book");
            this.availability = "Not Available";
        }

        static void Main(String[] args)
        {
            LibraryBook l1 = new LibraryBook("Song Of War", "K.M Rajesh", 500, "Available");
            Console.WriteLine("Book Available");
            l1.BorrowBook();

            Console.WriteLine();

            Console.WriteLine("Book Not Available Check");
            l1.BorrowBook();
        }
    }
}
