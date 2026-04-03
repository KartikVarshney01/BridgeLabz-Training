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
            PrintSeparator();
            Console.WriteLine("Welcome To The Address Book Program");
            PrintSeparator();

            // Creating The Utility Object
            addressBookUtility = new AddressBookUtilityImpl();

            // infintie While Loop - Address Book Menu
            while (true)
            {
                Console.WriteLine("\nADDRESS BOOK MENU");
                PrintSeparator();
                Console.WriteLine("| 1. Add New Address Book              |");
                Console.WriteLine("| 2. Select Address Book               |");
                Console.WriteLine("| 3. Search by City / State            |");
                Console.WriteLine("| 4. Count by City / State             |");
                Console.WriteLine("| 5. Exit                              |");
                PrintSeparator();

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

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
                        addressBookUtility.SearchByCityOrState();
                        break;
                    case 4:
                        addressBookUtility.CountByCityOrState();
                        break;
                    case 5:
                        Console.WriteLine("\nExiting Address Book System...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void ContactMenu(AddressBook selectedBook)
        {
            contactsUtility = new ContactsUtilityImpl(selectedBook, (AddressBookUtilityImpl)addressBookUtility);

            // Infinite Loop - Contact Menu
            while (true)
            {
                Console.WriteLine("\nCONTACT MENU");
                PrintSeparator();
                Console.WriteLine("| 1. Add New Contact                   |");
                Console.WriteLine("| 2. Edit Existing Contact             |");
                Console.WriteLine("| 3. Delete Existing Contact           |");
                Console.WriteLine("| 4. Sort Contacts by Name             |");
                Console.WriteLine("| 5. Sort Contacts by City/State/Zip   |");
                Console.WriteLine("| 6. Back to Address Book Menu         |");
                PrintSeparator();

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
                        contactsUtility.SortByName();
                        break;
                    case 5:
                        Console.WriteLine("\nSORT OPTIONS");
                        PrintSeparator();
                        Console.WriteLine("1. By City");
                        Console.WriteLine("2. By State");
                        Console.WriteLine("3. By Zip");
                        Console.WriteLine("4. Back");
                        PrintSeparator();

                        Console.Write("Enter Your Choice : ");
                        int ch = Convert.ToInt32(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                contactsUtility.SortByCity();
                                break;
                            case 2:
                                contactsUtility.SortByState();
                                break;
                            case 3:
                                contactsUtility.SortByZip();
                                break;
                            case 4:
                                Console.WriteLine("Backing To The Menu");
                                return;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("\nReturning To The Address Book Menu....");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice! Please Try Again");
                        break;
                }
            }
        }

        // Helper Function
        private void PrintSeparator()
        {
            Console.WriteLine("========================================");
        }
    }
}
