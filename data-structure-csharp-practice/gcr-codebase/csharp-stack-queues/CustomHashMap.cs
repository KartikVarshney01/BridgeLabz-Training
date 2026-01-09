using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_stack_queues
{
    internal class CustomHashMap
    {
        static void Main(String[] args)
        {
            CustomHashMapClass map = new CustomHashMapClass();

            map.Put(1, 10);
            map.Put(11, 20);

            Console.WriteLine(map.Get(1));
            Console.WriteLine(map.Get(11));

            map.Remove(1);
            Console.WriteLine(map.Get(1));
        }
    }

    class Node
    {
        public int key;
        public int value;
        public Node next;

        public Node(int key, int value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
    class CustomHashMapClass
    {
        private const int size = 10;
        private Node[] table;

        public CustomHashMapClass()
        {
            table = new Node[size];
        }

        private int Hash(int key)
        {
            return key % size;
        }

        public void Put(int key, int value)
        {
            int index = Hash(key);
            Node head = table[index];

            Node current = head;
            while (current != null)
            {
                if (current.key == key)
                {
                    current.value = value;
                    return;
                }
                current = current.next;
            }

            Node newNode = new Node(key, value);
            newNode.next = head;
            table[index] = newNode;
        }

        public int Get(int key)
        {
            int index = Hash(key);
            Node current = table[index];

            while (current != null)
            {
                if (current.key == key)
                    return current.value;
                current = current.next;
            }

            return -1;
        }

        public void Remove(int key)
        {
            int index = Hash(key);
            Node current = table[index];
            Node prev = null;

            while (current != null)
            {
                if (current.key == key)
                {
                    if (prev == null)
                        table[index] = current.next;
                    else
                        prev.next = current.next;
                    return;
                }
                prev = current;
                current = current.next;
            }
        }
    }
}
