using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class UsuarioLogin
    {
        public int LoginId { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Perfil Usuario { get; set; }
    }
}
