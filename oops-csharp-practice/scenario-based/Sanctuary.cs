using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.Draft
{
    /// <summary>
    /// The Program Of a WildLife Sanctuary helps us in learning the concepts of polymorphism and interface
    /// 
    /// version - 1.0;
    /// </summary>
    internal class Sanctury
    {
        // Static string sanctuary Name
        static string sanctuaryName = "EcoWing Wildlife Conservation Center";

        public static void Main()
        {
            Console.WriteLine("Welcome to " + sanctuaryName);
            Console.WriteLine();

            // Creating a birds array
            Bird[] birds = new Bird[]
            {
                new Eagle("Eagle"),
                new Sparrow("Sparrow"),
                new Duck("Duck"),
                new Penguin("Penguin"),
                new Seagull("Seagull")
            };

            // Output Display
            foreach (Bird bird in birds)
            {
                bird.DisplayBirdName();

                if (bird is IFlyable)
                {
                    ((IFlyable)bird).Fly();
                }

                if (bird is ISwimmable)
                {
                    ((ISwimmable)bird).Swim();
                }

                Console.WriteLine();
            }
        }
    }

    // IFlyable Interface for fly
    interface IFlyable
    {
        void Fly();
    }

    // ISwimmable Interface foor swim
    interface ISwimmable
    {
        void Swim();
    }

    // Bird Class
    public class Bird
    {
        protected string birdName;

        public Bird(string birdName)
        {
            this.birdName = birdName;
        }

        public void DisplayBirdName()
        {
            Console.WriteLine($"The Bird Name is : {birdName}");
        }

    }

    // Derived Class Eagle
    class Eagle : Bird, IFlyable
    {
        public Eagle(string birdName) : base(birdName) { }
        public void Fly()
        {
            Console.WriteLine($"{birdName} flies very high in the sky.");
        }
    }

    // Derived Class Sparrow
    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string birdName) : base(birdName) { }
        public void Fly()
        {
            Console.WriteLine($"{birdName} flies low in the sky.");
        }

    }

    // Derived Class Duck
    class Duck : Bird, ISwimmable
    {
        public Duck(string birdName) : base(birdName) { }

        public void Swim()
        {
            Console.WriteLine($"{birdName} is swimming in the pond.");
        }
    }

    // Derived Class Penguin
    class Penguin : Bird, ISwimmable
    {
        public Penguin(string birdName) : base(birdName) { }

        public void Swim()
        {
            Console.WriteLine($"{birdName} is swimming in cold or freezing water.");
        }
    }

    // Derived Class Seagull
    class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string birdName) : base(birdName) { }

        public void Fly()
        {
            Console.WriteLine($"{birdName} is flying near the sea.");
        }

        public void Swim()
        {
            Console.WriteLine($"{birdName} is swimming near the shore.");
        }
    }
}
