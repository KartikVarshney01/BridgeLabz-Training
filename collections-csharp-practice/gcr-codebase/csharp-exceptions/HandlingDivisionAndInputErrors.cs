using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class HandlingDivisionAndInputErrors
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Numerator : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Denomination : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result : {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error : Divide By Zero Not Possible");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error : Numeric Value Only");
            }
        }
    }
}
