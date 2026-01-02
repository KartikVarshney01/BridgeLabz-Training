using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class BookClass
    {
        class Book
        {
            string title;
            string author;
            int price;

            // Default Constructor
            public Book() { }

            // Parameterized Constructor
            public Book(string title, string author, int price)
            {
                this.title = title;
                this.author = author;
                this.price = price;
            }

            // Display Method
            public void Display()
            {
                Console.WriteLine("Book Details");
                Console.WriteLine($"Title : {title}");
                Console.WriteLine($"Author : {author}");
                Console.WriteLine($"Price : {price}");
            }
        }
        static void Main(String[] args)
        {
            // Using default constructor
            Book book1 = new Book();
            book1.Display();

            Console.WriteLine();

            // Using parameterized constructor
            Book book2 = new Book("Hello World", "Kartik", 599);
            book2.Display();
        }
    }
}
