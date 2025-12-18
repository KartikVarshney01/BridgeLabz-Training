class Add
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()); // first input
        int b = int.Parse(Console.ReadLine()); // second input
        int c = a + b; // sum of both inputs

        Console.WriteLine("The sum of two numbers : " + c);
    }
}