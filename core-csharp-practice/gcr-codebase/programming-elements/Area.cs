class Area
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine()); // Input radius
        double area = Math.PI * r * r;
        Console.WriteLine(area);
    }
}