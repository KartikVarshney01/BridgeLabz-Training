class Volume
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine()); // radius
        double h = double.Parse(Console.ReadLine()); // height

        double volume = Math.PI * r * r * h;
        Console.WriteLine(volume);
    }
}
