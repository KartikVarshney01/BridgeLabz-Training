using System;

class Chocolates{
    static void Main(){
        Console.Write("Enter number of chocolates: ");
        int Chocolatesnum = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int Childrennum = int.Parse(Console.ReadLine());

        int Each = Chocolatesnum / Childrennum;
        int RemainingCh = Chocolatesnum % Childrennum;

        Console.WriteLine("The number of chocolates each child gets is " + Each +" and the number of remaining chocolates is " + RemainingCh);
    }
}