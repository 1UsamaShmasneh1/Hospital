using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            Departments = new HashSet<Department>();
        }

        public int HospitalId { get; set; }
        public string HospitalTitle { get; set; } = null!;
        public int? AddressId { get; set; }

        public virtual Address? Address { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
