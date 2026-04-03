using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class BankManagerAndMathUtility
    {
        /* The program does two different functions 1. Bank Manager And 2.Mathematical Utility
         * 1. The Bank Manager Part does the work of a bank with it is helps in checking for manager and user
         * and then helps in creating user accounts and depositing,withdrawing and viewing a user account, it
         * also have only  manager access and user access.
         * 2. The mathematical utility is helpful in providing some math function for quick task of
         * finding factorial, checking prime, gcd of two numbers and nth fibonacci number
         * 
         * version - 1.0
         */

        // Bank Class for bank/branch data
        class Bank   
        {
            // Static ID created for branches
            static int nextId = 1001;
            // Minimum balance variable
            public static int minBalance = 2000;
            // static Bank name as it is shared
            static string bankName = "National Bank";
            // Account Capacity variable for Maximum accounts allowed
            public int accountCapacity = 0;
            // Current active accounts variable
            public int activeAccount = 0;
            // Creating an Array for users
            public User[] users;                
            public string branchName;            
            public string branchId;

            // Bank Parameterized constructor
            public Bank(string branchName, int capacity) 
            {
                this.branchName = branchName;    
                this.accountCapacity = capacity;
                // Initializing user array
                users = new User[capacity];
                // Creating branch ID
                this.branchId = "B" + nextId;    
                nextId++;                        
            }

            // Function Show Branch Details to Display branch information
            public void ShowBranchDetails()      
            {
                Console.WriteLine($"\nBank Name  : {bankName}");
                Console.WriteLine($"Branch Name: {branchName}");
                Console.WriteLine($"Branch ID  : {branchId}");
            }
        }

        // Manager class to control banking operations
        class Manager   
        {
            // Static ID for manager
            static int nextId = 101;
            // Reference to bank
            private Bank bank;              
            private string managerName;    
            private string managerId;      
            private int managerPassword;

            // Manager Parameterized constructor
            public Manager(string name, int pass, Bank b) 
            {
                managerName = name;         
                managerPassword = pass;     
                bank = b;      
                // Creating Manager ID
                managerId = "M" + nextId;   
                nextId++;                   
            }

            //Function Login to check for Manager Login
            public bool Login(int pass)     
            {
                if (pass == managerPassword)
                {
                    Console.WriteLine("Login Successful!");
                    return true;
                }
                return false;
            }

            // Function Create New Account helps in Creating new user account
            public void CreateNewAccount()  
            {
                // Checking if bank has capacity for a new account or not.
                if (bank.activeAccount >= bank.accountCapacity)
                {
                    Console.WriteLine("------ Bank Capacity is full -----");
                    return;
                }

                Console.Write("Enter User Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter PIN: ");
                int pin = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Initial Amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount < Bank.minBalance)
                {
                    Console.WriteLine($"Opening balance must be at least {Bank.minBalance}");
                    return;
                }

                // Creating user
                User newUser = new User(name, pin, amount, bank.branchId);
                // Storing user
                bank.users[bank.activeAccount] = newUser;  
                // Increaing Active Account Count
                bank.activeAccount++;                                      

                Console.WriteLine("\n--- New User Registered Successfully ---");
                newUser.ViewAccount();                                    
            }

            // Function to View account details
            public void ViewAccount(string accId)
            {
                User user = FindAccount(accId);
                if (user == null) return;

                user.ViewAccount();
            }

            // Function Find Account to Search user by account ID
            public User FindAccount(string accId)  
            {
                for (int i = 0; i < bank.activeAccount; i++)
                {
                    if (bank.users[i].accountId.Equals(accId))
                    {
                        return bank.users[i];
                    }
                }

                Console.WriteLine("--- User Not Found ---");
                return null;
            }

            // Function Deposit Money to helps in depositing money
            public void DepositMoney(string accId, int amnt) 
            {
                User user = FindAccount(accId);
                if (user == null) return;

                user.DepositMoney(amnt);
            }

            // Function WithDraw Money to helps in withdrawal of money from account
            public void WithdrawMoney(string accId, int amnt) 
            {
                User user = FindAccount(accId);
                if (user == null) return;

                if (amnt <= user.accountAmount && user.accountAmount - amnt >= Bank.minBalance)
                {
                    user.accountAmount -= amnt;
                    Console.WriteLine("Amount Withdrawn Successfully");
                }
                else
                {
                    Console.WriteLine("Minimum balance condition not reached.");
                }
            }
        }

        // User class representing a bank customer or user
        class User   
        {
            private static int nextId = 101; 
            public string userName;          
            public string accountId;         
            private int accountPIN;          
            string branchId;                 
            public int accountAmount = 0;

            // User constructor
            public User(string name, int pin, int amount, string branchId) 
            {
                userName = name;             
                accountPIN = pin;            
                this.branchId = branchId;    

                accountId = "U" + nextId;    
                accountAmount = amount;      
                nextId++;                    
            }

            // Function login check for user 
            public bool Login(int pin)       
            {
                if (pin == accountPIN)
                {
                    Console.WriteLine("Login Successful!");
                    return true;
                }

                Console.WriteLine("Wrong PIN!");
                return false;
            }

            // Function View Account to help in Display user details
            public void ViewAccount()        
            {
                Console.WriteLine("\n----- User Details -----");
                Console.WriteLine("Name      : " + userName);
                Console.WriteLine("AccountId : " + accountId);
                Console.WriteLine("Balance   : " + accountAmount);
                Console.WriteLine("------------------------");
            }

            public void DepositMoney(int amnt)
            {
                if (amnt <= 0) return;
                accountAmount += amnt;
                Console.WriteLine("Amount Deposited Successfully");
            }

            public void WithdrawMoney(int amnt)
            {
                if (accountAmount - amnt >= Bank.minBalance)
                {
                    accountAmount -= amnt;
                    Console.WriteLine("Amount Withdrawn Successfully");
                }
                else
                {
                    Console.WriteLine("Minimum balance condition not satisfied");
                }
            }
        }

        // Utility class for math operations
        class MathematicalUtility 
        {
            // Function for Factorial calculation
            public static long FactorialFun(int num) 
            {
                if (num < 0) return -1;
                if (num == 0) return 1;
                return num * FactorialFun(num - 1);
            }

            // Function to check whether a number is Prime or not.
            public static bool PrimeFun(int num) 
            {
                if (num == 0 || num == 1) return false;
                for (int i = 2; i * i <= num; i++)
                    if (num % i == 0) return false;
                return true;
            }

            // Recursive Function to find GCD 
            public static int GCDFun(int a, int b) 
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                if (b == 0) return a;
                return GCDFun(b, a % b);
            }

            // Function for Fibonacci calculation and finding nth fibonacci number
            public static int FibonacciFun(int n) 
            {
                if (n < 0) return -1;
                if (n == 0) return 0;
                if (n == 1) return 1;

                int a = 0, b = 1, c = 0;
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }

            // Function to start Math utility menu
            public static void RunMathUtility() 
            {
                while (true)
                {
                    Console.WriteLine("\n---- MATH UTILITY ----");
                    Console.WriteLine("1. Factorial Of A Number");
                    Console.WriteLine("2. Prime Check For A Number");
                    Console.WriteLine("3. GCD Of Two Numbers");
                    Console.WriteLine("4. Fibonacci Number At Nth Place");
                    Console.WriteLine("5. Back To Main Menu");
                    Console.Write("Enter Your Choice : ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter number : ");
                            int factNum = Convert.ToInt32(Console.ReadLine());
                            long factorial = FactorialFun(factNum);
                            Console.WriteLine(factorial == -1
                                ? "Invalid Numebr" : $"Result = {factorial}");
                            break;

                        case 2:
                            Console.Write("Enter a number : ");
                            int primeNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(PrimeFun(primeNum) ? "Prime Number" : "Not Prime Number");
                            break;

                        case 3:
                            Console.Write("Enter Number 1st : ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Number 2nd : ");
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("GCD = " + GCDFun(num1, num2));
                            break;

                        case 4:
                            Console.Write("Enter Nth Number : ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Result = " + FibonacciFun(n));
                            break;

                        case 5:
                            Console.WriteLine("Returning To Main Menu");
                            return;

                        default:
                            Console.WriteLine("Invalid Choice! Choose between 1-5");
                            break;
                    }
                }
            }
        }

        // Main Program Entry point
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.WriteLine("\n========= MAIN MENU =========");
                Console.WriteLine("1. Banking System");
                Console.WriteLine("2. Mathematical Utility");
                Console.WriteLine("3. Exit The Program");
                Console.Write("Enter Your Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RunBankingSystem();
                        break;

                    case 2:
                        MathematicalUtility.RunMathUtility();
                        break;

                    case 3:
                        Console.WriteLine("Program Closed Successfully.");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice! Choose between 1-3");
                        break;
                }
            }
        }
        static void RunBankingSystem()
        {
            // Taking User Input
            Console.Write("Enter Branch Name: ");          
            string branchname = Console.ReadLine();

            Console.Write("Enter Bank Capacity: ");        
            int capacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Minimum Balance: ");      
            Bank.minBalance = Convert.ToInt32(Console.ReadLine());

            Bank bank = new Bank(branchname, capacity);               
            bank.ShowBranchDetails();                       

            Console.Write("Enter Manager Name: ");         
            string managerName = Console.ReadLine();

            Console.Write("Set Manager Password: ");        
            int managerPass = Convert.ToInt32(Console.ReadLine());

            // Creating manager object
            Manager manager = new Manager(managerName, managerPass, bank);

            // Infinite While loop for role selection in bank class
            while (true)                                   
            {
                Console.WriteLine("\nChoose Role");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Back");
                Console.Write("Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        RunManagerMenu(manager);          
                        break;

                    case 2:
                        RunUserMenu(manager);         
                        break;

                    case 3:
                        Console.WriteLine("Returning Back");
                        return;                             

                    default:
                        Console.WriteLine("Invalid Choice! Choose between 1-3");
                        break;
                }
            }
        }

        static void RunManagerMenu(Manager manager)
        {
            int tries = 3;                                  
            bool isLoggedCheck = false;                       

            while (tries-- > 0)                            
            {
                Console.Write("Enter Manager Password: ");
                int pass = Convert.ToInt32(Console.ReadLine());

                if (manager.Login(pass))                    
                {
                    isLoggedCheck = true;                      
                    break;
                }
                Console.WriteLine("Wrong password. Remaining: " + tries);
            }

            while (isLoggedCheck)                           
            {
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. View Account");
                Console.WriteLine("5. Logout");
                Console.Write("Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        manager.CreateNewAccount();          
                        break;

                    case 2:
                        Console.Write("Enter Account ID: ");
                        string amount = Console.ReadLine();
                        Console.Write("Enter Amount: ");
                        manager.DepositMoney(amount, Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Enter Account ID: ");
                        string withdrawAmount = Console.ReadLine();
                        Console.Write("Enter Amount: ");
                        manager.WithdrawMoney(withdrawAmount, Convert.ToInt32(Console.ReadLine())); 
                        break;

                    case 4:
                        Console.Write("Enter Account ID: ");
                        manager.ViewAccount(Console.ReadLine()); 
                        break;

                    case 5:
                        Console.WriteLine("Manager Logged Out");
                        isLoggedCheck = false;                 
                        break;

                    default:
                        Console.WriteLine("Invalid Choice"); 
                        break;
                }
            }
        }

        static void RunUserMenu(Manager manager)
        {
            Console.Write("Enter Account ID: ");             
            string id = Console.ReadLine();

            User user = manager.FindAccount(id);             
            if (user == null) return;                        

            bool isLoggedCheck = false;                         

            for (int i = 3; i > 0; i--)                      
            {
                Console.Write("Enter PIN: ");
                if (user.Login(Convert.ToInt32(Console.ReadLine()))) 
                {
                    isLoggedCheck = true;                       
                    break;
                }
                Console.WriteLine("Wrong PIN. Remaining: " + (i - 1));
            }

            while (isLoggedCheck)                               
            {
                Console.WriteLine("\n1. View Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Logout");
                Console.Write("Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        user.ViewAccount();                 
                        break;

                    case 2:
                        Console.Write("Enter Amount: ");
                        user.DepositMoney(Convert.ToInt32(Console.ReadLine())); 
                        break;

                    case 3:
                        Console.Write("Enter Amount: ");
                        user.WithdrawMoney(Convert.ToInt32(Console.ReadLine())); 
                        break;

                    case 4:
                        Console.WriteLine("User Logged Out");
                        isLoggedCheck = false;                
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Choose between 1-4."); 
                        break;
                }
            }
        }
    }
}
