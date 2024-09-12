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
        public DbSet<Category> Category { get; set; }
    }
}
