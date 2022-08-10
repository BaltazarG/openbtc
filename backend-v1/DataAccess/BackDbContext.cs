using backend_v1.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace backend_v1.DataAccess
{
    public class BackDbContext : DbContext
    {
        public BackDbContext(DbContextOptions<BackDbContext> options) : base(options)
        {

        }

        // TODO: Add DbSets
        public DbSet<User>? Users { get; set; }

    }
}
