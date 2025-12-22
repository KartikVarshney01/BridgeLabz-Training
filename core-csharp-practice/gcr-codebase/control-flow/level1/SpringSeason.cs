using System;
// class named SpringSeason to check whether it is spring season or not.
class SpringSeason{
	static void Main(String[] args){
		// User Input
		Console.WriteLine("Enter the Month : ");
		int month = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the Day : ");
		int day = Convert.ToInt32(Console.ReadLine());
		
		// Function Output
		
		bool check = (month==3 && day>=20 && day<32) || (month==4 && day>0 && day<31) || (month==5 && day>0 && day<32) || (month==6 && day>0 && day<=20);
		
		Console.WriteLine(check?"Its a Spring Season." : "It is not a Spring Season");
	}	
}