using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}