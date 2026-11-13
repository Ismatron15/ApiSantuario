using System.Data.Entity;

namespace ApiSantuario.Models
{
    public class SantuarioContext : DbContext
    {
        public SantuarioContext() : base("name=SantuarioConnection") { }

        public DbSet<Caballero> Caballeros { get; set; }
        public DbSet<Armadura> Armaduras { get; set; }
    }
}