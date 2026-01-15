using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    // Interface for the Contacts Class Methods
    internal interface IContacts
    {
        // UC-2
        void AddContact();

        // UC-3
        void EditContact();

        // UC-4
        void DeleteContact();

        // UC-11
        //void SortByName();

    }
}
