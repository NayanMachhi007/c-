using Microsoft.EntityFrameworkCore;

namespace practice_database.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<studentInfo> students { get; set; } 
    }
}
