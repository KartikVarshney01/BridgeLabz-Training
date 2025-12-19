using System;
class Athlete{
    public static void Main(string[] args)
    {
	    Console.WriteLine("Enter Side 1 : ");
        double side1=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Side 2 : ");
        double side2=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Side 3 : ");
        double side3=double.Parse(Console.ReadLine());
        double perimeter=side1+side2+side3;
        double rounds=5/perimeter;
        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
    }
}
