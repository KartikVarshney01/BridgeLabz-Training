using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
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
            try
            {
                // Creating an temporary object to get details from the user
                Contacts newContact = new Contacts();

                Console.WriteLine("Enter the Person Details : ");

                Console.Write("Enter Your First Name : ");
                string firstName = Console.ReadLine();
                if (!ValidationHelper.ValidateName(firstName))
                    throw new InvalidContactException("Invalid First Name format.");
                newContact.FirstName = firstName;

                Console.Write("Enter Your Last Name : ");
                string lastName = Console.ReadLine();
                if (!ValidationHelper.ValidateName(lastName))
                    throw new InvalidContactException("Invalid Last Name format.");
                newContact.LastName = lastName;

                //UC-7 Checking if Person With Same Name Exists Or Not
                int foundIdx = SearchContact(newContact.FirstName, newContact.LastName);

                if (foundIdx != -1)
                {
                    Console.WriteLine("Person Already Exists In the Address Book. Look For Update Details");
                    return;
                }

                Console.Write("Enter Your Address : ");
                string address = Console.ReadLine();
                if (!ValidationHelper.ValidateAddress(address))
                    throw new InvalidContactException("Invalid Address.");
                newContact.Address = address;

                Console.Write("Enter Your City : ");
                string city = Console.ReadLine();
                if (!ValidationHelper.ValidateCityState(city))
                    throw new InvalidContactException("Invalid City.");
                newContact.City = city;

                Console.Write("Enter Your State : ");
                string state = Console.ReadLine();
                if (!ValidationHelper.ValidateCityState(state))
                    throw new InvalidContactException("Invalid State.");
                newContact.State = state;

                Console.Write("Enter Your Zip : ");
                string zip = Console.ReadLine();
                if (!ValidationHelper.ValidateZip(zip))
                    throw new InvalidContactException("Invalid Zip Code.");
                newContact.Zip = Convert.ToInt32(zip);

                Console.Write("Enter Your PhoneNumber : ");
                string phone = Console.ReadLine();
                if (!ValidationHelper.ValidatePhone(phone))
                    throw new InvalidContactException("Invalid Phone Number.");
                newContact.PhoneNumber = Convert.ToInt64(phone);

                Console.Write("Enter Your Email : ");
                string email = Console.ReadLine();
                if (!ValidationHelper.ValidateEmail(email))
                    throw new InvalidContactException("Invalid Email format.");
                newContact.Email = email;

                // Adding Inside The Current Address Book
                currentAddressBook.Contacts.Add(newContact);

                // UC - 9
                // Adding the Contacts into the city-person and state-person dictionary 
                // City 
                // If city data does not contains the city create a new key-value pair
                if (!addressUtility.cityData.ContainsKey(newContact.City))
                {
                    addressUtility.cityData[newContact.City] = new List<Contacts>();
                }
                // Adding contact in dictionary
                addressUtility.cityData[newContact.City].Add(newContact);

                // State
                // If state data does not contains the state create a new key-value pair
                if (!addressUtility.stateData.ContainsKey(newContact.State))
                {
                    addressUtility.stateData[newContact.State] = new List<Contacts>();
                }
                addressUtility.stateData[newContact.State].Add(newContact);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // UC-3 Edit Contact Method to add a edit a contact based on the user name input
        public void EditContact()
        {
            try
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
                string firstName = Console.ReadLine();
                if (!ValidationHelper.ValidateName(firstName))
                    throw new InvalidContactException("Invalid First Name format.");
                updateContact.FirstName = firstName;

                Console.Write("Enter Your Last Name : ");
                string lastName = Console.ReadLine();
                if (!ValidationHelper.ValidateName(lastName))
                    throw new InvalidContactException("Invalid Last Name format.");
                updateContact.LastName = lastName;

                Console.Write("Enter Your Address : ");
                string address = Console.ReadLine();
                if (!ValidationHelper.ValidateAddress(address))
                    throw new InvalidContactException("Invalid Address.");
                updateContact.Address = address;

                Console.Write("Enter Your City : ");
                string city = Console.ReadLine();
                if (!ValidationHelper.ValidateCityState(city))
                    throw new InvalidContactException("Invalid City.");
                updateContact.City = city;

                Console.Write("Enter Your State : ");
                string state = Console.ReadLine();
                if (!ValidationHelper.ValidateCityState(state))
                    throw new InvalidContactException("Invalid State.");
                updateContact.State = state;

                Console.Write("Enter Your Zip : ");
                string zip = Console.ReadLine();
                if (!ValidationHelper.ValidateZip(zip))
                    throw new InvalidContactException("Invalid Zip Code.");
                updateContact.Zip = Convert.ToInt32(zip);

                Console.Write("Enter Your PhoneNumber : ");
                string phone = Console.ReadLine();
                if (!ValidationHelper.ValidatePhone(phone))
                    throw new InvalidContactException("Invalid Phone Number.");
                updateContact.PhoneNumber = Convert.ToInt64(phone);

                Console.Write("Enter Your Email : ");
                string email = Console.ReadLine();
                if (!ValidationHelper.ValidateEmail(email))
                    throw new InvalidContactException("Invalid Email format.");
                updateContact.Email = email;

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
                    addressUtility.cityData[updateContact.City] = new List<Contacts>();
                }
                addressUtility.cityData[updateContact.City].Add(updateContact);

                // add updated state entry
                if (!addressUtility.stateData.ContainsKey(updateContact.State))
                {
                    addressUtility.stateData[updateContact.State] = new List<Contacts>();
                }
                addressUtility.stateData[updateContact.State].Add(updateContact);
            }
            catch(InvalidAddressBookException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // UC-4 To Delete A Contact Details and It Form the Address Book
        public void DeleteContact()
        {
            try
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
                // currentAddressBook.Contacts[deleteContactIdx] = null;
                currentAddressBook.Contacts.RemoveAt(deleteContactIdx);
                Console.WriteLine("Contact deleted successfully.");
            }
            catch(InvalidAddressBookException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // UC - 11 Sorting The Contacts By Name
        public void SortByName()
        {
            try
            {
                // Checking Empty Array
                if (IsAddressBookEmpty())
                {
                    Console.WriteLine("Address Book is Empty...");
                    return;
                }

                // Using Bubble Sort To Sort 
                for (int i = 0; i < currentAddressBook.Contacts.Count - 1; i++)
                {
                    for (int j = i + 1; j < currentAddressBook.Contacts.Count; j++)
                    {
                        if (string.Compare(
                            currentAddressBook.Contacts[i].FirstName,
                            currentAddressBook.Contacts[j].FirstName,
                            StringComparison.OrdinalIgnoreCase) > 0)
                        {
                            var temp = currentAddressBook.Contacts[i];
                            currentAddressBook.Contacts[i] = currentAddressBook.Contacts[j];
                            currentAddressBook.Contacts[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Contacts sorted successfully by name.");

                for(int i = 0; i < currentAddressBook.Contacts.Count; i++)
                {
                    Console.WriteLine(currentAddressBook.Contacts[i]);
                }
            }
            catch(InvalidAddressBookException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // UC-12 Sorting By City
        public void SortByCity()
        {
            try
            {
                // Checking Empty Array
                if (IsAddressBookEmpty())
                {
                    Console.WriteLine("Address Book is Empty...");
                    return;
                }

                // Using Bubble Sort To Sort 
                for (int i = 0; i < currentAddressBook.Contacts.Count - 1; i++)
                {
                    for (int j = i + 1; j < currentAddressBook.Contacts.Count; j++)
                    {
                        string city1 = currentAddressBook.Contacts[i].City;
                        string city2 = currentAddressBook.Contacts[j].City;

                        if (string.Compare(city1, city2, StringComparison.OrdinalIgnoreCase) > 0)
                        {
                            Contacts temp = currentAddressBook.Contacts[i];
                            currentAddressBook.Contacts[i] = currentAddressBook.Contacts[j];
                            currentAddressBook.Contacts[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Contacts sorted successfully by City.");

                for (int i = 0; i < currentAddressBook.Contacts.Count; i++)
                {
                    Console.WriteLine(currentAddressBook.Contacts[i]);
                }
            }
            catch(InvalidAddressBookException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // UC-12 Sorting By State
        public void SortByState()
        {
            try
            {
                // Checking Empty Array
                if (IsAddressBookEmpty())
                {
                    Console.WriteLine("Address Book is Empty...");
                    return;
                }

                // Using Bubble Sort To Sort 
                for (int i = 0; i < currentAddressBook.Contacts.Count - 1; i++)
                {
                    for (int j = i + 1; j < currentAddressBook.Contacts.Count; j++)
                    {
                        string state1 = currentAddressBook.Contacts[i].State;
                        string state2 = currentAddressBook.Contacts[j].State;

                        if (string.Compare(state1, state2, StringComparison.OrdinalIgnoreCase) > 0)
                        {
                            Contacts temp = currentAddressBook.Contacts[i];
                            currentAddressBook.Contacts[i] = currentAddressBook.Contacts[j];
                            currentAddressBook.Contacts[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Contacts sorted successfully by State.");

                for (int i = 0; i < currentAddressBook.Contacts.Count; i++)
                {
                    Console.WriteLine(currentAddressBook.Contacts[i]);
                }
            }
            catch(InvalidAddressBookException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // UC-12 Sorting By Zip
        public void SortByZip()
        {
            try
            {
                // Checking Empty Array
                if (IsAddressBookEmpty())
                {
                    Console.WriteLine("Address Book is Empty...");
                    return;
                }

                // Using Bubble Sort To Sort 
                for (int i = 0; i < currentAddressBook.Contacts.Count - 1; i++)
                {
                    for (int j = i + 1; j < currentAddressBook.Contacts.Count; j++)
                    {

                        if (currentAddressBook.Contacts[i].Zip > currentAddressBook.Contacts[j].Zip)
                        {
                            Contacts temp = currentAddressBook.Contacts[i];
                            currentAddressBook.Contacts[i] = currentAddressBook.Contacts[j];
                            currentAddressBook.Contacts[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Contacts sorted successfully by Zip.");

                for (int i = 0; i < currentAddressBook.Contacts.Count; i++)
                {
                    Console.WriteLine(currentAddressBook.Contacts[i]);
                }
            }
            catch(InvalidAddressBookException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(InvalidContactException e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }

        // Helper Function To help in Finding Our Contact in the array
        private int SearchContact()
        {
            // Checking If A Address Book Is Initialized or Not
            if (currentAddressBook.Contacts.Count == 0)
            {
                Console.WriteLine("No Address Book is Initialized yet.");
                return -1;
            }

            Console.Write("Enter the name you want to edit or delete : ");
            string searchName = Console.ReadLine();

            for (int i = 0; i < currentAddressBook.Contacts.Count; i++)
            {
                if (currentAddressBook.Contacts[i].FirstName
                    .Equals(searchName, StringComparison.OrdinalIgnoreCase))
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
            for (int i = 0; i < currentAddressBook.Contacts.Count; i++)
            {
                if (currentAddressBook.Contacts[i].FirstName
                    .Equals(FirstName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }

        // Helper Method to check if Address Book Is Empty or Not
        private bool IsAddressBookEmpty()
        {
            if (currentAddressBook.Contacts.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
