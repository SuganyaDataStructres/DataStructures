using System;
using System.Collections.Generic;
using System.Text;

namespace _005_Stack
{
    class Stack
    {
        public Node Head { get; set; }
        public void Push1(int n)
        {
            Node node = new Node(n);
            if (Head == null)
            {
                Head = node;
                return;
            }
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
        public void pop1()
        {
            if (Head == null)
            {
                return;
            }
            var current = Head;
            while (true)
            {
                if (current.Next == null)
                {
                    Head = null;
                    break;
                }
                if (current.Next.Next == null)
                {
                    current.Next = null;
                    break;
                }
                current = current.Next;
            }
        }
        public void Push(int n)
        {
            Node node = new Node(n);
            if (Head == null)
            {
                Head = node;
                return;
            }
            node.Next = Head;
            Head=node;
        }
        public void Pop()
        {
            if (Head == null)
            {
                return;
            }
            Head = Head.Next;
        }
        
    }
}
