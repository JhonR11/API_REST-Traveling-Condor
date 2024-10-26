using API_RESTCV.ENTITY;
using System.ComponentModel.DataAnnotations;

namespace API_RESTCV.DTOs
{
    public class UsuarioCreacionDTO
    {
        
        [Required] [StringLength(maximumLength: 70)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Contrasenia { get; set; }

        [Required]
        [MaxLength(14)]
        public string Role {  get; set; }


        public bool validRole()
        {
            foreach (var rol in Enum.GetValues(typeof(Rol))) {
               if(rol.ToString() == Role) return true;
            }

            return false;
        }
    
    }
}
