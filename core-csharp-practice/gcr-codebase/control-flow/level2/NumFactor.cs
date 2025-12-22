using System;
// class named NumFactor to find factors of a user given number.
class NumFactor{
    static void Main(){
        // Taking user input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors of " + num + " are:");

        for (int i=1;i<num;i++){
            if (num%i==0){
                Console.WriteLine(i);
            }
        }
    }
}
