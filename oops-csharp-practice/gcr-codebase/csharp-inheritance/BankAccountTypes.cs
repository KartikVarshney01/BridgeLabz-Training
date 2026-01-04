using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class BankAccountTypes
    {
        static void Main(String[] args)
        {
            SavingsAccount sa = new SavingsAccount(101, 50000, 4.5);
            CheckingAccount ca = new CheckingAccount(102, 30000, 10000);
            FixedDepositAccount fd = new FixedDepositAccount(103, 200000, 24);

            sa.DisplayAccountType();
            Console.WriteLine();

            ca.DisplayAccountType();
            Console.WriteLine();

            fd.DisplayAccountType();
        }
    }
    class BankAccount
    {
        public int AccountNumber;
        public double Balance;

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public SavingsAccount(int accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type : Savings Account");
            Console.WriteLine("Account No   : " + AccountNumber);
            Console.WriteLine("Balance      : " + Balance);
            Console.WriteLine("InterestRate : " + InterestRate + "%");
        }
    }

    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type    : Checking Account");
            Console.WriteLine("Account No      : " + AccountNumber);
            Console.WriteLine("Balance         : " + Balance);
            Console.WriteLine("Withdraw Limit  : " + WithdrawalLimit);
        }
    }

    class FixedDepositAccount : BankAccount
    {
        public int LockInPeriod;

        public FixedDepositAccount(int accountNumber, double balance, int lockInPeriod) : base(accountNumber, balance)
        {
            LockInPeriod = lockInPeriod;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type : Fixed Deposit Account");
            Console.WriteLine("Account No   : " + AccountNumber);
            Console.WriteLine("Balance      : " + Balance);
            Console.WriteLine("Lock Period  : " + LockInPeriod + " months");
        }
    }
}
