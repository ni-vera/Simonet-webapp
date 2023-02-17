using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp
{
    public class WebappDbContext :DbContext
    {
        public WebappDbContext(DbContextOptions<WebappDbContext> options) : base(options)
        {
        }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Propuesta> Propuestas { get; set; }
    }
}
