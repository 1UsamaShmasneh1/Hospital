using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseManager = new HashSet<Employee>();
        }

        public int EmployeeId { get; set; }
        public int? PersonId { get; set; }
        public int? ManagerId { get; set; }
        public int? JobId { get; set; }
        public int? DepartmentId { get; set; }
        public int? AccountId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Department? Department { get; set; }
        public virtual Job? Job { get; set; }
        public virtual Employee? Manager { get; set; }
        public virtual Person? Person { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
    }
}
