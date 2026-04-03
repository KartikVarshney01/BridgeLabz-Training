using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf
{
    // Interface Class ILibrary containing contract with the functions
    internal interface IBook
    {
        void AddBook(); // Add New Book Method
        void BookCheckOut(); // Book Check-Out Method
        void BookReturned(); // Book Returned Method
        //void BookDelete(); // Book Deletion Method

    }
}
