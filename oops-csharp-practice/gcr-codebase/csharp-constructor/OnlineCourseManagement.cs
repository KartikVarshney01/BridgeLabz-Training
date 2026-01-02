using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class OnlineCourseManagement
    {
        // Instance variables
        string courseName;
        int duration;
        double fee;

        // Class variable that is common for all courses
        static string instituteName = "National Institute";

        // Parameterized constructor
        public OnlineCourseManagement(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // Instance method to display course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Institute Name : " + instituteName);
            Console.WriteLine("Course Name    : " + courseName);
            Console.WriteLine("Duration       : " + duration + " months");
            Console.WriteLine("Fee            : " + fee);
        }

        // Class method to update institute name
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }

        static void Main()
        {
            OnlineCourseManagement c1 = new OnlineCourseManagement("C Programming", 12, 35000);
            OnlineCourseManagement c2 = new OnlineCourseManagement("App Development", 8, 28000);

            Console.WriteLine("Course Details Before Institute Update");
            c1.DisplayCourseDetails();
            Console.WriteLine();
            c2.DisplayCourseDetails();

            Console.WriteLine();

            OnlineCourseManagement.UpdateInstituteName("Tech Academy");

            Console.WriteLine("Course Details After Institute Update");
            c1.DisplayCourseDetails();
            Console.WriteLine();
            c2.DisplayCourseDetails();
        }
    }
}
