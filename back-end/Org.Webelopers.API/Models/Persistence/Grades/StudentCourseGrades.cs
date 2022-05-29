

using Org.Webelopers.Api.Models.Persistence.Courses;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class StudentCourseGrades
    {
        public CourseDto Course { get; set; }
        public List<GradesDetailDto> Grades{ get; set; }

    }
}
