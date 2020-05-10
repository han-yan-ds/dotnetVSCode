using System;

namespace dotnetVSCode
{
    class Program
    {
        static void Main(string[] args) // Main method is the entry point to the application
        {
            Console.WriteLine(Status.Playing); // Playing
            Console.WriteLine((Status)(3)); // HighScore (casting)
            object parsedEnum = Enum.Parse(typeof(Status), "Won");
            Console.WriteLine((Status)parsedEnum); // Won (parsing a string into an Enum THEN casting to that EnumType)
        }
    }
}
