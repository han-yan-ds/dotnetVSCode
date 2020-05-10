using System;

namespace FirstProject
{
    class Program
    {
        static void Main()
        {
            int parseResult; // nothing now, 78 later
            bool isParsed = int.TryParse("78", out parseResult); // true (return value of TryParse because it can parse "78" into an int

            Console.WriteLine("This is how an out modifier works in parameters... \nThe out parameter assigns a value to the variable outside the function's scope");
            Console.WriteLine("\tparseResult: {0} - this is the out parameter", parseResult);
            Console.WriteLine("\tisParsed: {0} - this is actually the return value of TryParse", isParsed);
        }
    }
}
