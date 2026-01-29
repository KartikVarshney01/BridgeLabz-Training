using System;
using System.IO;

class EmployeeDataWrite
{
    static void Main()
    {
        string filePath = "employees.csv";

        string[] employees = new string[6];

        // Header
        employees[0] = "ID,Name,Department,Salary";

        // Employee records
        employees[1] = "1,Kartik,IT,50000";
        employees[2] = "2,Rahul,HR,45000";
        employees[3] = "3,Ananya,Finance,60000";
        employees[4] = "4,Neha,Marketing,48000";
        employees[5] = "5,Amit,Sales,52000";

        File.WriteAllLines(filePath, employees);

        Console.WriteLine("Employee data written to CSV file successfully.");
    }
}