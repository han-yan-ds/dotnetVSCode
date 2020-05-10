using System;

namespace dotnetVSCode
{
    class Program
    {
        static void Main(string[] args) // Main method is the entry point to the application
        {
            Person han = new Person();
            han[0] = "bike";
            han[1] = "desk";
            han[2] = "bed";
            Console.WriteLine($"Han's first item was a {han[0]}");
        }
    }
}