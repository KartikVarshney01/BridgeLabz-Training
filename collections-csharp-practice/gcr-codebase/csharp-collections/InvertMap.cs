using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class InvertMap
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>{{ "A", 1 },{ "B", 2 },{ "C", 1 }};

            Console.WriteLine("Original Map:");
            foreach (KeyValuePair<string, int> entry in input)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }

            Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

            foreach (KeyValuePair<string, int> entry in input)
            {
                int value = entry.Value;
                string key = entry.Key;

                if (!invertedMap.ContainsKey(value))
                {
                    invertedMap[value] = new List<string>();
                }

                invertedMap[value].Add(key);
            }

            Console.WriteLine("\nInverted Map:");

            foreach (KeyValuePair<int, List<string>> entry in invertedMap)
            {
                Console.Write(entry.Key + " = [ ");
                foreach (string item in entry.Value)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
