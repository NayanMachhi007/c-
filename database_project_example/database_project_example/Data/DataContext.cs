using Microsoft.EntityFrameworkCore;

namespace database_project_example.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<EmployeeMst> EmployeeMsts { get; set; }
    }
}
