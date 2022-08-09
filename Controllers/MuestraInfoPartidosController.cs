using Microsoft.AspNetCore.Mvc;
using NuevaDB_Qatar22.Models;
using System.Collections.Generic;
using System.Linq;

namespace NuevaDB_Qatar22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuestraInfoPartidosController : ControllerBase
    {
        private readonly Qatar22DBContext context;

        public MuestraInfoPartidosController(Qatar22DBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<MuestraInfoPartido> GetMIP()
        {
            using (context)
            {
                var query = from a in context.Partidos
                            join b in context.Paises
                            on a.FkIdPaísA equals b.IdPaises
                            join c in context.Paises
                            on a.FkIdPaísB equals c.IdPaises
                            join d in context.EstadoDePartidos
                            on a.FkIdEstado equals d.IdEstado
                            join e in context.Estadios
                            on a.FkIdEstadio equals e.IdEstadio
                            join f in context.Fases
                            on a.FkIdFase equals f.IdFase
                            join g in context.Climas
                            on a.FkIdClima equals g.IdClima
                            select new MuestraInfoPartido
                            {
                                idPartido = a.IdPartido,
                                FkIdPaísA = b.IdPaises,
                                PaísA = b.País,
                                FkIdPaísB = b.IdPaises,
                                PaísB = c.País,
                                FkIdEstado = d.IdEstado,
                                FkIdEstadio = e.IdEstadio,
                                FkIdFase = f.IdFase,
                                FkIdClima = g.IdClima,
                                Estado = d.Estado,
                                Estadio = e.Nombre,
                                Fase = f.Nombre,
                                Clima = g.Clima1
                            };
                return query;
            }
        }
    }
}
