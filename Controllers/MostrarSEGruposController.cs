using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MostrarSEGruposController : ControllerBase
    {
        private readonly Qatar22DBContext context;

        public MostrarSEGruposController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<MostrarSEGrupo> GetMSEG()
        {
            using (context)
            {
                var query = from a in context.SeleccionesEnGrupos
                            join b in context.Paises
                            on a.FkIdPaís equals b.IdPaises
                            join c in context.Fgrupos
                            on a.FkIdFgrupos equals c.IdGrupos
                            select new MostrarSEGrupo
                            {
                                idSeleccionesEnGrupos = a.IdSeleccionesEnGrupos,
                                IdPaises = b.IdPaises,
                                País = b.País,
                                Imagen = b.Imagen,
                                IdGrupos = c.IdGrupos,
                                Grupos = c.Grupos
                                
                            };
                return query.ToList();
            }

            //return context.Países.ToList();

        }
    }

}
