using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class ElementFrquency
    {
        static void Main(string[] args)
        {
            // Input list
            List<string> fruits = new List<string> { "apple", "banana", "apple", "orange" };

            Dictionary<string, int> frequencyMap = FindFrequency(fruits);

            // Print result
            Console.WriteLine("Element Frequencies:");
            PrintDictionary(frequencyMap);
        }

        static Dictionary<string, int> FindFrequency(List<string> list)
        {
            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string item in list)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency[item] = 1;
                }
            }

            return frequency;
        }

        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }
    }
}
