using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Review.LibraryManagement
{
    internal class Book
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public override string ToString()
        {
            return "\n====================" +
                $"\nTitle : {BookTitle}" +
                $"\nAuthor : {BookAuthor}" +
                $"\n======================";
        }
    }
}
