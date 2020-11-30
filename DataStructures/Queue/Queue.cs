using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue
    {
        public Node Tail { get; set; }
        public Node Head { get; set; }
        
        public void EnQeue(int n)
        {
            Node node = new Node(n);
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            Tail.Next = node;
            Tail = node;
        }
        public void DeQeue()
        {
            if (Head == null)
            {
                Console.WriteLine("no element in the queue");
                return;
            }
            Head= Head.Next;
        }
    }
}
