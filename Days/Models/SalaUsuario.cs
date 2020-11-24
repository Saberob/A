using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class SalaUsuario
    {
        public int Id { get; set; }
        public int? SalaId { get; set; }
        public int? UsuarioId { get; set; }
        public string Nombre { get; set; }

        public virtual Sala Sala { get; set; }
        public virtual Perfil Usuario { get; set; }
    }
}
