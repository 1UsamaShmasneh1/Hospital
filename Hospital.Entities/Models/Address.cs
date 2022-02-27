using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Address
    {
        public Address()
        {
            Hospitals = new HashSet<Hospital>();
            People = new HashSet<Person>();
        }

        public int AddressId { get; set; }
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int ZipCode { get; set; }
        public string? Street { get; set; }
        public int? HouseNumber { get; set; }

        public virtual ICollection<Hospital> Hospitals { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
