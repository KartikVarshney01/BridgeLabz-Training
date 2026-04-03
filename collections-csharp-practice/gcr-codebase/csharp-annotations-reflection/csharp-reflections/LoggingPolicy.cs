using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    interface IGreeting
    {
        void SayHello(string name);
    }

    class Greeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }

    class LoggingProxy<T> : DispatchProxy
    {
        public T Target;

        protected override object Invoke(MethodInfo method, object[] args)
        {
            Console.WriteLine("Calling method: " + method.Name);
            return method.Invoke(Target, args);
        }
    }
    internal class LoggingPolicy
    {
        static void Main(string[] args)
        {
            IGreeting greeting = new Greeting();

            IGreeting proxy =
                DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();

            ((LoggingProxy<IGreeting>)proxy).Target = greeting;

            proxy.SayHello("Kartik");
        }
    }
}
