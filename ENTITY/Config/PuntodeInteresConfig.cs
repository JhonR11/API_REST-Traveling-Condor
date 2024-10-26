using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_RESTCV.ENTITY.Config
{
    public class PuntodeInteresConfig : IEntityTypeConfiguration<PuntoDeInteres>
    {
        public void Configure(EntityTypeBuilder<PuntoDeInteres> builder)
        {
            builder.Property(pi => pi.Nombre).HasMaxLength(40);
        }
    }
}
