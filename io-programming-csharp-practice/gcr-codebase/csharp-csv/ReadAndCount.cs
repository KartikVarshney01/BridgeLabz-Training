using System;
using System.IO;

class ReadAndCount
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            int count = 0;

            // Start from 1 to skip header
            for (int i = 1; i < lines.Length; i++)
            {
                count++;
            }

            Console.WriteLine("Number of records in CSV file: " + count);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
