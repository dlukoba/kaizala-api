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

        public DatabaseContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
            
        // }
    }
}