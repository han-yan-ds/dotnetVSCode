using System;

namespace dotnetVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> checkoutLine = new Queue<string>();
            checkoutLine.Enqueue("Han");
            checkoutLine.Enqueue("Bob");
            Console.WriteLine(checkoutLine.Dequeue()); // should be Han
            Console.WriteLine(checkoutLine.Dequeue()); // should be Bob
        }
    }
}
