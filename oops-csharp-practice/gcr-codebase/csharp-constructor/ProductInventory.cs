using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class ProductInventory
    {
        // Instance variables
        string productName;
        double price;

        // Class variable that is shared among all objects
        static int totalProducts = 0;

        // Parameterized Constructor
        public ProductInventory(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        // Instance method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Price        : {price}");
        }

        // Class method to display total products
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created : {totalProducts}");
        }

        static void Main()
        {
            ProductInventory p1 = new ProductInventory("Laptop", 55000);
            ProductInventory p2 = new ProductInventory("Keyboard", 800);

            Console.WriteLine("Product 1 Details");
            p1.DisplayProductDetails();

            Console.WriteLine();

            Console.WriteLine("Product 2 Details");
            p2.DisplayProductDetails();

            Console.WriteLine();

            ProductInventory.DisplayTotalProducts();
        }
    }
}
