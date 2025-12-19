using System;
class DistanceConvert
{
    static void Main(string[] args)
    {
        double distanceInFeet = double.Parse(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine("The distance in feet is " + distanceInFeet + " while in yards is " + distanceInYards + " and miles is " + distanceInMiles );
    }
}
