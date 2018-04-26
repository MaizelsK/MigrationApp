using System;
using System.Collections.Generic;

namespace MigrationApp
{
    public class Developer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }

        public Developer()
        {
            Id = Guid.NewGuid();
        }
    }
}
