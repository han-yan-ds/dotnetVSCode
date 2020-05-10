using System;

namespace dotnetVSCode
{
    class Program
    {
        static void Main(string[] args) // Main method is the entry point to the application
        {
            Person han = new Person(new DateTime(1987, 03, 08));
            Console.WriteLine($"Age is {han.Age}");
        }
    }
}
