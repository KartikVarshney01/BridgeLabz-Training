using System;
// class named Power to find power of a number using loops
class Power{
    static void Main(){
        // Taking user input
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Initializing result
        int result = 1;

        // Finding output
        for (int i=1;i<=power;i++){
            result =  result * num;
        }

        // Output
        Console.WriteLine($"Number {num} raised to power {power} is {result}.");
    }
}
