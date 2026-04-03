using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class HandlingFileNotFound
    {
        static void Main(string[] args)
        {
            try
            {
                string fileContent = File.ReadAllText("data.txt");
                Console.WriteLine($"File Content : {fileContent}");
            }
            catch (IOException)
            {
                Console.WriteLine("File Not Found");
            }
        }
    }
}
