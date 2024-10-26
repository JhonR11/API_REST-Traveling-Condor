using GMap.NET;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace API_RESTCV.ENTITY
{
    public class Ruta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<PuntoLatLng> PuntosRutas { get; set; }

        public int UsuarioId { get; set; }
    }

    public class PuntoLatLng
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
