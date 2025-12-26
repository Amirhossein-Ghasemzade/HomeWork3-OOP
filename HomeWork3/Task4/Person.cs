using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NationalId { get; set; }

        public Person(string name, int age, string nationalId) 
        {
            Name = name;
            Age = age;  
            NationalId = nationalId;
        }
        public virtual string GetDetails()
        {
            return $"Person -> Name: {Name}, Age: {Age}, NationalId: {NationalId} ";
        }
    }
}
