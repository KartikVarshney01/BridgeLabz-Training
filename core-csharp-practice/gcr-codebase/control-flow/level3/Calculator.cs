using System;
// class named Calculator to perform calculation on two user input numbers and a user input operation using switch case.
class Calculator{
    static void Main(){
        // Taking user input
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator: ");
        string op = Console.ReadLine();

        switch (op){
            case "+":
				double sum = first+second;
                Console.WriteLine($"Result = {sum}");
                break;
				
            case "-":
				double sub = first-second;
                Console.WriteLine($"Result = {sub}");
                break;
				
            case "*":
				double mul = first*second;
                Console.WriteLine($"Result = {mul}");
                break;
				
            case "/":
				double div = first/second;
                Console.WriteLine($"Result = (div)");
                break;
				
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
