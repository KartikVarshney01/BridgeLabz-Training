using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_sorting
{
    internal class ProductPricesQuickSort
    {
        static void Main(string[] args)
        {
            int[] prices = { 799, 299, 999, 149, 499, 899 };

            Console.WriteLine("Product prices before sorting:");
            PrintArray(prices);

            QuickSort(prices, 0, prices.Length - 1);

            Console.WriteLine("\nProduct prices after sorting (Ascending Order):");
            PrintArray(prices);
        }
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high], i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
        static void PrintArray(int[] arr)
        {
            foreach (int price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}
