using API_RESTCV.DTOs;
using API_RESTCV.ENTITY;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_RESTCV.Controllers
{
    [ApiController]
    [Route("api/Puntodeinteres")]
    public class PuntosdeInteresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PuntosdeInteresController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Post(PuntodeInteresCreacionDTO puntodeInteresCreacion)
        {
            var puntodeinteres = mapper.Map<PuntoDeInteres>(puntodeInteresCreacion);
            context.Add(puntodeinteres);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpGet("Obtener")]
        public async Task<ActionResult<IEnumerable<PuntodeInteresDTO>>> Get()
        {
            var allPuntos = await context.PuntosdeInteres.ToListAsync();

            if(allPuntos is null || allPuntos.Count == 0)
            {
                return NoContent();
            }

            var dtolist = mapper.Map<IEnumerable<PuntodeInteresDTO>>(allPuntos);
            return Ok(allPuntos);
        }


        [HttpPut("Update")]
        public async Task<ActionResult> Put(int id)
        {
            var puntointeres = context.PuntosdeInteres.FirstOrDefault(p => p.Id == id);
            if (puntointeres is null) { 
               return NotFound();
            }

            context.Update(puntointeres);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var puntointeres = await context.PuntosdeInteres.Where(p =>p.Id == id).ExecuteDeleteAsync();

            if (puntointeres == 0) { return NotFound(); }

            return NoContent();
        }
    }
}
