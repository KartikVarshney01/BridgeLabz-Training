using System;
namespace FactoryRobot
{
    // Custom Exception Class 
    class RobotSafetyException : Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
            
        }
    }
}