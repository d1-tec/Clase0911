using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class RecipesContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        public RecipesContext() : base("name=defaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RecipesContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .HasRequired(p => p.Country)
                .WithOptional(p => p.Ingredient);
        }
    }
}
