using AnimalDataEntitities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalData
{
    public class AnimalDataDbContext: DbContext
    {
        public AnimalDataDbContext() : base("AnimalDatabase")
        {

        }
        public DbSet<Animal> Animals { get; set; }     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
           
        }
    }

    
}
