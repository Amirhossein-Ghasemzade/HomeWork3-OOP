using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public static class PersonFactory
    {
        public static Patient CreatePatient(string name, int age, string narionalId, string patientId)
        {
            return new Patient (name, age, narionalId, patientId);
        }

        public static Doctor CreateDoctor(string name, int age, string narionalId, string doctorId, string specialization)
        {
            return new Doctor(name, age, narionalId, doctorId, specialization);
        }
    }
}
