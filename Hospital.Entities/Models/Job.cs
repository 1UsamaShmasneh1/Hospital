using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public int JobId { get; set; }
        public string JobTitle { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
