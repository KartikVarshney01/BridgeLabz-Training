using System;
class AeroVigilMenu
{
    private IAeroVigil FlightUtility;

    public AeroVigilMenu()
    {
        FlightUtility = new AeroVigilUtilityImpl();
    }
    public void Menu()
    {
        Console.WriteLine("Welcome to AeroVigil!");
        try
            {
                Console.WriteLine("Enter flight details");
                string input = Console.ReadLine();

                string[] details = input.Split(':');

                string flightNumber = details[0];
                string flightName = details[1];
                int passengerCount = int.Parse(details[2]);
                double currentFuelLevel = double.Parse(details[3]);

                FlightUtility.validateFlightNumber(flightNumber);
                FlightUtility.validateFlightName(flightName);
                FlightUtility.validatePassengerCount(passengerCount, flightName);

                double fuelRequired =
                    FlightUtility.CalculateFuel(flightName, currentFuelLevel);

                Console.WriteLine(
                    "Fuel required to fill the tank: " +
                    fuelRequired + " liters");
            }
        catch (InvalidFlightException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input format");
        }
    }
}