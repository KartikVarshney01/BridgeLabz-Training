using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class Friends
    {
        static void Main(String[] args)
        {
            // Initializing height and age array for three friends
            String[] name = { "Amar", "Akbar", "Anthony" };
            int[] heights = new int[3];
            int[] age = new int[3];

            // Taking Input
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the age and height of {name[i]} ");

                Console.Write($"Enter age of {name[i]}.");
                age[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter height of {name[0]}.");
                heights[i] = Convert.ToInt32(Console.ReadLine());

            }

            int youngestage = age[0];
            String agename = name[0];

            int tallestheight = heights[0];
            String heightname = name[0];

            // Finding Output
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < youngestage)
                {
                    youngestage = age[i];
                    agename = name[i];
                }

                if (heights[i] > tallestheight)
                {
                    tallestheight = heights[i];
                    heightname = name[i];
                }
            }

            // Displaying Output
            Console.WriteLine($"The youngest friend is : {agename}");
            Console.WriteLine($"The tallest friend is : {heightname}");
        }
    }
}
