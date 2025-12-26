using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task2
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }

        public Student(string name, int age, string studentId, string major)
            : base(name, age)
        {
            StudentID = studentId;
            Major = major;
        }

        public override string GetDetails()
        {
            return $"Student -> Name: {Name}, Age: {Age}, StudentID: {StudentID}, Major: {Major}";
        }
    }
}
