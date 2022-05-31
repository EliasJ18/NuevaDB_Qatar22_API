using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class EstadisticasDelPartido
    {
        public int? FkIdPartido { get; set; }
        public int? Estado { get; set; }
        public int? TiempoJugado { get; set; }
        public int? Clima { get; set; }
        public int? Espectadores { get; set; }

        public virtual Partido FkIdPartidoNavigation { get; set; }
    }
}
