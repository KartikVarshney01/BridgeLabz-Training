using System;
class IntOperation{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int ans1 = a + b * c;   // Multiplication before addition
        int ans2 = a * b + c;   // Multiplication before addition
        int ans3 = c + a / b;   // Division before addition
        int ans4 = a % b + c;   // Modulus before addition

        Console.WriteLine("The results of Int Operations are " + ans1 + ", " + ans2 + ", " + ans3 + ", and " + ans4);
    }
}
