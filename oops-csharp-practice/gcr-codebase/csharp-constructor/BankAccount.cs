using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class BankAccount
    {
        // Public member
        public int accountNumber;

        // Protected member
        protected string accountHolder;

        // Private member
        private double balance;

        // Constructor
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Getting balance
        public double GetBalance()
        {
            return balance;
        }

        // Setting the balance
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        // Method accessing protected member
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Account Holder : " + accountHolder);
            Console.WriteLine("Balance        : " + balance);
        }

        static void Main()
        {
            BankAccount acc = new BankAccount(15045, "Kartik", 35000);
            acc.DisplayAccountDetails();

            Console.WriteLine();
            acc.SetBalance(40000);
            Console.WriteLine("Updated Balance : " + acc.GetBalance());
        }
    }
}
