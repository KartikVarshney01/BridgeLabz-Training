using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_sorting
{
    internal class StudentAgesCollectionSort
    {
        static void Main(string[] args)
        {
            int[] ages = { 12, 15, 10, 14, 18, 13, 15, 11, 16 };

            Console.WriteLine("Student ages before sorting:");
            PrintArray(ages);

            CountingSort(ages, 10, 18);

            Console.WriteLine("\nStudent ages after sorting (Ascending Order):");
            PrintArray(ages);
        }

        static void CountingSort(int[] arr, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - minAge]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int age = arr[i];
                int index = count[age - minAge] - 1;
                output[index] = age;
                count[age - minAge]--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int age in arr)
            {
                Console.Write(age + " ");
            }
            Console.WriteLine();
        }
    }
}
