using System;
using System.Collections.Generic;
using System.Text;

namespace _003_LinkedLIsts
{
    class LinkedList
    {
        public Node Head { get; set; }
        public void Add(int num)
        {
            Node node = new Node(num);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var current = Head;
                while (true)
                {
                    if (current.Next == null)
                    {
                        current.Next = node;
                        break;
                    }
                    current = current.Next;
                }
            }
        }
        public void Print()
        {
            if (Head == null)
            {
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
        public void InsertAtLast(int num)
        {
            Node node = new Node(num);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var current = Head;
                while (true)
                {
                    if (current.Next == null)
                    {
                        current.Next = node;
                        break;
                    }
                    current = current.Next;
                }
            }
        }
        public void InsertAtFirst(int num)
        {
            Node node = new Node(num);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public void Remove(int num)
        {
            if (Head.Value == num)
            {
                Head = Head.Next;
                return;
            }
            var current = Head;
            while (true)
            {
                if (current.Next == null)
                {
                    break;
                }
                if (current.Next.Value == num)
                {
                    current.Next = current.Next.Next;
                    break;
                }
                current = current.Next;
            }
        }
        public int Length()
        {
            if (Head == null)
            {
                return 0;
            }
            int count = 1;
            var current = Head;
            while (true)
            {
                if (current.Next == null)
                {
                    break;
                }
                count++;
                current = current.Next;
            }
            return count;
        }
        public void InsertAt(int num, int n)
        {
            Node node = new Node(num);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                int count = 1;
                var current = Head;
                while (true)
                {
                    if (current == null)
                    {
                        break;
                    }

                    if (count == n)
                    {
                        node.Next = current.Next;
                        current.Next = node;
                        break;
                    }
                    count++;
                    current = current.Next;
                }
            }
        }
        public void RemoveAt(int n)
        {
            if (Head == null)
            {
                return;
            }
            if (n == 0)
            {
                Head = Head.Next;
                return;
            }
            else
            {
                var current = Head;
                int count = 1;
                while (true)
                {
                    if (current.Next == null)
                    {
                        break;
                    }
                    if (count == n)
                    {
                        current.Next = current.Next.Next;
                        break;
                    }
                    current = current.Next;
                    count++;
                }
            }
        }

    }
}
