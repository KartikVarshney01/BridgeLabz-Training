using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public string AddressBookName { get; set; }
        public List<Contacts> Contacts { get; set; }

        public AddressBook()
        {
            Contacts = new List<Contacts>();
        }

    }
}