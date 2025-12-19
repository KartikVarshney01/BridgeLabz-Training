using System;
class SamMark{
     static void Main(String[] args){
		int Mathsmark = 94;
		int Physicsmark = 95;
		int Chemistrymark = 96;
		double averagemark = ((Mathsmark+Physicsmark+Chemistrymark)/300.0)*100;
		//double averagepercent = averagemark*100;
		Console.WriteLine("Sam’s average mark in PCM is : " + averagemark);
	 }
}