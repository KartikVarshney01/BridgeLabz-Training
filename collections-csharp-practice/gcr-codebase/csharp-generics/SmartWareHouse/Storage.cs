using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.generic_csharp_practice.gcr_codebase.csharp_generics.SmartWareHouse
{
    internal class Storage<T> : IWarehouse<T>
        where T : Warehouse
    {
        private T[] items;
        private int count;

        public Storage()
        {
            Console.Write("Enter The Storage Capacity : ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            items = new T[capacity];
            count = 0;
        }

        public void AddItem(T item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count++] = item;
        }

        public void DisplayAllItems()
        {
            if (count == 0)
            {
                Console.WriteLine("No Items Available");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                items[i].DisplayInfo();
            }
        }

        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
    }
}
