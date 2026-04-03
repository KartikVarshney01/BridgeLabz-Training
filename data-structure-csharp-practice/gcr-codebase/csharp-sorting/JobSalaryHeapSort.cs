using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_sorting
{
    internal class JobSalaryHeapSort
    {
        static void Main(string[] args)
        {
            int[] salaries = { 45000, 60000, 35000, 80000, 50000 };

            Console.WriteLine("Salary demands before sorting:");
            PrintArray(salaries);

            HeapSort(salaries);

            Console.WriteLine("\nSalary demands after sorting (Ascending Order):");
            PrintArray(salaries);
        }

        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int heapSize, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < heapSize && arr[left] > arr[largest])
                largest = left;

            if (right < heapSize && arr[right] > arr[largest])
                largest = right;

            if (largest != root)
            {
                int swap = arr[root];
                arr[root] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, heapSize, largest);
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int salary in arr)
            {
                Console.Write(salary + " ");
            }
            Console.WriteLine();
        }
    }
}
