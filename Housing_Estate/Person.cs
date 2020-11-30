using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Person
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Years { get; set; }
        
        public Person(string firstName, string lastName, int years)
        {
            Firstname = firstName;
            Lastname = lastName;
            Years = years;
        }

        public void ToString()
        {
            Console.WriteLine($"{Firstname},{Lastname},{Years}");
        }
    }
}
