class SimpleInterest
{
    static void Main(string[] args)
    {
        int principal = int.Parse(Console.ReadLine());
        int rate = int.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());

        int si = (principal * rate * time) / 100;
        Console.WriteLine(si);
    }
}