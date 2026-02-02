using System;
using System.Collections.Generic;


namespace StreamBuzz
{
    public class Menu
    {
        private ICreatorService service;

        public Menu()
        {
            service = new CreatorServiceImpl();
        }

        public void DisplayMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Register Creator");
                Console.WriteLine("2. Show Top Posts");
                Console.WriteLine("3. Calculate Average Likes");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterCreatorMenu();
                        break;

                    case 2:
                        ShowTopPostsMenu();
                        break;

                    case 3:
                        ShowAverageLikes();
                        break;

                    case 4:
                        Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void RegisterCreatorMenu()
        {
            Console.WriteLine("Enter Creator Name:");
            string name = Console.ReadLine();

            double[] likes = new double[4];
            Console.WriteLine("Enter weekly likes (Week 1 to 4):");

            for (int i = 0; i < 4; i++)
            {
                likes[i] = Convert.ToDouble(Console.ReadLine());
            }

            CreatorStats creator = new CreatorStats
            {
                CreatorName = name,
                WeeklyLikes = likes
            };

            service.RegisterCreator(creator);
            Console.WriteLine("Creator registered successfully");
        }

        private void ShowTopPostsMenu()
        {
            Console.WriteLine("Enter like threshold:");
            double threshold = Convert.ToDouble(Console.ReadLine());

            Dictionary<string, int> result =
                service.GetTopPostCounts(
                    CreatorStats.EngagementBoard,
                    threshold
                );

            if (result.Count == 0)
            {
                Console.WriteLine("No top-performing posts this week");
            }
            else
            {
                foreach (KeyValuePair<string, int> entry in result)
                {
                    Console.WriteLine(entry.Key + " - " + entry.Value);
                }
            }
        }

        private void ShowAverageLikes()
        {
            double average = service.CalculateAverageLikes();
            Console.WriteLine("Overall average weekly likes: " + average);
        }
    }
}
