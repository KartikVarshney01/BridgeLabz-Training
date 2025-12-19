using System;

class SI{
    static void Main(){
        Console.Write("Enter principal Amount: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Enter time: ");
        double t = double.Parse(Console.ReadLine());

        double si = (p * r * t) / 100;

        Console.WriteLine("The Simple Interest is " + si +" for Principal " + p +", Rate of Interest " + r +" and Time " + t);
    }
}