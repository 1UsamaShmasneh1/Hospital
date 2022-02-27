using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class TreatmentInfo
    {
        public int TreatmentInfoId { get; set; }
        public byte? IsSmoking { get; set; }
        public string? Sensitive { get; set; }
        public string? ReasonOfComing { get; set; }
        public string? DiseaseDiagnosis { get; set; }
        public string? BloodPressure { get; set; }
        public string? Heat { get; set; }
        public string? Heartbeat { get; set; }
        public string? OxginInBlood { get; set; }
        public string? BloodTest { get; set; }
        public string? UrineTest { get; set; }
        public string? MedicalAdvice { get; set; }

        public virtual Treatment? Treatment { get; set; }
    }
}
