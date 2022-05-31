using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Plantilla
    {
        public Plantilla()
        {
            Jugadores = new HashSet<Jugadore>();
        }

        public int Id { get; set; }
        public int? FkIdJugador { get; set; }
        public int? FkIdPaís { get; set; }

        public virtual Paíse FkIdPaísNavigation { get; set; }
        public virtual ICollection<Jugadore> Jugadores { get; set; }
    }
}
