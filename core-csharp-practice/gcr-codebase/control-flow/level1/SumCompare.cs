using System;
// class named SumCompare to check two sum one compute from while loop and other by formula n*(n+1)/2;
class SumCompare{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// checking if number is natural or not
		
		if(num<=0) Console.WriteLine("The number is not a natural number");
		else{
			double sum = (num*(num+1))/2.0;
			double total = 0.0;
			while(num>0) total += num--;
			Console.WriteLine($"The Sum using formula is {sum}");
			Console.WriteLine($"The Sum using while loop is {total}");
		}
	}
}