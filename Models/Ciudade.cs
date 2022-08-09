using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Ciudade
    {
        public Ciudade()
        {
            Estadios = new HashSet<Estadio>();
        }

        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public int? FkIdPaís { get; set; }

        public virtual Paise FkIdPaísNavigation { get; set; }
        public virtual ICollection<Estadio> Estadios { get; set; }
    }
}
