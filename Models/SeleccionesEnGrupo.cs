using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class SeleccionesEnGrupo
    {
        public int Id { get; set; }
        public string FkIdFgrupos { get; set; }
        public int FkIdPaís { get; set; }

        public virtual Fgrupo FkIdFgruposNavigation { get; set; }
        public virtual Paíse FkIdPaísNavigation { get; set; }
    }
}
