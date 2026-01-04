using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class BankAccount
    {
        // static variables that are shared by all
        static string bankName = "National Bank";
        static int totalAccounts = 0;

        // Readonly Variables
        public readonly int accountNumber;

        // Instance Variables
        public string holderName;
        public double balance;

        // Constructor Call
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
            totalAccounts++;
        }

        public static void GetTotalAccounts()
        {
            Console.WriteLine($"The Total Number of Accounts are {totalAccounts}");
        }

        public static void DisplayAccount(object obj)
        {
            if (obj is BankAccount account)
            {
                Console.WriteLine("Bank Name        : " + bankName);
                Console.WriteLine("Account Number   : " + account.accountNumber);
                Console.WriteLine("Account Holder   : " + account.holderName);
                Console.WriteLine("Balance          : " + account.balance);
            }
            else
            {
                Console.WriteLine("Invalid Account Object");
            }
        }
        static void Main(String[] args)
        {
            BankAccount acc1 = new BankAccount(165, "Kartik", 5000);
            BankAccount acc2 = new BankAccount(185, "Harsh", 8000);

            BankAccount.DisplayAccount(acc1);
            Console.WriteLine();

            BankAccount.DisplayAccount(acc2);
            Console.WriteLine();

            BankAccount.GetTotalAccounts();
        }
    }
}
