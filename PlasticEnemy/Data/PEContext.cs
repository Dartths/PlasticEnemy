using Microsoft.EntityFrameworkCore;
using PlasticEnemy.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticEnemy.Data
{
    public class PEContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public PEContext(DbContextOptions<PEContext> options)
            : base(options) { }
    }
}
