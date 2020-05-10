namespace dotnetVSCode
{
    class Person
    {
        private string fName, lName;
        public Person(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public string Introduce()
        {
            return $"Hi my name is {this.fName} {this.lName}";
        }
    }
}