using Microsoft.AspNetCore.Identity;

namespace API_RESTCV.ENTITY
{
    public class Usuario : Persona
    {
        public string CorreoElectronico { get; set; }
        public string Contrasenia { get; set; }
        public Rol Role { get; set; }
        public virtual ICollection<Ruta> Rutas { get; set; }


        public Usuario() { }

        public Usuario(int Id, string Nombre, string CorreoElectronico, string Contrasenia, Rol Role) : 
            base(Id,Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.CorreoElectronico = CorreoElectronico;
            this.Contrasenia = Contrasenia;
            this.Role = Role;
        }
    }

    public enum Rol
    {
        SUPER_ADMIN,
        ADMIN,
        USER
    }
}
