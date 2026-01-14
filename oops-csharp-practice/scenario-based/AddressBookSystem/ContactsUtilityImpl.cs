using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    // Utility Class Contains All The Contacts Related Functions And Their Implementation
    internal class ContactsUtilityImpl : IContacts
    {
        // Private Reference For the current address book class
        private AddressBook currentAddressBook;

        // Constructor to initialize the address book reference
        public ContactsUtilityImpl(AddressBook AddressBook)
        {
            currentAddressBook = AddressBook;
        }

        // Add Contact Person To Add a new Contact in the system
        public void AddContact()
        {
            // Checking if Contacts Array of the current Address Book is initialized or not. if not initializing it.
            if (currentAddressBook.Contacts == null)
            {
                Console.WriteLine("No Address Book Found yet!\n");
                return;
            }

            // Check if address book is completely full
            bool hasSpace = false;
            for (int i = 0; i < currentAddressBook.Contacts.Length; i++)
            {
                if (currentAddressBook.Contacts[i] == null)
                {
                    hasSpace = true;
                    break;
                }
            }

            if (!hasSpace)
            {
                Console.WriteLine("Address Book is full.");
                return;
            }

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

            // Insert into FIRST available (null) slot
            for (int i = 0; i < currentAddressBook.Contacts.Length; i++)
            {
                if (currentAddressBook.Contacts[i] == null)
                {
                    currentAddressBook.Contacts[i] = newContact;
                    Console.WriteLine("Contact Added Successfully.");
                    return;
                }
            }
        }

        // UC-3 Edit Contact Method to add a edit a contact based on the user name input
        public void EditContact()
        {
            // Checking if there is any active contact in the system or not
            if (currentAddressBook.Contacts == null)
            {
                Console.WriteLine("No Address Book Details Found yet!\n");
                return;
            }

            // Finding The Index Or the Contact We Want to Edit
            int editContactIdx = SearchContact();
            if (editContactIdx == -1) return;

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

            currentAddressBook.Contacts[editContactIdx] = updateContact;
            Console.WriteLine($"Person {currentAddressBook.Contacts[editContactIdx].FirstName} Data is Updated\n");

        }

        // UC-4 To Delete A Contact Details and It Form the Address Book
        public void DeleteContact()
        {
            if (currentAddressBook.Contacts == null)
            {
                Console.WriteLine("No Contact Details Enteres yet!\n");
                return;
            }

            // Finding The Index Of the Contact we want to delete
            int deleteContactIdx = SearchContact();
            if (deleteContactIdx == -1) return;

            // Taking User confirmation before deleting the contact details.
            Console.Write("Please Confirm that you want to delete the contact details [yes/no] : ");
            string confirm = Console.ReadLine();

            if (confirm == "yes" || confirm == "Yes")
            {
                currentAddressBook.Contacts[deleteContactIdx] = null;
                Console.WriteLine("Person Contact Info is Deleted");
            }
            else
            {
                Console.WriteLine("Exiting...\n");
            }
        }

        // Helper Function To help in Finding Our Contact in the array
        public int SearchContact()
        {
            // Checking If A Address Book Is Initialized or Not
            if (currentAddressBook.Contacts == null)
            {
                Console.WriteLine("No Address Book is Initialized yet.");
                return -1;
            }

            Console.Write("Enter the name you want to edit or delete : ");
            string searchName = Console.ReadLine();

            for (int i = 0; i < currentAddressBook.Contacts.Length; i++)
            {
                if (currentAddressBook.Contacts[i] != null && currentAddressBook.Contacts[i].FirstName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            Console.WriteLine("Contact Not Found");
            return -1;
        }
    }
}
