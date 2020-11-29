using System;

namespace _004_DoubleLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            doubleLinkedList.AddAtTail(1);
            doubleLinkedList.AddAtTail(2);
            doubleLinkedList.AddAtTail(3);
            doubleLinkedList.AddAtHead(4);
            doubleLinkedList.AddAtHead(5);
            doubleLinkedList.AddAtHead(6);
            //doubleLinkedList.InsertAtIndex(7, 12);

            doubleLinkedList.RemoveAt(4);
            doubleLinkedList.Print();
            Console.WriteLine();
            doubleLinkedList.PrintReverse();

        }
    }
}
