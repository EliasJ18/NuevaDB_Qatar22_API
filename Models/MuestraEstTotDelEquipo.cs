namespace NuevaDB_Qatar22.Models
{
    public class MuestraEstTotDelEquipo
    { 
        public int EstTotalEquipoId { get; set; }
        public int IdPaises { get; set; }
        public string Pais { get; set; }
        public int? Amarillas { get; set; }
        public int? Lesionados { get; set; }
        public int? GF { get; set; }
        public int? GC { get; set; }
        public int? Puntos { get; set; }
    }
}
