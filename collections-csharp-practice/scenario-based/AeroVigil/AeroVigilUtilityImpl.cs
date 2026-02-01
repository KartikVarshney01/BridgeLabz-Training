using System;
using System.Text.RegularExpressions;
public class AeroVigilUtilityImpl : IAeroVigil
{
    public bool validateFlightNumber(string flightNumber)
    {
        Regex regex = new Regex("^FL-[1-9][0-9]{3}$");
        if (!regex.IsMatch(flightNumber))
        {
            throw new InvalidFlightException(
                $"The Flight Number {flightNumber} is invalid"
            );
        }
        return true;
    }

    public bool validateFlightName(string flightName)
    {
        if(flightName != "SpiceJet" && flightName != "Vistara" && flightName != "IndiGo" && flightName != "Air Arabia")
        {
            throw new InvalidFlightException(
                $"The Flight Name {flightName} is invalid"
            );
        }
        return true;
    }

    public bool validatePassengerCount(int passengerCount, string flightName)
    {
        int maxCapacity = 0;
        if(flightName == "SpiceJet") maxCapacity = 396;
        if(flightName == "Vistara") maxCapacity = 615;
        if(flightName == "IndiGo") maxCapacity = 230;
        if(flightName == "Air Arabia") maxCapacity = 130;

        if(passengerCount <= 0 || passengerCount > maxCapacity)
        {
            throw new InvalidFlightException(
                $"The Passenger Count {passengerCount} is invalid for {flightName}"
            );
        }
        return true;
    }

    public double CalculateFuel(string flightName,double currentFuel)
    {
        double maxFuel = 0;

        if(flightName == "SpiceJet") maxFuel = 200000;
        if(flightName == "Vistara") maxFuel = 300000;
        if(flightName == "IndiGo") maxFuel = 250000;
        if(flightName == "Air Arabia") maxFuel = 150000;

        if (currentFuel < 0 || currentFuel > maxFuel)
        {
            throw new InvalidFlightException(
                $"Invalid fuel level for {flightName}"
            );
        }
        return maxFuel-currentFuel;
    }
}