using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
    internal class CorrectMethodOverriding
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.MakeSound();
        }
    }
}
