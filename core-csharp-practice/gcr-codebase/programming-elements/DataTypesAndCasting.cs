using System;

class DataTypesAndCasting
{
    static void Main()
    {
        // BASIC DATA TYPES (User-level examples)

        // 1. int → used for whole numbers
        int age = 21;
        Console.WriteLine("Age (int): " + age);

        // 2. float → used for decimal values (less precision)
        float temperature = 36.6f;
        Console.WriteLine("Body Temperature (float): " + temperature);

        // 3. double → used for large decimal values (more precision)
        double Balance = 45892.75;
        Console.WriteLine("Bank Balance (double): " + Balance);

        // 4. char → used to store a single character
        char grade = 'A';
        Console.WriteLine("Grade (char): " + grade);

        // 5. bool → stores true or false
        bool isTrue = false;
        Console.WriteLine("Is user logged in? (bool): " + isTrue);

        // 6. string → used to store text
        string city = "Delhi";
        Console.WriteLine("City (string): " + city);

        Console.WriteLine();
        Console.WriteLine("===== TYPE CASTING EXAMPLES =====");

        // IMPLICIT CASTING
        // (Safe: small data type → large data type)


        int marks = 85;
        double marksInDouble = marks; // int automatically converted to double
        Console.WriteLine("Implicit Casting (int to double): " + marksInDouble);


        // EXPLICIT CASTING
        // (Manual: large data type → small data type)

        double price = 199.99;
        int roundedPrice = (int)price; // decimal part will be lost
        Console.WriteLine("Explicit Casting (double to int): " + roundedPrice);


        // USING CONVERT CLASS
        // (Mostly used when taking user input)
  
        string userInputAge = "30";
        int convertedAge = Convert.ToInt32(userInputAge);
        Console.WriteLine("Converted String to int: " + convertedAge);

        string salaryText = "55000.50";
        double salary = Convert.ToDouble(salaryText);
        Console.WriteLine("Converted String to double: " + salary);

   
        // STRING CHARACTER ACCESS

        string message = "Welcome";
        char firstLetter = message[0]; // Accessing first character
        Console.WriteLine("First letter of message: " + firstLetter);


        // NUMBER TO STRING

        int orderId = 12345;
        string orderIdText = orderId.ToString();
        Console.WriteLine("Order ID as string: " + orderIdText);

  
        // CHAR TO ASCII VALUE

        char symbol = 'Z';
        int ascii = symbol; // Implicit conversion
        Console.WriteLine("ASCII value of '" + symbol + "': " + ascii);

        Console.WriteLine();
    }
}