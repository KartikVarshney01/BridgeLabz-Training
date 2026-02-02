using System;
using System.Reflection.PortableExecutable;
using System.Text;
namespace FlipKey
{
    public class FlipKeyUtility
    {
        public string CleanseAndInvert(string input)
        {
            if(input == null || input.Length<6) return "";
            foreach(char c in input)
            {
                if(!char.IsLetter(c)) return "";
            }

            input = input.ToLower();
            StringBuilder result = new StringBuilder();

            foreach(char c in input)
            {
                if((int)c % 2 != 0 ) result.Append(c);
            }

             // Reverse
            char[] arr = result.ToString().ToCharArray();
            Array.Reverse(arr);

            // Uppercase even index
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    arr[i] = char.ToUpper(arr[i]);
            }

            return new string(arr);
        }
    }
}