using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Controllers.Contexts;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("PermitirApiRequest")]
    public class ClubesController : ControllerBase
    {
        private readonly Qatar22DBContext context;

        public ClubesController(Qatar22DBContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Clube>> Get()
        {
            return context.Clubes.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Clube> Get(int id)
        {
            var club = context.Clubes.FirstOrDefault(x => x.Id == id);

            if (club == null)
            {
                return NotFound();
            }

            return club;
        }
    }
}
