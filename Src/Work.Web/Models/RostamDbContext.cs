using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Work.Web.Models
{

    public class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
    }
    public class RostDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,144;Database=RostDB;User Id=sa;Password=H@med123;Integrated Security=true");
        }

        public DbSet<Course> Courses { get; set; }
    }
}
