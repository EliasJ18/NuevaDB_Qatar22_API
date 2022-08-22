using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/jugadores/datos-de-jugadores")]
    [ApiController]
    public class MuestraJugYDatosController : ControllerBase
    {
        private readonly Qatar22DBContext context;

        public MuestraJugYDatosController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<MuestraJugYPosicion> GetJYP()
        {
            using (context)
            {
                var query = from a in context.Jugadores
                            join b in context.Posiciones
                            on a.FkIdPosicion equals b.Id
                            join c in context.Clubes
                            on a.FkIdClub equals c.Id
                            select new MuestraJugYPosicion
                            {
                                id = a.Id,
                                nombre = a.Nombre,
                                fkIdPosicion = a.FkIdPosicion,
                                Posición = b.Posición,
                                edad = a.Edad,
                                fkIdClub = a.FkIdClub,
                                club = c.Club,
                                imagen = a.Imagen
                            };
                return query.ToList();
            }
        }
    }
}
