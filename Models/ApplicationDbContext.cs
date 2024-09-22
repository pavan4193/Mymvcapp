using Microsoft.EntityFrameworkCore;

namespace MyMvcApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add DbSets for your entities here, for example:
        // public DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Category>().ToTable("Categories"); 
            modelBuilder.Entity<Category>().HasData(
                new Category{Id=1, Name="Action", DisplayOrder=1},
                new Category{Id=2, Name="SciFi", DisplayOrder=2},
                new Category{Id=3, Name="History",DisplayOrder=3}
            );
        }
    }
}
