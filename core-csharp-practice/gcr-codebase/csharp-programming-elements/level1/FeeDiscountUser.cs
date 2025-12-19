using System;
class FeeDiscountUser{
     static void Main(String[] args){
		
		double fee = double.Parse(Console.ReadLine()) ;
		double discountpercent = double.Parse(Console.ReadLine());
		double discount = (fee*discountpercent)/100;
		double discountedfee = fee-discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedfee);
	 }
}