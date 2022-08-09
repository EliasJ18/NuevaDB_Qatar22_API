using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidosController : Controller
    {
        private readonly Qatar22DBContext context;

        public PartidosController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Partido>> Get()
        {
            return context.Partidos.ToList();
        }
    }
}
