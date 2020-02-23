using Microsoft.EntityFrameworkCore;
using PlasticEnemy.Data.Entities;

namespace PlasticEnemy.Data
{
    public class PEContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public PEContext(DbContextOptions<PEContext> options)
            : base(options) { }
    }
}
