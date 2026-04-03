using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_sorting
{
    internal class EmployeeIDSort
    {
        static void Main(String[] args)
        {
            int[] employeeIds = { 105, 101, 109, 102, 108, 161, 25 };

            Console.WriteLine("Employee IDs before sorting:");
            PrintArray(employeeIds);

            InsertionSort(employeeIds);

            Console.WriteLine("\nEmployee IDs after sorting (Ascending Order):");
            PrintArray(employeeIds);
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int id in arr)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
}
