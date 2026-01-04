using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class LibrarySystem
    {
        static void Main(String[] args)
        {
            Author a1 = new Author(
                "Coding Logic",
                2004,
                "Ajay K. Pandey",
                "Software engineering expert and author"
            );

            a1.DisplayAuthorInfo();
        }
        class Book
        {
            public string Title;
            public int PublicationYear;

            public Book(string title, int publicationYear)
            {
                Title = title;
                PublicationYear = publicationYear;
            }

            public void DisplayInfo()
            {
                Console.WriteLine("Title            : " + Title);
                Console.WriteLine("Publication Year : " + PublicationYear);
            }
        }

        class Author : Book
        {
            public string Name;
            public string Bio;

            public Author(string title, int publicationYear, string name, string bio)
                : base(title, publicationYear)
            {
                Name = name;
                Bio = bio;
            }

            public void DisplayAuthorInfo()
            {
                DisplayInfo();
                Console.WriteLine("Author Name      : " + Name);
                Console.WriteLine("Author Bio       : " + Bio);
            }
        }
    }
}
