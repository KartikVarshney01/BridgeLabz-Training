using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class CreatingAndHandlingACustomException
    {
        class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)
            {

            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Your Age : ");
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine("Access Granted");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above");
            }
        }
    }
}
