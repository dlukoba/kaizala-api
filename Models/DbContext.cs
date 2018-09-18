using Microsoft.EntityFrameworkCore;

namespace saf_kaizala_api.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : 
            base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("customers")
                .HasKey(c => c.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}