using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    [AttributeUsage(AttributeTargets.Field)]
    class InjectAttribute : Attribute
    {
    }

    class MessageService
    {
        public void SendMessage()
        {
            Console.WriteLine("Message sent successfully");
        }
    }

    class UserController
    {
        [Inject]
        public MessageService messageService;

        public void Process()
        {
            messageService.SendMessage();
        }
    }

    class SimpleDIContainer
    {
        public static T Resolve<T>() where T : new()
        {
            T obj = new T();
            Type type = typeof(T);

            FieldInfo[] fields = type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                if (Attribute.IsDefined(field, typeof(InjectAttribute)))
                {
                    object dependency = Activator.CreateInstance(field.FieldType);
                    field.SetValue(obj, dependency);
                }
            }

            return obj;
        }
    }
    internal class DependencyInjection
    {
        static void Main(string[] args)
        {
            UserController controller =
                SimpleDIContainer.Resolve<UserController>();

            controller.Process();
        }
    }
}
