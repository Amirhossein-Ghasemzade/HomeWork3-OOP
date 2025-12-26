using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public interface IDiagnosisStrategy
    {
        string MakeDiagnosis(Patient patient);
    }
}
