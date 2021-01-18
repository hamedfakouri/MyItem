using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Work.Web.ViewModels
{
    public class CourseViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime CreateDate { get; set; }

        //[Required(ErrorMessage = "Please choose profile image")]
        //[Display(Name = "Profile Picture")]
        public IFormFile CourseImage { get; set; }
    }
}
