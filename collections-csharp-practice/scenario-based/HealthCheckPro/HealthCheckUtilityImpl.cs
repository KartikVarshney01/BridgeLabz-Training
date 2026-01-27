using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static BridgeLabzTraining.collections_csharp_practice.scenario_based.HealthCheckPro.ApiAnnotations;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.HealthCheckPro
{
    internal class HealthCheckUtilityImpl : IHealthCheck
    {
        public void ScanController(Type controllerType)
        {
            MethodInfo[] methods = controllerType.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Console.WriteLine($"\nScanning Controller: {controllerType.Name}\n");

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"Method: {method.Name}");

                PublicAPIAttribute publicApi =
                    method.GetCustomAttribute<PublicAPIAttribute>();

                RequiresAuthAttribute requiresAuth =
                    method.GetCustomAttribute<RequiresAuthAttribute>();

                if (publicApi != null)
                {
                    Console.WriteLine("  Type: Public API");
                    Console.WriteLine($"  Description: {publicApi.Description}");
                }

                if (requiresAuth != null)
                {
                    Console.WriteLine("  Type: Requires Authentication");
                    Console.WriteLine($"  Role: {requiresAuth.Role}");
                }

                if (publicApi == null && requiresAuth == null)
                {
                    Console.WriteLine("  WARNING: No API metadata found!");
                }

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
