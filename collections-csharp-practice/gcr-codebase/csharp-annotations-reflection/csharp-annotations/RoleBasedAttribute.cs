using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class RoleAllowedAttribute : Attribute
    {
        public string Role;

        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }

    class AdminService
    {
        [RoleAllowed("ADMIN")]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully");
        }

        public void ViewUsers()
        {
            Console.WriteLine("Users list displayed");
        }
    }
    internal class RoleBasedAttribute
    {
        static void Main(string[] args)
        {
            string currentUserRole = "USER";

            AdminService service = new AdminService();
            Type type = typeof(AdminService);

            MethodInfo method = type.GetMethod("DeleteUser");

            RoleAllowedAttribute attribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

            if (attribute != null && attribute.Role == currentUserRole)
            {
                method.Invoke(service, null);
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
    }
}
