using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class PatientStatus
    {
        public PatientStatus()
        {
            Patients = new HashSet<Patient>();
        }

        public int StatusId { get; set; }
        public string StatusTitle { get; set; } = null!;

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
