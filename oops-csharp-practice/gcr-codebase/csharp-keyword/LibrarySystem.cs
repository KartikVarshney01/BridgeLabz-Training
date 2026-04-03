using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class LibrarySystem
    {
        // static variable shared across all
        static string LibraryName = "Disney Library";

        // readonly variable
        readonly string ISBN;

        // instance variables
        public string Title;
        public string Author;

        // constructor 
        public LibrarySystem(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        // static method
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name : " + LibraryName);
        }

        // display book Function to display using is 
        public static void DisplayBook(object obj)
        {
            if (obj is LibrarySystem book)
            {
                Console.WriteLine("Title  : " + book.Title);
                Console.WriteLine("Author : " + book.Author);
                Console.WriteLine("ISBN   : " + book.ISBN);
            }
            else
            {
                Console.WriteLine("Invalid Book Object");
            }
        }

        static void Main(String[] args)
        {
            LibrarySystem.DisplayLibraryName();
            Console.WriteLine();

            LibrarySystem book1 = new LibrarySystem("Coding", "R. K Pandey", "ISBN-1052");
            LibrarySystem book2 = new LibrarySystem("CSharp", "Rohit Raj", "ISBN-1059");

            LibrarySystem.DisplayBook(book1);
            Console.WriteLine();

            LibrarySystem.DisplayBook(book2);
        }
    }
}
