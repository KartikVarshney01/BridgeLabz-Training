using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystemMenu
    {
        // System Menu Containing The Start of our program. It The Area that is displayed to the user.
        private IContacts contactsUtility;
        public void SystemMenu()
        {
            // Creating The Utility Object
            contactsUtility = new ContactsUtilityImpl();
            
            // Infinite Loop
            while (true)
            {
                Console.WriteLine("Welcome To Address Book Program");
                Console.WriteLine("1. Add Contacts Size");
                Console.WriteLine("2. Add New Conatct Details");
                Console.WriteLine("3. Update Existing Conatct Details");
                Console.WriteLine("4. Delete Existing Conatct");
                Console.WriteLine("10. Exit The Program");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        contactsUtility.MultipleContacts();
                        break;
                    case 2:
                        contactsUtility.AddContact();
                        break;
                    case 3:
                        contactsUtility.EditContact();
                        break;
                    case 4:
                        contactsUtility.DeleteContact();
                        break;
                    case 10:
                        Console.WriteLine("Exiting The Address Book System");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
