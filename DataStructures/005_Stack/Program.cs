using System;

namespace _005_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push1(1);
            stack.Push1(2);
            stack.Push1(3);
            //stack.Push(2);
            stack.Pop1();
            stack.Pop1();
        }
    }
}
