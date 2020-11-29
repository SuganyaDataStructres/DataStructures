using System;

namespace _002_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array.
            int[] arr = { 1, 2, 3, 4, 5 };
            // accesing the 3 rd elemet
            int r = arr[3];
            Console.WriteLine(r);
            // assigning the 4th elemnt to new value
            arr[3] = 8;
            r = arr[3];
            Console.WriteLine(r);
        }
    }
}
