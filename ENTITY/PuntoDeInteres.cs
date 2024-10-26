using GMap.NET;

namespace API_RESTCV.ENTITY
{
    public class PuntoDeInteres
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public PuntoDeInteres() { }

        public PuntoDeInteres(int id, string nombre, double latitud, double longitud)
        {
            Id = id;
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}
