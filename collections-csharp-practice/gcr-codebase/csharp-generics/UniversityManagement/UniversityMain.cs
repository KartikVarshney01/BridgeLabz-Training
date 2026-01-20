using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_generics.UniversityManagement
{
    // ABSTRACT COURSE TYPE
    public abstract class CourseType
    {
        public abstract void Evaluate();
    }

    // EXAM BASED COURSE
    public class ExamCourse : CourseType
    {
        public override void Evaluate()
        {
            Console.WriteLine("Evaluation Method: Written Examination");
        }
    }

    // ASSIGNMENT BASED COURSE
    public class AssignmentCourse : CourseType
    {
        public override void Evaluate()
        {
            Console.WriteLine("Evaluation Method: Assignments Submission");
        }
    }

    // GENERIC INTERFACE (COVARIANCE)
    public interface ICourse<out T> where T : CourseType
    {
        string CourseName { get; }
        string Department { get; }
        T EvaluationType { get; }
    }

    // GENERIC COURSE CLASS
    public class Course<T> : ICourse<T> where T : CourseType
    {
        public string CourseName { get; private set; }
        public string Department { get; private set; }
        public T EvaluationType { get; private set; }

        public Course(string courseName, string department, T evaluationType)
        {
            CourseName = courseName;
            Department = department;
            EvaluationType = evaluationType;
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name  : " + CourseName);
            Console.WriteLine("Department   : " + Department);
            EvaluationType.Evaluate();
        }
    }

    // MAIN PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== University Course Management System ===\n");

            // Creating courses with different evaluation types
            Course<ExamCourse> mathCourse =
                new Course<ExamCourse>("Mathematics", "Science", new ExamCourse());

            Course<AssignmentCourse> csCourse =
                new Course<AssignmentCourse>("Computer Science", "Engineering", new AssignmentCourse());

            // Display course details
            mathCourse.DisplayCourseDetails();
            Console.WriteLine();

            csCourse.DisplayCourseDetails();
            Console.WriteLine();

            // VARIANCE DEMONSTRATION
            ICourse<CourseType> courseReference = mathCourse;

            Console.WriteLine("Accessing via Covariant Interface:");
            courseReference.EvaluationType.Evaluate();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
