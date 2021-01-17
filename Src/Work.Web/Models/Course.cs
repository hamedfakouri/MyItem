using System;
using System.Collections.Generic;

namespace Work.Web.Models
{
    public class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime CreateDate { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public string ImageUrl { get; set; }
    }
}