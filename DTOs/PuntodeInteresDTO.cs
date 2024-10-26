using System.ComponentModel.DataAnnotations;

namespace API_RESTCV.DTOs
{
    public class PuntodeInteresDTO
    {   
        public string Nombre { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
