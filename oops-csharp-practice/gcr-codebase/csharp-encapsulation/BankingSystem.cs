using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    internal class BankingSystem
    {
        // Main Function 
        static void Main()
        {
            BankAccount[] accounts = new BankAccount[2];

            accounts[0] = new SavingsAccount(156, "Kartik", 65000);
            accounts[1] = new CurrentAccount(15, "Aryan", 48000);

            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine("Interest: " + account.CalculateInterest());

                if (account is ILoanable loanAccount)
                {
                    loanAccount.ApplyForLoan(200000);
                    Console.WriteLine("Loan Eligible: " + loanAccount.CalculateLoanEligibility());
                }

                Console.WriteLine();
            }
        }

        // Interface ILoanable
        interface ILoanable
        {
            void ApplyForLoan(double amount);
            bool CalculateLoanEligibility();
        }

        // Abstract Class BankAccount
        abstract class BankAccount
        {
            private int accountNumber;
            private string holderName;
            protected double balance;

            public int AccountNumber
            {
                get { return accountNumber; }
            }

            public string HolderName
            {
                get { return holderName; }
            }

            protected BankAccount(int accountNumber, string holderName, double balance)
            {
                this.accountNumber = accountNumber;
                this.holderName = holderName;
                this.balance = balance;
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited: {amount}");
                }
            }

            public virtual void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }

            public abstract double CalculateInterest();

            public void DisplayDetails()
            {
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Holder Name: {holderName}");
                Console.WriteLine($"Balance: {balance}");
            }
        }

        // Savings Account Derived Class
        class SavingsAccount : BankAccount, ILoanable
        {
            private double InterestRate = 0.06;

            public SavingsAccount(int accNo, string name, double balance)
                : base(accNo, name, balance)
            {
            }

            public override double CalculateInterest()
            {
                return balance * InterestRate;
            }

            public void ApplyForLoan(double amount)
            {
                Console.WriteLine($"Loan applied for: {amount}");
            }

            public bool CalculateLoanEligibility()
            {
                return balance >= 50000;
            }
        }

        // Current Account Derived Class
        class CurrentAccount : BankAccount
        {
            private double InterestRate = 0.03;

            public CurrentAccount(int accNo, string name, double balance)
                : base(accNo, name, balance)
            {
            }

            public override double CalculateInterest()
            {
                return balance * InterestRate;
            }

            public override void Withdraw(double amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn with overdraft: {amount}");
            }
        }
    }
}
