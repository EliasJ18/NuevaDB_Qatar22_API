using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Controllers.Contexts;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public JugadoresController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Jugadore>> Get()
        {
            return context.Nombre.ToList();
        }
    }
}
