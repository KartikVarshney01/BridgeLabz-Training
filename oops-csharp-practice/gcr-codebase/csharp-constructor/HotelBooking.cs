using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class HotelBooking
    {
        string guestName;
        string roomType;
        int nights;

        // Default Constructor
        public HotelBooking()
        {
            guestName = "Jon Doe";
            roomType = "Single";
            nights = 3;
        }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking h)
        {
            this.guestName = h.guestName;
            this.roomType = h.roomType;
            this.nights = h.nights;
        }

        // Display Function
        public void Display()
        {
            Console.WriteLine($"Guest Name : {guestName}");
            Console.WriteLine($"Room Type : {roomType}");
            Console.WriteLine($"Nights : {nights}");
        }
        static void Main(String[] args)
        {
            HotelBooking h1 = new HotelBooking();
            Console.WriteLine("Default Constructor");
            h1.Display();

            HotelBooking h2 = new HotelBooking("Kartik", "King", 5);
            Console.WriteLine("\nParameterized Constructor");
            h2.Display();

            HotelBooking h3 = new HotelBooking(h2);
            Console.WriteLine("\nCopy Constructor");
            h3.Display();
        }
    }
}
