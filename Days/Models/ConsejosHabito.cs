using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class ConsejosHabito
    {
        public int Id { get; set; }
        public int? HabitoId { get; set; }
        public int? ConsejoId { get; set; }

        public virtual Consejo Consejo { get; set; }
        public virtual Habito Habito { get; set; }
    }
}
