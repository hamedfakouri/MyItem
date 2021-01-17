using Microsoft.EntityFrameworkCore;

namespace Work.Web.Models
{
    public class RostDbContext : DbContext
    {
        public RostDbContext(DbContextOptions<RostDbContext> items):base(items)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>().HasKey(sc => new { sc.TeacherId, sc.CourseId });
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseItem> CourseItems { get; set; }


    }
}