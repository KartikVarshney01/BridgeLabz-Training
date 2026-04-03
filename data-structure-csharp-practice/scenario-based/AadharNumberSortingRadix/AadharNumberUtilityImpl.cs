using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AadharNumberSortingRadix
{
    // Utility Class Containing Interface Methods Implementation
    internal class AadharNumberUtilityImpl : IAadhar
    {
        private Aadhar[] AadharList;
        private bool IsSorted;
        Random random;

        // Constructor Initializing Aadhar List And Random Function
        public AadharNumberUtilityImpl()
        {
            Console.Write("Enter Number Of Aadhars : ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            AadharList = new Aadhar[capacity];
            random = new Random();
        }

        // Method To Generate Aadhar's
        public void AddAadhar()
        {
            for(int i = 0; i < AadharList.Length; i++)
            {
                Aadhar newAadhar = new Aadhar();
                newAadhar.AadharNumber = random.NextInt64(111111111111, 999999999999);
                AadharList[i] = newAadhar;
            }
            DisplayAll();
        }

        // Method To Sort Using Radix Sort
        public void SortAadhar()
        {
            if (AadharList.Length == 0 || AadharList[0] == null)
            {
                Console.WriteLine("No Aadhar Details Found");
                return;
            }
            Console.WriteLine("Sorting Aadhars ... ");
            RadixSort(AadharList);
            IsSorted = true;
            Console.WriteLine("Aadhar Sorted Successfully");
        }

        public void SearchAadhar()
        {
            if (AadharList.Length == 0 || AadharList[0] == null)
            {
                Console.WriteLine("No Aadhar Details Found");
                return;
            }
            Console.Write("Enter The Aadhar Number You Want To Search : ");
            long searchNumber = Convert.ToInt64(Console.ReadLine());
            if (!IsSorted) SortAadhar();
            BinarySearch(searchNumber);
        }

        // Private Helper Method Radix Sort For Sorting
        private void RadixSort(Aadhar[] array)
        {
            long max = GetMax(array);
            for(long exp = 1; max/exp > 0; exp *= 10)
            {
                CountingSort(array, exp);
            }
        }

        // Private Helper Method To Find Max Element
        private long GetMax(Aadhar[] array)
        {
            long max = array[0].AadharNumber;
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i].AadharNumber > max)
                {
                    max = array[i].AadharNumber;
                }
            }
            return max;
        }

        // Private Helper Method For Counting Sort
        private void CountingSort(Aadhar[] array, long exp)
        {
            int length = array.Length;
            long[] output = new long[length];
            int[] count = new int[10];

            for (int i = 0; i < length; i++)
            {
                int digit = (int)((array[i].AadharNumber / exp) % 10);
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = length - 1; i >= 0; i--)
            {
                int digit = (int)((array[i].AadharNumber / exp) % 10);
                output[count[digit] - 1] = array[i].AadharNumber;
                count[digit]--;
            }

            for (int i = 0; i < length; i++)
            {
                array[i].AadharNumber = output[i];
            }
        }

        private void BinarySearch(long searchNumber)
        {
            int left = 0;
            int right = AadharList.Length - 1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if (AadharList[mid].AadharNumber == searchNumber)
                {
                    Console.WriteLine($"Aadhar Founded At Index {mid}.");
                    Console.WriteLine(AadharList[mid]);
                    return;
                }
                else if (AadharList[mid].AadharNumber < searchNumber)
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine("Aadhar Not Found");
        }

        // Private Helper Function To Display All Aadhars
        private void DisplayAll()
        {
            for(int i = 0; i < AadharList.Length; i++)
            {
                Console.WriteLine(AadharList[i]);
            }
        }
    }
}
