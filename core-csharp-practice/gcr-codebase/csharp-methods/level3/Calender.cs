using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class Calender
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter month : ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Display Output
            CalendarDisplay(month, year);
        }

        static void CalendarDisplay(int month, int year)
        {
            string monthname = GetMonthFun(month);
            int days = GetDaysFun(month, year);
            int firstday = FirstDayFun(month, year);

            Console.WriteLine($"\n  {monthname} year");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            for (int i = 0; i < firstday; i++)
            {
                Console.Write("    ");
            }

            for (int day = 1; day <= days; day++)
            {
                Console.Write($"{day,3} ");

                if ((day + firstday) % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static string GetMonthFun(int month)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[month - 1];
        }

        public static int GetDaysFun(int month, int year)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && LeapFun(year))
                return 29;

            return days[month - 1];
        }

        public static bool LeapFun(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static int FirstDayFun(int month, int year)
        {
            int d = 1;
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }
    }
}
