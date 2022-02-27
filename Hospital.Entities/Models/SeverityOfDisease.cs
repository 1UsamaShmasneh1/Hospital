using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class SeverityOfDisease
    {
        public SeverityOfDisease()
        {
            Patients = new HashSet<Patient>();
        }

        public int SeverityOfDiseaseId { get; set; }
        public string SeverityOfDeseaseTitle { get; set; } = null!;

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
