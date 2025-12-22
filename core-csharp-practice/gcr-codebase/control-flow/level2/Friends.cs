using System;
// class named Friends to check youngest and tallest among three friends based on their age.
class Friends{
    static void Main(){
		// Taking Input
    
        Console.Write("Enter Amar age: ");
        int amarage = Convert.ToInt32(Console.ReadLine());
        
		Console.Write("Enter Amar height: ");
        int amarheight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar age: ");
        int akbarage = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar height: ");
        int akbarheight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony age: ");
        int anthonyage = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony height: ");
        int anthonyheight = Convert.ToInt32(Console.ReadLine());

        // Finding Output
        if (amarage <= akbarage && amarage <= anthonyage)
            Console.WriteLine("Youngest Friend: Amar");
        else if (akbarage <= amarage && akbarage <= anthonyage)
            Console.WriteLine("Youngest Friend: Akbar");
        else
            Console.WriteLine("Youngest Friend: Anthony");

        if (amarheight >= akbarheight && amarheight >= anthonyheight)
            Console.WriteLine("Tallest Friend: Amar");
        else if (akbarheight >= amarheight && akbarheight >= anthonyheight)
            Console.WriteLine("Tallest Friend: Akbar");
        else
            Console.WriteLine("Tallest Friend: Anthony");
    }
}
