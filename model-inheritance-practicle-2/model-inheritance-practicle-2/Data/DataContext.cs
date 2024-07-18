using Microsoft.EntityFrameworkCore;
using model_inheritance_practicle_2.data;

namespace model_inheritance_practicle_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ServiceMst> ServiceMsts { get; set; }
    }
}
