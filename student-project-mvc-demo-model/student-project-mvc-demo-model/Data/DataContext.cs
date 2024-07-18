using Microsoft.EntityFrameworkCore;

namespace student_project_mvc_demo_model.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentTempMst> TempMst { get; set; }
    }
}
