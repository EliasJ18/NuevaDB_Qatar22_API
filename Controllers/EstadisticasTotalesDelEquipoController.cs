using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadisticasTotalesDelEquipoController : Controller
    {
        private readonly Qatar22DBContext context;

        public EstadisticasTotalesDelEquipoController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EstadisticasTotalesDelEquipo>> Get()
        {
            return context.EstadisticasTotalesDelEquipos.ToList();
        }
    }
}