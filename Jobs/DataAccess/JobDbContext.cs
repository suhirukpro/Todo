using Jobs.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Jobs.DataAccess
{
    public class JobDbContext:DbContext
    {

        public JobDbContext(DbContextOptions<JobDbContext> options):base(options)
        {

        }

        public DbSet<Job> Jobs { get; set; }
    }
}
