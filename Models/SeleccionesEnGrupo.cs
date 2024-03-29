﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class SeleccionesEnGrupo
    {
        public int IdSeleccionesEnGrupos { get; set; }
        public int FkIdFgrupos { get; set; }
        public int FkIdPaís { get; set; }

        public virtual Fgrupo FkIdFgruposNavigation { get; set; }
        public virtual Paise FkIdPaísNavigation { get; set; }
    }
}
