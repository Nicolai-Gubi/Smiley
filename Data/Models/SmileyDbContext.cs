using Microsoft.EntityFrameworkCore;

namespace Smileys.Data.Models
{
    public class SmileyDbContext : DbContext
    {
        public SmileyDbContext(DbContextOptions<SmileyDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
    }
}
