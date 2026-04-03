using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Field)]
    class JsonFieldAttribute : Attribute
    {
        public string Name;

        public JsonFieldAttribute(string name)
        {
            Name = name;
        }
    }

    class User
    {
        [JsonField("user_name")]
        public string Username;

        [JsonField("user_age")]
        public int Age;

        public User(string username, int age)
        {
            Username = username;
            Age = age;
        }
    }

    class JsonSerializer
    {
        public static string ToJson(object obj)
        {
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields();

            StringBuilder json = new StringBuilder();
            json.Append("{");

            bool first = true;

            foreach (FieldInfo field in fields)
            {
                JsonFieldAttribute attribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));

                if (attribute != null)
                {
                    if (!first)
                    {
                        json.Append(", ");
                    }

                    json.Append("\"" + attribute.Name + "\": ");

                    object value = field.GetValue(obj);

                    if (value is string)
                    {
                        json.Append("\"" + value + "\"");
                    }
                    else
                    {
                        json.Append(value);
                    }

                    first = false;
                }
            }

            json.Append("}");
            return json.ToString();
        }
    }

    internal class CustomSerialization
    {
        static void Main(string[] args)
        {
            User user = new User("Kartik", 22);

            string json = JsonSerializer.ToJson(user);
            Console.WriteLine(json);
        }
    }
}
