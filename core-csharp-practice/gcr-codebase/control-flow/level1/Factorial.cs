using System;
// class named Factorial to compute the factorial of a number.
class Factorial{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		int temp = num;
		
		// checking if number is positive or not.
		
		if(num<0) Console.WriteLine("The number is negative number");
		else{
			int ans = 1;
			while(num>0) ans *= num--;
			Console.WriteLine($"The factorial of {temp} is {ans}.");
		}
	}
}