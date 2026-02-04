using System;
namespace FactoryRobot
{
    public class FactoryRobotMain
    {
        /// <summary>
        /// Factory Robot Hazard Analyzer is a C# console application that calculates a 
        /// robot’s hazard risk based on arm precision, worker density, and machinery state. 
        /// It validates inputs, uses custom exception handling for invalid scenarios, and 
        /// computes the risk score using a predefined formula.
        /// 
        /// version - 1.0
        /// </summary>
        
        // Main Class Containg Program Entry Point And Taking User Input
        static void Main(string[] args)
        {
            // Using Try And Catch To Take User Input And Enure Exceptions Are Handled Properly
            try
            {
                FactoryRobotUtilityImpl Utility = new FactoryRobotUtilityImpl();
                Console.Write("Enter Arm Precision (0.0 - 1.0): ");
                double armPrecision = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Worker Density (1 - 20): ");
                int workerDensity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Machinery State (Worn/Faulty/Critical): ");
                string machineryState = Console.ReadLine();

                double risk = Utility.CalculateHazardRisk(armPrecision, workerDensity,
                    machineryState
                );

                Console.WriteLine("Robot Hazard Risk Score: " + risk);
            }
            catch (RobotSafetyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}