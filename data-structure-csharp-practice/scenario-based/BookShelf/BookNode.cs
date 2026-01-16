using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.BookShelf
{
    internal class BookNode
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookGenre { get; set; }
        public string BookStatus { get; set; }
        public BookNode NextBook { get; set; }

        public BookNode()
        {
            BookStatus = "Available";
        }

        public override string ToString()
        {
            return $"Title : {BookTitle} || Author : {BookAuthor} || Genre : {BookGenre} || Status : {BookStatus}";
        }
    }
}
