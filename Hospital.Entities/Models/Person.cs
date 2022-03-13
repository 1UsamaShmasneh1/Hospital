using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Person
    {
        public Person()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? AddressId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        public int? MedicalFileId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }

        public virtual Address? Address { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual MedicalFile MedicalFileMedicalFileNavigation { get; set; } = null!;
        public virtual MedicalFile? MedicalFilePerson { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
