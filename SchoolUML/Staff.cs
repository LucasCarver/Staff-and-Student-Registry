using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolUML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public Staff() { }

        public override string ToString()
        {
            return "Staff:\n" + base.ToString() + $"\nFacility: {School} Pay: {Pay:C2}\n";
        }
    }
}
