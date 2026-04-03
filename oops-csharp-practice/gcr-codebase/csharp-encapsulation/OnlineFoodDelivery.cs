using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    internal class OnlineFoodDelivery
    {
        static void Main()
        {
            FoodItem[] order = new FoodItem[2];

            order[0] = new VegItem("Paneer", 250, 6);
            order[1] = new NonVegItem("Chicken", 450, 2);

            foreach (FoodItem item in order)
            {
                item.GetItemDetails();
                Console.WriteLine("Total Price: " + item.CalculateTotalPrice());

                if (item is IDiscountable discountItem)
                {
                    Console.WriteLine(discountItem.GetDiscountDetails());
                    Console.WriteLine("Discount Amount: " + discountItem.ApplyDiscount());
                }

                Console.WriteLine();
            }
        }
        // Interface IDiscountable
        interface IDiscountable
        {
            double ApplyDiscount();
            string GetDiscountDetails();
        }

        // Abstract Class FoodItem
        abstract class FoodItem
        {
            private string itemName;
            private double price;
            private int quantity;

            public string ItemName
            {
                get { return itemName; }
            }

            public double Price
            {
                get { return price; }
            }

            public int Quantity
            {
                get { return quantity; }
            }

            protected FoodItem(string itemName, double price, int quantity)
            {
                this.itemName = itemName;
                this.price = price;
                this.quantity = quantity;
            }

            public abstract double CalculateTotalPrice();

            public void GetItemDetails()
            {
                Console.WriteLine($"Item Name: {itemName}");
                Console.WriteLine($"Price: {price}");
                Console.WriteLine($"Quantity: {quantity}");
            }
        }

        // Derived Class Veg Item 
        class VegItem : FoodItem, IDiscountable
        {
            private double DiscountRate = 0.16;

            public VegItem(string name, double price, int qty)
                : base(name, price, qty)
            {
            }

            public override double CalculateTotalPrice()
            {
                return Price * Quantity;
            }

            public double ApplyDiscount()
            {
                return CalculateTotalPrice() * DiscountRate;
            }

            public string GetDiscountDetails()
            {
                return "Veg Item Discount: 10%";
            }
        }

        // Derived Class Non-Veg Item
        class NonVegItem : FoodItem, IDiscountable
        {
            private double ExtraChargeRate = 0.20;
            private double DiscountRate = 0.07;

            public NonVegItem(string name, double price, int qty)
                : base(name, price, qty)
            {
            }

            public override double CalculateTotalPrice()
            {
                double basePrice = Price * Quantity;
                return basePrice + (basePrice * ExtraChargeRate);
            }

            public double ApplyDiscount()
            {
                return CalculateTotalPrice() * DiscountRate;
            }

            public string GetDiscountDetails()
            {
                return "Non-Veg Item Discount: 5%";
            }
        }
    }
}
