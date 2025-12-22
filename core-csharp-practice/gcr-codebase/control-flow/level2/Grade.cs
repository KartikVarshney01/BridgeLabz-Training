using System;
// class named Grade to show average,remarks and avgcent of three subjects.
class Grade{
    static void Main(){
		// Taking Input
        Console.Write("Enter Maths Marks: ");
        int math = Convert.ToInt32(Console.ReadLine());
		
        Console.Write("Enter Physics Marks: ");
        int phy = Convert.ToInt32(Console.ReadLine());
        
		Console.Write("Enter Chemistry Marks: ");
        int chem = Convert.ToInt32(Console.ReadLine());
    
        double avg = (chem+phy+math)/3.0;
        
		switch (avg)
        {
            case >=80 : Console.WriteLine($"Marks : {avg}\nGrade : A\nRemark: Level 4, above agency-normalized standards");
            break;
            case >= 70 and <=79 : Console.WriteLine($"Marks : {avg}\nGrade : B\nRemark: Level 3, at agency-normalized standards");
            break;
            case >= 60 and <= 69 : Console.WriteLine($"Marks : {avg}\nGrade : C\nRemark: (Level 2, below, but approaching agency-normalized standards)");
            break;
            case >= 50 and <= 59 : Console.WriteLine($"Marks : {avg}\nGrade : D\nRemark: (Level 1, well below agency-normalized standards)");
            break;
            case >= 40 and <= 49 : Console.WriteLine($"Marks : {avg}\nGrade : E\nRemark: (Level 1- , too below agency-normalized standards)");
            break;
            case <= 39 : Console.WriteLine($"Marks : {avg}\nGrade : R\nRemark: (Remedial standards)");
            break;
        }
    }
}