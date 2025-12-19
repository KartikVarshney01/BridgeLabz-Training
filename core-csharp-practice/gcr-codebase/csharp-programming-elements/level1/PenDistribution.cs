using System;
class PenDistribution{
     static void Main(String[] args){
		int pen = 14;
		int student = 3;
		int receivedpens = pen/student;
		int remainingpens = pen%student;
		Console.WriteLine("The Pen Per Student is " + receivedpens + " and the remaining pen not distributed is " + remainingpens);
	 }
}