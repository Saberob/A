using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class Consejo
    {
        public Consejo()
        {
            ConsejosHabitos = new HashSet<ConsejosHabito>();
        }

        public int ConsejoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Perfil Usuario { get; set; }
        public virtual ICollection<ConsejosHabito> ConsejosHabitos { get; set; }
    }
}
