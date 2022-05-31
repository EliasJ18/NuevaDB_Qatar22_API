﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class EstadisticasTotalesDelEquipo
    {
        public int? FkIdPaís { get; set; }
        public int? FkIdFase { get; set; }
        public int? Goles { get; set; }
        public int? Amarillas { get; set; }
        public int? Lesionados { get; set; }
        public int? Puntos { get; set; }
        public int? Gf { get; set; }
        public int? Gc { get; set; }

        public virtual Fase FkIdFaseNavigation { get; set; }
        public virtual Paíse FkIdPaísNavigation { get; set; }
    }
}
