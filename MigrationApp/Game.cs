using System;

namespace MigrationApp
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }

        public Developer Developer { get; set; }

        public Game()
        {
            Id = Guid.NewGuid();
        }
    }
}
