// class name SmallestNumber to check if the first number is the smallest.
class SmallestNumber{
	static void Main(String[] args){
		// Taking user input
		Console.WriteLine("Enter 1st Number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter 2nd Number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter 3rd Number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		// Output showing if the first number is the smallest.
		Console.WriteLine("Is the first number the smallest? " + (num1<num2 && num1<num3));
	}
}