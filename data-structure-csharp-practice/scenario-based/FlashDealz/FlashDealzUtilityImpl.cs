using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FlashDealz
{
    // Utility Class Containing The Interface Methods Implementation
    internal class FlashDealzUtilityImpl : IDealz
    {
        // Creating A Products Array.
        private Product[] Products;
        private Random random = new Random();

        // Creating a Discount Variable To Take Min And Max Discount 
        private int MinDiscount;
        private int MaxDiscount;
        public void AddProduct()
        {
            Console.Write("Enter Number of Total Products : ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Min Discount Offered : ");
            int minDis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Max Discount Offered : ");
            int maxDis = Convert.ToInt32(Console.ReadLine());

            Products = new Product[capacity];
            MinDiscount = minDis;
            MaxDiscount = maxDis;

            // Using For Loop To Create Products And Random Method To Get Random Discount Values Between Min And Max
            for(int i = 0; i < capacity; i++)
            {
                Product product = new Product();
                double Discount = random.NextDouble()*(MaxDiscount-MinDiscount)+MinDiscount;
                product.ProductDiscount = Math.Round(Discount, 2);
                Products[i] = product;
            }
            // Calling Display Product
            DisplayProduct();
        }

        // Sort Method To Sort The Products Array Based On Discount Values Using Quick Sort
        public void SortProduct()
        {
            Product[] TempProducts = (Product[])Products.Clone();
            QuickSort(TempProducts, 0, TempProducts.Length - 1);
            DisplayAllProducts(TempProducts);
        }
        private void QuickSort(Product[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(Product[] arr, int low, int high)
        {
            double pivot = arr[high].ProductDiscount;
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j].ProductDiscount < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        // Display All Method To Show All Products
        public void DisplayProduct()
        {
            DisplayAllProducts(Products);
        }

        // Helper Function
        private void DisplayAllProducts(Product[] product)
        {
            Console.WriteLine("ID    Discount");
            foreach(Product pro in product)
            {
                Console.WriteLine(pro);
            }
        }
    }
}
