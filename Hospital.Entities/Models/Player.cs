using System;
using System.Collections.Generic;

namespace Hospital.Entities.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; } = null!;
        public int TeamId { get; set; }

        public virtual Team Team { get; set; } = null!;
    }
}
