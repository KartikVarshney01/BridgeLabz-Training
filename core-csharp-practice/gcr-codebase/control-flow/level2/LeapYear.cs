using System;
// class LeapYear to check for whether a year is leap year or not using multiple if-else statements
class LeapYear{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the year : ");
		int year = Convert.ToInt32(Console.ReadLine());
		
		// output check using multiple if-else
		if(year<1582) Console.WriteLine("Not a leap year");
		else if(year%400==0) Console.WriteLine($"The year {year} is a leap year");
		else if(year%100==0) Console.WriteLine($"The year {year} is not a leap year");
		else if(year%4==0) Console.WriteLine($"The year {year} is a leap year");
		else Console.WriteLine("Not a leap year");
	}
}