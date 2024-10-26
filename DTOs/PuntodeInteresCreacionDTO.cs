using System.ComponentModel.DataAnnotations;

namespace API_RESTCV.DTOs
{
    public class PuntodeInteresCreacionDTO
    {
        [Required]
        [MaxLength(80)]
        public string Nombre { get; set; }

        [Required]
        public double Latitud { get; set; }
        [Required]
        public double Longitud { get; set; }
    }
}
