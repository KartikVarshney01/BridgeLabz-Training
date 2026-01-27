using System.Reflection;
using System.Text;


namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Student
    {
        public int Id;
        public string Name;
        public int Age;
    }

    class JsonConverter
    {
        public static string ToJson(object obj)
        {
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Public | BindingFlags.Instance);

            StringBuilder json = new StringBuilder();
            json.Append("{");

            for (int i = 0; i < fields.Length; i++)
            {
                FieldInfo field = fields[i];
                object value = field.GetValue(obj);

                json.Append("\"" + field.Name + "\": ");

                if (value is string)
                {
                    json.Append("\"" + value + "\"");
                }
                else
                {
                    json.Append(value);
                }

                if (i < fields.Length - 1)
                {
                    json.Append(", ");
                }
            }

            json.Append("}");
            return json.ToString();
        }
    }

    internal class JsonRepresentative
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Kartik";
            student.Age = 22;

            string json = JsonConverter.ToJson(student);
            Console.WriteLine(json);
        }
    }
}
