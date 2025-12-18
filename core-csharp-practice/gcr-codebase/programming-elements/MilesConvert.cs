class MilesConvert
{
    static void Main(string[] args)
    {
        double kilometer = double.Parse(Console.ReadLine());
        double miles = kilometer * 0.621371;

        Console.WriteLine(miles);
    }
}
