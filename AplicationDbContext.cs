using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Entidades;

namespace PruebaTecnica
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Operacion> Operaciones { get; set; }


    }
}
