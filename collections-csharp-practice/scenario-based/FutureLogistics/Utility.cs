using System;
using System.Text.RegularExpressions;

namespace FutureLogistics
{
    public class Utility
    {
        public static GoodsTransport ParseDetails(string input)
        {
            string[] data = input.Split(':');
            string transportId = data[0];

            if (!ValidateTransportId(transportId))
            {
                Console.WriteLine($"Transport id {transportId} is invalid");
                Console.WriteLine("Please provide a valid record");
                return null;
            }

            string date = data[1];
            int rating = int.Parse(data[2]);
            string type = data[3];

            if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new BrickTransport(
                    transportId, date, rating,
                    float.Parse(data[4]),
                    int.Parse(data[5]),
                    float.Parse(data[6])
                );
            }
            else
            {
                return new TimberTransport(
                    transportId, date, rating,
                    float.Parse(data[4]),
                    float.Parse(data[5]),
                    data[6],
                    float.Parse(data[7])
                );
            }
        }

        public static bool ValidateTransportId(string transportId)
        {
            return Regex.IsMatch(transportId, @"^RTS\d{3}[A-Z]$");
        }
    }
}
