//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
//{
//    internal class ConsoleInput
//    {
//        static void Main(string[] args)
//        {
//            string filePath = "UserInfo.txt";

//            try
//            {
//                // StreamReader for console input
//                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
//                {
//                    Console.Write("Enter your name: ");
//                    string name = reader.ReadLine();

//                    Console.Write("Enter your age: ");
//                    string age = reader.ReadLine();

//                    Console.Write("Enter your favorite programming language: ");
//                    string language = reader.ReadLine();

//                    // StreamWriter for file output
//                    using (StreamWriter writer = new StreamWriter(filePath))
//                    {
//                        writer.WriteLine("User Information");
//                        writer.WriteLine("----------------");
//                        writer.WriteLine($"Name: {name}");
//                        writer.WriteLine($"Age: {age}");
//                        writer.WriteLine($"Favorite Language: {language}");
//                    }
//                }

//                Console.WriteLine("\nUser information saved successfully.");
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine("File I/O error occurred: " + ex.Message);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Unexpected error occurred: " + ex.Message);
//            }
//        }
//    }
//}
