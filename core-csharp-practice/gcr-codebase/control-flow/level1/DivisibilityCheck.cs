// Class name DivisibilityCheck to check divisibility by 5.
class DivisibilityCheck{
	static void Main(String[] args){
		Console.WriteLine("Enter a number : ");
		// Taking user input
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Is the " + num + " divisible by 5? " + (num % 5 == 0));
	}
}
