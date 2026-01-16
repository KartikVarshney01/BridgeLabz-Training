using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf
{
    /// <summary>
    /// The Book Shelf Program Helps Learning about linked list and dictionary. It Works on having a library
    /// where we can add books, check out them and return them.
    /// We are Using Linked List to store and connect these books with one another and dictionary to map them
    /// with their genre. So we easily access books according to their genre.
    /// 
    /// version - 1.0
    /// </summary>
    internal class LibraryMain
    {
        // Main Class Containing Start Part of the program
        static void Main(String[] args)
        {
            LibraryMenu start = new LibraryMenu();
            start.Menu();
        }
    }
}
