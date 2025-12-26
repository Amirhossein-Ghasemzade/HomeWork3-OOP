using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class Doctor : Person
    {
        public string DoctorId { get; set; }
        public string Specialization { get; set; }

        public IDiagnosisStrategy DiagnosisStrategy { get; set; }

        public Doctor(string name, int age, string nationalId, string doctorId, string specialization)
            : base(name, age, nationalId)
        {
            DoctorId= doctorId;
            Specialization= specialization;

            if (specialization == "Cardiology")
            {
                DiagnosisStrategy = new CardiologyDiagnosisStrategy();
            }
            else if (specialization == "Neurology")
            {
                DiagnosisStrategy = new NeurologyDiagnosisStrategy();
            }
            else 
            {
                DiagnosisStrategy = new GeneralDiagnosisStrategy();
            }
        }

        public void Diagnose(Patient patient)
        {
            string diagnosis = DiagnosisStrategy.MakeDiagnosis(patient);
            patient.AddToMedicalHistory(diagnosis);
        }
        public override string GetDetails()
        {
            string result = "Doctor -> ";
            result += base.GetDetails();
            result += ", DoctorId: ";
            result += DoctorId;
            result += ", Specialization: ";
            result += Specialization;

            return result;
        }
    }
}
