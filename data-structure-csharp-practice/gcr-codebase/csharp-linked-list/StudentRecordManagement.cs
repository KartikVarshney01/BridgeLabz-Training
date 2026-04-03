using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining
{
    internal class StudentRecordManagement
    {
        // Main Function
        static void Main(String[] args)
        {
            // Creating the linked list
            StudentLinkedList list = new StudentLinkedList();

            list.AddAtBeginning(1, "Kartik", 21, 'A');
            list.AddAtEnd(2, "Aryan", 22, 'B');
            list.AddAtPosition(2, 3, "Ram", 25, 'A');

            Console.WriteLine("All Students:");
            list.DisplayAll();

            Console.WriteLine("Search Roll No 2:");
            list.SearchByRollNo(2);

            Console.WriteLine("Update Grade of Roll No 3:");
            list.UpdateGrade(3, 'A');

            Console.WriteLine("Delete Roll No 1:");
            list.DeleteByRollNo(1);

            Console.WriteLine("Final List:");
            list.DisplayAll();
        }
    }
    class Student
    {
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;
        public Student Next;

        public Student(int RollNo, string Name, int Age, char Grade)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Age = Age;
            this.Grade = Grade;
            Next = null;
        }
    }
    class StudentLinkedList
    {
        private Student head;

        // Function to Add at beginning
        public void AddAtBeginning(int rollNo, string name, int age, char grade)
        {
            Student newNode = new Student(rollNo, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        // Function to Add at end
        public void AddAtEnd(int rollNo, string name, int age, char grade)
        {
            Student newNode = new Student(rollNo, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Add at specific position
        public void AddAtPosition(int position, int rollNo, string name, int age, char grade)
        {
            if (position <= 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }

            Student newNode = new Student(rollNo, name, age, grade);
            Student temp = head;

            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Function to Delete by Roll Number
        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.RollNo == rollNo)
            {
                head = head.Next;
                Console.WriteLine("Student deleted successfully.");
                return;
            }

            Student temp = head;
            while (temp.Next != null && temp.Next.RollNo != rollNo)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Student deleted successfully.");
            }
        }

        // Function to Search by Roll Number
        public void SearchByRollNo(int rollNo)
        {
            Student temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    Console.WriteLine($"Found: RollNo={temp.RollNo}, Name={temp.Name}, Age={temp.Age}, Grade={temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        //Function to Update grade
        public void UpdateGrade(int rollNo, char newGrade)
        {
            Student temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        // Function to Display all records
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            Student temp = head;
            while (temp != null)
            {
                Console.WriteLine($"RollNo: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
    }

}
