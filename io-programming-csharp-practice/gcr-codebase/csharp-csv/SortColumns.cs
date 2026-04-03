using System;
using System.IO;

class SortColumns
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            // Bubble sort based on salary
            for (int i = 1; i < lines.Length - 1; i++)
            {
                for (int j = i + 1; j < lines.Length; j++)
                {
                    int salary1 = Convert.ToInt32(lines[i].Split(',')[3]);
                    int salary2 = Convert.ToInt32(lines[j].Split(',')[3]);

                    if (salary1 < salary2)
                    {
                        string temp = lines[i];
                        lines[i] = lines[j];
                        lines[j] = temp;
                    }
                }
            }

            Console.WriteLine("Top 5 Highest Paid Employees");
            Console.WriteLine("----------------------------");

            for (int i = 1; i <= 5 && i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                Console.WriteLine("Name   : " + data[1]);
                Console.WriteLine("Dept   : " + data[2]);
                Console.WriteLine("Salary : " + data[3]);
                Console.WriteLine("----------------------------");
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
