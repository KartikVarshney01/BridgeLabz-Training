using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level1
{
    internal class DateTimeOffSet
    {
        static void Main(String[] args)
        {
            // Taking current date and time as input
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            // Time zone objects 
            TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            // Convert UTC to different time zones
            DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

            // Display Output
            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine($"GMT : {gmtTime}");
            Console.WriteLine($"IST : {istTime}");
            Console.WriteLine($"PST : {pstTime}");
        }
    }
}
