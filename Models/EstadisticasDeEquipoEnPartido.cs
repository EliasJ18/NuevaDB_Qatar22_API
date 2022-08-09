using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class EstadisticasDeEquipoEnPartido
    {
        public int? FkIdPartido { get; set; }
        public int? FkIdPaís { get; set; }
        public int? Goles { get; set; }
        public int? Amarillas { get; set; }
        public int? Rojas { get; set; }
        public int? Lesionados { get; set; }

        public virtual Partido FkIdPartidoNavigation { get; set; }
        public virtual Paise FkIdPaísNavigation { get; set; }
    }
}
