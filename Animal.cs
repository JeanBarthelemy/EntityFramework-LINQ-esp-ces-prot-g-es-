using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLinq
{
    public class Animal
    {
        public Guid AnimalID { get; set; }
        public string Name { get; set; }

        public virtual Guid SpeciesID { get; set; }

    }
}
