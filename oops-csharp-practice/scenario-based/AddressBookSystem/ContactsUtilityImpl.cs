using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    // Utility Class Contains All The Contacts Related Functions And Their Implementation
    internal class ContactsUtilityImpl : IContacts
    {
        // Contact Object Person That is Private to secure the persons details
        private Contacts Person;

        // Add Contact Person To Add a new Contact in the system
        public void AddContact()
        {
            // Creating an temporary object to get details from the user
            Contacts newContact = new Contacts();

            Console.WriteLine("Enter the Person Details : ");
            Console.Write("Enter Your First Name : ");
            newContact.FirstName = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            newContact.LastName = Console.ReadLine();
            Console.Write("Enter Your Address : ");
            newContact.Address = Console.ReadLine();
            Console.Write("Enter Your City : ");
            newContact.City = Console.ReadLine();
            Console.Write("Enter Your State : ");
            newContact.State = Console.ReadLine();
            Console.Write("Enter Your Zip : ");
            newContact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your PhoneNumber : ");
            newContact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Your Email : ");
            newContact.Email = Console.ReadLine();

            Person = newContact;
            Console.WriteLine("New Person Contacts Details Add Successfully");

            Console.WriteLine(Person);
        }
    }
}
