using System;
using System.IO;

class ModifyCsv
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        if (File.Exists(inputFile))
        {
            string[] lines = File.ReadAllLines(inputFile);
            string[] updated = new string[lines.Length];

            updated[0] = lines[0]; // header

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                string department = data[2];
                int salary = Convert.ToInt32(data[3]);

                if (department == "IT")
                {
                    salary = salary + (salary * 10 / 100);
                }

                updated[i] = data[0] + "," + data[1] + "," + data[2] + "," + salary;
            }

            File.WriteAllLines(outputFile, updated);
            Console.WriteLine("Updated CSV file created");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
