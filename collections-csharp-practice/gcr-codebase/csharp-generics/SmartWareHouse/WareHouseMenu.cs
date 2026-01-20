using BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal class WareHouseMenu
    {
        private IWarehouse<Electronics> electronicsStorage =
        new Storage<Electronics>();

        private IWarehouse<Groceries> groceriesStorage =
            new Storage<Groceries>();

        private IWarehouse<Furniture> furnitureStorage =
            new Storage<Furniture>();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n===== Smart Warehouse Management System =====");
                Console.WriteLine("1. Add Electronics");
                Console.WriteLine("2. Add Groceries");
                Console.WriteLine("3. Add Furniture");
                Console.WriteLine("4. Display Electronics");
                Console.WriteLine("5. Display Groceries");
                Console.WriteLine("6. Display Furniture");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: AddElectronics(); break;
                    case 2: AddGroceries(); break;
                    case 3: AddFurniture(); break;
                    case 4: electronicsStorage.DisplayAllItems(); break;
                    case 5: groceriesStorage.DisplayAllItems(); break;
                    case 6: furnitureStorage.DisplayAllItems(); break;
                    case 0: Console.WriteLine("Exiting system..."); return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        private void AddElectronics()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Warranty (years): ");
            int warranty = Convert.ToInt32(Console.ReadLine());

            electronicsStorage.AddItem(new Electronics(name, qty, warranty));
            Console.WriteLine("Electronics added successfully!");
        }

        private void AddGroceries()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Expiry Date: ");
            int expiry = Convert.ToInt32(Console.ReadLine());

            groceriesStorage.AddItem(new Groceries(name, qty, expiry));
            Console.WriteLine("Groceries added successfully!");
        }

        private void AddFurniture()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Material: ");
            string material = Console.ReadLine();

            furnitureStorage.AddItem(new Furniture(name, qty, material));
            Console.WriteLine("Furniture added successfully!");
        }
    }
}

