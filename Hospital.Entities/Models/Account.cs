using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte Status { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
