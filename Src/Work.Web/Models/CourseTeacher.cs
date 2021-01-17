namespace Work.Web.Models
{
    public class CourseTeacher
    {
        public Teacher Teacher { get; set; }
        public long TeacherId { get; set; }
        public Course Course { get; set; }
        public long CourseId { get; set; }
    }
}