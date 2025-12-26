using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class Patient : Person
    {
        public string PatientId { get; set; }
        public List<string> MedicalHistory { get; set; }

        public Patient(string name, int age, string nationaltId, string patientId)
            : base(name, age, nationaltId)
        {
            PatientId = patientId;
            MedicalHistory = new List<string>();
        }
        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }
        public override string GetDetails()
        {
            string history;
            if (MedicalHistory.Count == 0)
            {
                history = "NO History";
            }
            else
            {
                history = "";
                for (int i = 0; i < MedicalHistory.Count; i++)
                {
                    history += MedicalHistory[i];
                    if (i < MedicalHistory.Count - 1)
                        history += ", ";
                }
            }
            string result = "Patient -> ";
            result += base.GetDetails();
            result += " , PatientId: ";
            result += PatientId;
            result += ", History: ";
            result += history;

            return result;
        }
    }
}