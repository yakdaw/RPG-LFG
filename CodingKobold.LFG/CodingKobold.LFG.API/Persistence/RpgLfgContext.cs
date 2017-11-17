using CodingKobold.LFG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodingKobold.LFG.API.Persistence
{
    public class RpgLfgContext : DbContext
    {
        public RpgLfgContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO : Fluent API
            base.OnModelCreating(modelBuilder);
        }
    }
}
