using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Controllers.Contexts;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FgruposController : ControllerBase
    {
        private readonly Qatar22DBContext context;

        public FgruposController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Fgrupo>> Get()
        {
            return context.Fgrupos.ToList(); 
        }
    }
}
