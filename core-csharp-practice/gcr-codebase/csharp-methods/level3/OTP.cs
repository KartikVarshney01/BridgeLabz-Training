using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class OTP
    {
        static void Main(String[] args)
        {
            // Initializing an array to store random otps.
            int[] otps = new int[10];

            // Calling Function to generate 6 digit random otps. 
            for (int i = 0; i < otps.Length; i++)
            {
                otps[i] = OTPFun();
            }

            // Display Output
            Console.WriteLine("Generated OTPs are : ");
            foreach (int otp in otps)
            {
                Console.WriteLine(otp);
            }

            bool unique = UniqueCheck(otps);

            Console.WriteLine($"Are all OTPs unique? : {unique}");
        }

        static int OTPFun()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }

        public static bool UniqueCheck(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                        return false;
                }
            }
            return true;
        }
    }
}
