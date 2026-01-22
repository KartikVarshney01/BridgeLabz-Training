//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
//{
//    internal class ReadAndWrite
//    {
//        static void Main(string[] args)
//        {
//            string sourcePath = "text.txt";
//            string destinationPath = "destination.txt";

//            try
//            {
//                // Check if source file exists
//                if (!File.Exists(sourcePath))
//                {
//                    Console.WriteLine("Source file does not exist.");
//                    return;
//                }

//                // Read from source file
//                using (FileStream readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
//                {
//                    byte[] buffer = new byte[readStream.Length];
//                    readStream.Read(buffer, 0, buffer.Length);

//                    // Write to destination file
//                    using (FileStream writeStream = new FileStream(
//                        destinationPath, FileMode.Create, FileAccess.Write))
//                    {
//                        writeStream.Write(buffer, 0, buffer.Length);
//                    }
//                }

//                Console.WriteLine("File copied successfully.");
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine("An IO error occurred: " + ex.Message);
//            }
//        }
//    }
//}
