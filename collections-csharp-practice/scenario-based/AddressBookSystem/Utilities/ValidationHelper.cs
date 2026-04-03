using System;
using System.Text.RegularExpressions;
namespace AddressBookSystem
{
    public static class ValidationHelper
    {
        // Name: First letter capital, minimum 3 letters
        public static bool ValidateName(string name)
        {
            return Regex.IsMatch(name,"^[A-Z][a-zA-Z]{2,}$");
        }

        // Address: minimum 4 characters
        public static bool ValidateAddress(string address)
        {
            return Regex.IsMatch(address, @"^[a-zA-Z0-9\s,.-]{4,}$");
        }

        // City & State: First letter capital
        public static bool ValidateCityState(string value)
        {
            return Regex.IsMatch(value, "^[A-Z][a-zA-Z]{2,}$");
        }

        // Zip: 6 digits (India)
        public static bool ValidateZip(string zip)
        {
            return Regex.IsMatch(zip, @"^\d{6}$");
        }

        // Phone: 10 digits starting from 6-9
        public static bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]\d{9}$");
        }

        // Email validation
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
    }
}