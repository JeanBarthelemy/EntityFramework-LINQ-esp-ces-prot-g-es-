using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLinq
{
    public class FactoryDB
    {
        public static void CreateDB()
        {
            using (var context = new AnimalSpeciesDatabase())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var species1 = new Species()
                {
                    Name = "White Cougar"
                };

                var species2 = new Species()
                {
                    Name = "White Tiger"
                };

                var species3 = new Species()
                {
                    Name = "Albino Turtle"
                };

                species1.Animals = new List<Animal>
                {
                    new Animal { Name = "Snow White Courgar"},
                    new Animal { Name = "Desert White Cougar"},
                    new Animal { Name = "Forest White Cougar"}
                };

                context.Add(species1);

                species2.Animals = new List<Animal>();
                for (int i = 1; i <= 100; i++)
                {
                    species2.Animals.Add(new Animal { Name = $"White Tiger {i}" });
                }

                context.Add(species2);

                species3.Animals = new List<Animal>();
                for (int i = 1; i <= 15; i++)
                {
                    species3.Animals.Add(new Animal { Name = $"Albino Turtle {i}" });
                }

                context.Add(species3);

                context.SaveChanges();

            }
        }
    }
}
