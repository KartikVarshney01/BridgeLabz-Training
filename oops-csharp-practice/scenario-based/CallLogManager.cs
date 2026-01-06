using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    /// <summary>
    /// The program is used to track call logs and store them and uses to view them, or sort them by time or finding
    /// a specific logs using keywords
    /// 
    /// version - 1.0
    /// </summary>
    internal class CallLogManager
    {
        static void Main(String[] args)
        {
            // Taking Input for the logs capacity
            Console.Write("Enter call log capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            TeleCom telecom = new TeleCom(capacity);

            while (true)
            {
                Console.WriteLine("\n1. Add Call Log");
                Console.WriteLine("2. Show All Call Logs");
                Console.WriteLine("3. Search By Keyword");
                Console.WriteLine("4. Sort By Time");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        telecom.AddCallLog();
                        break;

                    case 2:
                        telecom.DisplayAllCallLog();
                        break;

                    case 3:
                        telecom.SearchByKeyword();
                        break;

                    case 4:
                        telecom.FilterByTime();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }

    // Class CallLog
    class CallLog
    {
        public int phoneNumber;
        public string message;
        public DateTime timeStamp;

        public CallLog(int  phoneNumber, string message)
        {
            this.phoneNumber = phoneNumber;
            this.message = message;
            this.timeStamp = DateTime.Now;
        }

        // Function to display a calllog
        public void DisplayCallLog()
        {
            Console.WriteLine($"Phone Number : {phoneNumber}");
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"TimeStamp : {timeStamp}");
        }
    }

    // class Telecom
    class TeleCom
    {
        private int Idx;

        // Array Creation to store call logs
        CallLog[] logs;

        public TeleCom(int capacity)
        {
            logs = new CallLog[capacity];
        }

        public void AddCallLog()
        {
            Console.Write("Enter your phone number : ");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your message : ");
            string message = Console.ReadLine();

            CallLog newCall = new CallLog(phone, message);
            logs[Idx++] = newCall;
        }

        public void SearchByKeyword()
        {
            // Taking Input for the keyword
            Console.Write("Enter the keyword : ");
            string keyword = Console.ReadLine();

            for (int i = 0; i < Idx; i++)
            {
                if (logs[i].message.Contains(keyword)) logs[i].DisplayCallLog();
            }
        }

        // Filter By Time uses bubble sort to sort
        public void FilterByTime()
        {
            for (int i = 0; i < Idx - 1; i++)
            {
                bool check = true;
                for (int j = i; j < Idx - 1; j++)
                {
                    CallLog log1 = logs[j];
                    CallLog log2 = logs[j + 1];
                    int compare = log1.timeStamp.CompareTo(log2.timeStamp);
                    if (compare == 0)
                    {
                        CallLog temp = logs[j];
                        logs[j] = logs[j + 1];
                        logs[j + 1] = temp;
                        check = false;
                    }
                }
                if (check) break;
            }
            DisplayAllCallLog();
        }

        public void DisplayAllCallLog()
        {
            Console.WriteLine("====Call Logs====");
            for(int i = 0;i < Idx; i++)
            {
                logs[i].DisplayCallLog();
            }
        }
    }
}
