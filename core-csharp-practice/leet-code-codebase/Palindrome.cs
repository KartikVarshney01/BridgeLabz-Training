class Palindrome
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(Fun(x));
    }

    static bool Fun(int x)
    {
        int original = x; // Original number
        int rev = 0;      // Reverse value

        while (x > 0)
        {
            int v = x % 10;   // Last digit
            rev = rev * 10 + v;
            x /= 10;
        }
        return original == rev;
    }
}