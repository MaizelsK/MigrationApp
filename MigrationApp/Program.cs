using System;
using System.Collections.Generic;

namespace MigrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start programm");
            
            using (var context = new GameContext())
            {
                context.Developers.Add(new Developer
                {
                    Name = "Ubisoft",
                    Games = new List<Game>
                    {
                        new Game{ Name="Assassin's Creed Origins", Description="Egypt period" }
                    }
                });

                context.SaveChanges();
            }

            Console.ReadLine();          
        }
    }
}
