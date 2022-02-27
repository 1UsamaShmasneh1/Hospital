using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public int? PersonId { get; set; }
        public int? TurnId { get; set; }
        public int? SeverityOfDiseaseId { get; set; }
        public int? DepartmentId { get; set; }
        public int? StatusId { get; set; }
        public int? TreatmentId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Person? Person { get; set; }
        public virtual SeverityOfDisease? SeverityOfDisease { get; set; }
        public virtual PatientStatus? Status { get; set; }
        public virtual Treatment? Treatment { get; set; }
        public virtual Turn? Turn { get; set; }
    }
}
