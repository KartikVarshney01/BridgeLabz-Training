using System;
// class named SumCompareFor to check two sum one compute from for loop and other by formula n*(n+1)/2;
class SumCompareFor{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// checking if number is natural or not
		
		if(num<=0) Console.WriteLine("The number is not a natural number");
		else{
			double sum = (num*(num+1))/2.0;
			double total = 0.0;
			for(int i=num;i>0;i--) total += i;
			Console.WriteLine($"The Sum using formula is {sum}");
			Console.WriteLine($"The Sum using while loop is {total}");
		}
	}
}