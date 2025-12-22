using System;
// Class named DigitsCount to count digits in a number
class DigitsCount{
    static void Main(){
        // Taking user input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while(num!=0){
            num /= 10;
            count++;
        }

        // Output 
        Console.WriteLine($"Number of digits is {count}");
    }
}
