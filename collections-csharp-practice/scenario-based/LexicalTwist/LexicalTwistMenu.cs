using System;

class LexicalTwistMenu
{
    private LexicalUtilityImpl Utility;
    public LexicalTwistMenu()
    {
        Utility = new LexicalUtilityImpl();
    }
    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("Welcome To Lexical Twist");
            Console.WriteLine("1. Enter Strings");
            Console.WriteLine("2. Exit");
            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1 :
                    Utility.AddWords();
                    break;
                case 2:
                    Console.WriteLine("Exiting From Lexical Twist");
                    return;
                default:
                    break;
            }
        }
    }
}