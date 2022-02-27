using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class MedicalFile
    {
        public MedicalFile()
        {
            Treatments = new HashSet<Treatment>();
        }

        public int MedicalFileId { get; set; }
        public int? PersonId { get; set; }

        public virtual Person MedicalFileNavigation { get; set; } = null!;
        public virtual Person? Person { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
