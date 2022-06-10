using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Partido
    {
        [Key]
        public int IdPartido { get; set; }
        public int? FkIdPaísA { get; set; }
        public int? FkIdPaísB { get; set; }
        public DateTime? FechaHora { get; set; }
        public int? FkIdEstadio { get; set; }
        public int? FkIdFase { get; set; }
        public virtual Estadio FkIdEstadioNavigation { get; set; }
        public virtual Fase FkIdFaseNavigation { get; set; }
        [NotMapped]
        public virtual Paíse FkIdPaísANavigation { get; set; }
        [NotMapped]
        public virtual Paíse FkIdPaísBNavigation { get; set; }
    }
}
