// class named VoteEligible to check if a person is eligible to vote or not based on age.
class VoteEligible{
	static void Main(String[] args){
		// User Input their age
		Console.WriteLine("Enter your age : ");
		int age = Convert.ToInt32(Console.ReadLine());
		
		// Function Output
		if(age>=18) Console.WriteLine("The person's age is " + age + " and can vote.");
		else Console.WriteLine("The person's age is " + age + " and cannot vote.");
	}
}