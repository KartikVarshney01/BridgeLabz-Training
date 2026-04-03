using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateData
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("users.csv");

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string email = data[2];
            string phone = data[3];

            bool emailValid = Regex.IsMatch(email, emailPattern);
            bool phoneValid = phone.Length == 10;

            if (!emailValid || !phoneValid)
            {
                Console.WriteLine("Invalid Row: " + lines[i]);
            }
        }
    }
}
