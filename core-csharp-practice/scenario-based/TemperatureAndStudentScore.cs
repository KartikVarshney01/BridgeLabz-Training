using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    internal class TemperatureAndStudentScore
    {
        /* The program does two functions:
         * 1. It works as a temperature Analyzer to take hourly temp data for 7 days and find the average temp of each day and also to  find the hottest and coldest day.
         * 2. It works as a Student Test Score Manager to take user input for number of students and finding their average marks with their highest and lowest marks and marks above average.
         * 
         * version - 1.0
         */
        static void Main(String[] args)
        {
            TemperatureAndStudentScore ProgramStart = new TemperatureAndStudentScore();
            ProgramStart.StartMenu();
        }
        // Start menu contains the start of the code and the options of choosing between temperature analyzer and student score manager
        void StartMenu()
        {
            // Using infinite while loop to run option menu again and again untill user have done all the tasks.
            while (true)
            {
                // Printing Menu And choice option
                Console.WriteLine("----Start Menu----");
                Console.WriteLine("1. Temperature Analyzer");
                Console.WriteLine("2. Student Test Score Manager");
                Console.WriteLine("3. Program Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Using Switch Function for choosing options and calling each functionality
                switch (choice)
                {
                    case 1:
                        // Calling Temperature Analyzer function to perform its work
                        TemperatureAnalyzer();
                        break;

                    case 2:
                        // Calling Student Test Score Manager Function for its work
                        StudentScoreManager();
                        break;

                    case 3:
                        Console.WriteLine("Exited the Program");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice! Choose between 1-3");
                        break;
                }
                Console.WriteLine();
            }
        }
        void TemperatureAnalyzer()
        {
            // Creating temp array to store temperature data of 24 hours for 7 days.
            float[,] temp = new float[7, 24];

            Random random = new Random();
            // Using for loop to input temperature data generated using random function in the array.
            for(int i = 0; i < 7; i++) // day loop
            {
                for(int j = 0; j < 24; j++) // hour loop
                {
                    temp[i, j] = random.Next(-10, 50);
                }
            }

            int hottestday = 0;
            int coldestday = 0;
            float maxtemp = temp[0,0];
            float mintemp = temp[0,0];

            Console.WriteLine("Average Temperatue Findings are : ");

            for (int i = 0; i < 7; i++) // day loop
            {
                // Initializing sum variable to sum per day temperature to find the daily average.
                float sum = 0;
                for (int j = 0; j < 24; j++)
                {
                    sum += temp[i, j];

                    // Checking hourly temp to find max temp and min temperature to find their respective days
                    if (temp[i, j] > maxtemp)
                    {
                        maxtemp = temp[i, j];
                        hottestday = i;
                    }

                    if (temp[i, j] < mintemp)
                    {
                        mintemp = temp[i, j];
                        coldestday = i;
                    }
                }
                Console.WriteLine($"Day {i + 1} Average Temperature is : {sum / 24}°C");
            }
            Console.WriteLine();
            // Displaying the Hottest And Coldest Days 
            Console.WriteLine($"Hottest Day: Day {hottestday + 1} with (Max = {maxtemp}°C)");
            Console.WriteLine($"Coldest Day: Day {coldestday + 1} with (Min = {mintemp}°C)");
        }

        // StudentScoreManager Function to perform tasks of student test score manager of finding and displaying
        // average score, highest and lowest score and also to find the score above average score
        void StudentScoreManager()
        {
            // Taking Input
            Console.Write("Enter number of students : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Creating score array to store the students score
            int[] Marks = new int[num];

            // Using for loop to store input
            for (int i = 0; i < num; i++)
            {
                // Initializing score variable to store the user input score before assigning it to array
                int marks;
                
                // Using the do while loop to look out for invalid or negative score or marks
                do
                {
                    Console.Write($"Enter marks for {i + 1} student : ");
                    marks = Convert.ToInt32(Console.ReadLine());

                    if (marks < 0)
                    {
                        Console.WriteLine("Marks cannot be negative. Enter valid marks");
                    }

                } while (marks < 0);

                Marks[i] = marks;
            }

            // Initializing sum, max and min variables to find average, lowest and highest marks
            int sum = 0;
            int max = Marks[0];
            int min = Marks[0];

            foreach (int m in Marks)
            {
                sum += m;
                if (m > max) max = m;
                if (m < min) min = m;
            }

            // Finding Average marks
            double avg = (double)sum / num;

            Console.WriteLine($"Average Marks for the students are : {avg}");
            Console.WriteLine($"Highest Marks among the students are : {max}");
            Console.WriteLine($"Lowest Marks among the students are : {min}");
            Console.WriteLine("Marks above average marks are :");
            foreach (int m in Marks)
            {
                if (m > avg)
                    Console.WriteLine(m);
            }
        }
    }
}
