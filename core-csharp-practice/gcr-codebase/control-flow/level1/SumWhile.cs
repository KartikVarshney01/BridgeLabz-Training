using System;
// class named SumWhile to sum user input value until value hit 0.
class SumWhile{
	static void Main(String[] args){
		//Taking Input
		Console.Write("Enter the starting number : ");
		double num = Convert.ToDouble(Console.ReadLine());
		
		// Initializing sum variable
		
		double sum = 0.0;
		
		while(num != 0){
		sum += num;
		Console.Write("Enter number : ");
		num = Convert.ToDouble(Console.ReadLine());
		}
		
		// Output
		Console.WriteLine($"The sum is {sum}");
	}
}