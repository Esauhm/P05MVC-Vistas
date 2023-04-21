using Microsoft.EntityFrameworkCore;

namespace MVC_Practica01.Models
{
    public class EquiposDBContext : DbContext
    {
        public EquiposDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Marcas> marcas { get; set; }

        public DbSet<equipos> equipos { get; set; }
    }
}
