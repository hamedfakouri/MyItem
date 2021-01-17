using System.ComponentModel.DataAnnotations;

namespace Work.Web.Models
{
    public enum CourseStatus
    {
        [Display(Name = "آینده")]
        Future,
        [Display(Name = "در حال ایجاد")]
        InProgress,
        [Display(Name = "تکمیل شده")]
        Completed
    }
}