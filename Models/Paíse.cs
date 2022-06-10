using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    
    public partial class Paíse
    {
        
        public Paíse()
        {
            Ciudades = new HashSet<Ciudade>();
            PartidoFkIdPaísANavigations = new HashSet<Partido>();
            PartidoFkIdPaísBNavigations = new HashSet<Partido>();
            Plantillas = new HashSet<Plantilla>();
            SeleccionesEnGrupos = new HashSet<SeleccionesEnGrupo>();
        }

        public int Id { get; set; }
        public string País { get; set; }

        public virtual ICollection<Ciudade> Ciudades { get; set; }
        [NotMapped]
        public virtual ICollection<Partido> PartidoFkIdPaísANavigations { get; set; }
        [NotMapped]
        public virtual ICollection<Partido> PartidoFkIdPaísBNavigations { get; set; }
        public virtual ICollection<Plantilla> Plantillas { get; set; }
        public virtual ICollection<SeleccionesEnGrupo> SeleccionesEnGrupos { get; set; }
    }
}
