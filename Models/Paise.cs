using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Paise
    {
        public Paise()
        {
            Ciudades = new HashSet<Ciudade>();
            EstadisticasTotalesDelEquipos = new HashSet<EstadisticasTotalesDelEquipo>();
            PartidoFkIdPaisANavigations = new HashSet<Partido>();
            PartidoFkIdPaisBNavigations = new HashSet<Partido>();
            Plantillas = new HashSet<Plantilla>();
            SeleccionesEnGrupos = new HashSet<SeleccionesEnGrupo>();
        }

        public int IdPaises { get; set; }
        public string Pais { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Ciudade> Ciudades { get; set; }
        public virtual ICollection<EstadisticasTotalesDelEquipo> EstadisticasTotalesDelEquipos { get; set; }
        public virtual ICollection<Partido> PartidoFkIdPaisANavigations { get; set; }
        public virtual ICollection<Partido> PartidoFkIdPaisBNavigations { get; set; }
        public virtual ICollection<Plantilla> Plantillas { get; set; }
        public virtual ICollection<SeleccionesEnGrupo> SeleccionesEnGrupos { get; set; }
    }
}
