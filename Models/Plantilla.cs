using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Plantilla
    {
        public int Id { get; set; }
        public int? FkIdJugador { get; set; }
        public int? FkIdPaís { get; set; }

        public virtual Paise FkIdPaísNavigation { get; set; }
    }
}
