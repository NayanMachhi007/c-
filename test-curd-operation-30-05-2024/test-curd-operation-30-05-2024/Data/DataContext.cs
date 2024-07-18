using Microsoft.EntityFrameworkCore;

namespace test_curd_operation_30_05_2024.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Emptesttable> Emptesttables { get; set; }
    }
}
