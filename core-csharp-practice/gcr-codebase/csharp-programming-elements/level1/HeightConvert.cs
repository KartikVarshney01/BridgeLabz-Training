using System;

class HeightConvert{
    static void Main(string[] args)
    {
        double heightinCm = double.Parse(Console.ReadLine());

        double Inches = heightinCm / 2.54;

        int feet = (int)(Inches / 12);
        double inches = Inches % 12;

        Console.WriteLine("Your Height in cm is " + heightinCm + " while in feet is " + feet + " and inches is " + inches);
    }
}