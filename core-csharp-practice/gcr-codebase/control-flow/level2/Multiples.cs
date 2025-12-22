using System;
// class named Multiples to find multiplies of a number below 100.
class Multiples{
    static void Main(){
        // Taking user input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiples of " + num + " below 100 are:");

		// Output
        for (int i=100;i>=1;i--){
            if (i%num==0){
                Console.WriteLine(i);
            }
        }
    }
}
