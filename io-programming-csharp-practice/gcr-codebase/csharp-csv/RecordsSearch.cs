using System;
using System.IO;

class RecordsSearch
{
    static void Main()
    {
        string filePath = "employees.csv";
        string searchName = "Neha";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                if (data[1] == searchName)
                {
                    Console.WriteLine("Employee Found");
                    Console.WriteLine("Department : " + data[2]);
                    Console.WriteLine("Salary     : " + data[3]);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found");
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
