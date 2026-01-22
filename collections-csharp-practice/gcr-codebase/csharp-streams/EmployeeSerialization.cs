using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }
    internal class EmployeeSerialization
    {
        static void Main(string[] args)
        {
            string file = "employees.json";

            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Kartik", Department = "IT", Salary = 50000 },
                new Employee { Id = 2, Name = "Satyam", Department = "HR", Salary = 45000 }
            };

            string json = JsonSerializer.Serialize(employees);
            File.WriteAllText(file, json);

            string readJson = File.ReadAllText(file);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(readJson);

            foreach (var emp in list)
            {
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Department + " " + emp.Salary);
            }
        }
    }
}
