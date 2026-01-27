using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.HealthCheckPro
{
    internal interface IHealthCheck
    {
        void ScanController(Type controllerType);
    }
}
