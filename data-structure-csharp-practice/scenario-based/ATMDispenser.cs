using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based
{
    /// <summary>
    /// The Program ATM Dispenser is used to perform function of dispensing notes out of ATM for a desired amount.
    /// It Has 3 Scenario's 
    /// 1. The Dispense Amount contains 500 Rs notes
    /// 2. The Dispense Amount Does Not Contains 500 Rs notes.
    /// 3. If The Amount is something that is not reached by the notes you own then it will show you the nearest amount you can reach.
    /// 
    /// version - 1.0
    /// </summary>
    internal class ATMDispenser
    {
        // Creating a notes array that holds all available notes value
        static int[] notes = {1, 2, 5, 10, 20, 50, 100, 200, 500};
        // Creating a quantity array to hold corresponding notes quantity for a user.
        static int[] quantity;

        // Main Function that provides a starting point for the program
        static void Main(string[] args)
        {
            ATMDispenser Atm = new ATMDispenser();
            Atm.ATMMenu();

        }

        // ATM Menu Function that displays the entire menu.
        void ATMMenu()
        {
            // Input Money Function is called to take user input for the amount of notes they have in the bank.
            InputMoney();

            // Taking Input for the amount the user wants to take out.
            Console.Write("Enter The Amount you want to take out : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("====ATM Menu====");
                Console.WriteLine("1. Dispense Counting RS 500 Note.");
                Console.WriteLine("2. Dispense Without Counting RS 500 Note.");
                Console.WriteLine("3. Exit The ATM");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Dispense(amount);
                        break;
                    case 2:
                        DispenseWithout500(amount);
                        break;
                    case 3:
                        Console.WriteLine("Exiting The ATM");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }

        // Input Money Function that initialized the quantity array and take user input
        void InputMoney()
        {
            quantity = new int[notes.Length];
            for(int i=0;i<notes.Length;i++)
            {
                Console.Write($"Enter number of Rs{notes[i]} notes : ");
                quantity[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Dispense Function that dispense the amount of asks including 500 Rs notes
        void Dispense(int amount)
        {
            // Initializing a dictionary to store the dispense amount with their quantity
            Dictionary<int,int> disp = new Dictionary<int,int>();
            
            // Storing the amount into a temporary variable total.
            int total = amount;

            for(int i = notes.Length-1; i >= 0; i--)
            {
                // Checking if The Total Amount is greater than note value and we have that note in the bank
                if (total >= notes[i] && quantity[i]>0)
                {
                    // Taking the minimum of quantity or count of notes
                    int count = Math.Min(total / notes[i], quantity[i]);
                    total -= count * notes[i];
                    quantity[i] -= count;

                    if(count > 0)
                    {
                        disp.Add(notes[i], count);
                    }
                }
            }

            // FallBack Function where if amount is not reached it gives the nearest amount.
            if (total != 0)
            {
                Console.WriteLine("\n Exact amount cannot be dispensed");
                Console.WriteLine($"Remaining amount: {total}");
                Console.WriteLine($"Nearest payable amount: {amount - total}");
                return;
            }

            Console.WriteLine("\nDispensed Notes:");
            foreach (var item in disp)
                Console.WriteLine($"{item.Key} x {item.Value}");
            Console.WriteLine($"Total Amount dispensed is : {amount}");
        }

        static void DispenseWithout500(int amount)
        {
            Dictionary<int, int> disp = new Dictionary<int, int>();
            int total = amount;
            for (int i = notes.Length - 2; i >= 0; i--)
            {
                if (total >= notes[i] && quantity[i] > 0)
                {
                    int count = Math.Min(total / notes[i], quantity[i]);
                    total -= count * notes[i];
                    quantity[i] -= count;

                    if (count > 0)
                    {
                        disp.Add(notes[i], count);
                    }
                }
            }
            if (total != 0)
            {
                Console.WriteLine("\n Exact amount cannot be dispensed");
                Console.WriteLine($"Remaining amount: {total}");
                Console.WriteLine($"Nearest payable amount: {amount - total}");
                return;
            }

            Console.WriteLine("\nDispensed Notes:");
            foreach (var item in disp)
                Console.WriteLine($"{item.Key} x {item.Value}");
            Console.WriteLine($"Total Amount dispensed is : {amount}");
        }
    }
}
