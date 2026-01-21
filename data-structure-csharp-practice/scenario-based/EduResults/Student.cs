using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.EduResults
{
    // Encapsulated Student Class 
    internal class Student
    {
        private static int NextID = 1;
        public int StudentId { get; set; }
        public int StudentMarks { get; set; }
        public string DistrictName { get; set; }

        public Student()
        {
            this.StudentId = NextID++;
        }

        public override string ToString()
        {
            return $"Student ID : {StudentId} || Student Marks : {StudentMarks} || Student District : {DistrictName}";
        }
    }
}
