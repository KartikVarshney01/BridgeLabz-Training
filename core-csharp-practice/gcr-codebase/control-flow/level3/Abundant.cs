using System;
// Class named Abundant to check whether a number is Abundant or not.
class Abundant{
    static void Main(){
        // Taking input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i=1;i<num;i++){
            if(num%i==0){
                sum += i;
            }
        }

        // Output
        if(sum>num) Console.WriteLine($"{num} is an Abundant Number.");
        else Console.WriteLine($"{num} is not an Abundant Number.");
    }
}
