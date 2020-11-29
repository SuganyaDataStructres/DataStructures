using System;
using System.Collections.Generic;
using System.Text;

namespace _003_LinkedLIsts
{
    class Node
    {
        public Node(int num)
        {
            Value = num;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
