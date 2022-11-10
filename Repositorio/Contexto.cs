using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class BdContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }

        public BdContexto() { }
        public BdContexto(DbContextOptions<BdContexto> options) : base(options) { }
    }
}
