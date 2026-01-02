using System;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    /// <summary>
    /// The Program of Bus Route Distance Tracker And Lucky Draw is used to:
    /// 1. Find The Fare of each Passenger at their destination
    /// 2. Taking A Number And Finding Whether a user has win the lottery or not.
    /// I have Combine Both these So When A new Passenger gets on the bus they are assign a lucky draw number and on 
    /// gettin of the bus they got to know the results of the draw, learning if they win the draw or not.
    /// 
    /// version - 1.0
    /// </summary>
    internal class Bus
    {
        //Creating Variables for Bus Name, Array for Bus Stops And Array for DataOfPassenger. 
        string busName;
        string[,] busStops;          // [i,0] = stop name, [i,1] = distance
        string[,] dataOfPassenger;     // [i,0] = passenger name, [i,1] = boarding distance

        // Variables for TotalPassengers Count and Bus Current Stop
        int totalPassengers = 0;
        int currentStop = 0;

        // Initializing A Lucky Draw Class to call the lucky draw class and its functions
        LuckyDraw luck = new LuckyDraw();

        // Function To Start The Bus Journey
        public void StartBus()
        {
            Console.WriteLine($"The Current Stop Of The {busName} : {busStops[currentStop, 0]}");
            // Calling Board Passenger Function to Start With First Boarding.
            PassengersBoard();
            // Calling Move Bus Function To Start The Bus on its Journey.
            MoveBus();
        }

        // The Board Passenger Function To Board The Passengers in the bus
        public void PassengersBoard()
        {
            // Checking if bus is Full On each stops.
            if (totalPassengers >= dataOfPassenger.GetLength(0))
            {
                Console.WriteLine("Bus is full. Wait For The Next Bus");
                return;
            }

            // Initializing The Available Variable to find the current available seats inside a bus
            int available = dataOfPassenger.GetLength(0) - totalPassengers;

            Console.Write($"Enter number of passengers to board (seats available {available}): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Getting If Number of available seats are lower or number of passengers waiting on the stop.
            n = Math.Min(n, available);

            for (int i = 0; i < dataOfPassenger.GetLength(0) && n > 0; i++)
            {
                if (dataOfPassenger[i, 0] == null)
                {
                    Console.Write("Enter Passenger Name: ");
                    dataOfPassenger[i, 0] = Console.ReadLine();
                    dataOfPassenger[i, 1] = busStops[currentStop, 1];
                    // On Entering The Bus Finding the lucky Draw Number 
                    dataOfPassenger[i, 2] = luck.DrawLottery();

                    totalPassengers++;
                    n--;
                }
            }
        }

        // Function To Input or Set The Bus Data Including its Name, Number of stops, Stops Name, Distamce from 
        // First Stop and The Capacity of the bus
        public void SetBusData()
        {
            Console.Write("Enter Your Bus Name : ");
            string name = Console.ReadLine();

            busName = name;

            Console.Write("Enter the number of stops the bus has : ");
            int n = Convert.ToInt32(Console.ReadLine());

            busStops = new string[n, 2];

            Console.WriteLine("Enter Each Stop name and Distance from initial Stop : ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Stop {i + 1} Name: ");
                busStops[i, 0] = Console.ReadLine();

                Console.Write("Distance from initial Stop: ");
                busStops[i, 1] = Console.ReadLine();
            }

            // Getting The Bus Capacity
            Console.Write("Enter Bus Capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            dataOfPassenger = new string[capacity, 3];
        }

        public void MoveBus()
        {
            if (currentStop == busStops.GetLength(0) - 1)
                return;

            currentStop++;

            Console.WriteLine($"\nCurrent Stop of the bus {busName} : {busStops[currentStop, 0]}");

            // Bool To check if The Current Stop is Also the last 
            bool isLastStop = currentStop == busStops.GetLength(0) - 1;

            // If Last Stop Reached Then DeBoard All The Passengers
            if (isLastStop)
            {
                if (totalPassengers > 0)
                    ForceDeboardAll();
                return;
            }
            
            // If there are more stops to be had, then first deboard the passengers and then we move to boarding.
            if (totalPassengers > 0)
                PassengersDeBoard();

            if (totalPassengers < dataOfPassenger.GetLength(0))
                PassengersBoard();

            MoveBus();
        }

        
        // Function for the Passengers Deboarding
        public void PassengersDeBoard()
        {
            for (int i = 0; i < dataOfPassenger.GetLength(0); i++)
            {
                // If cuurntly no passenger in thr seat then continue to next seat.
                if (dataOfPassenger[i, 0] == null) continue;

                Console.Write($"Should {dataOfPassenger[i, 0]} Deboard at this stop {busStops[currentStop,0]}? (y/n) : ");
                char ch = Console.ReadLine()[0];

                if (ch == 'y' || ch == 'Y')
                {
                    // Calculating Total Fare Or Distance a passenger travel to.
                    int fare = CalculateFare(i);
                    Console.WriteLine($"Your Total Fare: {fare}");
                    // Finding The Lucky Draw Result
                    Console.WriteLine($"Lucky Draw Result: {dataOfPassenger[i, 2]}");

                    // Emptying the deboarding passenger seat at the array.
                    dataOfPassenger[i, 0] = null;
                    dataOfPassenger[i, 1] = null;
                    totalPassengers--;
                }
            }
        }

        // Function FOr Force Deboarding At Last Stop to make sure on reaching every passengers get off.
        void ForceDeboardAll()
        {
            for (int i = 0; i < dataOfPassenger.GetLength(0); i++)
            {
                if (dataOfPassenger[i, 0] == null) continue;

                int fare = CalculateFare(i);
                Console.WriteLine($"Passenger: {dataOfPassenger[i, 0]} Your Fare : {fare}");
                Console.WriteLine($"Lucky Draw Result: {dataOfPassenger[i, 2]}");

                // Emptying the array to make seats available for next set.
                dataOfPassenger[i, 0] = null;
                dataOfPassenger[i, 1] = null;
                totalPassengers--;
            }
        }

        // Function To calculate the total distance travelled by the passenger or their fare
        int CalculateFare(int idx)
        {
            int boardingDistance = Convert.ToInt32(dataOfPassenger[idx, 1]);
            int currentDistance = Convert.ToInt32(busStops[currentStop, 1]);
            return currentDistance - boardingDistance;
        }
        static void Main()
        {
            Bus bus = new Bus();
            bus.SetBusData();

            Console.WriteLine($"Bus {bus.busName} has Started its Journey");
            bus.StartBus();
            Console.WriteLine($"Bus {bus.busName} has reached its Destination");
        }
    }

    // Class LuckDraw to find give a draw number and then checking if he won or not.
    class LuckyDraw
    {
        Random random = new Random();

        public string DrawLottery()
        {
            int num = random.Next(0, 10000);

            if (num % 3 == 0 && num % 5 == 0)
                return "Congratulaions! You Have Won The Draw.";
            else
                return "Sorry! You Lost The Draw.";
        }
    }
}
