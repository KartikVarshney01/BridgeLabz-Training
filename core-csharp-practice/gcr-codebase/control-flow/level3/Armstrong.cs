using System;
// Class named Armstrong to check whether a number is Armstrong number or not.
class Armstrong{
    static void Main(){
        // Taking user input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Initializing variables
        int sum = 0;
        int originalNum = num;

        // Finding Output
        while(originalNum!=0){
            int remainder = originalNum%10;
            sum += remainder * remainder * remainder;
            originalNum /= 10;
        }

        // Output
        if(sum==num){
            Console.WriteLine($"{num} is an Armstrong number.");
        }else{
            Console.WriteLine($"{num} is not an Armstrong number.");
        }
    }
}
