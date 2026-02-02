using System;

namespace FutureLogistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = FutureLogisticsMenu.GetInput();
            GoodsTransport transport = Utility.ParseDetails(input);

            if (transport == null)
                return;

            Console.WriteLine($"Transporter id : {transport.TransportId}");
            Console.WriteLine($"Date of transport : {transport.TransportDate}");
            Console.WriteLine($"Rating of the transport : {transport.TransportRating}");
            Console.WriteLine($"Vehicle for transport : {transport.VehicleSelection()}");
            Console.WriteLine($"Total charge : {transport.CalculateTotalCharge()}");
        }
    }
}
