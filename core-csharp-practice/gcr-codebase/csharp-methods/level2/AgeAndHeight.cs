using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class AgeAndHeight
    {
        static void Main(String[] args)
        {
            // Creating two arrays age and height
            String[] names = { "Amar", "Akbar", "Anthony" };
            int[] age = new int[3];
            int[] height = new int[3];

            // Taking Input
            Console.WriteLine("Enter 3 friends age and height : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of {names[i]} : ");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter height of {names[i]} : ");
                height[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calling function to find youngest and tallest friend
            int youngest = FindYoungest(age);
            int tallest = FindTallest(height);

            // Display Output
            Console.WriteLine($"The Youngest Friend is : {names[youngest]}\n" +
                $"The Tallest Friend is : {names[tallest]}");

        }

        static int FindYoungest(int[] age)
        {
            int young = 0;
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[young]) young = i;
            }
            return young;
        }

        static int FindTallest(int[] height)
        {
            int tallest = 0;
            for (int i = 1; i < 3; i++)
            {
                if (height[i] > height[tallest]) tallest = i;
            }
            return tallest;
        }
    }
}
