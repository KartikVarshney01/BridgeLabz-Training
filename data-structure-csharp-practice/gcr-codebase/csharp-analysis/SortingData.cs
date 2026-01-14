using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_analysis
{
    internal class SortingData
    {
        static void Main()
        {
            int sizes = 10000;
            int[] data = ArrayCreate(sizes);

            Console.WriteLine($"\nDataset Size: {sizes}");

            // Creating Separate Array for each sorting with same data
            int[] bubbleData = (int[])data.Clone();
            int[] mergeData = (int[])data.Clone();
            int[] quickData = (int[])data.Clone();

            // Creating StopWatch 
            Stopwatch timer = new Stopwatch();

            // Bubble Sort
            timer.Start();
            BubbleSort(bubbleData);
            timer.Stop();
            Console.WriteLine($"Bubble Sort Time: {timer.ElapsedMilliseconds} ms");

            // Merge Sort
            timer.Restart();
            MergeSort(mergeData, 0, mergeData.Length - 1);
            timer.Stop();
            Console.WriteLine($"Merge Sort Time: {timer.ElapsedMilliseconds} ms");

            // Quick Sort
            timer.Restart();
            QuickSort(quickData, 0, quickData.Length - 1);
            timer.Stop();
            Console.WriteLine($"Quick Sort Time: {timer.ElapsedMilliseconds} ms");
        }

        static int[] ArrayCreate(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) arr[i] = random.Next(1, size);
            return arr;
        }

        // Bubble Sort 
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftarr = new int[n1];
            int[] rightarr = new int[n2];

            Array.Copy(arr, left, leftarr, 0, n1);
            Array.Copy(arr, mid + 1, rightarr, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                arr[k++] = (leftarr[i] <= rightarr[j]) ? leftarr[i++] : rightarr[j++];
            }

            while (i < n1) arr[k++] = leftarr[i++];
            while (j < n2) arr[k++] = rightarr[j++];
        }

        // Quick Sort
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low >= high) return;

            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

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
    }
}
