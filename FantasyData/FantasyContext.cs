using FantasyAppData.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyAppData
{
    public class FantasyContext : DbContext
    {
        public FantasyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Lineup> Lineups { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Customer> Customer { get; set; }

    }
}

    