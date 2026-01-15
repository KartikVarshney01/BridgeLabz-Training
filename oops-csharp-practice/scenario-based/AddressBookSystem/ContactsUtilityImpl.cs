using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    // Utility Class Contains All The Contacts Related Functions And Their Implementation
    internal class ContactsUtilityImpl : IContacts
    {
        // Address Book Utility Reference
        private AddressBookUtilityImpl addressUtility;

        // Private Reference For the current address book class
        private AddressBook currentAddressBook;

        // Constructor to initialize the address book reference
        public ContactsUtilityImpl(AddressBook AddressBook, AddressBookUtilityImpl addressBookUtility)
        {
            currentAddressBook = AddressBook;
            this.addressUtility = addressBookUtility;
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

            //UC-7 Checking if Person With Same Name Exists Or Not
            int foundIdx = SearchContact(newContact.FirstName, newContact.LastName);

            if (foundIdx != -1)
            {
                Console.WriteLine("Person Already Exists In the Address Book. Look For Update Details");
                return;
            }

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
                    break;
                }
            }

            // UC - 9
            // Adding the Contacts into the city-person and state-person dictionary 
            // City 
            // If city data does not contains the city create a new key-value pair
            if (!addressUtility.cityData.ContainsKey(newContact.City))
            {
                addressUtility.cityData[newContact.City] = new LinkedList<Contacts>();
            }
            // Adding contact in dictionary
            addressUtility.cityData[newContact.City].AddLast(newContact);

            // State
            // If state data does not contains the state create a new key-value pair
            if (!addressUtility.stateData.ContainsKey(newContact.State))
            {
                addressUtility.stateData[newContact.State] = new LinkedList<Contacts>();
            }
            addressUtility.stateData[newContact.State].AddLast(newContact);
        }

        // UC-3 Edit Contact Method to add a edit a contact based on the user name input
        public void EditContact()
        {
            // Checking if there is any active contact in the system or not
            if (IsAddressBookEmpty())
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

            Contacts oldContact = currentAddressBook.Contacts[editContactIdx];

            currentAddressBook.Contacts[editContactIdx] = updateContact;
            Console.WriteLine($"Person {currentAddressBook.Contacts[editContactIdx].FirstName} Data is Updated\n");

            // remove old city entry
            if (addressUtility.cityData.ContainsKey(oldContact.City))
            {
                addressUtility.cityData[oldContact.City].Remove(oldContact);

                if (addressUtility.cityData[oldContact.City].Count == 0)
                    addressUtility.cityData.Remove(oldContact.City);
            }

            // remove old state entry
            if (addressUtility.stateData.ContainsKey(oldContact.State))
            {
                addressUtility.stateData[oldContact.State].Remove(oldContact);

                if (addressUtility.stateData[oldContact.State].Count == 0)
                    addressUtility.stateData.Remove(oldContact.State);
            }

            // add updated city entry
            if (!addressUtility.cityData.ContainsKey(updateContact.City))
            {
                addressUtility.cityData[updateContact.City] = new LinkedList<Contacts>();
            }
            addressUtility.cityData[updateContact.City].AddLast(updateContact);

            // add updated state entry
            if (!addressUtility.stateData.ContainsKey(updateContact.State))
            {
                addressUtility.stateData[updateContact.State] = new LinkedList<Contacts>();
            }
            addressUtility.stateData[updateContact.State].AddLast(updateContact);



        }

        // UC-4 To Delete A Contact Details and It Form the Address Book
        public void DeleteContact()
        {
            if (IsAddressBookEmpty())
            {
                Console.WriteLine("No Contact Details Enteres yet!\n");
                return;
            }

            // Finding The Index Of the Contact we want to delete
            int deleteContactIdx = SearchContact();
            if (deleteContactIdx == -1) return;

            Contacts deleteContact = currentAddressBook.Contacts[deleteContactIdx];

            // Taking User confirmation before deleting the contact details.
            Console.Write("Please Confirm that you want to delete the contact details [yes/no] : ");
            string confirm = Console.ReadLine();

            if (!(confirm == "yes" || confirm == "Yes"))
            {
                Console.WriteLine("Exiting...\n");
                return;
            }

            // remove from city dictionary
            if (addressUtility.cityData.ContainsKey(deleteContact.City))
            {
                addressUtility.cityData[deleteContact.City].Remove(deleteContact);

                if (addressUtility.cityData[deleteContact.City].Count == 0)
                    addressUtility.cityData.Remove(deleteContact.City);
            }

            // remove from state dictionary
            if (addressUtility.stateData.ContainsKey(deleteContact.State))
            {
                addressUtility.stateData[deleteContact.State].Remove(deleteContact);

                if (addressUtility.stateData[deleteContact.State].Count == 0)
                    addressUtility.stateData.Remove(deleteContact.State);
            }
        }

        // UC - 11 Sorting The Contacts By Name
        //public void SortByName()
        //{
        //    // Checking Empty Array
        //    if (IsAddressBookEmpty())
        //    {
        //        Console.WriteLine("Address Book is Empty...");
        //        return;
        //    }

        //    for (int i = 0; i < currentAddressBook.Contacts.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < currentAddressBook.Contacts.Length; j++)
        //        {
        //            if (currentAddressBook.Contacts[i] == null || currentAddressBook.Contacts[j] == null) continue;

        //            string name1 = currentAddressBook.Contacts[i].FirstName + currentAddressBook.Contacts[i].LastName;
        //            string name2 = currentAddressBook.Contacts[j].FirstName + currentAddressBook.Contacts[j].LastName;

        //            if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
        //            {
        //                Contacts temp = currentAddressBook.Contacts[i];
        //                currentAddressBook.Contacts[i] = currentAddressBook.Contacts[j];
        //                currentAddressBook.Contacts[j] = temp;
        //            }
        //        }
        //    }

        //    Console.WriteLine("Contacts sorted successfully by name.");
        //}

        // Helper Function To help in Finding Our Contact in the array
        private int SearchContact()
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

        // Helper Method to Search By Name and Returning the Corresponding Index
        private int SearchContact(string FirstName, string LastName)
        {
            // Searching data in contacts array
            for (int i = 0; i < currentAddressBook.Contacts.Length; i++)
            {
                if (currentAddressBook.Contacts[i] != null)
                {
                    if (currentAddressBook.Contacts[i].FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase)
                        && currentAddressBook.Contacts[i].LastName.Equals(LastName, StringComparison.OrdinalIgnoreCase))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        // Helper Method to check if Address Book Is Empty or Not
        private bool IsAddressBookEmpty()
        {
            foreach (Contacts contact in currentAddressBook.Contacts)
            {
                if (contact != null)
                    return false;
            }
            return true;
        }
    }
}
