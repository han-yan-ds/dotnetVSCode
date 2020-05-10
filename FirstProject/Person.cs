using System.Collections.Generic;

namespace dotnetVSCode
{
    class Person
    {
        public string fName, lName;
        public readonly List<string> things = new List<string>();

        public Person() { } // this is redundant and only used so Object Initialization Syntax works (see Program.cs)
        public Person(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public Person(string fullName) 
            : this(fullName.Split(' ')[0], fullName.Split(' ')[1])
        {
          // " : this()" calls the basic constructor (above) before doing rest of the code/
        }

        public void resetPossessions()
        {
            /*
             * Below's commented out line will not work because I have made things readonly
             * "readonly" makes it so a variable cannot be REASSIGNED
             * This list can be modified though
             */
            // this.things = new List<string>();
        }

        public string Introduce()
        {
            return $"Hi my name is {this.fName} {this.lName}. I have {this.things.Count} things.";
        }
    }
}