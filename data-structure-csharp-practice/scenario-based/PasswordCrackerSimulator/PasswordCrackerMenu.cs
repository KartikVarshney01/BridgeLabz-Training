using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    // Menu Class Containing The User Menu of our Program
    internal class PasswordCrackerMenu
    {
        // Private Reference for the Utility Class
        private PasswordCrackerUtilityImpl cracker;
        
        // Constructor Initializing the Utility Reference
        public PasswordCrackerMenu()
        {
            cracker = new PasswordCrackerUtilityImpl();
        }

        // Menu Method
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome To The Password Vault");
                Console.WriteLine("1. Set Password");
                Console.WriteLine("2. Generate Password");
                Console.WriteLine("3. Crack Password");
                Console.WriteLine("4. Exit The Password Vault");
                Console.Write("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cracker.SetPassword();
                        break;
                    case 2:
                        cracker.GenerateDecodePassword();
                        break;
                    case 3:
                        cracker.FindPassword();
                        break;
                    case 4:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
