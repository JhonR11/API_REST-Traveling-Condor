using API_RESTCV.ENTITY;
using System.ComponentModel.DataAnnotations;

namespace API_RESTCV.DTOs
{
    public class RutaCreacionDTO
    {
        [Required][MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        public List<PuntoLatLng> PuntosRutas { get; set; }

        [Required]
        public int UsuarioId { get; set; }
    }
}
