using System;
using System.Collections.Generic;

#nullable disable

namespace NuevaDB_Qatar22.Models
{
    public partial class Jugadore
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? FkIdPosicion { get; set; }
        public int? Edad { get; set; }
        public int? FkIdClub { get; set; }
        public int? FkIdPlantilla { get; set; }
        public string Imagen { get; set; }
    }
}
