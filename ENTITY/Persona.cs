namespace API_RESTCV.ENTITY
{
    public  abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ruta> Rutas { get; set; } = new List<Ruta>();


        public Persona() { }
        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
