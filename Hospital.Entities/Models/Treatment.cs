using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Treatment
    {
        public Treatment()
        {
            Patients = new HashSet<Patient>();
            TreatmentMedications = new HashSet<TreatmentMedication>();
        }

        public int TreatmentId { get; set; }
        public int? MedicalFileId { get; set; }
        public DateTime TreatmentDate { get; set; }
        public int? TreatmentInfoId { get; set; }

        public virtual MedicalFile? MedicalFile { get; set; }
        public virtual TreatmentInfo? TreatmentInfo { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<TreatmentMedication> TreatmentMedications { get; set; }
    }
}
