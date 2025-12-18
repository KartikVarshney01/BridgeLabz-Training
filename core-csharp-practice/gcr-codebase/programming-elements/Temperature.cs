using System;

class Temperature
{
    static void Main(string[] args)
    {
        double cel = double.Parse(Console.ReadLine());
        double fah = (cel * 9.0 / 5.0) + 32;
        Console.WriteLine(fah);
    }
}