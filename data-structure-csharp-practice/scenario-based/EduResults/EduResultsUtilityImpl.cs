using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.EduResults
{
    // Utility Class Containing The Inplementation of Interface Methods 
    internal class EduResultsUtilityImpl : IEduResults
    {
        // Private Dictionary Refernece
        private Dictionary<string, List<Student>> DistrictLists;

        // Constructor Initializing Dictionary
        public EduResultsUtilityImpl()
        {
            DistrictLists = new Dictionary<string, List<Student>>();
        }

        // Add Marks Method Used To Add New Dictionary And Student With Their Marks In The Dictionary
        public void AddMarks()
        {
            Console.Write("Enter The Number Of Districts : ");
            int districtNo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < districtNo; i++)
            {
                Console.Write("Enter Name of District : ");
                string districtName = Console.ReadLine();

                // Adding only if The Dictionary Key Does Not Exist
                if (!DistrictLists.TryAdd(districtName, new List<Student>()))
                {
                    Console.WriteLine("District Already Present");
                    continue;
                }

                Console.Write("Enter Number of Students : ");
                int studentNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Marks of Students in Sorted Order");
                for (int j = 0; j < studentNumber; j++)
                {
                    Console.Write("Enter Student Marks : ");
                    int mark = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student();
                    student.StudentMarks = mark;
                    student.DistrictName = districtName;

                    DistrictLists[districtName].Add(student);
                }

            }
        }

        // Method To Merge Each District Marks Into A Combined List
        public void MergeMarks()
        {
            List<Student> allStudents = new List<Student>();

            foreach (KeyValuePair<string, List<Student>> district in DistrictLists)
            {
                allStudents.AddRange(district.Value);
            }

            allStudents = MergeSort(allStudents);

            Console.WriteLine("\n----- STATE WISE RANK LIST -----");

            int rank = 1;
            foreach (Student student in allStudents)
            {
                Console.WriteLine("Rank " + rank + " -> " + student);
                rank++;
            }
        }

        public void DistrictRank()
        {
            if (DistrictLists.Count == 0)
            {
                Console.WriteLine("No data available.");
                return;
            }

            Console.WriteLine("\n===== DISTRICT WISE RANK LIST =====");

            foreach (KeyValuePair<string, List<Student>> district in DistrictLists)
            {
                Console.WriteLine("\nDistrict : " + district.Key);
                Console.WriteLine("----------------------------------");

                // Sort students of this district using Merge Sort
                List<Student> sortedStudents = MergeSort(district.Value);

                int rank = 1;
                foreach (Student student in district.Value)
                {
                    Console.WriteLine(
                        "Rank " + rank + " -> " + student
                    );
                    rank++;
                }
            }
        }

        // Private Helper Method For Merge Sort
        private List<Student> MergeSort(List<Student> students)
        {
            if (students.Count <= 1)
            {
                return students;
            }

            int mid = students.Count / 2;

            List<Student> left = new List<Student>();
            List<Student> right = new List<Student>();

            for (int i = 0; i < mid; i++) left.Add(students[i]);

            for (int i = mid; i < students.Count; i++) right.Add(students[i]);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private List<Student> Merge(List<Student> left, List<Student> right)
        {
            List<Student> result = new List<Student>();

            int i = 0;
            int j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].StudentMarks >= right[j].StudentMarks)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }
    }
}