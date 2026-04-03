using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.BookBuddy
{
    // Encapsulated Book Class Containg details regarding book
    internal class Book
    {
        // Book Variables of Title And Author
        public string bookTitle {  get; set; }
        public string bookAuthor { get; set; }

        public override string ToString()
        {
            return $"Book Title : {bookTitle} || Book Author : {bookAuthor}";
        }
    }
}
