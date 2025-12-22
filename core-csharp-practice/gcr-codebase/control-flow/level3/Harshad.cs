using System;
// Class named Harshad to check whether a number is Harshad number or not.
class Harshad{
    static void Main(){
        // Taking User input
        Console.Write("Enter a num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalnum = num;
        while (originalnum != 0){
            int remainder = originalnum % 10;  
            sum += remainder;
            originalnum /= 10;
        }

        // Output
        if (num%sum==0) Console.WriteLine($"{num} is a Harshad num.");
        else Console.WriteLine($"{num} is not a Harshad num.");
    }
}
