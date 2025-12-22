using System;
// class named FactorialFor to compute the factorial of a number using for loop. 
class FactorialFor{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		int temp = num;
		
		// checking if number is positive or not.
		
		if(num<0) Console.WriteLine("The number is negative number");
		
		else{
			int ans = 1;
			for(int i=num;i>0;i--) ans *= i;
			Console.WriteLine($"The factorial of {temp} is {ans}.");
		}
	}
}