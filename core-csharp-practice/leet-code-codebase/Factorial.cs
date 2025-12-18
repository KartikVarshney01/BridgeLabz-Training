class Factorial
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fun(n));
    }

    static int Fun(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * Fun(n - 1);
    }
}