using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Entidades
{
    public class Operacion
    {
        public string Id { get; set; }
        public List<Carga>? Carga { get; set; }
        public string ContactoBodega { get; set; }

        public string DireccionBodega { get; set; }

        public DateTime FechaRetiro { get; set; }

        public string NumeroContenedor { get; set; }

        public int PesoContenedor { get; set; }

        public int VolumenCarga { get; set; }

    }

    public class Carga
    {
        public string Id { get; set; }
        public string NumeroCarga { get; set; }

        public double ValorCarga { get; set; }
    }
}
