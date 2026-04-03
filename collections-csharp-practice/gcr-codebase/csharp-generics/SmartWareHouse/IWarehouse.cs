using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal interface IWarehouse<T>
    {
        void AddItem(T item);
        void DisplayAllItems();
    }
}
