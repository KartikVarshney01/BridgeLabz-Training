using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class Restaurant
    {
        static void Main(String[] args)
        {
            IWorker chef = new Chef("Rahul", 101);
            IWorker waiter = new Waiter("Amit", 102);

            chef.PerformDuties();
            waiter.PerformDuties();
        }
    }
    interface IWorker
    {
        void PerformDuties();
    }

    // Superclass
    class Person
    {
        public string Name;
        public int Id;

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }

    // Chef class
    class Chef : Person, IWorker
    {
        public Chef(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Chef cooks food");
        }
    }

    // Waiter class
    class Waiter : Person, IWorker
    {
        public Waiter(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Waiter serves food to customers");
        }
    }
}
