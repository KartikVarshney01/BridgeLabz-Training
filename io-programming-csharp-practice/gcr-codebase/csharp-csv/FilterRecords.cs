using System;
using System.IO;

class FilterRecords
{
    static void Main()
    {
        string filePath = "students.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Students with marks more than 80");
            Console.WriteLine("--------------------------------");

            // Start from 1 to skip header
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                int marks = Convert.ToInt32(values[3]);

                if (marks > 80)
                {
                    Console.WriteLine("ID    : " + values[0]);
                    Console.WriteLine("Name  : " + values[1]);
                    Console.WriteLine("Age   : " + values[2]);
                    Console.WriteLine("Marks : " + values[3]);
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
