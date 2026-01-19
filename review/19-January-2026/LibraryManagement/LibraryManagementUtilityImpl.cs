using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BridgeLabzTraining.Review.LibraryManagement
{
    internal class LibraryManagementUtilityImpl
    {
        private Book[] books;
        private int currentCapacity;
        
        public LibraryManagementUtilityImpl()
        {
            Console.Write("Enter The Library Capacity : ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            books = new Book[capacity];
            currentCapacity = 0;
        }

        public void AddBook()
        {
            if (currentCapacity >= books.Length)
            {
                Console.WriteLine("Library is Full");
                return;
            }
            if(currentCapacity >= books.Length)
            {
                Console.WriteLine("Library is Full");
                return;
            }
            Book newBook = new Book();
            Console.Write("Enter Book Title : ");
            newBook.BookTitle = Console.ReadLine();
            Console.Write("Enter Book Author : ");
            newBook.BookAuthor = Console.ReadLine();

            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = newBook;
                    currentCapacity++;
                    break;
                }
            }
            Console.WriteLine("Book Added Successfully");
        }

        public void EditBook()
        {
            if (currentCapacity <= 0)
            {
                Console.WriteLine("Library Hold No Book");
                return;
            }
            Console.Write("Enter Book Name You Want To Edit : ");
            string editName = Console.ReadLine();

            bool found = false;

            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].BookTitle.Equals(editName,StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter New Title : ");
                    string newTitle = Console.ReadLine();
                    Console.WriteLine("Enter New Author : ");
                    string newAuthor = Console.ReadLine();

                    books[i].BookTitle = newTitle;
                    books[i].BookAuthor = newAuthor;

                    found = true;
                    if (found) return;
                }
            }
        }

        public void RemoveBook()
        {
            if(currentCapacity == 0)
            {
                Console.WriteLine("Library is Empty");
                return;
            }

            Console.Write("Enter Book Title You Want To Remove : ");
            string removeTitle = Console.ReadLine();

            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    if(books[i].BookTitle.Equals(removeTitle, StringComparison.OrdinalIgnoreCase))
                    {
                        books[i] = null;
                        currentCapacity--;
                        Console.WriteLine("Book Removed Successfully");
                        return;
                    }
                }
            }
        }
        //public void SearchBook()
        //{
        //    if (currentCapacity == 0)
        //    {
        //        Console.WriteLine("Library is Empty");
        //        return;
        //    }
        //    Console.Write("Enter Book Title Your Want To Search : ");
        //    string searchTitle = Console.ReadLine();
        //    for (int i = 0; i < books.Length; i++)
        //    {
        //        if (books[i] != null && books[i].BookTitle.Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
        //        {
        //            Console.WriteLine(books[i]);
        //            return;
        //        }
        //    }
        //}

        public void SearchBook()
        {
            if (currentCapacity == 0)
            {
                Console.WriteLine("Library is Emtpy");
                return;
            }
            Console.Write("Enter Book Title Your Want To Search : ");
            string searchTitle = Console.ReadLine();
            SortBooks();
            BinarySearch(searchTitle);
        }

        private void BinarySearch(string title)
        {
            int left = 0;
            int right = books.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (books[mid].BookTitle.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[mid]);
                    return;
                }
                else if (CompareBook(books[mid].BookTitle, title))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }

        public void SortBooks()
        {
            if(currentCapacity == 0)
            {
                Console.WriteLine("Library is Empty");
                return;
            }

            for(int i = 0; i < currentCapacity; i++)
            {
                bool isSort = false;
                for(int j = 0; j < currentCapacity-1; j++)
                {
                    if (books[j] != null)
                    {
                        if (CompareBook(books[j].BookTitle, books[j + 1].BookAuthor)){
                            Book temp = books[j];
                            books[j] = books[j + 1];
                            books[j + 1] = temp;
                            isSort = true;
                        }
                        if (!isSort) return;
                    }
                }
            }
            //DisplayBooks();
        }

        public void DisplayBooks()
        {
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine(books[i]);
                }
            }
        }
        private bool CompareBook(string a, string b)
        {
            int length = Math.Min(a.Length, b.Length);
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
    }
}
