using System;

namespace _003_LinkedLIsts
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            int z = linkedList.Length();
            Console.WriteLine(z);
            linkedList.InsertAt(12, 4);
            linkedList.RemoveAt(5);
            linkedList.Print();
        }
    }
}
