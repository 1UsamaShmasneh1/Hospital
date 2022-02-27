using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class TreatmentMedication
    {
        public int TreatmentMedicationId { get; set; }
        public int? MedicationId { get; set; }
        public int? TreatmentId { get; set; }
        public int? BerDay { get; set; }
        public int? BerBite { get; set; }
        public int? Days { get; set; }

        public virtual Medication? Medication { get; set; }
        public virtual Treatment? Treatment { get; set; }
    }
}
