using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class Mensaje
    {
        public int MensajeId { get; set; }
        public int? UsuarioId { get; set; }
        public int? SalaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int? TipoId { get; set; }
        public string Link { get; set; }

        public virtual Sala Sala { get; set; }
        public virtual TipoMensaje Tipo { get; set; }
        public virtual Perfil Usuario { get; set; }
    }
}
