using Microsoft.EntityFrameworkCore;
using PlasticEnemy.Data.Entities;

namespace PlasticEnemy.Data
{
    public class PEContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<PlasticEntry> PlasticEntries { get; set; }
        public DbSet<PlasticType> PlasticTypes { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Action> Actions { get; set; }
        public PEContext(DbContextOptions<PEContext> options)
            : base(options) { }
    }
}
