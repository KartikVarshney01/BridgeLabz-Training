using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Review.LibraryManagement
{
    internal interface ILibrary
    {
        void AddBook();
        void EditBook();
        void RemoveBook();
        void SearchBook();
        void SortBooks();
        void DisplayBooks();
    }
}
