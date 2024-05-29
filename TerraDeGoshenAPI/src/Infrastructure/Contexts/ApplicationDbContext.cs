using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CategoryRef> Categories { get; set; }
        public DbSet<ColorRef> Colors { get; set; }
        public DbSet<ImageRef> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SizeRef> Sizes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
        }
    }
}