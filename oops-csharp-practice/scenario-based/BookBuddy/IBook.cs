using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.BookBuddy
{
    // Interface Ibook holding signature of the functions
    internal interface IBook
    {
        void AddBook();
        void SortBooksAlphabetically();
        void SearchBookByAuthor();

        void DisplayAllBooks();

    }
}
