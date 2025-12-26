using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task2
{
    public class Professor  : Person
    {
        public string ProfessorId { get; set; }
        public string Subject { get; set; }

        public Professor(string name, int age, string professorId, string subject)
            :base(name, age)
        {
            ProfessorId = professorId;
            Subject = subject;
        }

        public override string GetDetails()
        {
            return $"Professor -> Name: {Name}, Age: {Age}, ProfessorId: {ProfessorId}, Subject: {Subject}";
        }
    }
}
