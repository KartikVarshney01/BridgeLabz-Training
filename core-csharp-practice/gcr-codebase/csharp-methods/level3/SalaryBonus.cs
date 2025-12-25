using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class SalaryBonus
    {
        static void Main(String[] args)
        {
            int employees = 10;

            // Calling fun to find bonus and new data
            int[,] employeeinfo = InfoFun(employees);
            double[,] updatedinfo = BonusFun(employeeinfo);

            // Display Output
            Display(employeeinfo, updatedinfo);
        }

        static int[,] InfoFun(int employees)
        {
            int[,] info = new int[employees, 2];
            Random random = new Random();

            for (int i = 0; i < employees; i++)
            {
                info[i, 0] = random.Next(10000, 100000); // 5-digit salary
                info[i, 1] = random.Next(1, 11);         // Years of service (1–10)
            }

            return info;
        }

        static double[,] BonusFun(int[,] data)
        {
            int employees = data.GetLength(0);
            double[,] result = new double[employees, 2];

            for (int i = 0; i < employees; i++)
            {
                int salary = data[i, 0];
                int years = data[i, 1];

                double rate = (years > 5) ? 0.05 : 0.02;
                double bonus = salary * rate;
                double newsalary = salary + bonus;

                result[i, 0] = newsalary;
                result[i, 1] = bonus;
            }

            return result;
        }

        static void Display(int[,] oldinfo, double[,] newinfo)
        {
            double TOldSalary = 0;
            double TNewSalary = 0;
            double TBonus = 0;

            Console.WriteLine("\nEmployee Bonus Details (Zara)");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 0; i < oldinfo.GetLength(0); i++)
            {
                int oldsalary = oldinfo[i, 0];
                int years = oldinfo[i, 1];
                double bonus = newinfo[i, 1];
                double newsalary = newinfo[i, 0];

                TOldSalary += oldsalary;
                TNewSalary += newsalary;
                TBonus += bonus;

                Console.WriteLine($"{i + 1}\t{oldsalary}\t\t{years}\t{bonus:F2}\t\t{newsalary:F2}");
            }

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"TOTAL\t{TOldSalary:F2}\t\t\t{TBonus:F2}\t{TNewSalary:F2}");
        }
    }
}
