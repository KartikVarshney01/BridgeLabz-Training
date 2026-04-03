using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Field)]
    class MaxLengthAttribute : Attribute
    {
        public int Value;

        public MaxLengthAttribute(int value)
        {
            Value = value;
        }
    }

    class User
    {
        [MaxLength(10)]
        public string Username;

        public User(string username)
        {
            FieldInfo field = typeof(User).GetField("Username");

            MaxLengthAttribute attribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(field, typeof(MaxLengthAttribute));

            if (attribute != null && username.Length > attribute.Value)
            {
                throw new ArgumentException(
                    "Username exceeds maximum length of " + attribute.Value);
            }

            Username = username;
        }
    }

    internal class MaxLengthAttributeCreate
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User("Kartik");
                Console.WriteLine("User created: " + user1.Username);

                User user2 = new User("VeryLongUsername");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
