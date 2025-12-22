using System;
// class name BMI to calculate bmi of a body from given height and weight.
class BMI{
    static void Main(){
        // Taking user input
        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightcm = Convert.ToDouble(Console.ReadLine());

        // Converting height to meters
        double heightm = heightcm / 100;

        // BMI calculate
        double bmi = weight / (heightm * heightm);

        // Output
        if (bmi <= 18.4)
            Console.WriteLine("Status: Underweight");
        else if (bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("Status: Normal");
        else if (bmi >= 25.0 && bmi <= 39.9)
            Console.WriteLine("Status: Overweight");
        else
            Console.WriteLine("Status: Obese");
    }
}
