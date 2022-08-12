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
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
    }
}
