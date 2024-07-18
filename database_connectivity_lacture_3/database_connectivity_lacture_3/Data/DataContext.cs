using Microsoft.EntityFrameworkCore;

namespace database_connectivity_lacture_3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<EmployeeMst> employees { get; set; }
    }
}
