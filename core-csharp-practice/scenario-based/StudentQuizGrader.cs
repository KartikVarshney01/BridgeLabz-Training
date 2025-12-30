using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    /* The Program is used to find the total score earned by the student in a 10 questions quiz.
     * USing two arrays 1. Correct Answer and 2. Student Answer to store and compare them and calculate their total
     * Also showing details on each question of whether correct or worng
     * Also used to provide percentage 
     * 
     * version - 1.0
     */
    internal class StudentQuizGrader
    {
        string[] CorrectAnswer = new string[10];
        string[] StudentAnswer = new string[10];

        // Quiz Grader Start function is used to call the other function and taking start input
        void QuizGraderStart()
        {
            // Using while loop to loop through the menu for user selection
            while (true)
            {
                Console.WriteLine("\n\n====QuizMenu====");
                Console.WriteLine("1. Enter The Correct Answers.");
                Console.WriteLine("2. Enter The Student Answers.");
                Console.WriteLine("3. Finding Student Score.");
                Console.WriteLine("4. Program Exit.");
                Console.WriteLine("\nEnter the choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CorrectAnswerInput();
                        break;
                    case 2:
                        StudentAnswerInput();
                        break;
                    case 3:
                        FindScore();
                        break;
                    case 4:
                        Console.WriteLine("Program Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice! Enter Valid option");
                        break;
                }
            }
        }
        // function CorrectAnswerInput to take input of the correct answers and storing them in the array
        void CorrectAnswerInput()
        {
            Console.WriteLine("Enter the Correct Anwers for the quiz.");
            // Taking User Input of the correct answers
            for(int i = 0; i < CorrectAnswer.Length; i++)
            {
                CorrectAnswer[i] = Console.ReadLine();
            }
            Console.WriteLine("Correct answer updated successfully.");
        }
        // function StudentAnswerInput is used to take input for the student answer to the quiz
        void StudentAnswerInput()
        {
            Console.WriteLine("Enter the student answers. ");
            // Using for loop for taking user input of student answer
            for(int i=0; i < StudentAnswer.Length; i++)
            {
                StudentAnswer[i] = Console.ReadLine();
            }
            Console.WriteLine("Student Answers added successfully");
        }
        // Function FindScore to find the score of the student and getting the correct and worng response
        void FindScore()
        {
            int score = 0;
            for(int i = 0; i < CorrectAnswer.Length; i++)
            {
                if (CorrectAnswer[i].Equals(StudentAnswer[i], StringComparison.OrdinalIgnoreCase))
                {
                    score += 1;
                    Console.WriteLine($"Question {i + 1} : Correct Answer");
                }
                else
                {
                    Console.WriteLine($"Question {i + 1} : Worng Answer");
                }
            }

            // Creating percentage variable to hold percent score. 
            int percentage = score * 10;

            //Display Score,Percentage And Pass/Fail Remark
            Console.WriteLine("====Report====");
            Console.WriteLine($"Score : {score}");
            Console.WriteLine($"Percentage : {percentage}");
            Console.WriteLine((percentage>30)?"Passed the Quiz":"Failed the Quiz");
        }
        static void Main(String[] args)
        {
            StudentQuizGrader start = new StudentQuizGrader();
            start.QuizGraderStart();
        }
    }
}
