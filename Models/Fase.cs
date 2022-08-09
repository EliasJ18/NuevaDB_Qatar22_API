using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Fase
    {
        public Fase()
        {
            EstadisticasTotalesDelEquipos = new HashSet<EstadisticasTotalesDelEquipo>();
            Partidos = new HashSet<Partido>();
        }

        public int IdFase { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<EstadisticasTotalesDelEquipo> EstadisticasTotalesDelEquipos { get; set; }
        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
