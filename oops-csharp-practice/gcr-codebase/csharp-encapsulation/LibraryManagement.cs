using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    internal class LibraryManagement
    {
        static void Main()
        {
            LibraryItem[] items = new LibraryItem[3];

            items[0] = new Book(1, "Coding", "Robert");
            items[1] = new Magazine(2, "Infinity", "Timothy");
            items[2] = new DVD(3, "Dune", "Nolan");

            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();
                Console.WriteLine("Loan Duration (days): " + item.GetLoanDuration());

                if (item is IReservable reservableItem)
                {
                    reservableItem.ReserveItem("Kartik");
                    Console.WriteLine("Available After Reservation: " + reservableItem.CheckAvailability());
                }

                Console.WriteLine();
            }
        }
    }
    // Interface class IReservable
    interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }

    // Abstract Class Library Item
    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;
        private string borrowerName;
        private bool isAvailable = true;

        public int ItemId
        {
            get { return itemId; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        protected LibraryItem(int itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item ID: {itemId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Available: {isAvailable}");
        }

        protected void AssignBorrower(string name)
        {
            borrowerName = name;
            isAvailable = false;
        }

        protected void ReleaseItem()
        {
            borrowerName = null;
            isAvailable = true;
        }

        protected bool IsAvailable()
        {
            return isAvailable;
        }
    }

    // Derived Book Class
    class Book : LibraryItem, IReservable
    {
        public Book(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                AssignBorrower(borrowerName);
                Console.WriteLine($"Book reserved by : {borrowerName}");
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    // Derived Magazine Class
    class Magazine : LibraryItem, IReservable
    {
        public Magazine(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                AssignBorrower(borrowerName);
                Console.WriteLine($"Magazine reserved by : {borrowerName}");
            }
            else
            {
                Console.WriteLine("Magazine is not available");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    // Derived DVD Class
    class DVD : LibraryItem, IReservable
    {
        public DVD(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                AssignBorrower(borrowerName);
                Console.WriteLine($"DVD reserved by :  {borrowerName}");
            }
            else
            {
                Console.WriteLine("DVD is not available");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }
}
