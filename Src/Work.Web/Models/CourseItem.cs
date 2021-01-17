using System;

namespace Work.Web.Models
{
    public class CourseItem
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
        public CourseStatus CourseStatus { get; set; }
        public CourseAccessType CourseAccessType { get; set; }

    }
}