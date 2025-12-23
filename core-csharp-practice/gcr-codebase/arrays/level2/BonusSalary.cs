using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class BonusSalary
    {
        static void Main(String[] args)
        {
            // Initializing salary, year of service, bonus, new salary, totalbonus.

            double[] salary = new double[10];
            double[] yearofservice = new double[10];
            double[] bonus = new double[10];
            double[] newsalary = new double[10];

            double totalbonus = 0, totaloldsalary = 0, totalnewsalary = 0;

            // Taking user input
            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine($"Enter details of employee {i + 1} : ");

                Console.Write("Enter the salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the year of service : ");
                double years = Convert.ToDouble(Console.ReadLine());

                if (sal < 0 || years < 0)
                {
                    Console.WriteLine("Invalid Data, Enter Again!");
                    i--;
                    continue;
                }

                salary[i] = sal;
                yearofservice[i] = years;
            }

            // Finding Bonus
            for (int i = 0; i < bonus.Length; i++)
            {
                if (yearofservice[i] > 5) bonus[i] = salary[i] * 0.05;
                else bonus[i] = salary[i] * 0.02;

                newsalary[i] = salary[i] + bonus[i];

                totalbonus += bonus[i];
                totaloldsalary += salary[i];
                totalnewsalary += newsalary[i];
            }

            // Printing Output
            Console.WriteLine($"The Total Bonus is : {totalbonus}\n The Total Old Salary is : {totaloldsalary}\n The Total New Salary is : {totalnewsalary}");
        }
    }
}
