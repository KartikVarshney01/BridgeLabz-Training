using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_generics.ResumeScreening
{
    // ABSTRACT JOB ROLE
    public abstract class JobRole
    {
        public string CandidateName { get; set; }
        public int Experience { get; set; }

        public abstract bool Evaluate();
        public abstract void DisplayRoleCriteria();
    }

    // SOFTWARE ENGINEER ROLE
    public class SoftwareEngineer : JobRole
    {
        public int CodingSkillRating { get; set; }

        public override bool Evaluate()
        {
            return Experience >= 2 && CodingSkillRating >= 7;
        }

        public override void DisplayRoleCriteria()
        {
            Console.WriteLine("Role            : Software Engineer");
            Console.WriteLine("Min Experience  : 2 Years");
            Console.WriteLine("Coding Skill    : >= 7");
        }
    }

    // DATA SCIENTIST ROLE
    public class DataScientist : JobRole
    {
        public int MLKnowledgeRating { get; set; }

        public override bool Evaluate()
        {
            return Experience >= 3 && MLKnowledgeRating >= 6;
        }

        public override void DisplayRoleCriteria()
        {
            Console.WriteLine("Role            : Data Scientist");
            Console.WriteLine("Min Experience  : 3 Years");
            Console.WriteLine("ML Knowledge    : >= 6");
        }
    }

    // GENERIC RESUME CLASS
    public class Resume<T> where T : JobRole
    {
        public T JobProfile { get; private set; }

        public Resume(T jobProfile)
        {
            JobProfile = jobProfile;
        }

        public void ProcessResume()
        {
            Console.WriteLine("\nProcessing Resume...");
            JobProfile.DisplayRoleCriteria();

            Console.WriteLine("\nCandidate Name  : " + JobProfile.CandidateName);
            Console.WriteLine("Experience     : " + JobProfile.Experience + " Years");

            bool result = JobProfile.Evaluate();

            Console.WriteLine("\nScreening Result: " +
                (result ? "SHORTLISTED " : "REJECTED "));
        }
    }

    // GENERIC SCREENING METHOD
    public class ResumeScreeningEngine
    {
        public static void ScreenResume<T>(Resume<T> resume)
            where T : JobRole
        {
            resume.ProcessResume();
        }
    }

    // MAIN PROGRAM
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== AI-Driven Resume Screening System ===");

            // Software Engineer Resume
            SoftwareEngineer se = new SoftwareEngineer
            {
                CandidateName = "Amit",
                Experience = 3,
                CodingSkillRating = 8
            };

            Resume<SoftwareEngineer> seResume =
                new Resume<SoftwareEngineer>(se);

            ResumeScreeningEngine.ScreenResume(seResume);

            Console.WriteLine();

            // Data Scientist Resume
            DataScientist ds = new DataScientist
            {
                CandidateName = "Neha",
                Experience = 2,
                MLKnowledgeRating = 5
            };

            Resume<DataScientist> dsResume =
                new Resume<DataScientist>(ds);

            ResumeScreeningEngine.ScreenResume(dsResume);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
