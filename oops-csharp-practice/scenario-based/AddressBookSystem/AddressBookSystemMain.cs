using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystemMain
    {
        /// <summary>
        /// The Address Book System is a program where we are learning about using UC and all our topics.
        /// In The Start we have a Main Class providing a Entry Point for the program to start. 
        /// The Main Then Calls The Menu Where The System or Our program Starts. It Prints Welcome To Address Book Program.
        /// UC-1 : We have made a encapsulated Contacts class that have all the contacts fields.
        /// UC-2 : We Add A Method To allow addition of a new contact by the user.
        /// UC-3 : We Add A Method That allows for a user to update a contact info
        /// UC-4 : We Add A Method That allows users to delete a conatct.
        /// UC-5 : We Add A Method That Allows The user To Initialize the Size of the Contacts Array to help in multiple contacts storage
        /// UC-6  : We Added A Address Book Class, Address Book Interface And Address Book Utility And Modified Contacts Utility And
        ///         AddressBookSystemMenu
        /// UC-7 : We Add A new Functionality in the Add Contact where it searches for if there is already a person or contact exists with 
        ///        the same name or not.
        /// UC-8 : We Add The Functionality To Search The COntacts or Persons By The City Or State Among All Address Books        
        /// UC-9 : We Add The Dictionary To Maintain A City-Person And A State-Person List for every new Contact. It Allows us to view All The 
        ///        Persons a specific city or state
        /// UC-10 : We Add The Function To Count The Number of Persons in a City or State.
        /// 
        /// 
        /// version - 1.9
        /// </summary>
        static void Main(string[] args)
        {
            AddressBookSystemMenu start = new AddressBookSystemMenu();
            start.SystemMenu();
        }
    }
}
