// class is named NaturalNumSum to show that it is checking whether a number is natural or not and then finding the sum upto that natural number.
class NaturalNumSum(){
	static void Main(String[] args){
		// Taking a number from the user
		Console.WriteLine("Enter a number: ");
		
		int num = Convert.ToInt32(Console.ReadLine());
		
		// Using if and else statements to check for natural number and its sum.
		
		if(num>=0){
			int sum =  (num * (num + 1))/2;
			Console.WriteLine("The sum of " + num + " natural number is " + sum);
		}else{
			Console.WriteLine("The number " + num + " is not a natural number");
		}
	}
}