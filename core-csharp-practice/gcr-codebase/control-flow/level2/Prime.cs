using System;
// class name Prime to check whether a number is prime or not.
class Prime{
	static void Main(String[] args){
		// Taking Input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// Initializing isPrime variable 
		bool isPrime = true;
		
		// Checking if number is 1 or negative.
		if(num<2) Console.WriteLine("The number is not valid.");
		else{
			for(int i=2;i<num;i++){
				if(num%i==0){
					isPrime=false;
					break;
				}
			}
		}
		if(isPrime) Console.WriteLine($"The number {num} is a prime number");
		else Console.WriteLine($"The number {num} is not a prime number");
	}
}
