using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        // Dictionary To Store All AddressBooks Reference Data With key: Address Book Name
        Dictionary<string, AddressBook> addressData = new Dictionary<string, AddressBook>();

        // Dictionary To Store All Persons By City
        internal Dictionary<string, LinkedList<Contacts>> cityData = new Dictionary<string, LinkedList<Contacts>>();

        // Dictionary To Store All Persons By State
        internal Dictionary<string, LinkedList<Contacts>> stateData = new Dictionary<string, LinkedList<Contacts>>();

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

        // Method To Search For Persons By City Or State
        public void SearchByCityOrState()
        {
            if (addressData.Count == 0)
            {
                Console.WriteLine("No Address Book Currently Available");
                return;
            }

            while (true)
            {
                Console.WriteLine("Search By City Or State [1. City, 2. State, 3.Exit]");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SearchByCity();
                        return;
                    case 2:
                        SearchByState();
                        return;
                    case 3:
                        Console.WriteLine("Returning");
                        return;
                    default:
                        break;
                }
            }
        }

        // Method To Count For Persons By City Or State
        public void CountByCityOrState()
        {
            if (addressData.Count == 0)
            {
                Console.WriteLine("No Address Book Currently Available");
                return;
            }

            while (true)
            {
                Console.WriteLine("Count By City Or State [1. City, 2. State, 3.Exit]");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CountByCity();
                        return;
                    case 2:
                        CountByState();
                        return;
                    case 3:
                        Console.WriteLine("Returning");
                        return;
                    default:
                        break;
                }
            }
        }

        // Helper Method To find persons based on city
        private void SearchByCity()
        {
            Console.Write("Enter City Name To Start The Search : ");
            string city = Console.ReadLine();

            Console.WriteLine("\n Contact List Based On City \n");

            if (!cityData.ContainsKey(city))
            {
                Console.WriteLine("City Data is Empty.");
                return;
            }

            foreach (Contacts contact in cityData[city])
            {
                DisplayInfo(contact);
            }
        }

        // Helper Method To find persons based on state
        private void SearchByState()
        {
            Console.Write("Enter State Name To Start The Search : ");
            string state = Console.ReadLine();

            Console.WriteLine("\n Persons List Based On State \n");

            if (!stateData.ContainsKey(state))
            {
                Console.WriteLine("State Data is Empty.");
                return;
            }

            foreach (Contacts contact in stateData[state])
            {
                DisplayInfo(contact);
            }
        }

        // Private Helper Function To help with counting the persons in city.
        private void CountByCity()
        {
            Console.Write("Enter The Name of the City : ");
            string city = Console.ReadLine();

            if (!cityData.ContainsKey(city))
            {
                Console.WriteLine("City Data not Found");
                return;
            }
            Console.WriteLine($"The Number Of Persons in City {city} : {cityData[city].Count}");
        }

        // Private Helper Function To help in counting the persons in state
        private void CountByState()
        {
            Console.Write("Enter The Name of the State : ");
            string state = Console.ReadLine();

            if (!stateData.ContainsKey(state))
            {
                Console.WriteLine("State Data not Found");
                return;
            }
            Console.WriteLine($"The Number Of Persons in State {state} : {stateData[state].Count}");
        }

        private void DisplayInfo(Contacts contact)
        {
            Console.WriteLine(
                $"Name : {contact.FirstName} {contact.LastName}" +
                $"Address : {contact.Address} " +
                $"City : {contact.City} || State : {contact.State}");
        }
    }
}
