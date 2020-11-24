using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            Consejos = new HashSet<Consejo>();
            HabitosPerfils = new HashSet<HabitosPerfil>();
            Mensajes = new HashSet<Mensaje>();
            SalaUsuarios = new HashSet<SalaUsuario>();
            UsuarioLogins = new HashSet<UsuarioLogin>();
        }

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Cumpleaños { get; set; }

        public virtual ICollection<Consejo> Consejos { get; set; }
        public virtual ICollection<HabitosPerfil> HabitosPerfils { get; set; }
        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<SalaUsuario> SalaUsuarios { get; set; }
        public virtual ICollection<UsuarioLogin> UsuarioLogins { get; set; }
    }
}
