using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Partido
    {
        public int IdPartido { get; set; }
        public int? FkIdPaísA { get; set; }
        public int? FkIdPaísB { get; set; }
        public DateTime? FechaHora { get; set; }
        public int? FkIdEstado { get; set; }
        public int? FkIdEstadio { get; set; }
        public int? FkIdFase { get; set; }
        public int? FkIdClima { get; set; }

        public virtual Estadio FkIdEstadioNavigation { get; set; }
        public virtual Fase FkIdFaseNavigation { get; set; }
        public virtual Paise FkIdPaísANavigation { get; set; }
        public virtual Paise FkIdPaísBNavigation { get; set; }
    }
}
