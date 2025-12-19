using System;
class PurchasePrice{
    static void Main(string[] args){
        double unitPrice = double.Parse(Console.ReadLine());
        int quantity = int.Parse(Console.ReadLine());
        double totalPrice = unitPrice * quantity;
		
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}
