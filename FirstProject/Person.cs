using System;

namespace dotnetVSCode
{
    class Person
    {
        /*
         * Below is a C# shorthand for creating private fields and its accessors
         * In particular, not giving it a "set" means it can only be set during initialization (constructor)
         */
        public DateTime DateOfBirth { get; }

        public Person(DateTime dob)
        {
            DateOfBirth = dob;
        }

        /*
         * Below is a reference for how to incorporate logic into the getter/setter shorthand
         */
        public int Age
        {
            get => (DateTime.Today - DateOfBirth).Days/365;
            // could also be: 
            // get { return (DateTime.Today - DateOfBirth).Days/365; }
        }
    }
}