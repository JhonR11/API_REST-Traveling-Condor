using API_RESTCV.ENTITY;
using Microsoft.EntityFrameworkCore;

namespace API_RESTCV.Seeding
{
    public class SeedingInicial
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var SuperAdmin = new Usuario()
            {
                Id = 2,
               Nombre = "El Administador Maestro",
                CorreoElectronico = "javierdialf03@gmail.com",
                Contrasenia = "admin123456",
                Role = Rol.SUPER_ADMIN
            };

            var usuarioSIVA = new Usuario()
            {
                Id = 3,
                Nombre = "adminSIVA",
                CorreoElectronico = "ventanillaunica@siva.gov.co",
                Contrasenia = "sabranellos",
                Role = Rol.ADMIN
            };

           
         

            modelBuilder.Entity<Usuario>().HasData(SuperAdmin, usuarioSIVA);
        }
    }
}
