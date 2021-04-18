using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Models
{
    public class ObraContext : DbContext
    {
        public ObraContext(DbContextOptions<ObraContext> options) : base(options)
        {

        }

        public DbSet<Obra> Obra { get; set; }
    }
}
