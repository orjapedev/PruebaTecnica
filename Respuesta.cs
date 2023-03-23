namespace PruebaTecnica
{
    public class Respuesta
    {
        public string CodigoRespuesta { get; set; }
        public string Descripcion { get; set; }

        public Respuesta(string codigo,  string descripcion)
        {
            this.CodigoRespuesta = codigo;
            this.Descripcion = descripcion;
        }
    }
}
