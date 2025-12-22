using System;
//class named CountDownWhile to count down a number sequence for rocket launch
class CountDownWhile{
	static void Main(String[] args){
		// User Input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// Output
		while(num>0){
			Console.WriteLine(num--);
		}
	}
}