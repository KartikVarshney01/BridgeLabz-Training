using System;
class TotalIncome{
    static void Main(){
        Console.Write("Enter your salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter your bonus: ");
        double bonus = double.Parse(Console.ReadLine());

        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome + ".");
    }
}
