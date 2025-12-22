using System;
// class named Factor to find greatest factor beside number itself.
class Factor{
    static void Main(){
        // Taking user input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Initializing greatest factor
        int GreatestFac = 1;

        // Finding output
        for (int i=num-1;i>=1;i--){
            if (num%i==0){
                GreatestFac = i;
                break;
            }
        }

        // Output
        Console.WriteLine($"Greatest Factor of number other than itself is {GreatestFac}");
    }
}
