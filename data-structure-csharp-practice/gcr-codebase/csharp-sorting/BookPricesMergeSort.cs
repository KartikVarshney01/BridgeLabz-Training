using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_sorting
{
    internal class BookPricesMergeSort
    {
        static void Main(String[] args)
        {
            int[] prices = { 450, 299, 799, 150, 399, 999 };

            Console.WriteLine("Book prices before sorting:");
            PrintArray(prices);

            MergeSort(prices, 0, prices.Length - 1);

            Console.WriteLine("\nBook prices after sorting (Ascending Order):");
            PrintArray(prices);
        }
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] leftArr = arr[left..(mid + 1)];
            int[] rightArr = arr[(mid + 1)..(right + 1)];
            int i = 0, j = 0, k = left;
            while (i < leftArr.Length && j < rightArr.Length)
            {
                arr[k++] = leftArr[i] <= rightArr[j] ? leftArr[i++] : rightArr[j++];
            }
            while (i < leftArr.Length) arr[k++] = leftArr[i++];
            while (j < rightArr.Length) arr[k++] = rightArr[j++];
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
