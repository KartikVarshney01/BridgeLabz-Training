using System;
//class named CountDownFor to count down a number sequence for rocket launch
class CountDownFor{
	static void Main(String[] args){
		// User Input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// Output
		for(int i=num;i>0;i--){
			Console.WriteLine(i);
		}
	}
}