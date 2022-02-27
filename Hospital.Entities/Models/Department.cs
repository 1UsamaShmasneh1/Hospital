using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            Patients = new HashSet<Patient>();
        }

        public int DepartmentId { get; set; }
        public int? HospitalId { get; set; }
        public string DepartmentTitle { get; set; } = null!;

        public virtual Hospital? Hospital { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
