using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    internal class SentenceFormatter
    {
        /* The program runs for a string and perform various operations on them according to user choice from the menu. The various choices are to format a paragraph
         * ,counting total word count, finding largest word, and replacing old word to new word
         * 
         * version - 1.0
         */
        static void Main(String[] args)
        {
            SentenceFormatter sf = new SentenceFormatter();
            sf.StringFun();
        }

        void StringFun()
        {
            // Taking Input for scenario case
            Console.WriteLine("Menu");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Choose for Auto-Formattting");
            Console.WriteLine("2. Choose for Analyzing And Replacing the paragarph");

            // Taking Input Choice
            Console.Write("Enter the Choosen Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FormatFun();
                    break;

                case 2:
                    // Taking Input of paragraph
                    Console.Write("Enter the paragraph : ");
                    string s = Console.ReadLine();

                    while (true)
                    {
                        Console.WriteLine("\nAnalyze Menu");
                        Console.WriteLine("1. Count the number of words in paragraph");
                        Console.WriteLine("2. Find And Display the longest word");
                        Console.WriteLine("3. Replace all occurrence of a specific word with another word");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter the choice : ");
                        int op = Convert.ToInt32(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                // TotalWord Function to find the total words count in the paragraph
                                int count = TotalWord(s);
                                // Display Output
                                Console.WriteLine($"The total count of words in the paragraph is : {count}");
                                break;

                            case 2:
                                // LongestFun Function to find the longest word in the given paragraph
                                LongestWord(s);
                                break;

                            case 3:
                                // Calling ReplaceWord function to find and replace the old word
                                s = ReplaceWord(s);
                                Console.WriteLine($"The paragraph after replacement is : {s}");
                                break;

                            // To break out of menu and end the code
                            case 4:
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Choose between 1-4");
                                break;
                        }
                    }
            }
        }
        void FormatFun()
        {
            // Taking Input of the string
            Console.WriteLine("Enter the paragraph : ");
            string s = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Empty paragraph provided.");
                return;
            }

            // Creating a result stringbuilder to store all formatting changes
            StringBuilder result = new StringBuilder();

            bool capitalCheck = true;

            // Calling User-Defined Trim Function to trim unessecary spaces
            s = TrimFun(s);

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (char.IsLetter(ch))
                {
                    result.Append(capitalCheck ? char.ToUpper(ch) : char.ToLower(ch));
                    capitalCheck = false;
                }
                else if (ch == '.' || ch == '!' || ch == '?')
                {
                    result.Append(ch);
                    capitalCheck = true;

                    if (i + 1 < s.Length && s[i + 1] != ' ')
                    {
                        result.Append(' ');
                    }
                }
                else if (ch == ' ')
                {
                    if (result.Length > 0 && result[result.Length - 1] != ' ')
                    {
                        result.Append(" ");
                    }
                }
                else result.Append(ch);
            }

            Console.WriteLine("The Formatted Paragraph is : ");
            Console.WriteLine(result.ToString());
        }

        string TrimFun(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return "";

            int i = 0;
            int j = s.Length - 1;

            while (i <= j && s[i] == ' ') i++;
            while (j >= i && s[j] == ' ') j--;

            return s.Substring(i, j - i + 1);
        }

        int TotalWord(string s)
        {
            // Initializing the count variable
            int count = 0;
            // Initializing wordCheck to check if there is a word or not before incrementing count. 
            bool wordCheck = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && !wordCheck)
                {
                    count++;
                    wordCheck = true;
                }
                else if (s[i] == ' ')
                {
                    wordCheck = false;
                }
            }
            return count;
        }

        void LongestWord(string s)
        {
            string[] words = Split(s);
            string longest = "";

            foreach (string w in words)
            {
                if (w.Length > longest.Length)
                {
                    longest = w;
                }
            }

            // Display Output
            Console.WriteLine($"Longest word in the paragraph is : {longest}");
        }

        string[] Split(string s)
        {
            // Finding total words in the paragraph
            int count = TotalWord(s);

            // Creating words array to store wach words
            string[] words = new string[count];

            StringBuilder sb = new StringBuilder();
            int idx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                // Creating StringBuilder sb to note each word before addding to the array

                if (ch != ' ')
                {
                    sb.Append(ch);
                }
                else if (sb.Length > 0)
                {
                    // Adding current word to words array
                    words[idx++] = sb.ToString();
                    // Clearing the current stored word to make space for new word
                    sb.Clear();
                }
            }
            if (sb.Length > 0 && idx < words.Length) words[idx] = sb.ToString();
            return words;
        }
        string ReplaceWord(string s)
        {

            Console.Write("Enter the old word : ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter the new word : ");
            string newWord = Console.ReadLine();

            // Creating result variable to store final paragraph
            string result = "";
            string currentWord = "";  // Stores one word at a time

            // Loop runs one extra time to process last word
            for (int i = 0; i <= s.Length; i++)
            {
                // Build current word until space is found
                if (i < s.Length && s[i] != ' ')
                {
                    currentWord += s[i];
                }
                else
                {
                    // Compare current word with old word
                    if (WordsEqual(currentWord, oldWord))
                        result += newWord;   // Replace word
                    else
                        result += currentWord;

                    // Add space if not end of string
                    if (i < s.Length)
                        result += " ";

                    // Reset for next word
                    currentWord = "";
                }
            }

            // Remove extra space at the end manually
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }

        // Function to compare two words ignoring case without using any inbuilt case-conversion method
        bool WordsEqual(string a, string b)
        {
            // If lengths are different, words cannot be equal
            if (a.Length != b.Length)
                return false;

            // Compare each character using ASCII conversion
            for (int i = 0; i < a.Length; i++)
            {
                char c1 = a[i];
                char c2 = b[i];

                // Convert uppercase to lowercase manually
                if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
                if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);

                // If any character does not match, return false
                if (c1 != c2)
                    return false;
            }
            return true;
        }
    }
}
