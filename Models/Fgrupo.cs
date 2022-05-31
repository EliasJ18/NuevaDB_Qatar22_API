using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Fgrupo
    {
        public Fgrupo()
        {
            SeleccionesEnGrupos = new HashSet<SeleccionesEnGrupo>();
        }

        public string Id { get; set; }
        public string Grupos { get; set; }

        public virtual ICollection<SeleccionesEnGrupo> SeleccionesEnGrupos { get; set; }
    }
}
