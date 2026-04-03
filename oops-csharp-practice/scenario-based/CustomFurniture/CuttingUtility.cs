using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.CustomFurniture
{
    internal class CuttingUtility : ICutting
    {
        private WoodenRod rod;
        private PriceChart chart;

        public void AddPriceChart()
        {
            Console.WriteLine("Enter number of sizes in Price Chart:");
            int n = Convert.ToInt32(Console.ReadLine());
            chart = new PriceChart(n);

            rod = new WoodenRod();
        }

        public void ScenarioA()
        {
            rod.length = 12;
            if (rod == null || chart == null) 
            { 
                Console.WriteLine("Add Price Chart first!"); 
                return; 
            }

            int length = rod.GetLength();
            int revenue = 0;

            while (length > 0)
            {
                int cut = chart.GetBestSize(length);
                if (cut == 0) break;
                revenue += chart.GetPrice(cut);
                length -= cut;
            }

            Console.WriteLine("Scenario A Revenue: " + revenue);
        }

        public void ScenarioB()
        {
            Console.WriteLine("Enter Rod Length for cutting:");
            int rodLength = Convert.ToInt32(Console.ReadLine());
            rod.length = rodLength;

            if (rod == null || chart == null) 
            { 
                Console.WriteLine("Add Price Chart first!"); 
                return; 
            }

            Console.Write("Enter mandatory piece size: ");
            int mandatorySize = Convert.ToInt32(Console.ReadLine());

            int length = rod.GetLength();
            if (mandatorySize <= 0 || mandatorySize > length)
            {
                Console.WriteLine("Invalid mandatory piece!");
                return;
            }

            int revenue = chart.GetPrice(mandatorySize);
            length -= mandatorySize;

            while (length > 0)
            {
                int cut = chart.GetBestSize(length);
                if (cut == 0) break;
                revenue += chart.GetPrice(cut);
                length -= cut;
            }

            Console.WriteLine("Scenario B Revenue: " + revenue);
        }

        public void ScenarioC()
        {
            Console.WriteLine("Enter Rod Length for cutting:");
            int rodLength = Convert.ToInt32(Console.ReadLine());
            rod.length = rodLength;


            if (rod == null || chart == null) 
            { 
                Console.WriteLine("Add Price Chart first!"); 
                return; 
            }

            int length = rod.GetLength();
            int revenue = 0;

            while (length > 0)
            {
                int cut = chart.GetBestSize(length);
                if (cut == 0) break;
                revenue += chart.GetPrice(cut);
                length -= cut;
            }

            int waste = length; 
            Console.WriteLine("Scenario C Revenue: " + revenue + ", Waste: " + waste);
        }
    }
}
