using System;
class DoubleOpt{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double ans1 = a + b * c;   // Multiplication before addition
        double ans2 = a * b + c;   // Multiplication before addition
        double ans3 = c + a / b;   // Division before addition
        double ans4 = a % b + c;   // Modulus before addition

        Console.WriteLine("The results of Double Operations are " + ans1 + ", " + ans2 + ", " + ans3 + ", and " + ans4);
    }
}
