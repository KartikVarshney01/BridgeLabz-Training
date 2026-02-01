using System;
public interface IAeroVigil
{
    bool validateFlightNumber(string flightNumber);
    bool validateFlightName(string flightName);
    bool validatePassengerCount(int passengerCount, string flightName);
    double CalculateFuel(string flightName, double currentFuel);

}