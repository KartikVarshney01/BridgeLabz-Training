using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    /// <summary>
    /// The Program helps in our understanding of encapsulation, abstraction, and interface.
    /// The program is of product and their discount with tax applied on them and providing final price
    /// 
    /// version - 1.0
    /// </summary>
    internal class ECommercePlatform
    {
        static void Main(String[] args)
        {
            Product[] products = new Product[3];

            products[0] = new Electronics(1526, "TV", 5200);
            products[1] = new Clothing(2651, "TShirt", 750);
            products[2] = new Groceries(1501, "Wheat", 780);

            DisplayFinalPrice(products);
        }

        // Display Final Price function for displaying and calculating the final price after tax and discount
        static void DisplayFinalPrice(Product[] products)
        {
            foreach (Product product in products)
            {
                double discount = product.CalculateDiscount();
                double tax = 0;

                if (product is ITaxable taxable)
                {
                    tax = taxable.CalculateTax();
                    Console.Write(((ITaxable)product).GetTaxDetails());
                }

                double finalPrice = product.Price + tax - discount;

                product.DisplayProduct();
                Console.WriteLine("Discount    : " + discount);
                Console.WriteLine("Tax         : " + tax);
                Console.WriteLine("Final Price : " + finalPrice);
                Console.WriteLine();
            }
        }
    }

    // Interface ITaxable
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    // Abstract Class Product containing product details
    abstract class Product
    {
        private int productId;
        private string productName;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(int productId, string productName, double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        public abstract double CalculateDiscount();

        public void DisplayProduct()
        {
            Console.WriteLine($"Product Id : {productId}");
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Product Price : {price}");
        }
    }

    // Derived Class Electronics 
    class Electronics : Product, ITaxable
    {
        public Electronics(int productId, string productName, double price)
            : base(productId, productName, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.20;
        }

        public string GetTaxDetails()
        {
            return "Electronics Tax : 20% GST";
        }
    }

    // Derived Class Clothing
    class Clothing : Product, ITaxable
    {
        public Clothing(int productId, string productName, double price) : base(productId, productName, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }

        public double CalculateTax()
        {
            return Price * 0.06;
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax : 6% GST";
        }
    }

    // Derived Class Groceries
    class Groceries : Product
    {
        public Groceries(int productId, string productName, double price) : base(productId, productName, price)
        {

        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}
