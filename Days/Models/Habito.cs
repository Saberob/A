using System;
using System.Collections.Generic;

#nullable disable

namespace Days.Models
{
    public partial class Habito
    {
        public Habito()
        {
            ConsejosHabitos = new HashSet<ConsejosHabito>();
            HabitosPerfils = new HashSet<HabitosPerfil>();
        }

        public int HabitoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ConsejosHabito> ConsejosHabitos { get; set; }
        public virtual ICollection<HabitosPerfil> HabitosPerfils { get; set; }
    }
}
