using Microsoft.EntityFrameworkCore;

namespace saf_kaizala_api.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : 
            base (options)
        {

        }
    }
}