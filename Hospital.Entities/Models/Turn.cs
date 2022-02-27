using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Turn
    {
        public int TurnId { get; set; }
        public string TurnTitle { get; set; } = null!;
        public byte Status { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
