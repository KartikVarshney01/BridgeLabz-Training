using System;
// class named EvenOdd to check or show whether a number is even or odd on each iteration.
class EvenOdd{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// checking if number is positive or not.
		
		if(num<=0) Console.WriteLine("The number is not a natural number");
		else{
			for(int i=1;i<=num;i++){
				if(i%2==0) Console.WriteLine($"The number {i} is even");
				else Console.WriteLine($"The number {i} is odd");
			}
		}
	}
}