
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace API_RESTCV.ENTITY.Config
{
    public class RutaConfig : IEntityTypeConfiguration<Ruta>
    {
        public void Configure(EntityTypeBuilder<Ruta> builder)
        {
            builder.Property(r => r.Nombre).HasMaxLength(15);
            builder.Property(ru => ru.PuntosRutas).HasConversion(
                  v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                        v => JsonSerializer.Deserialize<List<PuntoLatLng>>(v, (JsonSerializerOptions)null));
        }

    }
}
