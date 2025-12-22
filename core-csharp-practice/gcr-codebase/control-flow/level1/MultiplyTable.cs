using System;
// Class named MultiplyTable to find multiplication from 6 to 9;
class MultiplyTable{
	static void Main(String[] args){
		//Taking user input
		Console.Write("Enter the number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		// Output
		for(int i=6;i<=9;i++){
			Console.WriteLine($"{num} * {i} = {num*i}");
		}
	}
}