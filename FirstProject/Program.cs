using System;
using System.Runtime.CompilerServices;

namespace dotnetVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Demonstrating Object Initialization Syntax
             *  This is used so we won't need 15 different constructor overloads
             *  This only works if all the initial properties are public properties
             *   Notice {} instead of () in syntax
             */
            // Person han = new Person("Han", "Yan");
            Person han = new Person
            {
                fName = "Han",
                lName = "Yan"
            };
            Console.WriteLine(han.Introduce());
        }
    }
}
