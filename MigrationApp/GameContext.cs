using System.Data.Entity;

namespace MigrationApp
{
    public class GameContext : DbContext
    {
        public GameContext() : base("TestDb") { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
    }
}
