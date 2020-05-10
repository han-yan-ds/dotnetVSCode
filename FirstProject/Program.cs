using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace dotnetVSCode
{
    class Program
    {
        public static double Sum(params double[] args) // This is how I set Rest Operator for variable number of params in C#
        {
            // Array.Aggregate is C#'s array reduce method
            return args.Aggregate((accum, x) => accum + x); 
        }
        static void Main(string[] args)
        {
            double sum = Program.Sum(1, 2, 3, 4); // See?
            Console.WriteLine($"The sum is {sum}");
        }
    }
}