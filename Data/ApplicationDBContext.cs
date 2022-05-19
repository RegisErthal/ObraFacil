using Microsoft.EntityFrameworkCore;
namespace ObraFacil.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Developer> Developers { get; set; }

    }
}
