using System;
using System.Collections.Generic;
using System.Text;

namespace _004_DoubleLinkedLists
{
    class DoubleLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void AddAtHead(int n)
        {
            Node node = new Node(n);
            if (Head == null || Tail==null)
            {
                Head=node;
                Tail = node;
            }
            else
            {
                if (Head.Previous == null)
                {
                    Head.Previous = node;
                    node.Next = Head;
                    Head = node;
                }
            }
        }
        public void AddAtTail(int n)
        {
            Node node = new Node(n);
            if (Tail == null || Head==null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                if (Tail.Next == null)
                {
                    Tail.Next = node;
                    node.Previous = Tail;
                    Tail = node;
                }
            }
        }
        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("no elements in the double linked list");
                return;
            }
            else
            {
                var current = Head;
                while (true)
                {
                    Console.WriteLine(current.Value);
                    if (current.Next == null)
                    {
                        break;
                    }
                    current = current.Next;
                }
            }
        }
        public void PrintReverse()
        {
            if (Tail == null)
            {
                Console.WriteLine("no element in the double linked lists");
                return;
            }
            else
            {
                var current = Tail;
                while (true)
                {
                    Console.WriteLine(current.Value);
                    if (current.Previous == null)
                    {
                        break;
                    }
                    current = current.Previous;
                }
                
            }
        }
        public void InsertAtIndex(int ind, int val)
        {
            Node node = new Node(val); 
            if (ind == 0)
            {
                this.AddAtHead(val);
            }
            else
            {
                int count = 1;
                var current = Head;
                while (true)
                {
                    if (current == null)
                    {
                        Console.WriteLine("unable to insert");
                        break;
                    }
                    if (count == ind)
                    {
                        if (current.Next == null)
                        {
                            Tail = node;
                        }
                        else
                        {
                            node.Next = current.Next;
                            current.Next.Previous = node;
                        }
                        
                        node.Previous = current;
                        current.Next = node;
                        break;
                    }
                    count++;
                    current = current.Next;
                }
            }
        }
        public void Remove(int n)
        {
            if (Head == null)
            {
                Console.WriteLine("no elemeny in the linkedlist");
                return;
            }
            if (Head.Value == n)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                    return;
                }
                Head.Previous = null;
                return;
            }
            else
            {
                var current = Head;
                while (true)
                {
                    if (current.Next == null)
                    {
                        Console.WriteLine("element is not found");
                        break;
                    }
                    if (current.Next.Value== n)
                    {
                        current.Next = current.Next.Next;
                        if (current.Next == null)
                        {
                            Tail = current;
                            break;
                        }
                        current.Next.Previous = current;
                        break;
                    }
                    current = current.Next;
                }
            }
        }
        public void RemoveAt(int ind)
        {
            if (Head == null)
            {
                Console.WriteLine("no element is not there");
            }
            if (ind == 0)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                    return;
                }
                Head.Previous = null;
                return;
            }
            var current = Head;
            int count = 1;
            while (true)
            {
                if (current.Next==null)
                {
                    Console.WriteLine("this element is not foundddfkjdkdfkjj");
                    break;
                }
                if (count == ind)
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Tail = current;
                        break;
                    }
                    current.Next.Previous = current;
                    break;
                }
                current = current.Next;
                count++;
            }
        }
    }
}
