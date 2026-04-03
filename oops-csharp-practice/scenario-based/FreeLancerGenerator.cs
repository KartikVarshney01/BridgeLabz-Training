using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    /* Free Lancer Generator Program helps to perform functions of 
     * 1. Taking Invoice or order details with tasks and their amount (Logo Design - 3000 INR, Web Make - 4500 INR)
     * 2. Separate these into tasks and their amount.
     * 3. Calculate their total amount.
     * 4. Print the Generated Invoice
     * 
     * version - 1.0
     */
    internal class FreeLancerGenerator
    {
        // non-static arrays to store tasks and amount
        public string[] tasks;
        public int[] amounts;

        // Function to the start menu
        void GeneratorStart()
        {
            // Infinite while loop for menu reappearing
            while (true)
            {
                Console.WriteLine("====Start Menu====");
                Console.WriteLine("1. Taking Invoice");
                Console.WriteLine("2. Calculating Invoice");
                Console.WriteLine("3. Display Invoice");
                Console.WriteLine("4. Program Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InvoiceInput();
                        break;
                    case 2:
                        GetTotalAmount();
                        break;
                    case 3:
                        DisplayInvoice();
                        break;
                    case 4:
                        Console.WriteLine("The Program has Ended");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice! Choose between 1-4.");
                        break;
                }
            }
        }

        // method to take user input for the invoice
        void InvoiceInput()
        {
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();
            SplitTaskAndAmount(s);
        }

        // function to take the user inputted invoice and separating it into tasks and amount.
        void SplitTaskAndAmount(string s)
        {
            // Creating temp array to store initial split and get the tasks and amount array size
            string[] temp = s.Split(',');

            tasks = new string[temp.Length];
            amounts = new int[temp.Length];

            // For loop to assign tasks and amount to their respective arrays
            for (int i = 0; i < temp.Length; i++)
            {
                // Creating a temp 2 array to further break the tasks form their amounts.
                string[] temp2 = temp[i].Trim().Split('-');

                tasks[i] = temp2[0].Trim();
                amounts[i] = Convert.ToInt32(temp2[1].Trim().Split(' ')[0]);
            }
        }

        // method to find the total invoice amount genrated
        void GetTotalAmount()
        {
            // If user has not inputted any invoice. Then returning invalid
            if (amounts == null)
            {
                Console.WriteLine("Invalid! Enter the invoice first.");
                return;
            }
            int totalAmount = 0;
            for (int i = 0; i < amounts.Length; i++)
            {
                totalAmount += amounts[i];
            }
            Console.WriteLine($"Total Amount : {totalAmount}");
        }

        // Method to display the invoice
        void DisplayInvoice()
        {
            if (tasks == null)
            {
                Console.WriteLine("Invalid! No Invoice To Print.");
                return;
            }
            Console.WriteLine("====Invoice Details====");
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"Tasks : {tasks[i]} , Amount : {amounts[i]}");
            }
        }
        static void Main()
        {
            // Creating the Class object to access non-static function
            FreeLancerGenerator invoiceStart = new FreeLancerGenerator();
            invoiceStart.GeneratorStart();
        }
    }
}
