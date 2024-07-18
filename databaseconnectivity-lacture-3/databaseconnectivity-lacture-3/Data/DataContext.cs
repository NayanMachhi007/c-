using Microsoft.EntityFrameworkCore;

namespace databaseconnectivity_lacture_3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<StudentMst> StudentMst { get; set; }
    }
}
