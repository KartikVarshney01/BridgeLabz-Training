using System;
// class name FizzBuzz using while loop
class FizzBuzzWhile{
    static void Main(string[] args){
        // Taking user input
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Output
        if (num < 0)
        {
            Console.WriteLine("The number is not a positive number.");
        }
        else
        {
            int i = 0;
            while (i <= num)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

                i++;
            }
        }
    }
}
