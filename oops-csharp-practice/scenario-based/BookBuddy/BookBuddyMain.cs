using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.BookBuddy
{
    /// <summary>
    /// The Book Buddy is a program that is written using oops concept. Its job is to store a record of books in a array and helps us
    /// in adding a new book, sorting them alphabetically, and searching by author. It also displays all the books in the database.
    /// 
    /// version - 1.0
    /// </summary>
    internal class BookBuddyMain
    {
        // Starting Point of the Program
        static void Main(string[] args)
        {
            BookBuddyMenu start = new BookBuddyMenu();
            start.Menu();
        }
    }
}
