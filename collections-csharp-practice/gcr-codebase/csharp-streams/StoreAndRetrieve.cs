//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
//{
//    internal class StoreAndRetrieve
//    {
//        static void Main(string[] args)
//        {
//            string file = "student.dat";

//            // Write
//            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
//            {
//                writer.Write(101);
//                writer.Write("Kartik");
//                writer.Write(8.9);
//            }

//            // Read
//            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
//            {
//                int roll = reader.ReadInt32();
//                string name = reader.ReadString();
//                double gpa = reader.ReadDouble();

//                Console.WriteLine($"{roll} {name} {gpa}");
//            }
//        }
//    }
//}
