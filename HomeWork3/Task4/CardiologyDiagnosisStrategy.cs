using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class CardiologyDiagnosisStrategy : IDiagnosisStrategy
    {
        public string MakeDiagnosis(Patient patient)
        {
            return "Heart Disease Suspected";
        }
    }
}
