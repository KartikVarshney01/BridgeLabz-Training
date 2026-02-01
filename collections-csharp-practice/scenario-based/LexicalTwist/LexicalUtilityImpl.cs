using System;
using System.Text;

class LexicalUtilityImpl
{
    public void AddWords()
    {
        Console.Write("Enter First Word : ");
        string str1 = Console.ReadLine();

        if (str1.Contains(" "))
        {
            Console.WriteLine($"{str1} is an invalid word");
            return;
        }

        Console.Write("Enter Second Word : ");
        string str2 = Console.ReadLine();

        if (str2.Contains(" "))
        {
            Console.WriteLine($"{str2} is an invalid word");
            return;
        }

        str1 = str1.ToLower();
        str2 = str2.ToLower();
        
        if (isReverse(str1, str2))
        {
            ReversedWord(str1);
        }
        else
        {
            string combined = str1+str2;
            combined = combined.ToUpper();
            NotReversed(combined);
        }
    }
    private bool isReverse(string str1, string str2)
    {
        if(str1.Length!=str2.Length) return false;
        int j = str2.Length - 1;
        for (int i = 0; i < str1.Length; i++, j--)
        {
            if (str1[i] != str2[j]) return false;
        }
        return true;
    }

    private void ReversedWord(string str1)
    {
        StringBuilder result = new StringBuilder();
        string s = str1.ToLower();
        for(int i = str1.Length - 1; i >= 0; i--)
        {
            if(s[i]=='a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                result.Append('@');
            }
            else
            {
                result.Append(s[i]);
            }
        }
        Console.WriteLine($"The Result is {result.ToString()}");    
    }
    private void NotReversed(string combined)
    {
        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char c in combined)
        {
            if (IsVowel(c))
                vowelCount++;
            else
                consonantCount++;
        }

        if (vowelCount > consonantCount)
        {
            PrintFirstTwoUnique(combined, true);
        }
        else if (consonantCount > vowelCount)
        {
            PrintFirstTwoUnique(combined, false);
        }
        else
        {
            Console.WriteLine("Vowels and consonants are equal");
        }
    }

    private void PrintFirstTwoUnique(string word, bool pickVowels)
    {
        HashSet<char> set = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        foreach (char c in word)
        {
            if (pickVowels && IsVowel(c) && !set.Contains(c))
            {
                set.Add(c);
                result.Append(c);
            }
            else if (!pickVowels && !IsVowel(c) && !set.Contains(c))
            {
                set.Add(c);
                result.Append(c);
            }

            if (result.Length == 2)
            {
                Console.WriteLine(result.ToString());
                return;
            }
        }
    }

    private bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
            || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
    }
}