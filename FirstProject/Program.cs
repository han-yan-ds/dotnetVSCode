using System;

namespace dotnetVSCode
{
    class Program
    {
        static void Main()
        {
            /*
             * Demonstrating the PRACTICAL difference between Structs and Classes
             */
            RefType reference = new RefType(0);
            ValType value = new ValType(0);
            RefType reference2 = reference;
            ValType value2 = value;
            Console.WriteLine("Initially,\n\treference = {0}\n\treference2 = {1}\n\tvalue = {2}\n\tvalue2 = {3}", reference.value, reference2.value, value.value, value2.value);
            
            reference2.value++;
            value2.value++;
            Console.WriteLine("After incrementing the \"___2\"s...,\n\treference = {0}\n\treference2 = {1}\n\tvalue = {2}\n\tvalue2 = {3}", reference.value, reference2.value, value.value, value2.value);
            Console.WriteLine("Notice:\n\tThe two CLASS INSTANCES point to the same object,\n\tThe two STRUCT INSTANCES point to separate objects");
        }
    }
}