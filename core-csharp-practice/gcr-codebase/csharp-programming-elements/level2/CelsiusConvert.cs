using System;
class CelsiusConvert{
    static void Main(){
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius.");
    }
}
