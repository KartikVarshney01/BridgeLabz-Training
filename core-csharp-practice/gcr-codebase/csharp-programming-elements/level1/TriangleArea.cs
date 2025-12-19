using System;

class TriangleArea
{
    static void Main(string[] args)
    {
        double baseinch = double.Parse(Console.ReadLine());
        double heightinch = double.Parse(Console.ReadLine());

        double areainch = 0.5 * baseinch * heightinch;

        double areaCm = areainch * 2.54 * 2.54;

        Console.WriteLine("The area of the triangle is " + areainch + " square inches and " + areaCm + " square centimeters");
    }
}
