using BlazorWasm.Menu.DAL.Configurations;
using BlazorWasm.Menu.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Menu.DAL
{
    public class MenuDbContext : DbContext
    {

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }

        public MenuDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IngridientConfig());
            modelBuilder.ApplyConfiguration(new RecipeConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
