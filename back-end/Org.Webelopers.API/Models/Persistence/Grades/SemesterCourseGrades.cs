

using Org.Webelopers.Api.Models.Persistence.Semester;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class SemesterCourseGrades
    {
        public SemesterDto Semester { get; set; }
        public List<StudentCourseGrades> Courses { get; set; }

    }
}
