using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BibliotecaAPI.Models
{
    public class ObraContext : DbContext
    {
        public ObraContext(DbContextOptions<ObraContext> options) : base(options)
        {

        }

        public DbSet<Obra> Obra { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Obra>().Property(p => p.Autores).HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<List<string>>(v));
        }
    }
}
