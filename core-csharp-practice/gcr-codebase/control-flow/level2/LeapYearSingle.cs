using System;
// class LeapYearSingle to check whether a given year is leap or not using single if statements
class LeapYearSingle{
	static void Main(String[] args){
		// Taking user input
		Console.Write("Enter the year : ");
		int year = Convert.ToInt32(Console.ReadLine());
		
		// output check using multiple if-else
		if(year>=1582 &&(year%400==0)||(year%4==0 && year%100!=0)) Console.WriteLine($"The year {year} is a leap year");
		else Console.WriteLine($"The year {year} is not a leap year");
	}
}