using System;
// class named Bonus to find bonus depending on year of service.
class Bonus{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the salary : ");
		int salary = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the years of service : ");
		int yearsofservice = Convert.ToInt32(Console.ReadLine());
		
		// Output
		if(yearsofservice>5){
			double sum = (salary * 5)/100;
			Console.WriteLine($"The bonus amount is {sum}");
		}else{
			Console.WriteLine("The yearsofservice of service is not reached");
		}
	}
}