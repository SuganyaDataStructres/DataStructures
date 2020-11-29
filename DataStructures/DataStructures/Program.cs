using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Suganya\Github\DataStructures\DataStructures\DataStructures\Definations.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine(text);
        }
    }
}
