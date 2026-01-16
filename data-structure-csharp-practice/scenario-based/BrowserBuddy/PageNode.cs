using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based
{
    // PageNode Class
    internal class PageNode
    {
        public string Url;
        public PageNode Prev;
        public PageNode Next;

        public PageNode(string url)
        {
            Url = url;
            Prev = null;
            Next = null;
        }
    }
}
