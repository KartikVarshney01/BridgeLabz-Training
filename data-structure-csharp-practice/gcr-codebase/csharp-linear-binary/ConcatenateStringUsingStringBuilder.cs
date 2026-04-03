using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class ConcatenateStringUsingStringBuilder
    {
        static void Main(string[] args)
        {
            ConcatenateStringUsingStringBuilder start = new ConcatenateStringUsingStringBuilder();
            string[] words = { "Hello", "World", "All", "Everyone", "Hi", "Java", "Python" };
            Console.WriteLine("The Array of words is : ");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine($"\nConcated Words Using StringBuilder is : {start.Concatenate(words)}");
        }
        string Concatenate(string[] words)
        {
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                result.Append(word);
            }
            return result.ToString();
        }
    }
}
