using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    // Address Book Interface 
    internal interface IAddressBook
    {
        // To Add New Address Books
        void AddAddressBook();

        // To Select a Existing Address Book
        AddressBook SelectAddressBook();

    }
}
