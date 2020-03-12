using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkLinq
{
    class AnimalSpeciesDatabase : DbContext
    {
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Species> Species { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AnimalSpeciesDB;Integrated Security=True");
        }
    }
}
