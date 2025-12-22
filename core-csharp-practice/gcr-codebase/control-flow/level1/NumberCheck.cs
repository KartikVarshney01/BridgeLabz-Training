// class named NumberCheck to check whether a number is positive, negative or zero.
class NumberCheck{
	static void Main(String[] args){
		// User Input
		Console.WriteLine("Enter the number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// If-Else statement checking for conditions and giving output based on them.
		if(num>0) Console.WriteLine($"The number {num} is positive.");
		else if(num<0) Console.WriteLine($"The number {num} is negative.");
		else Console.WriteLine($"The number {num} is zero.")
;	}	
}