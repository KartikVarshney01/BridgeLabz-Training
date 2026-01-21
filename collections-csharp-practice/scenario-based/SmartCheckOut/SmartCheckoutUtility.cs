using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.SmartCheckOut
{
    internal class SmartCheckoutUtility : ISmartCheckout
    {
        // Stores items for quick lookup using Dictionary
        private Dictionary<string, Item> ItemCatalog;
        // Maintains customers in FIFO order using Queue
        private Queue<Customer> CustomerQueue;
        Random random;

        public SmartCheckoutUtility()
        {
            ItemCatalog = new Dictionary<string, Item>();
            CustomerQueue = new Queue<Customer>();
            random = new Random();
        }

        // Adds items to the supermarket catalog
        public void AddCatalog()
        {
            Console.Write("Enter Number of Items You Want To Add To The Mart : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                Console.Write("Enter Item Name : ");
                string itemName = Console.ReadLine();

                int price = random.Next(10, 1000);

                int quantity = random.Next(1, 500);

                Item item = new Item();
                item.ItemName = itemName;
                item.ItemPrice = price;
                item.AvailableQuantity = quantity;

                if (!ItemCatalog.TryAdd(itemName, item))
                {
                    Console.WriteLine("Item already exists in catalog");
                }
            }
        }

        // Update Or Add New Item To The Catalog
        public void UpdateCatalog()
        {
            Console.Write("Enter Name Of the Item You Want to Add/Update : ");
            string itemName = Console.ReadLine();

            if (!ItemCatalog.ContainsKey(itemName))
            {
                Item item = new Item();
                item.ItemName = itemName;
                item.ItemPrice = random.Next(10,1000);
                item.AvailableQuantity = random.Next(1,500);

                ItemCatalog.Add(itemName, item);
            }
            else
            {
                Console.WriteLine("item Already In Mart");
                Console.WriteLine("Updating Item Info");
                ItemCatalog[itemName].ItemPrice = random.Next(10, 1000);
                ItemCatalog[itemName].AvailableQuantity = random.Next(1, 500);
            }
        }

        // Remove An Item From The Catalog
        public void RemoveItem()
        {
            Console.Write("Enter Item Name To Remove : ");
            string itemName = Console.ReadLine();

            if (ItemCatalog.Remove(itemName))
            {
                Console.WriteLine("Item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item not found in catalog.");
            }
        }

        // Adds a customer and selected items to the queue
        public void AddCustomer()
        {
            Console.Write("Enter Number of Items Customer Wants To Buy : ");
            int itemNum = Convert.ToInt32(Console.ReadLine());

            Customer newCustomer = new Customer();

            for (int i = 0; i < itemNum; i++)
            {
                Console.Write("Enter Item Name : ");
                string itemName = Console.ReadLine();

                Console.Write("Enter Quantity Required : ");
                int qtyRequired = Convert.ToInt32(Console.ReadLine());

                if (!ItemCatalog.ContainsKey(itemName))
                {
                    Console.WriteLine("Item not available in mart.");
                    i--;
                    continue;
                }

                Item catalogItem = ItemCatalog[itemName];

                if (catalogItem.AvailableQuantity < qtyRequired)
                {
                    Console.WriteLine("Insufficient stock.");
                    i--;
                    continue;
                }

                // Create purchased item copy
                Item purchasedItem = new Item();
                purchasedItem.ItemName = catalogItem.ItemName;
                purchasedItem.ItemPrice = catalogItem.ItemPrice;
                purchasedItem.AvailableQuantity = qtyRequired;

                newCustomer.CustomerItemList.Add(purchasedItem);

                // Reduce stock from catalog
                catalogItem.AvailableQuantity -= qtyRequired;
            }

            CustomerQueue.Enqueue(newCustomer);
            Console.WriteLine("Customer added to checkout queue.");
        }

        // Processes billing for the first customer in queue
        public void Checkout()
        {
            if(CustomerQueue.Count == 0)
            {
                Console.WriteLine("Custome Queue is Empty.");
                return;
            }
            Customer checkoutCustomer = CustomerQueue.Dequeue();
            Console.WriteLine("\n----- CHECKOUT BILL -----");
            Console.WriteLine("Customer ID : " + checkoutCustomer.CustomerId);
            Console.WriteLine("-------------------------");


            int totalAmount = 0;

            foreach (Item item in checkoutCustomer.CustomerItemList)
            {
                int itemTotal = item.ItemPrice * item.AvailableQuantity;
                totalAmount += itemTotal;

                Console.WriteLine(
                    "Item : " + item.ItemName +
                    ", Price : " + item.ItemPrice +
                    ", Quantity : " + item.AvailableQuantity +
                    ", Total : " + itemTotal
                );
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("TOTAL BILL AMOUNT : " + totalAmount);
            Console.WriteLine("Checkout completed.\n");
        }

        // Displays all available items and stock
        public void DisplayCatalog()
        {
            if (ItemCatalog.Count == 0)
            {
                Console.WriteLine("Catalog is empty.");
                return;
            }

            Console.WriteLine("\n----- ITEM CATALOG -----");

            foreach (KeyValuePair<string, Item> entry in ItemCatalog)
            {
                Item item = entry.Value;

                Console.WriteLine(
                    "Item ID : " + item.ItemId +
                    ", Name : " + item.ItemName +
                    ", Price : " + item.ItemPrice +
                    ", Available Qty : " + item.AvailableQuantity
                );
            }

            Console.WriteLine("------------------------\n");
        }
    }
}
