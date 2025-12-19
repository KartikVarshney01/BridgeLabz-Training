using System;
class FeeDiscount{
     static void Main(String[] args){
		
		int fee = 125000;
		int discountpercent = 10;
		double discount = (fee*discountpercent)/100;
		double discountedfee = fee-discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedfee);
	 }
}