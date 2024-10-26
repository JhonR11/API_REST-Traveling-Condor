using API_RESTCV.DTOs;
using API_RESTCV.ENTITY;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_RESTCV.Controllers
{
    [ApiController]
    [Route("api/Rutas")]
    public class RutaController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public RutaController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost("agregar")]
        public async Task<ActionResult> Post(RutaCreacionDTO rutaCreacion)
        {
            var ruta = mapper.Map<Ruta>(rutaCreacion);
            context.Add(ruta);
            await context.SaveChangesAsync();
            return Ok(ruta);
        }


        [HttpPost("rutasUsuario")]
        public async Task<ActionResult<IEnumerable<Ruta>>> Get(RutaRequestDTO request)
        {
            var rutas = await context.Rutas.Where(r => r.UsuarioId == request.IdUsuario).ToListAsync();

            return (rutas.Count == 0) ? NoContent() : Ok(rutas);
        }

        [HttpPut("editar")]
        public async Task<ActionResult> Put(int idRuta, RutaCreacionDTO rutaCreacion)
        {
            var ruta = mapper.Map<Ruta>(rutaCreacion);
            ruta.Id = idRuta;
            context.Update(ruta);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Delete(int id)
        {
            var ruta = await context.Rutas.Where(r => r.Id == id).ExecuteDeleteAsync();

            if(ruta == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
