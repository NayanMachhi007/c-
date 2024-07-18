using Microsoft.EntityFrameworkCore;

namespace database_project_example_2.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmployeeSecond> EmployeeSeconds { get; set; }
    }
}
