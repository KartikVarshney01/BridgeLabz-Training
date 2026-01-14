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
            Console.WriteLine("New Person Contacts Details Add Successfully\n");

        }

        // UC-3 Edit Contact Method to add a edit a contact based on the user name input
        public void EditContact()
        {
            // Checking if there is any active contact in the system or not
            if(Person == null)
            {
                Console.WriteLine("No Contact Details Enteres yet!\n");
                return;
            }

            Console.Write("Enter the Contact First Name you want to edit : ");
            string editName = Console.ReadLine();

            // Checking if the person that is currently active matched the person user wants to edit or update
            if(!Person.FirstName.Equals(editName,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contact Not Matched\n");
                return;
            }

            //Creating a temporary object to store the update details
            Contacts updateContact = new Contacts();

            Console.WriteLine("Enter the Person Updated Details : \n");
            Console.Write("Enter Your First Name : ");
            updateContact.FirstName = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            updateContact.LastName = Console.ReadLine();
            Console.Write("Enter Your Address : ");
            updateContact.Address = Console.ReadLine();
            Console.Write("Enter Your City : ");
            updateContact.City = Console.ReadLine();
            Console.Write("Enter Your State : ");
            updateContact.State = Console.ReadLine();
            Console.Write("Enter Your Zip : ");
            updateContact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your PhoneNumber : ");
            updateContact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Your Email : ");
            updateContact.Email = Console.ReadLine();

            Person = updateContact;
            Console.WriteLine($"Person {Person.FirstName} Data is Updated\n");

        }
    }
}
