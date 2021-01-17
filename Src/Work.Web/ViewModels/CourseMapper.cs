using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work.Web.Models;

namespace Work.Web.ViewModels
{
    public static class CourseMapper
    {
        public static Course Map(this CourseViewModel dto)
        {
            return new Course()
            {
                Title = dto.Title,
                Description = dto.Description,
                Details = dto.Details,
            };
        }
    }
}
