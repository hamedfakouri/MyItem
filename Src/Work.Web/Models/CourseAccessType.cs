using System.ComponentModel.DataAnnotations;

namespace Work.Web.Models
{
    public enum CourseAccessType
    {
        [Display(Name = "رایگان")]
        Free,
        [Display(Name = "نقدی")]
        Payable,
        [Display(Name = "ویژه اعضا")]
        JustForUser
    }
}