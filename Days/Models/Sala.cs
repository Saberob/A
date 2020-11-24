using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class Sala
    {
        public Sala()
        {
            Mensajes = new HashSet<Mensaje>();
            SalaUsuarios = new HashSet<SalaUsuario>();
        }

        public int SalaId { get; set; }
        public int? TipoId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual TipoSala Tipo { get; set; }
        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<SalaUsuario> SalaUsuarios { get; set; }
    }
}
