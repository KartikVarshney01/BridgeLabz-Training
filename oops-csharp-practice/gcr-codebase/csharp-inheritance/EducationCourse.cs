using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class EducationCourse
    {
        static void Main(String[] args)
        {
            PaidOnlineCourse course = new PaidOnlineCourse("C#", 120, "Udemy", true, 8500, 30);
            course.DisplayCourseDetails();
        }
    }
    class Course
    {
        public string CourseName;
        public int Duration;

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Duration    : " + Duration + " hours");
        }
    }

    class OnlineCourse : Course
    {
        public string Platform;
        public bool IsRecorded;

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayCourseDetails()
        {
            base.DisplayCourseDetails();
            Console.WriteLine("Platform    : " + Platform);
            Console.WriteLine("Recorded    : " + IsRecorded);
        }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;
        public double Discount;

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayCourseDetails()
        {
            base.DisplayCourseDetails();
            Console.WriteLine("Fee         : " + Fee);
            Console.WriteLine("Discount    : " + Discount + "%");
        }
    }
}