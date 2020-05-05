using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolUML
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person() { }

        public override string ToString()
        {
            return $"Name: {Name} Address: {Address}";
        }
    }
}
