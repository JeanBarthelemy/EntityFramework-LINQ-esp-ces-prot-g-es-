using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLinq
{
    public class ShowInfoViaLinq
    {
        public static List<Species> GetSpeciesFromDB()
        {
            using (var context = new AnimalSpeciesDatabase())
            {
                var speciesSelected = from s in context.Species
                                      select s;

                return speciesSelected.ToList();
            }
        }

        public static int ShowAnimalsNumberBySpecies(Species species)
        {
            using (var context = new AnimalSpeciesDatabase())
            {
                var animalsCount =  (from a in context.Animals
                                    join s in context.Species
                                    on a.SpeciesID equals s.SpeciesID
                                    where s.Name == species.Name
                                    select a.AnimalID).Count();

                return animalsCount;
            }
        }
    }
}
