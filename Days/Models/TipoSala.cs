using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class TipoSala
    {
        public TipoSala()
        {
            Salas = new HashSet<Sala>();
        }

        public int TipoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Sala> Salas { get; set; }
    }
}
