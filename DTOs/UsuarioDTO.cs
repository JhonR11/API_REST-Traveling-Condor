using API_RESTCV.ENTITY;

namespace API_RESTCV.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Rol Role { get; set; }
    }
}
