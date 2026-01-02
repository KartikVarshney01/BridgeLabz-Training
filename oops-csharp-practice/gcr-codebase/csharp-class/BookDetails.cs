using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.class_and_objects
{
    internal class BookDetails
    {
        class Book
        {
            string title;
            string author;
            int price;

            public void DetailsSet(string title, string author, int price)
            {
                this.title = title;
                this.author = author;
                this.price = price;
            }
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
            Book book = new Book();
            book.DetailsSet("Book1", "Write1", 100);
            book.Display();
        }
    }
}
