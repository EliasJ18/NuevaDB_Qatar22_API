namespace NuevaDB_Qatar22.Models
{
    public class MuestraJugYPosicion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int? fkIdPosicion { get; set; }
        public string Posición { get; set; }
        public int? fkIdClub { get; set; }
        public string club { get; set; }
        public int? edad { get; set; }
        public string imagen { get; set; }
    }
}
