using System;

internal class StudentMarks
{
    static void Main(string[] args)
    {
        int[] marks = { 78, 45, 89, 62, 91, 55 };

        Console.WriteLine("Marks before sorting:");
        PrintArray(marks);

        BubbleSort(marks);

        Console.WriteLine("\nMarks after sorting (Ascending Order):");
        PrintArray(marks);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
