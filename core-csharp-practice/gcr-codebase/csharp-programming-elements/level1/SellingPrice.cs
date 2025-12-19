using System;
class SellingPrice{
     static void Main(String[] args){
		int costprice = 129;
		int sellingprice = 191;
		int profit = sellingprice-costprice;
		double profitpercent = (profit*100)/costprice;
		Console.WriteLine("The cost price is INR " + costprice + " and selling price is INR " + sellingprice + "\nThe Profit is INR " + profit + " And the Profit Percentage is " + profitpercent);
	 }
}