using CodingKobold.LFG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodingKobold.LFG.API.Model
{
    public class RpgLfgContext : DbContext
    {
        public DbSet<Player> Type { get; set; }
    }

    public partial class Player
    {
        
    }
}