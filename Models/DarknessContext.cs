using Microsoft.EntityFrameworkCore;

namespace database_to_d3.Models
{
    public class DarknessContext : DbContext
    {
        public DarknessContext(DbContextOptions<DarknessContext> options)
            : base(options)
        {
        }

        public DbSet<Darkness> DarknessItems { get; set; }
    }
}