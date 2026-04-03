using System;
using System.Collections.Generic;
using System.Net.Quic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    /* The Cafeteria Program to take 10 menu items daily and then display them and taking user input of their 
     * order and showing them.
     * 
     * version - 1.0;
     */
    internal class CafeteriaMenu
    {
        // Initializing menu array to store food items
        string[] menu;

        // Function SetMenuUp to store today's menu items
        void SetMenuUp()
        {
            menu = new string[10];

            Console.WriteLine("--------------------------------");
            Console.WriteLine("SET TODAY'S CAFETERIA MENU");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.Write("Enter Item " + (i + 1) + " : ");
                menu[i] = Console.ReadLine();
            }
        }

        // Function Display Menu for displaying today's menu
        void DisplayMenu()
        {
            if (menu == null)
            {
                Console.WriteLine("Menu is Empty. Wait For menu to set.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("TODAY'S MENU");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + menu[i]);
            }
        }

        // Function Customer Order to store Customer Order and their quantity
        void CustomerOrder()
        {
            // Displaying Today's Menu
            DisplayMenu();

            // Initializing the customerOrder array to store customer order with their quantity.
            int[,] customerOrder = new int[10, 2];
            int idx = 0; // index variable for customer order array

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("PLACE YOUR ORDER");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter 0 To Finalize Your Order");

            while (true)
            {
                // Taking order ID and quantity Input
                Console.Write("Enter Order Id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (id == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("YOUR ORDER HAS BEEN PLACED");
                    Console.WriteLine("--------------------------------");
                    break;
                }

                Console.Write("Enter the Item Quantity : ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                customerOrder[idx, 0] = id - 1;
                customerOrder[idx, 1] = quantity;
                idx++;
            }

            ShowOrder(customerOrder, idx);
        }

        // Function ShowOrder to display the Customer Order 
        void ShowOrder(int[,] customerOrder, int idx)
        {
            if (idx == 0)
            {
                Console.WriteLine("No Order Placed. Please Place Your Order First");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("FINAL ORDER DETAILS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Item Name        Quantity");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < idx; i++)
            {
                Console.WriteLine(menu[customerOrder[i, 0]] + "        " + customerOrder[i, 1]);
            }
        }

        // Function for starting the Cafeteria Function
        void MenuStart()
        {
            Console.WriteLine();
            Console.WriteLine("Set Up Today's Menu");
            SetMenuUp();

            // Infinite While Loop for Options Choosing
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("WELCOME TO THE DELUXE CAFE");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Display Today's Menu");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. Exit Cafeteria");
                Console.Write("Enter Your Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayMenu();
                        break;

                    case 2:
                        CustomerOrder();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("THANK YOU FOR VISITING THE CAFE");
                        Console.WriteLine("--------------------------------");
                        return;

                    default:
                        Console.WriteLine("Choose between 1-3");
                        break;
                }
            }
        }

        static void Main()
        {
            // Creating The Menu Start Object
            CafeteriaMenu start = new CafeteriaMenu();
            start.MenuStart();
        }
    }
}

