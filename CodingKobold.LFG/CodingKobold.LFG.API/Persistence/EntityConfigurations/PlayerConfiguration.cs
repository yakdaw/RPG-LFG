using CodingKobold.LFG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingKobold.LFG.API.Persistence.EntityConfigurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .Property(p => p.Nickname)
                .IsRequired(true)
                .HasMaxLength(25);

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(20);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(35);

            builder
                .Property(p => p.City)
                .HasMaxLength(60);
        }
    }
}