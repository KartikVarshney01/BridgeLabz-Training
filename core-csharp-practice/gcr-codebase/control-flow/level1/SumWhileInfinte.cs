using System;
// class named SumWhileInfinite to sum user input value until value hit 0.
class SumWhileInfinite{
	static void Main(String[] args){
		
		// Initializing sum variable
		
		double sum = 0.0;
		
		while(true){
			// Taking Input
			Console.Write("Enter number : ");
			double num = Convert.ToDouble(Console.ReadLine());
			
			if(num==0 || num<0) break;
			
			sum += num;
		}
		
		// Output
		Console.WriteLine($"The sum is {sum}");
	}
}