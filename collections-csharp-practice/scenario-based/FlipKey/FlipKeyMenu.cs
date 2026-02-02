using System;
namespace FlipKey
{
    public class FlipKeyMenu
    {
        private FlipKeyUtility Utility;

        public FlipKeyMenu()
        {
            Utility = new FlipKeyUtility();
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Welcome To Flip Key");
                Console.WriteLine("1. Give String");
                Console.WriteLine("2. Exit");
                Console.Write("Enter Your Choice : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter The String : ");
                        string input = Console.ReadLine();
                        string result = Utility.CleanseAndInvert(input);
                        if(result != "") Console.WriteLine($"The generated key is - {result}.");
                        else Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}