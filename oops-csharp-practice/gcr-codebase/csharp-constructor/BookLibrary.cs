using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class BookLibrary
    {
        // Public member
        public string ISBN;

        // Protected member
        protected string title;

        // Private member
        private string author;

        // Constructor
        public BookLibrary(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        // Setter for author
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        // Getter for author
        public string GetAuthor()
        {
            return author;
        }

        // Method accessing protected member
        public void DisplayBookDetails()
        {
            Console.WriteLine("ISBN   : " + ISBN);
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Author : " + author);
        }

        static void Main()
        {
            BookLibrary b = new BookLibrary("ISBN101", "C Sharp Programming", "Jon Doe");
            b.DisplayBookDetails();
        }
    }
}
