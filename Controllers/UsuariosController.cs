using API_RESTCV.DTOs;
using API_RESTCV.ENTITY;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_RESTCV.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UsuariosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("Creacion")]
        public async Task<ActionResult> Post(UsuarioCreacionDTO usuarioCreacion)
        {
            if(usuarioCreacion.validRole() == false)
            {
                return BadRequest("Rol no valido");
            }
            var usuario = mapper.Map<Usuario>(usuarioCreacion);
            context.Add(usuario);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpPost("Iniciosesion")]
        public async Task<ActionResult<UsuarioDTO>> PostLogin(UsarioLoginDTO usuarioLogin)
        {
            Usuario? usuario = await context.Usuarios
                                              .Where(u => u.CorreoElectronico == usuarioLogin.Correo
                                                      && u.Contrasenia == usuarioLogin.Contrasenia)
                                              .FirstOrDefaultAsync();

            if (usuario == null)
            {
                return NotFound();
            }

            var usuarioDTO = mapper.Map<UsuarioDTO>(usuario);
            return Ok(usuarioDTO);
        }


        [HttpGet("listaUsuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> getUser()
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Delete(int id)
        {
            var filaAlterada = await context.Usuarios.Where(us => us.Id == id).ExecuteDeleteAsync();

            if(filaAlterada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }



        [HttpPut("Update (le falta aun)")]
        public async Task<ActionResult> Update(int id, UsuarioCreacionDTO usuarioCreacion)
        {
            var usuario = mapper.Map<Usuario>(usuarioCreacion);
            usuario.Id = id;
            context.Update(usuario);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}

