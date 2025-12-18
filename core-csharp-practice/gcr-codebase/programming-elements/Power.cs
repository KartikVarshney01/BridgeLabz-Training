class Power
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine()); // base
        double e = double.Parse(Console.ReadLine()); // exponent

        double ans = Math.Pow(a, e);
        Console.WriteLine(ans);
    }
}