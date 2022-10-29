using Microsoft.EntityFrameworkCore;

namespace Stock_trading.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Aksje> Aksjer { get; set; }
    }
}
