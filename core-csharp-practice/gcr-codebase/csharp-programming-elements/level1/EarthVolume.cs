using System;
class EarthVolume{
     static void Main(String[] args){
		double radiusinkm = 6378;
		double radiusinmiles = radiusinkm/1.6;
		double volumeinkm = (4.0 * Math.PI * Math.Pow(radiusinkm,3))/3.0;
		double volumeinmiles = (4.0 * Math.PI * Math.Pow(radiusinmiles,3))/3.0;
		Console.WriteLine("The volume of earth in cubic kilometers is " + volumeinkm + " and cubic miles is " + volumeinmiles); 
	 }
}