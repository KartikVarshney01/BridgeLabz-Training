using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_sorting
{
    internal class ExamScoreSelectionSort
    {
        static void Main(string[] args)
        {
            int[] scores = { 78, 92, 65, 88, 71, 95 };

            Console.WriteLine("Exam scores before sorting:");
            PrintArray(scores);

            SelectionSort(scores);

            Console.WriteLine("\nExam scores after sorting (Ascending Order):");
            PrintArray(scores);
        }
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int score in arr)
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
        }
    }
}
