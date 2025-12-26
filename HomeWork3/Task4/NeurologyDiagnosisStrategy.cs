using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class NeurologyDiagnosisStrategy : IDiagnosisStrategy
    {
        public string MakeDiagnosis(Patient patient)
        {
            return "Neurogocal issue suspected";
        }
    }
}
