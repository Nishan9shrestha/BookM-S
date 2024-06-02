using Microsoft.EntityFrameworkCore;
using BookM_S.Models;

namespace YourProjectNamespace.Models  // Adjust namespace as per your project structure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        // Add DbSet properties for other entities if needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities (e.g., relationships, indexes)
            base.OnModelCreating(modelBuilder);
        }
    }
}
