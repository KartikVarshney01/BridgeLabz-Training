using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Student
    {
        public int Id;
        public string Name;
    }

    class ObjectMapper
    {
        public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
        {
            object obj = Activator.CreateInstance(clazz);

            foreach (KeyValuePair<string, object> entry in properties)
            {
                FieldInfo field = clazz.GetField(
                    entry.Key,
                    BindingFlags.Public | BindingFlags.Instance);

                if (field != null)
                {
                    field.SetValue(obj, entry.Value);
                }
            }

            return (T)obj;
        }
    }

    internal class CustomObjectMapper
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Id", 101);
            data.Add("Name", "Kartik");

            Student student = ObjectMapper.ToObject<Student>(
                typeof(Student), data);

            Console.WriteLine("Id: " + student.Id);
            Console.WriteLine("Name: " + student.Name);
        }
    }
}
