using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class InventoryManagementSystem
    {
        static void Main()
        {
            Inventory inventory = new Inventory();

            inventory.AddAtBeginning(101, "Mouse", 15, 800);
            inventory.AddAtEnd(102, "Keyboard", 7, 1900);
            inventory.AddAtPosition(2, 103, "Monitor", 5, 8600);

            Console.WriteLine("Inventory List:");
            inventory.DisplayAll();

            Console.WriteLine("Search Item by ID:");
            inventory.SearchByItemId(102);

            Console.WriteLine("Update Quantity:");
            inventory.UpdateQuantity(101, 15);

            Console.WriteLine("Total Inventory Value:");
            inventory.CalculateTotalValue();

            Console.WriteLine("Sort by Price (Descending):");
            inventory.Sort("price", false);
            inventory.DisplayAll();

            Console.WriteLine("Remove Item:");
            inventory.RemoveByItemId(103);
            inventory.DisplayAll();
        }
    }
    // Item class (Node)
    class Item
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;
        public Item Next;

        public Item(int itemId, string itemName, int quantity, double price)
        {
            ItemId = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }

    // Singly Linked List class
    class Inventory
    {
        private Item head;

        // Add at beginning
        public void AddAtBeginning(int id, string name, int qty, double price)
        {
            Item newItem = new Item(id, name, qty, price);
            newItem.Next = head;
            head = newItem;
        }

        // Add at end
        public void AddAtEnd(int id, string name, int qty, double price)
        {
            Item newItem = new Item(id, name, qty, price);

            if (head == null)
            {
                head = newItem;
                return;
            }

            Item temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newItem;
        }

        // Add at specific position (1-based)
        public void AddAtPosition(int position, int id, string name, int qty, double price)
        {
            if (position <= 1)
            {
                AddAtBeginning(id, name, qty, price);
                return;
            }

            Item temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            Item newItem = new Item(id, name, qty, price);
            newItem.Next = temp.Next;
            temp.Next = newItem;
        }

        // Remove by Item ID
        public void RemoveByItemId(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            if (head.ItemId == id)
            {
                head = head.Next;
                Console.WriteLine("Item removed successfully.");
                return;
            }

            Item temp = head;
            while (temp.Next != null && temp.Next.ItemId != id)
                temp = temp.Next;

            if (temp.Next == null)
                Console.WriteLine("Item not found.");
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Item removed successfully.");
            }
        }

        // Update quantity by Item ID
        public void UpdateQuantity(int id, int newQty)
        {
            Item temp = head;

            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    temp.Quantity = newQty;
                    Console.WriteLine("Quantity updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Item not found.");
        }

        // Search by Item ID
        public void SearchByItemId(int id)
        {
            Item temp = head;

            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    DisplayItem(temp);
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Item not found.");
        }

        // Search by Item Name
        public void SearchByItemName(string name)
        {
            Item temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayItem(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Item not found.");
        }

        // Calculate total inventory value
        public void CalculateTotalValue()
        {
            double total = 0;
            Item temp = head;

            while (temp != null)
            {
                total += temp.Price * temp.Quantity;
                temp = temp.Next;
            }

            Console.WriteLine($"Total Inventory Value: ₹{total}");
        }

        // Sort inventory
        public void Sort(string criteria, bool ascending = true)
        {
            if (head == null) return;

            for (Item i = head; i.Next != null; i = i.Next)
            {
                for (Item j = i.Next; j != null; j = j.Next)
                {
                    bool condition = false;

                    if (criteria == "name")
                        condition = ascending
                            ? string.Compare(i.ItemName, j.ItemName) > 0
                            : string.Compare(i.ItemName, j.ItemName) < 0;

                    else if (criteria == "price")
                        condition = ascending
                            ? i.Price > j.Price
                            : i.Price < j.Price;

                    if (condition)
                        Swap(i, j);
                }
            }

            Console.WriteLine("Inventory sorted successfully.");
        }

        // Swap item data
        private void Swap(Item a, Item b)
        {
            (a.ItemId, b.ItemId) = (b.ItemId, a.ItemId);
            (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
            (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
            (a.Price, b.Price) = (b.Price, a.Price);
        }

        // Display all items
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Item temp = head;
            while (temp != null)
            {
                DisplayItem(temp);
                temp = temp.Next;
            }
        }

        // Display method
        private void DisplayItem(Item item)
        {
            Console.WriteLine(
                $"ID: {item.ItemId}, Name: {item.ItemName}, Qty: {item.Quantity}, Price: ₹{item.Price}"
            );
        }
    }
}
