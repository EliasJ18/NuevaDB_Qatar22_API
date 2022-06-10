using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Ciudade
    {
        public Ciudade()
        {
            Estadios = new HashSet<Estadio>();
            Fases = new HashSet<Fase>();
        }
        [Key]
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public int? FkIdPaís { get; set; }

        public virtual Paíse FkIdPaísNavigation { get; set; }
        public virtual ICollection<Estadio> Estadios { get; set; }
        public virtual ICollection<Fase> Fases { get; set; }
    }
}
