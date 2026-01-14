using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystemMenu
    {
        // System Menu Containing The Start of our program. It The Area that is displayed to the user.
        private IContacts contactsUtility;

        // Creating a private reference of the IAddressBook Interface
        private IAddressBook addressBookUtility;
        public void SystemMenu()
        {
            Console.WriteLine("Welcome To The Address Book Program");

            // Creating The Utility Object
            addressBookUtility = new AddressBookUtilityImpl();

            // infintie While Loop - Address Book Menu
            while (true)
            {
                Console.WriteLine("====Address Book Menu====");
                Console.WriteLine("\n1: Add New Address Book");
                Console.WriteLine("2: Select Address Book");
                Console.WriteLine("3: Exit Address Book System\n");

                Console.Write("Enter Your Choise: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===========================\n");

                switch (choice)
                {
                    case 1:
                        addressBookUtility.AddAddressBook();
                        break;
                    case 2:
                        AddressBook selectedBook = addressBookUtility.SelectAddressBook();
                        if (selectedBook != null)
                        {
                            ContactMenu(selectedBook);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting Address Book System...\n");
                        return;
                    default:
                        break;
                }
            }
        }

        private void ContactMenu(AddressBook selectedBook)
        {
            contactsUtility = new ContactsUtilityImpl(selectedBook);

            // Infinite Loop - Contact Menu
            while (true)
            {
                Console.WriteLine("====Contact Menu====");
                Console.WriteLine("1. Add New Conatct Details");
                Console.WriteLine("2. Update Existing Conatct Details");
                Console.WriteLine("3. Delete Existing Conatct");
                Console.WriteLine("4. Back To Address Book Menu\n");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        contactsUtility.AddContact();
                        break;
                    case 2:
                        contactsUtility.EditContact();
                        break;
                    case 3:
                        contactsUtility.DeleteContact();
                        break;
                    case 4:
                        Console.WriteLine("Returning To The Address Book Menu");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
