using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        // Dictionary To Store All AddressBooks Reference Data With key: Address Book Name
        Dictionary<string, AddressBook> addressData = new Dictionary<string, AddressBook>();

        // Method to Add Address Book In the Dictionary
        public void AddAddressBook()
        {
            Console.WriteLine("Creating New Address Book"); 

            Console.Write("Enter the Address Book Name : ");
            string name = Console.ReadLine();

            // Checking if Address Book already exists
            if (addressData.ContainsKey(name.ToLower()))
            {
                Console.WriteLine("The Name Already Exists! Choose A Different Name");
                return;
            }

            // Creating a new Address Book Object To Store Address Book Info 
            AddressBook addressBook = new AddressBook();
            addressBook.AddressBookName = name.ToLower();

            Console.Write("Enter the Capacity of this Address Book : ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            
            if (capacity <= 0)
            {
                Console.WriteLine("Invalid capacity.");
                return;
            }

            // Assigning Contacts With Capacity and initializing the Contacts Array
            addressBook.Contacts = new Contacts[capacity];

            // Storing The New Address Book Inside Dictionary
            addressData.Add(addressBook.AddressBookName, addressBook);

            Console.WriteLine("Your New Address Book Has Created Successfully");
        }

        // Method To Select Any Existing Address Book By Name And Returning Its Reference
        public AddressBook SelectAddressBook()
        {
            // Checking for empty dictionay
            if (addressData.Count == 0)
            {
                Console.WriteLine("No Address Books Available. Add A Address Book First.");
                return null;
            }

            Console.WriteLine("You Can Select Any Available Address Book: ");

            // Generating a List of All Existing Address Books on Console Screen
            int idx = 1;
            foreach (string addressBookName in addressData.Keys)
            {
                Console.WriteLine(idx + ": " + addressBookName);
                idx++;
            }

            // Getting Address Book Name User Want To Select
            Console.Write("Enter Address Book Name To Select [n: No Selection]: ");
            string userChoise = Console.ReadLine().ToLower();

            if (userChoise.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No Address Book Has Chosen..");
                return null;
            }

            // If Address Book exists return reference else return null
            if (addressData.ContainsKey(userChoise))
            {
                Console.WriteLine($"Selecting Address Book : {userChoise}");
                return addressData[userChoise];
            }
            else
            {
                Console.WriteLine($"No Address Book Has Found Of Name : {userChoise}");
                return null;
            }
        }
    }
}
