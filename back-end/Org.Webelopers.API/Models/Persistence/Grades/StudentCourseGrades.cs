

using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class StudentCourseGrades
    {
        public string CourseName { get; set; }
        public List<GradesDetailDto> grades{ get; set; }

    }
}
