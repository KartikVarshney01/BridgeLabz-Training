using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class ShoppingCart
    {
        // static variable shared by all products
        public static double Discount = 0.0;

        // readonly variable
        public readonly int ProductID;

        // instance variables
        public string ProductName;
        public double Price;
        public int Quantity;

        // constructor 
        public ShoppingCart(int ProductID, string ProductName, double Price, int Quantity)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        // static method to update the discount percentage
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        // Display Method
        public static void Display(object obj)
        {
            if (obj is ShoppingCart cart)
            {
                Console.WriteLine("Product ID   : " + cart.ProductID);
                Console.WriteLine("Name         : " + cart.ProductName);
                Console.WriteLine("Price        : " + cart.Price);
                Console.WriteLine("Quantity     : " + cart.Quantity);
                Console.WriteLine("Discount %   : " + Discount);
            }
            else
            {
                Console.WriteLine("Invalid Product Object");
            }
        }

        static void Main(String[] args)
        {
            ShoppingCart.UpdateDiscount(10.0);
            Console.WriteLine("Current Discount: " + ShoppingCart.Discount + "%\n");

            ShoppingCart c1 = new ShoppingCart(1512, "Wireless Mouse", 999.0, 6);
            ShoppingCart c2 = new ShoppingCart(1082, "USB-C Cable", 199.0, 5);

            ShoppingCart.Display(c1);
            Console.WriteLine();

            ShoppingCart.Display(c2);
            Console.WriteLine();
        }
    }

}
