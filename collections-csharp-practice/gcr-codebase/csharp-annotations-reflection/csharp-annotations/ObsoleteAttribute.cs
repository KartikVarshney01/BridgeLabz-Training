using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    class LegacyAPI
    {
        [Obsolete("OldFeature is outdated. Use NewFeature instead.")]
        public void OldFeature()
        {
            Console.WriteLine("This is the old feature");
        }

        public void NewFeature()
        {
            Console.WriteLine("This is the new feature");
        }
    }
    internal class Obsolete
    {
        static void Main(string[] args)
        {
            LegacyAPI api = new LegacyAPI();

            api.OldFeature();
            api.NewFeature();
        }
    }
}
