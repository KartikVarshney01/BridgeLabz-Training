using System;

namespace TechVille.Utilities
{
    public static class InputValidator
    {
        public static bool IsValidAge(int age)
        {
            return age > 0;
        }

        public static bool IsValidIncome(double income)
        {
            return income >= 0;
        }

        public static bool IsValidResidency(int years)
        {
            return years >= 0;
        }
    }
}