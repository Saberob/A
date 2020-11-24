using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class HabitosPerfil
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int? HabitoId { get; set; }

        public virtual Habito Habito { get; set; }
        public virtual Perfil Usuario { get; set; }
    }
}
