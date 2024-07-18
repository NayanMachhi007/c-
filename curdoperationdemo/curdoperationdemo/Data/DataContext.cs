using Microsoft.EntityFrameworkCore;

namespace curdoperationdemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeMst> Employees { get; set; }
    }
}
