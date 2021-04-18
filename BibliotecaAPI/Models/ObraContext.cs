using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
