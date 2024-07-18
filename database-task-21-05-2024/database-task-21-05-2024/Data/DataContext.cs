using Microsoft.EntityFrameworkCore;

namespace database_task_21_05_2024.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ServicesMst> servicesMsts { get; set; }
    }
}
