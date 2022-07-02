using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController: ControllerBase
    {
        private readonly Qatar22DBContext context;

        public JugadoresController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Jugadore>> Get()
        {
            return context.Jugadores.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Jugadore> Get(int id)
        {
            var jugador = context.Jugadores.FirstOrDefault(x => x.Id == id);

            if (jugador == null)
            {
                return NotFound();
            }

            return jugador;
        }
    }
}
