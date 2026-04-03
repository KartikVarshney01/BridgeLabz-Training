using System;
using System.Collections.Generic;
using System.Text;
using static BridgeLabzTraining.collections_csharp_practice.scenario_based.HealthCheckPro.ApiAnnotations;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.HealthCheckPro
{
    internal class LabTestController
    {
        [PublicAPI("Fetch all lab tests")]
        public void GetTests()
        {
        }

        [RequiresAuth("Admin")]
        public void AddTest()
        {
        }

        public void DeleteTest()
        {
        }
    }
}
