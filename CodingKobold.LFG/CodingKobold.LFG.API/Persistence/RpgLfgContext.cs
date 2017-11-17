using CodingKobold.LFG.API.Persistence.EntityConfigurations;
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
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
