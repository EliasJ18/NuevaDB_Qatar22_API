using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Posicione
    {
        public Posicione()
        {
            Jugadores = new HashSet<Jugadore>();
        }

        public int Id { get; set; }
        public string Posición { get; set; }

        public virtual ICollection<Jugadore> Jugadores { get; set; }
    }
}
