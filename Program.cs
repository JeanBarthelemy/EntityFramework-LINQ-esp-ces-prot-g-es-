using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLinq
{
    static class Program
    {
        static void Main()
        {

            FactoryDB.CreateDB();
            List<Species> species = ShowInfoViaLinq.GetSpeciesFromDB();
            Species species1 = species[0];
            Species species2 = species[1];
            Species species3 = species[2];

            int animalCount1 = ShowInfoViaLinq.ShowAnimalsNumberBySpecies(species1);
            int animalCount2 = ShowInfoViaLinq.ShowAnimalsNumberBySpecies(species2);
            int animalCount3 = ShowInfoViaLinq.ShowAnimalsNumberBySpecies(species3);
            //Console.WriteLine(animalList);
            string message = "Species : " + species1.Name + "    Animals' number = " + animalCount1 + "\n" +
                            "Species : " + species2.Name + "    Animals' number = " + animalCount2 + "\n" +
                            "Species : " + species3.Name + "    Animals' number = " + animalCount3;
            MessageBox.Show(message, "Animals' number by species", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


            
        }
    }
}
