using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_generics.DynamicOnlineMarketPlace
{
    // CATEGORY INTERFACE
    public interface ICategory
    {
        string CategoryName { get; }
    }

    public class BookCategory : ICategory
    {
        public string CategoryName => "Books";
    }

    public class ClothingCategory : ICategory
    {
        public string CategoryName => "Clothing";
    }

    // GENERIC PRODUCT CLASS
    public class Product<TCategory> where TCategory : ICategory
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public TCategory Category { get; private set; }

        public Product(string name, double price, TCategory category)
        {
            ProductName = name;
            Price = price;
            Category = category;
        }

        public void Display()
        {
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Category     : " + Category.CategoryName);
            Console.WriteLine("Price        : " + Price);
        }
    }

    // GENERIC METHOD 
    public class DiscountService
    {
        public static void ApplyDiscount<TCategory>(
            Product<TCategory> product,
            double percentage)
            where TCategory : ICategory
        {
            if (percentage <= 0 || percentage >= 100)
            {
                Console.WriteLine("Invalid discount percentage");
                return;
            }

            product.Price -= product.Price * (percentage / 100);
            Console.WriteLine($"Discount Applied: {percentage}%");
        }
    }

    // MAIN
    class Program
    {
        static void Main()
        {
            Product<BookCategory> book =
                new Product<BookCategory>("Clean Code", 599, new BookCategory());

            Product<ClothingCategory> shirt =
                new Product<ClothingCategory>("T-Shirt", 999, new ClothingCategory());

            book.Display();
            Console.WriteLine();
            DiscountService.ApplyDiscount(book, 10);
            book.Display();

            Console.WriteLine();

            shirt.Display();
            Console.WriteLine();
            DiscountService.ApplyDiscount(shirt, 20);
            shirt.Display();

            Console.ReadKey();
        }
    }
}
