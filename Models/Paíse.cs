﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Paíse
    {
        public Paíse()
        {
            Ciudades = new HashSet<Ciudade>();
            EstadisticasTotalesDelEquipos = new HashSet<EstadisticasTotalesDelEquipo>();
            PartidoFkIdPaísANavigations = new HashSet<Partido>();
            PartidoFkIdPaísBNavigations = new HashSet<Partido>();
            Plantillas = new HashSet<Plantilla>();
            SeleccionesEnGrupos = new HashSet<SeleccionesEnGrupo>();
        }

        public int IdPaises { get; set; }
        public string País { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Ciudade> Ciudades { get; set; }
        public virtual ICollection<EstadisticasTotalesDelEquipo> EstadisticasTotalesDelEquipos { get; set; }
        public virtual ICollection<Partido> PartidoFkIdPaísANavigations { get; set; }
        public virtual ICollection<Partido> PartidoFkIdPaísBNavigations { get; set; }
        public virtual ICollection<Plantilla> Plantillas { get; set; }
        public virtual ICollection<SeleccionesEnGrupo> SeleccionesEnGrupos { get; set; }
    }
}
