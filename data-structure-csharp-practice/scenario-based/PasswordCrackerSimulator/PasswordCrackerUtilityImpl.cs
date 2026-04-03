using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    // Utiility Class
    internal class PasswordCrackerUtilityImpl : IPasswordCracker
    {
        // Private Reference For Current Password
        private PasswordVault CurrentPassword;
        private bool isFound;
        private int attempts;
        
        // Constructor
        public PasswordCrackerUtilityImpl()
        {
            CurrentPassword = new PasswordVault();
            isFound = false;
            attempts = 0;
        }

        // Set Password Method Setting The Password
        public void SetPassword()
        {
            Console.Write("Enter Your Password : ");
            string password = Console.ReadLine();

            CurrentPassword.Password = password;
        }

        // Scenario - A : Generating All Possible Passwords For the given length
        public void GenerateDecodePassword()
        {
            Console.Write("Enter the length : ");
            int length = Convert.ToInt32(Console.ReadLine());
            GeneratePassword(new StringBuilder(), length);
        }

        // Scenario - B : Finding The Password 
        public void FindPassword()
        {
            if (CurrentPassword.Password == null)
            {
                Console.WriteLine("Set Password First");
                return;
            }

            // reset state
            isFound = false;
            attempts = 0;

            Console.WriteLine("\nCracking Password...");
            GenerateAndCrack(new StringBuilder(), CurrentPassword.Password.Length);

            Console.WriteLine("\nAttempts Taken : " + attempts);
        }

        // Backtracking with stop condition
        private void GenerateAndCrack(StringBuilder result, int length)
        {
            if (isFound)
                return;

            if (result.Length == length)
            {
                attempts++;
                Console.Write($"\rCracking Password : " + result + " ");
                if (result.ToString().Equals(CurrentPassword.Password))
                {
                    //Console.WriteLine($"Password Cracked : {result}");
                    isFound = true;
                }
                return;
            }

            for (int i = 0; i < 26; i++)
            {
                char ch = (char)(i + 97);
                result.Append(ch);
                GenerateAndCrack(result, length);
                result.Remove(result.Length - 1, 1);
            }
        }

        // Private Helper Function
        private void GeneratePassword(StringBuilder result, int length)
        {
            if (result.Length == length)
            {
                Console.WriteLine(result.ToString());
                return;
            }
            for (int i = 0; i < 26; i++)
            {
                char ch = (char)(i + 97);
                result.Append(ch);
                GeneratePassword(result, length);
                result.Remove(result.Length - 1, 1);
            }
        }
    }
}
