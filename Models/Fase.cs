using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Fase
    {
        public Fase()
        {
            Partidos = new HashSet<Partido>();
        }

        public int IdFase { get; set; }
        public int? FkIdCiudad { get; set; }
        public string Nombre { get; set; }

        public virtual Ciudade FkIdCiudadNavigation { get; set; }
        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
