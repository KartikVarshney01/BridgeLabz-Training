using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class CountWords
    {
        static void Main()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                            StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word] = wordCount[word] + 1;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                    }
                }
            }

            List<KeyValuePair<string, int>> sortedWords =
                wordCount.OrderByDescending(w => w.Value).ToList();

            Console.WriteLine("Top 5 most frequent words:\n");

            for (int i = 0; i < 5 && i < sortedWords.Count; i++)
            {
                Console.WriteLine(sortedWords[i].Key + " : " + sortedWords[i].Value);
            }
        }
    }
}
