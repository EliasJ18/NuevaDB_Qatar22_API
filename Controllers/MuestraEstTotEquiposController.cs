using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/equipos/estadisticas-totales")]
    [ApiController]
    public class MuestraEstTotEquiposController : ControllerBase
    {
        private readonly Qatar22DBContext context;

        public MuestraEstTotEquiposController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<MuestraEstTotDelEquipo> GetMETDE()
        {
            using (context)
            {
                var res = from a in context.EstadisticasTotalesDelEquipos
                             join b in context.Paises
                            on a.FkIdPaís equals b.IdPaises
                             select new MuestraEstTotDelEquipo
                             {
                                EstTotalEquipoId = a.EstTotalEquipoId,
                                IdPaises = b.IdPaises,
                                País = b.País,
                                Amarillas = a.Amarillas,
                                Lesionados = a.Lesionados,
                                GF = a.Gf,
                                GC = a.Gc,
                                Puntos = a.Puntos
                            };
                return res.ToList();
            }

            

        }
    }
}
