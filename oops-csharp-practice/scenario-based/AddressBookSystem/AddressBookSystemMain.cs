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
        /// </summary>
        static void Main(string[] args)
        {
            AddressBookSystemMenu start = new AddressBookSystemMenu();
            start.SystemMenu();
        }
    }
}
