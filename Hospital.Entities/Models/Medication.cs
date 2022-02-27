using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Medication
    {
        public Medication()
        {
            TreatmentMedications = new HashSet<TreatmentMedication>();
        }

        public int MedicationId { get; set; }
        public string MedicationTitle { get; set; } = null!;

        public virtual ICollection<TreatmentMedication> TreatmentMedications { get; set; }
    }
}
