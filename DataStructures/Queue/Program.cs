using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQeue(1);
            queue.EnQeue(2);
            queue.EnQeue(3);
            queue.DeQeue();
            queue.DeQeue();
        }
    }
}
