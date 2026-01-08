using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class LibraryManagementSystem
    {
        static void Main()
        {
            Library library = new Library();

            library.AddAtBeginning("Coding", "John", "Fiction", 101, true);
            library.AddAtEnd("CSharp", "Karan", "Productivity", 102, true);
            library.AddAtPosition(2, "Web", "Arjun", "Fiction", 103, false);

            Console.WriteLine("All Books (Forward):");
            library.DisplayForward();

            Console.WriteLine("All Books (Reverse):");
            library.DisplayReverse();

            Console.WriteLine("Search by Title CSharp:");
            library.SearchByTitle("CSharp");

            Console.WriteLine("Search by Author Arjun:");
            library.SearchByAuthor("Arjun");

            Console.WriteLine("Update Availability for Book ID 103:");
            library.UpdateAvailability(103, true);

            Console.WriteLine("Final Library (Forward):");
            library.DisplayForward();

            library.CountBooks();

            Console.WriteLine("Remove Book ID 101:");
            library.RemoveByBookId(101);
            library.DisplayForward();
            library.CountBooks();
        }
    }
    // Book class (node)
    class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookId;
        public bool IsAvailable;
        public Book Prev;
        public Book Next;

        public Book(string title, string author, string genre, int bookId, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookId = bookId;
            IsAvailable = isAvailable;
            Prev = null;
            Next = null;
        }
    }

    // Doubly Linked List for library
    class Library
    {
        private Book head;
        private Book tail;

        // Add at beginning
        public void AddAtBeginning(string title, string author, string genre, int bookId, bool isAvailable)
        {
            Book newBook = new Book(title, author, genre, bookId, isAvailable);

            if (head == null)
            {
                head = tail = newBook;
            }
            else
            {
                newBook.Next = head;
                head.Prev = newBook;
                head = newBook;
            }
        }

        // Add at end
        public void AddAtEnd(string title, string author, string genre, int bookId, bool isAvailable)
        {
            Book newBook = new Book(title, author, genre, bookId, isAvailable);

            if (tail == null)
            {
                head = tail = newBook;
            }
            else
            {
                tail.Next = newBook;
                newBook.Prev = tail;
                tail = newBook;
            }
        }

        // Add at specific position (1-based)
        public void AddAtPosition(int position, string title, string author, string genre, int bookId, bool isAvailable)
        {
            if (position <= 1)
            {
                AddAtBeginning(title, author, genre, bookId, isAvailable);
                return;
            }

            Book temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            Book newBook = new Book(title, author, genre, bookId, isAvailable);
            newBook.Next = temp.Next;
            newBook.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = newBook;
            else
                tail = newBook;

            temp.Next = newBook;
        }

        // Remove by Book ID
        public void RemoveByBookId(int bookId)
        {
            Book temp = head;

            while (temp != null)
            {
                if (temp.BookId == bookId)
                {
                    if (temp == head)
                        head = temp.Next;
                    if (temp == tail)
                        tail = temp.Prev;

                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;

                    Console.WriteLine("Book removed successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Book not found.");
        }

        // Search by Title
        public void SearchByTitle(string title)
        {
            Book temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Book not found.");
        }

        // Search by Author
        public void SearchByAuthor(string author)
        {
            Book temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No books found for this author.");
        }

        // Update availability
        public void UpdateAvailability(int bookId, bool newStatus)
        {
            Book temp = head;

            while (temp != null)
            {
                if (temp.BookId == bookId)
                {
                    temp.IsAvailable = newStatus;
                    Console.WriteLine("Availability updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Book not found.");
        }

        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            Book temp = head;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.Next;
            }
        }

        // Display reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            Book temp = tail;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.Prev;
            }
        }

        // Count total books
        public void CountBooks()
        {
            int count = 0;
            Book temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            Console.WriteLine($"Total Books in Library: {count}");
        }

        // Display method
        private void DisplayBook(Book book)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
    }
}
