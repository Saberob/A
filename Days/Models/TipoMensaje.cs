using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class TipoMensaje
    {
        public TipoMensaje()
        {
            Mensajes = new HashSet<Mensaje>();
        }

        public int TipoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }
    }
}
