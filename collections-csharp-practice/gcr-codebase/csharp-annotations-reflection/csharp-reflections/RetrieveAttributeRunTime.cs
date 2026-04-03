using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    [AttributeUsage(AttributeTargets.Class)]
    class AuthorAttribute : Attribute
    {
        public string Name;

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [Author("Kartik Varshney")]
    class Project { }
    internal class RetrieveAttributeRunTime
    {
        static void Main(string[] args)
        {
            Type type = typeof(Project);

            AuthorAttribute author =
                (AuthorAttribute)Attribute.GetCustomAttribute(
                    type, typeof(AuthorAttribute));

            if (author != null)
            {
                Console.WriteLine("Author: " + author.Name);
            }
        }
    }
}
