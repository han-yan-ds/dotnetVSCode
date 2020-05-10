using System;
using System.Collections.Generic;

namespace dotnetVSCode
{
    public class Person
    {
        private readonly List<string> things;

        public Person ()
        {
            things = new List<string>();
        }

        public string this[int i]
            /* ABOVE SYNTAX!
             * This allows a Person object to be able to use indexer notation
             * Eg: han[0] = "bike"
             */
        {
            get { return things[i]; }
            set {
                if (things.Count < i + 1) things.Add(value);
                else things[i] = value;
                }
        }
    }
}